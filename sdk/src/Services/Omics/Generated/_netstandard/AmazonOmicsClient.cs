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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Omics.Model;
using Amazon.Omics.Model.Internal.MarshallTransformations;
using Amazon.Omics.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Omics
{
    /// <summary>
    /// <para>Implementation for accessing Omics</para>
    ///
    /// Amazon Web Services HealthOmics is a service that helps users such as bioinformaticians,
    /// researchers, and scientists to store, query, analyze, and generate insights from genomics
    /// and other biological data. It simplifies and accelerates the process of storing and
    /// analyzing genomic information for Amazon Web Services.
    /// 
    ///  
    /// <para>
    /// For an introduction to the service, see <a href="https://docs.aws.amazon.com/omics/latest/dev/what-is-healthomics.html">What
    /// is Amazon Web Services HealthOmics?</a> in the <i>Amazon Web Services HealthOmics
    /// User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonOmicsClient : AmazonServiceClient, IAmazonOmics
    {
        private static IServiceMetadata serviceMetadata = new AmazonOmicsMetadata();
        
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
            : base(new AmazonOmicsConfig()) { }

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
            : base(new AmazonOmicsConfig{RegionEndpoint = region}) { }

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
            : base(config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
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

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonOmicsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonOmicsAuthSchemeHandler());
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


        #region  AbortMultipartReadSetUpload

        internal virtual AbortMultipartReadSetUploadResponse AbortMultipartReadSetUpload(AbortMultipartReadSetUploadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AbortMultipartReadSetUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortMultipartReadSetUploadResponseUnmarshaller.Instance;

            return Invoke<AbortMultipartReadSetUploadResponse>(request, options);
        }



        /// <summary>
        /// Stops a multipart read set upload into a sequence store and returns a response with
        /// no body if the operation is successful. To confirm that a multipart read set upload
        /// has been stopped, use the <c>ListMultipartReadSetUploads</c> API operation to view
        /// all active multipart read set uploads.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartReadSetUpload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AbortMultipartReadSetUpload service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.NotSupportedOperationException">
        /// The operation is not supported by Amazon Omics, or the API does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/AbortMultipartReadSetUpload">REST API Reference for AbortMultipartReadSetUpload Operation</seealso>
        public virtual Task<AbortMultipartReadSetUploadResponse> AbortMultipartReadSetUploadAsync(AbortMultipartReadSetUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AbortMultipartReadSetUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortMultipartReadSetUploadResponseUnmarshaller.Instance;

            return InvokeAsync<AbortMultipartReadSetUploadResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AcceptShare

        internal virtual AcceptShareResponse AcceptShare(AcceptShareRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptShareResponseUnmarshaller.Instance;

            return Invoke<AcceptShareResponse>(request, options);
        }



        /// <summary>
        /// Accept a resource share request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptShare service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/AcceptShare">REST API Reference for AcceptShare Operation</seealso>
        public virtual Task<AcceptShareResponse> AcceptShareAsync(AcceptShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptShareResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptShareResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDeleteReadSet

        internal virtual BatchDeleteReadSetResponse BatchDeleteReadSet(BatchDeleteReadSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteReadSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteReadSetResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteReadSetResponse>(request, options);
        }



        /// <summary>
        /// Deletes one or more read sets. If the operation is successful, it returns a response
        /// with no body. If there is an error with deleting one of the read sets, the operation
        /// returns an error list. If the operation successfully deletes only a subset of files,
        /// it will return an error list for the remaining files that fail to be deleted. There
        /// is a limit of 100 read sets that can be deleted in each <c>BatchDeleteReadSet</c>
        /// API call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteReadSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<BatchDeleteReadSetResponse> BatchDeleteReadSetAsync(BatchDeleteReadSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteReadSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteReadSetResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteReadSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelAnnotationImportJob

        internal virtual CancelAnnotationImportJobResponse CancelAnnotationImportJob(CancelAnnotationImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelAnnotationImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelAnnotationImportJobResponseUnmarshaller.Instance;

            return Invoke<CancelAnnotationImportJobResponse>(request, options);
        }



        /// <summary>
        /// Cancels an annotation import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelAnnotationImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CancelAnnotationImportJobResponse> CancelAnnotationImportJobAsync(CancelAnnotationImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelAnnotationImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelAnnotationImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CancelAnnotationImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelRun

        internal virtual CancelRunResponse CancelRun(CancelRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelRunResponseUnmarshaller.Instance;

            return Invoke<CancelRunResponse>(request, options);
        }



        /// <summary>
        /// Cancels a run using its ID and returns a response with no body if the operation is
        /// successful. To confirm that the run has been cancelled, use the <c>ListRuns</c> API
        /// operation to check that it is no longer listed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CancelRunResponse> CancelRunAsync(CancelRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelRunResponseUnmarshaller.Instance;

            return InvokeAsync<CancelRunResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelVariantImportJob

        internal virtual CancelVariantImportJobResponse CancelVariantImportJob(CancelVariantImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelVariantImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelVariantImportJobResponseUnmarshaller.Instance;

            return Invoke<CancelVariantImportJobResponse>(request, options);
        }



        /// <summary>
        /// Cancels a variant import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelVariantImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CancelVariantImportJobResponse> CancelVariantImportJobAsync(CancelVariantImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelVariantImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelVariantImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CancelVariantImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CompleteMultipartReadSetUpload

        internal virtual CompleteMultipartReadSetUploadResponse CompleteMultipartReadSetUpload(CompleteMultipartReadSetUploadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CompleteMultipartReadSetUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteMultipartReadSetUploadResponseUnmarshaller.Instance;

            return Invoke<CompleteMultipartReadSetUploadResponse>(request, options);
        }



        /// <summary>
        /// Completes a multipart read set upload into a sequence store after you have initiated
        /// the upload process with <c>CreateMultipartReadSetUpload</c> and uploaded all read
        /// set parts using <c>UploadReadSetPart</c>. You must specify the parts you uploaded
        /// using the parts parameter. If the operation is successful, it returns the read set
        /// ID(s) of the uploaded read set(s).
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/synchronous-uploads.html">Direct
        /// upload to a sequence store</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartReadSetUpload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CompleteMultipartReadSetUpload service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.NotSupportedOperationException">
        /// The operation is not supported by Amazon Omics, or the API does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CompleteMultipartReadSetUpload">REST API Reference for CompleteMultipartReadSetUpload Operation</seealso>
        public virtual Task<CompleteMultipartReadSetUploadResponse> CompleteMultipartReadSetUploadAsync(CompleteMultipartReadSetUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CompleteMultipartReadSetUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteMultipartReadSetUploadResponseUnmarshaller.Instance;

            return InvokeAsync<CompleteMultipartReadSetUploadResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAnnotationStore

        internal virtual CreateAnnotationStoreResponse CreateAnnotationStore(CreateAnnotationStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAnnotationStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnnotationStoreResponseUnmarshaller.Instance;

            return Invoke<CreateAnnotationStoreResponse>(request, options);
        }



        /// <summary>
        /// Creates an annotation store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnnotationStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateAnnotationStoreResponse> CreateAnnotationStoreAsync(CreateAnnotationStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAnnotationStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnnotationStoreResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAnnotationStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAnnotationStoreVersion

        internal virtual CreateAnnotationStoreVersionResponse CreateAnnotationStoreVersion(CreateAnnotationStoreVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAnnotationStoreVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnnotationStoreVersionResponseUnmarshaller.Instance;

            return Invoke<CreateAnnotationStoreVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new version of an annotation store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnnotationStoreVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAnnotationStoreVersion service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateAnnotationStoreVersion">REST API Reference for CreateAnnotationStoreVersion Operation</seealso>
        public virtual Task<CreateAnnotationStoreVersionResponse> CreateAnnotationStoreVersionAsync(CreateAnnotationStoreVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAnnotationStoreVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnnotationStoreVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAnnotationStoreVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateMultipartReadSetUpload

        internal virtual CreateMultipartReadSetUploadResponse CreateMultipartReadSetUpload(CreateMultipartReadSetUploadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMultipartReadSetUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMultipartReadSetUploadResponseUnmarshaller.Instance;

            return Invoke<CreateMultipartReadSetUploadResponse>(request, options);
        }



        /// <summary>
        /// Initiates a multipart read set upload for uploading partitioned source files into
        /// a sequence store. You can directly import source files from an EC2 instance and other
        /// local compute, or from an S3 bucket. To separate these source files into parts, use
        /// the <c>split</c> operation. Each part cannot be larger than 100 MB. If the operation
        /// is successful, it provides an <c>uploadId</c> which is required by the <c>UploadReadSetPart</c>
        /// API operation to upload parts into a sequence store.
        /// 
        ///  
        /// <para>
        /// To continue uploading a multipart read set into your sequence store, you must use
        /// the <c>UploadReadSetPart</c> API operation to upload each part individually following
        /// the steps below:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify the <c>uploadId</c> obtained from the previous call to <c>CreateMultipartReadSetUpload</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Upload parts for that <c>uploadId</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you have finished uploading parts, use the <c>CompleteMultipartReadSetUpload</c>
        /// API to complete the multipart read set upload and to retrieve the final read set IDs
        /// in the response.
        /// </para>
        ///  
        /// <para>
        /// To learn more about creating parts and the <c>split</c> operation, see <a href="https://docs.aws.amazon.com/omics/latest/dev/synchronous-uploads.html">Direct
        /// upload to a sequence store</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMultipartReadSetUpload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMultipartReadSetUpload service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.NotSupportedOperationException">
        /// The operation is not supported by Amazon Omics, or the API does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateMultipartReadSetUpload">REST API Reference for CreateMultipartReadSetUpload Operation</seealso>
        public virtual Task<CreateMultipartReadSetUploadResponse> CreateMultipartReadSetUploadAsync(CreateMultipartReadSetUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMultipartReadSetUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMultipartReadSetUploadResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMultipartReadSetUploadResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateReferenceStore

        internal virtual CreateReferenceStoreResponse CreateReferenceStore(CreateReferenceStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReferenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReferenceStoreResponseUnmarshaller.Instance;

            return Invoke<CreateReferenceStoreResponse>(request, options);
        }



        /// <summary>
        /// Creates a reference store and returns metadata in JSON format. Reference stores are
        /// used to store reference genomes in FASTA format. A reference store is created when
        /// the first reference genome is imported. To import additional reference genomes from
        /// an Amazon S3 bucket, use the <c>StartReferenceImportJob</c> API operation. 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/create-reference-store.html">Creating
        /// a HealthOmics reference store</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReferenceStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateReferenceStoreResponse> CreateReferenceStoreAsync(CreateReferenceStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReferenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReferenceStoreResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReferenceStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRunCache

        internal virtual CreateRunCacheResponse CreateRunCache(CreateRunCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRunCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRunCacheResponseUnmarshaller.Instance;

            return Invoke<CreateRunCacheResponse>(request, options);
        }



        /// <summary>
        /// Creates a run cache to store and reference task outputs from completed private runs.
        /// Specify an Amazon S3 location where Amazon Web Services HealthOmics saves the cached
        /// data. This data must be immediately accessible and not in an archived state. You can
        /// save intermediate task files to a run cache if they are declared as task outputs in
        /// the workflow definition file.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/workflows-call-caching.html">Call
        /// caching</a> and <a href="https://docs.aws.amazon.com/omics/latest/dev/workflow-cache-create.html">Creating
        /// a run cache</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRunCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRunCache service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateRunCache">REST API Reference for CreateRunCache Operation</seealso>
        public virtual Task<CreateRunCacheResponse> CreateRunCacheAsync(CreateRunCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRunCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRunCacheResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRunCacheResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRunGroup

        internal virtual CreateRunGroupResponse CreateRunGroup(CreateRunGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRunGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRunGroupResponseUnmarshaller.Instance;

            return Invoke<CreateRunGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a run group to limit the compute resources for the runs that are added to
        /// the group. Returns an ARN, ID, and tags for the run group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRunGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateRunGroupResponse> CreateRunGroupAsync(CreateRunGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRunGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRunGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRunGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSequenceStore

        internal virtual CreateSequenceStoreResponse CreateSequenceStore(CreateSequenceStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSequenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSequenceStoreResponseUnmarshaller.Instance;

            return Invoke<CreateSequenceStoreResponse>(request, options);
        }



        /// <summary>
        /// Creates a sequence store and returns its metadata. Sequence stores are used to store
        /// sequence data files called read sets that are saved in FASTQ, BAM, uBAM, or CRAM formats.
        /// For aligned formats (BAM and CRAM), a sequence store can only use one reference genome.
        /// For unaligned formats (FASTQ and uBAM), a reference genome is not required. You can
        /// create multiple sequence stores per region per account. 
        /// 
        ///  
        /// <para>
        /// The following are optional parameters you can specify for your sequence store:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <c>s3AccessConfig</c> to configure your sequence store with S3 access logs (recommended).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>sseConfig</c> to define your own KMS key for encryption.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>eTagAlgorithmFamily</c> to define which algorithm to use for the HealthOmics
        /// eTag on objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>fallbackLocation</c> to define a backup location for storing files that have
        /// failed a direct upload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>propagatedSetLevelTags</c> to configure tags that propagate to all objects
        /// in your store.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/create-sequence-store.html">Creating
        /// a HealthOmics sequence store</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSequenceStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateSequenceStoreResponse> CreateSequenceStoreAsync(CreateSequenceStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSequenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSequenceStoreResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSequenceStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateShare

        internal virtual CreateShareResponse CreateShare(CreateShareRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateShareResponseUnmarshaller.Instance;

            return Invoke<CreateShareResponse>(request, options);
        }



        /// <summary>
        /// Creates a cross-account shared resource. The resource owner makes an offer to share
        /// the resource with the principal subscriber (an AWS user with a different account than
        /// the resource owner).
        /// 
        ///  
        /// <para>
        /// The following resources support cross-account sharing:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// HealthOmics variant stores
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HealthOmics annotation stores
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Private workflows
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateShare service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateShare">REST API Reference for CreateShare Operation</seealso>
        public virtual Task<CreateShareResponse> CreateShareAsync(CreateShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateShareResponseUnmarshaller.Instance;

            return InvokeAsync<CreateShareResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateVariantStore

        internal virtual CreateVariantStoreResponse CreateVariantStore(CreateVariantStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVariantStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVariantStoreResponseUnmarshaller.Instance;

            return Invoke<CreateVariantStoreResponse>(request, options);
        }



        /// <summary>
        /// Creates a variant store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVariantStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateVariantStoreResponse> CreateVariantStoreAsync(CreateVariantStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVariantStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVariantStoreResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVariantStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateWorkflow

        internal virtual CreateWorkflowResponse CreateWorkflow(CreateWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowResponseUnmarshaller.Instance;

            return Invoke<CreateWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Creates a private workflow. Before you create a private workflow, you must create
        /// and configure these required resources:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <i>Workflow definition files</i>: Define your workflow in one or more workflow definition
        /// files, written in WDL, Nextflow, or CWL. The workflow definition specifies the inputs
        /// and outputs for runs that use the workflow. It also includes specifications for the
        /// runs and run tasks for your workflow, including compute and memory requirements. The
        /// workflow definition file must be in .zip format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) <i>Parameter template</i>: You can create a parameter template file that
        /// defines the run parameters, or Amazon Web Services HealthOmics can generate the parameter
        /// template for you.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>ECR container images</i>: Create container images for the workflow in a private
        /// ECR repository, or synchronize images from a supported upstream registry with your
        /// Amazon ECR private repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) <i>Sentieon licenses</i>: Request a Sentieon license if using the Sentieon
        /// software in a private workflow.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/creating-private-workflows.html">Creating
        /// or updating a private workflow in Amazon Web Services HealthOmics</a> in the <i>Amazon
        /// Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateWorkflowResponse> CreateWorkflowAsync(CreateWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkflowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateWorkflowVersion

        internal virtual CreateWorkflowVersionResponse CreateWorkflowVersion(CreateWorkflowVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowVersionResponseUnmarshaller.Instance;

            return Invoke<CreateWorkflowVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new workflow version for the workflow that you specify with the <c>workflowId</c>
        /// parameter.
        /// 
        ///  
        /// <para>
        /// When you create a new version of a workflow, you need to specify the configuration
        /// for the new version. It doesn't inherit any configuration values from the workflow.
        /// </para>
        ///  
        /// <para>
        /// Provide a version name that is unique for this workflow. You cannot change the name
        /// after HealthOmics creates the version.
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't include any personally identifiable information (PII) in the version name. Version
        /// names appear in the workflow version ARN.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/workflow-versions.html">Workflow
        /// versioning in Amazon Web Services HealthOmics</a> in the <i>Amazon Web Services HealthOmics
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkflowVersion service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateWorkflowVersion">REST API Reference for CreateWorkflowVersion Operation</seealso>
        public virtual Task<CreateWorkflowVersionResponse> CreateWorkflowVersionAsync(CreateWorkflowVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkflowVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkflowVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAnnotationStore

        internal virtual DeleteAnnotationStoreResponse DeleteAnnotationStore(DeleteAnnotationStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAnnotationStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnnotationStoreResponseUnmarshaller.Instance;

            return Invoke<DeleteAnnotationStoreResponse>(request, options);
        }



        /// <summary>
        /// Deletes an annotation store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnnotationStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteAnnotationStoreResponse> DeleteAnnotationStoreAsync(DeleteAnnotationStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAnnotationStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnnotationStoreResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAnnotationStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAnnotationStoreVersions

        internal virtual DeleteAnnotationStoreVersionsResponse DeleteAnnotationStoreVersions(DeleteAnnotationStoreVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAnnotationStoreVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnnotationStoreVersionsResponseUnmarshaller.Instance;

            return Invoke<DeleteAnnotationStoreVersionsResponse>(request, options);
        }



        /// <summary>
        /// Deletes one or multiple versions of an annotation store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnnotationStoreVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAnnotationStoreVersions service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteAnnotationStoreVersions">REST API Reference for DeleteAnnotationStoreVersions Operation</seealso>
        public virtual Task<DeleteAnnotationStoreVersionsResponse> DeleteAnnotationStoreVersionsAsync(DeleteAnnotationStoreVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAnnotationStoreVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnnotationStoreVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAnnotationStoreVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteReference

        internal virtual DeleteReferenceResponse DeleteReference(DeleteReferenceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReferenceResponseUnmarshaller.Instance;

            return Invoke<DeleteReferenceResponse>(request, options);
        }



        /// <summary>
        /// Deletes a reference genome and returns a response with no body if the operation is
        /// successful. The read set associated with the reference genome must first be deleted
        /// before deleting the reference genome. After the reference genome is deleted, you can
        /// delete the reference store using the <c>DeleteReferenceStore</c> API operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/deleting-reference-and-sequence-stores.html">Deleting
        /// HealthOmics reference and sequence stores</a> in the <i>Amazon Web Services HealthOmics
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReference service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteReferenceResponse> DeleteReferenceAsync(DeleteReferenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReferenceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReferenceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteReferenceStore

        internal virtual DeleteReferenceStoreResponse DeleteReferenceStore(DeleteReferenceStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReferenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReferenceStoreResponseUnmarshaller.Instance;

            return Invoke<DeleteReferenceStoreResponse>(request, options);
        }



        /// <summary>
        /// Deletes a reference store and returns a response with no body if the operation is
        /// successful. You can only delete a reference store when it does not contain any reference
        /// genomes. To empty a reference store, use <c>DeleteReference</c>.
        /// 
        ///  
        /// <para>
        /// For more information about your workflow status, see <a href="https://docs.aws.amazon.com/omics/latest/dev/deleting-reference-and-sequence-stores.html">Deleting
        /// HealthOmics reference and sequence stores</a> in the <i>Amazon Web Services HealthOmics
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReferenceStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteReferenceStoreResponse> DeleteReferenceStoreAsync(DeleteReferenceStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReferenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReferenceStoreResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReferenceStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRun

        internal virtual DeleteRunResponse DeleteRun(DeleteRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRunResponseUnmarshaller.Instance;

            return Invoke<DeleteRunResponse>(request, options);
        }



        /// <summary>
        /// Deletes a run and returns a response with no body if the operation is successful.
        /// You can only delete a run that has reached a <c>COMPLETED</c>, <c>FAILED</c>, or <c>CANCELLED</c>
        /// stage. A completed run has delivered an output, or was cancelled and resulted in no
        /// output. When you delete a run, only the metadata associated with the run is deleted.
        /// The run outputs remain in Amazon S3 and logs remain in CloudWatch.
        /// 
        ///  
        /// <para>
        /// To verify that the workflow is deleted:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <c>ListRuns</c> to confirm the workflow no longer appears in the list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetRun</c> to verify the workflow cannot be found.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteRunResponse> DeleteRunAsync(DeleteRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRunResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRunResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRunCache

        internal virtual DeleteRunCacheResponse DeleteRunCache(DeleteRunCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRunCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRunCacheResponseUnmarshaller.Instance;

            return Invoke<DeleteRunCacheResponse>(request, options);
        }



        /// <summary>
        /// Deletes a run cache and returns a response with no body if the operation is successful.
        /// This action removes the cache metadata stored in the service account, but does not
        /// delete the data in Amazon S3. You can access the cache data in Amazon S3, for inspection
        /// or to troubleshoot issues. You can remove old cache data using standard S3 <c>Delete</c>
        /// operations. 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/workflow-cache-delete.html">Deleting
        /// a run cache</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRunCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRunCache service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteRunCache">REST API Reference for DeleteRunCache Operation</seealso>
        public virtual Task<DeleteRunCacheResponse> DeleteRunCacheAsync(DeleteRunCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRunCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRunCacheResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRunCacheResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRunGroup

        internal virtual DeleteRunGroupResponse DeleteRunGroup(DeleteRunGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRunGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRunGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteRunGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a run group and returns a response with no body if the operation is successful.
        /// 
        ///  
        /// <para>
        /// To verify that the run group is deleted:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <c>ListRunGroups</c> to confirm the workflow no longer appears in the list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetRunGroup</c> to verify the workflow cannot be found.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRunGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteRunGroupResponse> DeleteRunGroupAsync(DeleteRunGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRunGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRunGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRunGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteS3AccessPolicy

        internal virtual DeleteS3AccessPolicyResponse DeleteS3AccessPolicy(DeleteS3AccessPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteS3AccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteS3AccessPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteS3AccessPolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes an access policy for the specified store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteS3AccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteS3AccessPolicy service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.NotSupportedOperationException">
        /// The operation is not supported by Amazon Omics, or the API does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteS3AccessPolicy">REST API Reference for DeleteS3AccessPolicy Operation</seealso>
        public virtual Task<DeleteS3AccessPolicyResponse> DeleteS3AccessPolicyAsync(DeleteS3AccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteS3AccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteS3AccessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteS3AccessPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSequenceStore

        internal virtual DeleteSequenceStoreResponse DeleteSequenceStore(DeleteSequenceStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSequenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSequenceStoreResponseUnmarshaller.Instance;

            return Invoke<DeleteSequenceStoreResponse>(request, options);
        }



        /// <summary>
        /// Deletes a sequence store and returns a response with no body if the operation is successful.
        /// You can only delete a sequence store when it does not contain any read sets.
        /// 
        ///  
        /// <para>
        /// Use the <c>BatchDeleteReadSet</c> API operation to ensure that all read sets in the
        /// sequence store are deleted. When a sequence store is deleted, all tags associated
        /// with the store are also deleted.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/deleting-reference-and-sequence-stores.html">Deleting
        /// HealthOmics reference and sequence stores</a> in the <i>Amazon Web Services HealthOmics
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSequenceStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteSequenceStoreResponse> DeleteSequenceStoreAsync(DeleteSequenceStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSequenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSequenceStoreResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSequenceStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteShare

        internal virtual DeleteShareResponse DeleteShare(DeleteShareRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteShareResponseUnmarshaller.Instance;

            return Invoke<DeleteShareResponse>(request, options);
        }



        /// <summary>
        /// Deletes a resource share. If you are the resource owner, the subscriber will no longer
        /// have access to the shared resource. If you are the subscriber, this operation deletes
        /// your access to the share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteShare service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteShare">REST API Reference for DeleteShare Operation</seealso>
        public virtual Task<DeleteShareResponse> DeleteShareAsync(DeleteShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteShareResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteShareResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteVariantStore

        internal virtual DeleteVariantStoreResponse DeleteVariantStore(DeleteVariantStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVariantStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVariantStoreResponseUnmarshaller.Instance;

            return Invoke<DeleteVariantStoreResponse>(request, options);
        }



        /// <summary>
        /// Deletes a variant store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVariantStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteVariantStoreResponse> DeleteVariantStoreAsync(DeleteVariantStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVariantStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVariantStoreResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVariantStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteWorkflow

        internal virtual DeleteWorkflowResponse DeleteWorkflow(DeleteWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Deletes a workflow by specifying its ID. This operation returns a response with no
        /// body if the deletion is successful.
        /// 
        ///  
        /// <para>
        /// To verify that the workflow is deleted:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <c>ListWorkflows</c> to confirm the workflow no longer appears in the list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>GetWorkflow</c> to verify the workflow cannot be found.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteWorkflowResponse> DeleteWorkflowAsync(DeleteWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkflowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteWorkflowVersion

        internal virtual DeleteWorkflowVersionResponse DeleteWorkflowVersion(DeleteWorkflowVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkflowVersionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a workflow version. Deleting a workflow version doesn't affect any ongoing
        /// runs that are using the workflow version.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/workflow-versions.html">Workflow
        /// versioning in Amazon Web Services HealthOmics</a> in the <i>Amazon Web Services HealthOmics
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkflowVersion service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteWorkflowVersion">REST API Reference for DeleteWorkflowVersion Operation</seealso>
        public virtual Task<DeleteWorkflowVersionResponse> DeleteWorkflowVersionAsync(DeleteWorkflowVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkflowVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAnnotationImportJob

        internal virtual GetAnnotationImportJobResponse GetAnnotationImportJob(GetAnnotationImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAnnotationImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnnotationImportJobResponseUnmarshaller.Instance;

            return Invoke<GetAnnotationImportJobResponse>(request, options);
        }



        /// <summary>
        /// Gets information about an annotation import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnnotationImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetAnnotationImportJobResponse> GetAnnotationImportJobAsync(GetAnnotationImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAnnotationImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnnotationImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetAnnotationImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAnnotationStore

        internal virtual GetAnnotationStoreResponse GetAnnotationStore(GetAnnotationStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAnnotationStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnnotationStoreResponseUnmarshaller.Instance;

            return Invoke<GetAnnotationStoreResponse>(request, options);
        }



        /// <summary>
        /// Gets information about an annotation store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnnotationStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetAnnotationStoreResponse> GetAnnotationStoreAsync(GetAnnotationStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAnnotationStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnnotationStoreResponseUnmarshaller.Instance;

            return InvokeAsync<GetAnnotationStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAnnotationStoreVersion

        internal virtual GetAnnotationStoreVersionResponse GetAnnotationStoreVersion(GetAnnotationStoreVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAnnotationStoreVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnnotationStoreVersionResponseUnmarshaller.Instance;

            return Invoke<GetAnnotationStoreVersionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the metadata for an annotation store version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnnotationStoreVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAnnotationStoreVersion service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetAnnotationStoreVersion">REST API Reference for GetAnnotationStoreVersion Operation</seealso>
        public virtual Task<GetAnnotationStoreVersionResponse> GetAnnotationStoreVersionAsync(GetAnnotationStoreVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAnnotationStoreVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnnotationStoreVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetAnnotationStoreVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetReadSet

        internal virtual GetReadSetResponse GetReadSet(GetReadSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReadSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadSetResponseUnmarshaller.Instance;

            return Invoke<GetReadSetResponse>(request, options);
        }



        /// <summary>
        /// Retrieves detailed information from parts of a read set and returns the read set in
        /// the same format that it was uploaded. You must have read sets uploaded to your sequence
        /// store in order to run this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetReadSetResponse> GetReadSetAsync(GetReadSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReadSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetReadSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetReadSetActivationJob

        internal virtual GetReadSetActivationJobResponse GetReadSetActivationJob(GetReadSetActivationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReadSetActivationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadSetActivationJobResponseUnmarshaller.Instance;

            return Invoke<GetReadSetActivationJobResponse>(request, options);
        }



        /// <summary>
        /// Returns detailed information about the status of a read set activation job in JSON
        /// format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetActivationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetReadSetActivationJobResponse> GetReadSetActivationJobAsync(GetReadSetActivationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReadSetActivationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadSetActivationJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetReadSetActivationJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetReadSetExportJob

        internal virtual GetReadSetExportJobResponse GetReadSetExportJob(GetReadSetExportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReadSetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadSetExportJobResponseUnmarshaller.Instance;

            return Invoke<GetReadSetExportJobResponse>(request, options);
        }



        /// <summary>
        /// Retrieves status information about a read set export job and returns the data in JSON
        /// format. Use this operation to actively monitor the progress of an export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetReadSetExportJobResponse> GetReadSetExportJobAsync(GetReadSetExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReadSetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadSetExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetReadSetExportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetReadSetImportJob

        internal virtual GetReadSetImportJobResponse GetReadSetImportJob(GetReadSetImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReadSetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadSetImportJobResponseUnmarshaller.Instance;

            return Invoke<GetReadSetImportJobResponse>(request, options);
        }



        /// <summary>
        /// Gets detailed and status information about a read set import job and returns the data
        /// in JSON format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetReadSetImportJobResponse> GetReadSetImportJobAsync(GetReadSetImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReadSetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadSetImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetReadSetImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetReadSetMetadata

        internal virtual GetReadSetMetadataResponse GetReadSetMetadata(GetReadSetMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReadSetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadSetMetadataResponseUnmarshaller.Instance;

            return Invoke<GetReadSetMetadataResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the metadata for a read set from a sequence store in JSON format. This operation
        /// does not return tags. To retrieve the list of tags for a read set, use the <c>ListTagsForResource</c>
        /// API operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetReadSetMetadataResponse> GetReadSetMetadataAsync(GetReadSetMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReadSetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadSetMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<GetReadSetMetadataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetReference

        internal virtual GetReferenceResponse GetReference(GetReferenceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReferenceResponseUnmarshaller.Instance;

            return Invoke<GetReferenceResponse>(request, options);
        }



        /// <summary>
        /// Downloads parts of data from a reference genome and returns the reference file in
        /// the same format that it was uploaded.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/create-reference-store.html">Creating
        /// a HealthOmics reference store</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReference service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetReferenceResponse> GetReferenceAsync(GetReferenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReferenceResponseUnmarshaller.Instance;

            return InvokeAsync<GetReferenceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetReferenceImportJob

        internal virtual GetReferenceImportJobResponse GetReferenceImportJob(GetReferenceImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReferenceImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReferenceImportJobResponseUnmarshaller.Instance;

            return Invoke<GetReferenceImportJobResponse>(request, options);
        }



        /// <summary>
        /// Monitors the status of a reference import job. This operation can be called after
        /// calling the <c>StartReferenceImportJob</c> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReferenceImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetReferenceImportJobResponse> GetReferenceImportJobAsync(GetReferenceImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReferenceImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReferenceImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetReferenceImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetReferenceMetadata

        internal virtual GetReferenceMetadataResponse GetReferenceMetadata(GetReferenceMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReferenceMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReferenceMetadataResponseUnmarshaller.Instance;

            return Invoke<GetReferenceMetadataResponse>(request, options);
        }



        /// <summary>
        /// Retrieves metadata for a reference genome. This operation returns the number of parts,
        /// part size, and MD5 of an entire file. This operation does not return tags. To retrieve
        /// the list of tags for a read set, use the <c>ListTagsForResource</c> API operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReferenceMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetReferenceMetadataResponse> GetReferenceMetadataAsync(GetReferenceMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReferenceMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReferenceMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<GetReferenceMetadataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetReferenceStore

        internal virtual GetReferenceStoreResponse GetReferenceStore(GetReferenceStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReferenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReferenceStoreResponseUnmarshaller.Instance;

            return Invoke<GetReferenceStoreResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a reference store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReferenceStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetReferenceStoreResponse> GetReferenceStoreAsync(GetReferenceStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReferenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReferenceStoreResponseUnmarshaller.Instance;

            return InvokeAsync<GetReferenceStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRun

        internal virtual GetRunResponse GetRun(GetRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRunResponseUnmarshaller.Instance;

            return Invoke<GetRunResponse>(request, options);
        }



        /// <summary>
        /// Gets detailed information about a specific run using its ID.
        /// 
        ///  
        /// <para>
        /// Amazon Web Services HealthOmics stores a configurable number of runs, as determined
        /// by service limits, that are available to the console and API. If <c>GetRun</c> does
        /// not return the requested run, you can find all run logs in the CloudWatch logs. For
        /// more information about viewing the run logs, see <a href="https://docs.aws.amazon.com/omics/latest/dev/monitoring-cloudwatch-logs.html">CloudWatch
        /// logs</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetRunResponse> GetRunAsync(GetRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRunResponseUnmarshaller.Instance;

            return InvokeAsync<GetRunResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRunCache

        internal virtual GetRunCacheResponse GetRunCache(GetRunCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRunCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRunCacheResponseUnmarshaller.Instance;

            return Invoke<GetRunCacheResponse>(request, options);
        }



        /// <summary>
        /// Retrieves detailed information about the specified run cache using its ID.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/workflows-call-caching.html">Call
        /// caching for Amazon Web Services HealthOmics runs</a> in the <i>Amazon Web Services
        /// HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRunCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRunCache service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetRunCache">REST API Reference for GetRunCache Operation</seealso>
        public virtual Task<GetRunCacheResponse> GetRunCacheAsync(GetRunCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRunCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRunCacheResponseUnmarshaller.Instance;

            return InvokeAsync<GetRunCacheResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRunGroup

        internal virtual GetRunGroupResponse GetRunGroup(GetRunGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRunGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRunGroupResponseUnmarshaller.Instance;

            return Invoke<GetRunGroupResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a run group and returns its metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRunGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetRunGroupResponse> GetRunGroupAsync(GetRunGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRunGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRunGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetRunGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRunTask

        internal virtual GetRunTaskResponse GetRunTask(GetRunTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRunTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRunTaskResponseUnmarshaller.Instance;

            return Invoke<GetRunTaskResponse>(request, options);
        }



        /// <summary>
        /// Gets detailed information about a run task using its ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRunTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetRunTaskResponse> GetRunTaskAsync(GetRunTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRunTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRunTaskResponseUnmarshaller.Instance;

            return InvokeAsync<GetRunTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetS3AccessPolicy

        internal virtual GetS3AccessPolicyResponse GetS3AccessPolicy(GetS3AccessPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetS3AccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetS3AccessPolicyResponseUnmarshaller.Instance;

            return Invoke<GetS3AccessPolicyResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details about an access policy on a given store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetS3AccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetS3AccessPolicy service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.NotSupportedOperationException">
        /// The operation is not supported by Amazon Omics, or the API does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetS3AccessPolicy">REST API Reference for GetS3AccessPolicy Operation</seealso>
        public virtual Task<GetS3AccessPolicyResponse> GetS3AccessPolicyAsync(GetS3AccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetS3AccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetS3AccessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetS3AccessPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSequenceStore

        internal virtual GetSequenceStoreResponse GetSequenceStore(GetSequenceStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSequenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSequenceStoreResponseUnmarshaller.Instance;

            return Invoke<GetSequenceStoreResponse>(request, options);
        }



        /// <summary>
        /// Retrieves metadata for a sequence store using its ID and returns it in JSON format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSequenceStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetSequenceStoreResponse> GetSequenceStoreAsync(GetSequenceStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSequenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSequenceStoreResponseUnmarshaller.Instance;

            return InvokeAsync<GetSequenceStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetShare

        internal virtual GetShareResponse GetShare(GetShareRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetShareResponseUnmarshaller.Instance;

            return Invoke<GetShareResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the metadata for the specified resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetShare service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetShare">REST API Reference for GetShare Operation</seealso>
        public virtual Task<GetShareResponse> GetShareAsync(GetShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetShareResponseUnmarshaller.Instance;

            return InvokeAsync<GetShareResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetVariantImportJob

        internal virtual GetVariantImportJobResponse GetVariantImportJob(GetVariantImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVariantImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVariantImportJobResponseUnmarshaller.Instance;

            return Invoke<GetVariantImportJobResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a variant import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVariantImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetVariantImportJobResponse> GetVariantImportJobAsync(GetVariantImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVariantImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVariantImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetVariantImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetVariantStore

        internal virtual GetVariantStoreResponse GetVariantStore(GetVariantStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVariantStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVariantStoreResponseUnmarshaller.Instance;

            return Invoke<GetVariantStoreResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a variant store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVariantStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetVariantStoreResponse> GetVariantStoreAsync(GetVariantStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVariantStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVariantStoreResponseUnmarshaller.Instance;

            return InvokeAsync<GetVariantStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWorkflow

        internal virtual GetWorkflowResponse GetWorkflow(GetWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Gets all information about a workflow using its ID.
        /// 
        ///  
        /// <para>
        /// If a workflow is shared with you, you cannot export the workflow.
        /// </para>
        ///  
        /// <para>
        /// For more information about your workflow status, see <a href="https://docs.aws.amazon.com/omics/latest/dev/using-get-workflow.html">Verify
        /// the workflow status</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetWorkflowResponse> GetWorkflowAsync(GetWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkflowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWorkflowVersion

        internal virtual GetWorkflowVersionResponse GetWorkflowVersion(GetWorkflowVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowVersionResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowVersionResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a workflow version. For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/workflow-versions.html">Workflow
        /// versioning in Amazon Web Services HealthOmics</a> in the <i>Amazon Web Services HealthOmics
        /// User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkflowVersion service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetWorkflowVersion">REST API Reference for GetWorkflowVersion Operation</seealso>
        public virtual Task<GetWorkflowVersionResponse> GetWorkflowVersionAsync(GetWorkflowVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkflowVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAnnotationImportJobs

        internal virtual ListAnnotationImportJobsResponse ListAnnotationImportJobs(ListAnnotationImportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnnotationImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnnotationImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListAnnotationImportJobsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of annotation import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnnotationImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListAnnotationImportJobsResponse> ListAnnotationImportJobsAsync(ListAnnotationImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnnotationImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnnotationImportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAnnotationImportJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAnnotationStores

        internal virtual ListAnnotationStoresResponse ListAnnotationStores(ListAnnotationStoresRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnnotationStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnnotationStoresResponseUnmarshaller.Instance;

            return Invoke<ListAnnotationStoresResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of annotation stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnnotationStores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListAnnotationStoresResponse> ListAnnotationStoresAsync(ListAnnotationStoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnnotationStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnnotationStoresResponseUnmarshaller.Instance;

            return InvokeAsync<ListAnnotationStoresResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAnnotationStoreVersions

        internal virtual ListAnnotationStoreVersionsResponse ListAnnotationStoreVersions(ListAnnotationStoreVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnnotationStoreVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnnotationStoreVersionsResponseUnmarshaller.Instance;

            return Invoke<ListAnnotationStoreVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the versions of an annotation store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnnotationStoreVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnnotationStoreVersions service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListAnnotationStoreVersions">REST API Reference for ListAnnotationStoreVersions Operation</seealso>
        public virtual Task<ListAnnotationStoreVersionsResponse> ListAnnotationStoreVersionsAsync(ListAnnotationStoreVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnnotationStoreVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnnotationStoreVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAnnotationStoreVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMultipartReadSetUploads

        internal virtual ListMultipartReadSetUploadsResponse ListMultipartReadSetUploads(ListMultipartReadSetUploadsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMultipartReadSetUploadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMultipartReadSetUploadsResponseUnmarshaller.Instance;

            return Invoke<ListMultipartReadSetUploadsResponse>(request, options);
        }



        /// <summary>
        /// Lists in-progress multipart read set uploads for a sequence store and returns it in
        /// a JSON formatted output. Multipart read set uploads are initiated by the <c>CreateMultipartReadSetUploads</c>
        /// API operation. This operation returns a response with no body when the upload is complete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartReadSetUploads service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMultipartReadSetUploads service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.NotSupportedOperationException">
        /// The operation is not supported by Amazon Omics, or the API does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListMultipartReadSetUploads">REST API Reference for ListMultipartReadSetUploads Operation</seealso>
        public virtual Task<ListMultipartReadSetUploadsResponse> ListMultipartReadSetUploadsAsync(ListMultipartReadSetUploadsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMultipartReadSetUploadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMultipartReadSetUploadsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMultipartReadSetUploadsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListReadSetActivationJobs

        internal virtual ListReadSetActivationJobsResponse ListReadSetActivationJobs(ListReadSetActivationJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReadSetActivationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReadSetActivationJobsResponseUnmarshaller.Instance;

            return Invoke<ListReadSetActivationJobsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of read set activation jobs and returns the metadata in a JSON formatted
        /// output. To extract metadata from a read set activation job, use the <c>GetReadSetActivationJob</c>
        /// API operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReadSetActivationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListReadSetActivationJobsResponse> ListReadSetActivationJobsAsync(ListReadSetActivationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReadSetActivationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReadSetActivationJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReadSetActivationJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListReadSetExportJobs

        internal virtual ListReadSetExportJobsResponse ListReadSetExportJobs(ListReadSetExportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReadSetExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReadSetExportJobsResponseUnmarshaller.Instance;

            return Invoke<ListReadSetExportJobsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of read set export jobs in a JSON formatted response. This API operation
        /// is used to check the status of a read set export job initiated by the <c>StartReadSetExportJob</c>
        /// API operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReadSetExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListReadSetExportJobsResponse> ListReadSetExportJobsAsync(ListReadSetExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReadSetExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReadSetExportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReadSetExportJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListReadSetImportJobs

        internal virtual ListReadSetImportJobsResponse ListReadSetImportJobs(ListReadSetImportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReadSetImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReadSetImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListReadSetImportJobsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of read set import jobs and returns the data in JSON format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReadSetImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListReadSetImportJobsResponse> ListReadSetImportJobsAsync(ListReadSetImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReadSetImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReadSetImportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReadSetImportJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListReadSets

        internal virtual ListReadSetsResponse ListReadSets(ListReadSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReadSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReadSetsResponseUnmarshaller.Instance;

            return Invoke<ListReadSetsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of read sets from a sequence store ID and returns the metadata in
        /// JSON format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReadSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListReadSetsResponse> ListReadSetsAsync(ListReadSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReadSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReadSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReadSetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListReadSetUploadParts

        internal virtual ListReadSetUploadPartsResponse ListReadSetUploadParts(ListReadSetUploadPartsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReadSetUploadPartsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReadSetUploadPartsResponseUnmarshaller.Instance;

            return Invoke<ListReadSetUploadPartsResponse>(request, options);
        }



        /// <summary>
        /// Lists all parts in a multipart read set upload for a sequence store and returns the
        /// metadata in a JSON formatted output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReadSetUploadParts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReadSetUploadParts service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.NotSupportedOperationException">
        /// The operation is not supported by Amazon Omics, or the API does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSetUploadParts">REST API Reference for ListReadSetUploadParts Operation</seealso>
        public virtual Task<ListReadSetUploadPartsResponse> ListReadSetUploadPartsAsync(ListReadSetUploadPartsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReadSetUploadPartsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReadSetUploadPartsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReadSetUploadPartsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListReferenceImportJobs

        internal virtual ListReferenceImportJobsResponse ListReferenceImportJobs(ListReferenceImportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReferenceImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReferenceImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListReferenceImportJobsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the metadata of one or more reference import jobs for a reference store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReferenceImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListReferenceImportJobsResponse> ListReferenceImportJobsAsync(ListReferenceImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReferenceImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReferenceImportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReferenceImportJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListReferences

        internal virtual ListReferencesResponse ListReferences(ListReferencesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReferencesResponseUnmarshaller.Instance;

            return Invoke<ListReferencesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the metadata of one or more reference genomes in a reference store.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/create-reference-store.html">Creating
        /// a reference store</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListReferencesResponse> ListReferencesAsync(ListReferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReferencesResponseUnmarshaller.Instance;

            return InvokeAsync<ListReferencesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListReferenceStores

        internal virtual ListReferenceStoresResponse ListReferenceStores(ListReferenceStoresRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReferenceStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReferenceStoresResponseUnmarshaller.Instance;

            return Invoke<ListReferenceStoresResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of reference stores linked to your account and returns their metadata
        /// in JSON format.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/create-reference-store.html">Creating
        /// a reference store</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReferenceStores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListReferenceStoresResponse> ListReferenceStoresAsync(ListReferenceStoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReferenceStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReferenceStoresResponseUnmarshaller.Instance;

            return InvokeAsync<ListReferenceStoresResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRunCaches

        internal virtual ListRunCachesResponse ListRunCaches(ListRunCachesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRunCachesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRunCachesResponseUnmarshaller.Instance;

            return Invoke<ListRunCachesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of your run caches and the metadata for each cache.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRunCaches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRunCaches service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListRunCaches">REST API Reference for ListRunCaches Operation</seealso>
        public virtual Task<ListRunCachesResponse> ListRunCachesAsync(ListRunCachesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRunCachesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRunCachesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRunCachesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRunGroups

        internal virtual ListRunGroupsResponse ListRunGroups(ListRunGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRunGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRunGroupsResponseUnmarshaller.Instance;

            return Invoke<ListRunGroupsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of all run groups and returns the metadata for each run group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRunGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListRunGroupsResponse> ListRunGroupsAsync(ListRunGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRunGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRunGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRunGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRuns

        internal virtual ListRunsResponse ListRuns(ListRunsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRunsResponseUnmarshaller.Instance;

            return Invoke<ListRunsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of runs and returns each run's metadata and status.
        /// 
        ///  
        /// <para>
        /// Amazon Web Services HealthOmics stores a configurable number of runs, as determined
        /// by service limits, that are available to the console and API. If the <c>ListRuns</c>
        /// response doesn't include specific runs that you expected, you can find all run logs
        /// in the CloudWatch logs. For more information about viewing the run logs, see <a href="https://docs.aws.amazon.com/omics/latest/dev/monitoring-cloudwatch-logs.html">CloudWatch
        /// logs</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListRunsResponse> ListRunsAsync(ListRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRunsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRunsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRunTasks

        internal virtual ListRunTasksResponse ListRunTasks(ListRunTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRunTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRunTasksResponseUnmarshaller.Instance;

            return Invoke<ListRunTasksResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of tasks and status information within their specified run. Use this
        /// operation to monitor runs and to identify which specific tasks have failed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRunTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListRunTasksResponse> ListRunTasksAsync(ListRunTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRunTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRunTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListRunTasksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSequenceStores

        internal virtual ListSequenceStoresResponse ListSequenceStores(ListSequenceStoresRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSequenceStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSequenceStoresResponseUnmarshaller.Instance;

            return Invoke<ListSequenceStoresResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of sequence stores and returns each sequence store's metadata.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/create-sequence-store.html">Creating
        /// a HealthOmics sequence store</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSequenceStores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListSequenceStoresResponse> ListSequenceStoresAsync(ListSequenceStoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSequenceStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSequenceStoresResponseUnmarshaller.Instance;

            return InvokeAsync<ListSequenceStoresResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListShares

        internal virtual ListSharesResponse ListShares(ListSharesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSharesResponseUnmarshaller.Instance;

            return Invoke<ListSharesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the resource shares associated with an account. Use the filter parameter
        /// to retrieve a specific subset of the shares.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListShares service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListShares service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListShares">REST API Reference for ListShares Operation</seealso>
        public virtual Task<ListSharesResponse> ListSharesAsync(ListSharesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSharesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSharesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListVariantImportJobs

        internal virtual ListVariantImportJobsResponse ListVariantImportJobs(ListVariantImportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVariantImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVariantImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListVariantImportJobsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of variant import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVariantImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListVariantImportJobsResponse> ListVariantImportJobsAsync(ListVariantImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVariantImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVariantImportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVariantImportJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListVariantStores

        internal virtual ListVariantStoresResponse ListVariantStores(ListVariantStoresRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVariantStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVariantStoresResponseUnmarshaller.Instance;

            return Invoke<ListVariantStoresResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of variant stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVariantStores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListVariantStoresResponse> ListVariantStoresAsync(ListVariantStoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVariantStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVariantStoresResponseUnmarshaller.Instance;

            return InvokeAsync<ListVariantStoresResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWorkflows

        internal virtual ListWorkflowsResponse ListWorkflows(ListWorkflowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of existing workflows. You can filter for specific workflows by their
        /// name and type. Using the type parameter, specify <c>PRIVATE</c> to retrieve a list
        /// of private workflows or specify <c>READY2RUN</c> for a list of all Ready2Run workflows.
        /// If you do not specify the type of workflow, this operation returns a list of existing
        /// workflows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListWorkflowsResponse> ListWorkflowsAsync(ListWorkflowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkflowsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWorkflowVersions

        internal virtual ListWorkflowVersionsResponse ListWorkflowVersions(ListWorkflowVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowVersionsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the workflow versions for the specified workflow. For more information, see
        /// <a href="https://docs.aws.amazon.com/omics/latest/dev/workflow-versions.html">Workflow
        /// versioning in Amazon Web Services HealthOmics</a> in the <i>Amazon Web Services HealthOmics
        /// User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkflowVersions service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListWorkflowVersions">REST API Reference for ListWorkflowVersions Operation</seealso>
        public virtual Task<ListWorkflowVersionsResponse> ListWorkflowVersionsAsync(ListWorkflowVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkflowVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutS3AccessPolicy

        internal virtual PutS3AccessPolicyResponse PutS3AccessPolicy(PutS3AccessPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutS3AccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutS3AccessPolicyResponseUnmarshaller.Instance;

            return Invoke<PutS3AccessPolicyResponse>(request, options);
        }



        /// <summary>
        /// Adds an access policy to the specified store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutS3AccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutS3AccessPolicy service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.NotSupportedOperationException">
        /// The operation is not supported by Amazon Omics, or the API does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/PutS3AccessPolicy">REST API Reference for PutS3AccessPolicy Operation</seealso>
        public virtual Task<PutS3AccessPolicyResponse> PutS3AccessPolicyAsync(PutS3AccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutS3AccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutS3AccessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutS3AccessPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartAnnotationImportJob

        internal virtual StartAnnotationImportJobResponse StartAnnotationImportJob(StartAnnotationImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAnnotationImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAnnotationImportJobResponseUnmarshaller.Instance;

            return Invoke<StartAnnotationImportJobResponse>(request, options);
        }



        /// <summary>
        /// Starts an annotation import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAnnotationImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartAnnotationImportJobResponse> StartAnnotationImportJobAsync(StartAnnotationImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAnnotationImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAnnotationImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartAnnotationImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartReadSetActivationJob

        internal virtual StartReadSetActivationJobResponse StartReadSetActivationJob(StartReadSetActivationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartReadSetActivationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReadSetActivationJobResponseUnmarshaller.Instance;

            return Invoke<StartReadSetActivationJobResponse>(request, options);
        }



        /// <summary>
        /// Activates an archived read set and returns its metadata in a JSON formatted output.
        /// AWS HealthOmics automatically archives unused read sets after 30 days. To monitor
        /// the status of your read set activation job, use the <c>GetReadSetActivationJob</c>
        /// operation.
        /// 
        ///  
        /// <para>
        /// To learn more, see <a href="https://docs.aws.amazon.com/omics/latest/dev/activating-read-sets.html">Activating
        /// read sets</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReadSetActivationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartReadSetActivationJobResponse> StartReadSetActivationJobAsync(StartReadSetActivationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartReadSetActivationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReadSetActivationJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartReadSetActivationJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartReadSetExportJob

        internal virtual StartReadSetExportJobResponse StartReadSetExportJob(StartReadSetExportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartReadSetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReadSetExportJobResponseUnmarshaller.Instance;

            return Invoke<StartReadSetExportJobResponse>(request, options);
        }



        /// <summary>
        /// Starts a read set export job. When the export job is finished, the read set is exported
        /// to an Amazon S3 bucket which can be retrieved using the <c>GetReadSetExportJob</c>
        /// API operation.
        /// 
        ///  
        /// <para>
        /// To monitor the status of the export job, use the <c>ListReadSetExportJobs</c> API
        /// operation. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReadSetExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartReadSetExportJobResponse> StartReadSetExportJobAsync(StartReadSetExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartReadSetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReadSetExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartReadSetExportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartReadSetImportJob

        internal virtual StartReadSetImportJobResponse StartReadSetImportJob(StartReadSetImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartReadSetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReadSetImportJobResponseUnmarshaller.Instance;

            return Invoke<StartReadSetImportJobResponse>(request, options);
        }



        /// <summary>
        /// Imports a read set from the sequence store. Read set import jobs support a maximum
        /// of 100 read sets of different types. Monitor the progress of your read set import
        /// job by calling the <c>GetReadSetImportJob</c> API operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReadSetImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartReadSetImportJobResponse> StartReadSetImportJobAsync(StartReadSetImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartReadSetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReadSetImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartReadSetImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartReferenceImportJob

        internal virtual StartReferenceImportJobResponse StartReferenceImportJob(StartReferenceImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartReferenceImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReferenceImportJobResponseUnmarshaller.Instance;

            return Invoke<StartReferenceImportJobResponse>(request, options);
        }



        /// <summary>
        /// Imports a reference genome from Amazon S3 into a specified reference store. You can
        /// have multiple reference genomes in a reference store. You can only import reference
        /// genomes one at a time into each reference store. Monitor the status of your reference
        /// import job by using the <c>GetReferenceImportJob</c> API operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReferenceImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartReferenceImportJobResponse> StartReferenceImportJobAsync(StartReferenceImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartReferenceImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReferenceImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartReferenceImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartRun

        internal virtual StartRunResponse StartRun(StartRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRunResponseUnmarshaller.Instance;

            return Invoke<StartRunResponse>(request, options);
        }



        /// <summary>
        /// Starts a new run and returns details about the run, or duplicates an existing run.
        /// A run is a single invocation of a workflow. If you provide request IDs, Amazon Web
        /// Services HealthOmics identifies duplicate requests and starts the run only once. Monitor
        /// the progress of the run by calling the <c>GetRun</c> API operation.
        /// 
        ///  
        /// <para>
        /// To start a new run, the following inputs are required:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A service role ARN (<c>roleArn</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The run's workflow ID (<c>workflowId</c>, not the <c>uuid</c> or <c>runId</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Amazon S3 location (<c>outputUri</c>) where the run outputs will be saved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All required workflow parameters (<c>parameter</c>), which can include optional parameters
        /// from the parameter template. The run cannot include any parameters that are not defined
        /// in the parameter template. To see all possible parameters, use the <c>GetRun</c> API
        /// operation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For runs with a <c>STATIC</c> (default) storage type, specify the required storage
        /// capacity (in gibibytes). A storage capacity value is not required for runs that use
        /// <c>DYNAMIC</c> storage.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>StartRun</c> can also duplicate an existing run using the run's default values.
        /// You can modify these default values and/or add other optional inputs. To duplicate
        /// a run, the following inputs are required:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A service role ARN (<c>roleArn</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ID of the run to duplicate (<c>runId</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Amazon S3 location where the run outputs will be saved (<c>outputUri</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn more about the optional parameters for <c>StartRun</c>, see <a href="https://docs.aws.amazon.com/omics/latest/dev/starting-a-run.html">Starting
        /// a run</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>retentionMode</c> input to control how long the metadata for each run is
        /// stored in CloudWatch. There are two retention modes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify <c>REMOVE</c> to automatically remove the oldest runs when you reach the maximum
        /// service retention limit for runs. It is recommended that you use the <c>REMOVE</c>
        /// mode to initiate major run requests so that your runs do not fail when you reach the
        /// limit.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>retentionMode</c> is set to the <c>RETAIN</c> mode by default, which allows
        /// you to manually remove runs after reaching the maximum service retention limit. Under
        /// this setting, you cannot create additional runs until you remove the excess runs.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn more about the retention modes, see <a href="https://docs.aws.amazon.com/omics/latest/dev/run-retention.html">Run
        /// retention mode</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartRunResponse> StartRunAsync(StartRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartRunResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartVariantImportJob

        internal virtual StartVariantImportJobResponse StartVariantImportJob(StartVariantImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartVariantImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartVariantImportJobResponseUnmarshaller.Instance;

            return Invoke<StartVariantImportJobResponse>(request, options);
        }



        /// <summary>
        /// Starts a variant import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartVariantImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartVariantImportJobResponse> StartVariantImportJobAsync(StartVariantImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartVariantImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartVariantImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartVariantImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAnnotationStore

        internal virtual UpdateAnnotationStoreResponse UpdateAnnotationStore(UpdateAnnotationStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAnnotationStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnnotationStoreResponseUnmarshaller.Instance;

            return Invoke<UpdateAnnotationStoreResponse>(request, options);
        }



        /// <summary>
        /// Updates an annotation store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnnotationStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateAnnotationStoreResponse> UpdateAnnotationStoreAsync(UpdateAnnotationStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAnnotationStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnnotationStoreResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAnnotationStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAnnotationStoreVersion

        internal virtual UpdateAnnotationStoreVersionResponse UpdateAnnotationStoreVersion(UpdateAnnotationStoreVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAnnotationStoreVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnnotationStoreVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateAnnotationStoreVersionResponse>(request, options);
        }



        /// <summary>
        /// Updates the description of an annotation store version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnnotationStoreVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAnnotationStoreVersion service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateAnnotationStoreVersion">REST API Reference for UpdateAnnotationStoreVersion Operation</seealso>
        public virtual Task<UpdateAnnotationStoreVersionResponse> UpdateAnnotationStoreVersionAsync(UpdateAnnotationStoreVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAnnotationStoreVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnnotationStoreVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAnnotationStoreVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRunCache

        internal virtual UpdateRunCacheResponse UpdateRunCache(UpdateRunCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRunCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRunCacheResponseUnmarshaller.Instance;

            return Invoke<UpdateRunCacheResponse>(request, options);
        }



        /// <summary>
        /// Updates a run cache using its ID and returns a response with no body if the operation
        /// is successful. You can update the run cache description, name, or the default run
        /// cache behavior with <c>CACHE_ON_FAILURE</c> or <c>CACHE_ALWAYS</c>. To confirm that
        /// your run cache settings have been properly updated, use the <c>GetRunCache</c> API
        /// operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/how-run-cache.html">How
        /// call caching works</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRunCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRunCache service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateRunCache">REST API Reference for UpdateRunCache Operation</seealso>
        public virtual Task<UpdateRunCacheResponse> UpdateRunCacheAsync(UpdateRunCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRunCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRunCacheResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRunCacheResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRunGroup

        internal virtual UpdateRunGroupResponse UpdateRunGroup(UpdateRunGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRunGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRunGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateRunGroupResponse>(request, options);
        }



        /// <summary>
        /// Updates the settings of a run group and returns a response with no body if the operation
        /// is successful.
        /// 
        ///  
        /// <para>
        /// You can update the following settings with <c>UpdateRunGroup</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of CPUs
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Run time (measured in minutes)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Number of GPUs
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Number of concurrent runs
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Group name
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To confirm that the settings have been successfully updated, use the <c>ListRunGroups</c>
        /// or <c>GetRunGroup</c> API operations to verify that the desired changes have been
        /// made.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRunGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateRunGroupResponse> UpdateRunGroupAsync(UpdateRunGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRunGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRunGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRunGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSequenceStore

        internal virtual UpdateSequenceStoreResponse UpdateSequenceStore(UpdateSequenceStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSequenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSequenceStoreResponseUnmarshaller.Instance;

            return Invoke<UpdateSequenceStoreResponse>(request, options);
        }



        /// <summary>
        /// Update one or more parameters for the sequence store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSequenceStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSequenceStore service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateSequenceStore">REST API Reference for UpdateSequenceStore Operation</seealso>
        public virtual Task<UpdateSequenceStoreResponse> UpdateSequenceStoreAsync(UpdateSequenceStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSequenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSequenceStoreResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSequenceStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateVariantStore

        internal virtual UpdateVariantStoreResponse UpdateVariantStore(UpdateVariantStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVariantStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVariantStoreResponseUnmarshaller.Instance;

            return Invoke<UpdateVariantStoreResponse>(request, options);
        }



        /// <summary>
        /// Updates a variant store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVariantStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateVariantStoreResponse> UpdateVariantStoreAsync(UpdateVariantStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVariantStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVariantStoreResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVariantStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateWorkflow

        internal virtual UpdateWorkflowResponse UpdateWorkflow(UpdateWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkflowResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkflowResponse>(request, options);
        }



        /// <summary>
        /// Updates information about a workflow.
        /// 
        ///  
        /// <para>
        /// You can update the following workflow information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Description
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Default storage type
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Default storage capacity (with workflow ID)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation returns a response with no body if the operation is successful. You
        /// can check the workflow updates by calling the <c>GetWorkflow</c> API operation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/update-private-workflow.html">Update
        /// a private workflow</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateWorkflowResponse> UpdateWorkflowAsync(UpdateWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkflowResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorkflowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateWorkflowVersion

        internal virtual UpdateWorkflowVersionResponse UpdateWorkflowVersion(UpdateWorkflowVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkflowVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkflowVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkflowVersionResponse>(request, options);
        }



        /// <summary>
        /// Updates information about the workflow version. For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/workflow-versions.html">Workflow
        /// versioning in Amazon Web Services HealthOmics</a> in the <i>Amazon Web Services HealthOmics
        /// User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflowVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkflowVersion service method, as returned by Omics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateWorkflowVersion">REST API Reference for UpdateWorkflowVersion Operation</seealso>
        public virtual Task<UpdateWorkflowVersionResponse> UpdateWorkflowVersionAsync(UpdateWorkflowVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkflowVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkflowVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorkflowVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UploadReadSetPart

        internal virtual UploadReadSetPartResponse UploadReadSetPart(UploadReadSetPartRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UploadReadSetPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadReadSetPartResponseUnmarshaller.Instance;

            return Invoke<UploadReadSetPartResponse>(request, options);
        }



        /// <summary>
        /// Uploads a specific part of a read set into a sequence store. When you a upload a read
        /// set part with a part number that already exists, the new part replaces the existing
        /// one. This operation returns a JSON formatted response containing a string identifier
        /// that is used to confirm that parts are being added to the intended upload.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/synchronous-uploads.html">Direct
        /// upload to a sequence store</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadReadSetPart service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UploadReadSetPart service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.NotSupportedOperationException">
        /// The operation is not supported by Amazon Omics, or the API does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UploadReadSetPart">REST API Reference for UploadReadSetPart Operation</seealso>
        public virtual Task<UploadReadSetPartResponse> UploadReadSetPartAsync(UploadReadSetPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UploadReadSetPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadReadSetPartResponseUnmarshaller.Instance;

            return InvokeAsync<UploadReadSetPartResponse>(request, options, cancellationToken);
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
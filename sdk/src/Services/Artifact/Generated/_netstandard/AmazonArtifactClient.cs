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
 * Do not modify this file. This file is generated from the artifact-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Artifact.Model;
using Amazon.Artifact.Model.Internal.MarshallTransformations;
using Amazon.Artifact.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Artifact
{
    /// <summary>
    /// <para>Implementation for accessing Artifact</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// This reference provides descriptions of the low-level AWS Artifact Service API.
    /// </summary>
    public partial class AmazonArtifactClient : AmazonServiceClient, IAmazonArtifact
    {
        private static IServiceMetadata serviceMetadata = new AmazonArtifactMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonArtifactClient with the credentials loaded from the application's
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
        public AmazonArtifactClient()
            : base(new AmazonArtifactConfig()) { }

        /// <summary>
        /// Constructs AmazonArtifactClient with the credentials loaded from the application's
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
        public AmazonArtifactClient(RegionEndpoint region)
            : base(new AmazonArtifactConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonArtifactClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonArtifactClient Configuration Object</param>
        public AmazonArtifactClient(AmazonArtifactConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonArtifactClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonArtifactClient(AWSCredentials credentials)
            : this(credentials, new AmazonArtifactConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonArtifactClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonArtifactClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonArtifactConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonArtifactClient with AWS Credentials and an
        /// AmazonArtifactClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonArtifactClient Configuration Object</param>
        public AmazonArtifactClient(AWSCredentials credentials, AmazonArtifactConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonArtifactClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonArtifactClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonArtifactConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonArtifactClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonArtifactClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonArtifactConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonArtifactClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonArtifactClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonArtifactClient Configuration Object</param>
        public AmazonArtifactClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonArtifactConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonArtifactClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonArtifactClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonArtifactConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonArtifactClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonArtifactClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonArtifactConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonArtifactClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonArtifactClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonArtifactClient Configuration Object</param>
        public AmazonArtifactClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonArtifactConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IArtifactPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IArtifactPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ArtifactPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonArtifactEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonArtifactAuthSchemeHandler());
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


        #region  CreateComplianceInquiry

        internal virtual CreateComplianceInquiryResponse CreateComplianceInquiry(CreateComplianceInquiryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateComplianceInquiryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComplianceInquiryResponseUnmarshaller.Instance;

            return Invoke<CreateComplianceInquiryResponse>(request, options);
        }



        /// <summary>
        /// Create a new compliance inquiry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComplianceInquiry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateComplianceInquiry service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ConflictException">
        /// Request to create/modify content would result in a conflict.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/CreateComplianceInquiry">REST API Reference for CreateComplianceInquiry Operation</seealso>
        public virtual Task<CreateComplianceInquiryResponse> CreateComplianceInquiryAsync(CreateComplianceInquiryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateComplianceInquiryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComplianceInquiryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateComplianceInquiryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExportComplianceInquiry

        internal virtual ExportComplianceInquiryResponse ExportComplianceInquiry(ExportComplianceInquiryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportComplianceInquiryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportComplianceInquiryResponseUnmarshaller.Instance;

            return Invoke<ExportComplianceInquiryResponse>(request, options);
        }



        /// <summary>
        /// Export a compliance inquiry report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportComplianceInquiry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportComplianceInquiry service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/ExportComplianceInquiry">REST API Reference for ExportComplianceInquiry Operation</seealso>
        public virtual Task<ExportComplianceInquiryResponse> ExportComplianceInquiryAsync(ExportComplianceInquiryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportComplianceInquiryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportComplianceInquiryResponseUnmarshaller.Instance;

            return InvokeAsync<ExportComplianceInquiryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAccountSettings

        internal virtual GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<GetAccountSettingsResponse>(request, options);
        }



        /// <summary>
        /// Get the account settings for Artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ConflictException">
        /// Request to create/modify content would result in a conflict.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual Task<GetAccountSettingsResponse> GetAccountSettingsAsync(GetAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetComplianceInquiryMetadata

        internal virtual GetComplianceInquiryMetadataResponse GetComplianceInquiryMetadata(GetComplianceInquiryMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComplianceInquiryMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceInquiryMetadataResponseUnmarshaller.Instance;

            return Invoke<GetComplianceInquiryMetadataResponse>(request, options);
        }



        /// <summary>
        /// Get the metadata for a single compliance inquiry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceInquiryMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComplianceInquiryMetadata service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/GetComplianceInquiryMetadata">REST API Reference for GetComplianceInquiryMetadata Operation</seealso>
        public virtual Task<GetComplianceInquiryMetadataResponse> GetComplianceInquiryMetadataAsync(GetComplianceInquiryMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComplianceInquiryMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceInquiryMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<GetComplianceInquiryMetadataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetReport

        internal virtual GetReportResponse GetReport(GetReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReportResponseUnmarshaller.Instance;

            return Invoke<GetReportResponse>(request, options);
        }



        /// <summary>
        /// Get the content for a single report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReport service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ConflictException">
        /// Request to create/modify content would result in a conflict.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/GetReport">REST API Reference for GetReport Operation</seealso>
        public virtual Task<GetReportResponse> GetReportAsync(GetReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReportResponseUnmarshaller.Instance;

            return InvokeAsync<GetReportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetReportMetadata

        internal virtual GetReportMetadataResponse GetReportMetadata(GetReportMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReportMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReportMetadataResponseUnmarshaller.Instance;

            return Invoke<GetReportMetadataResponse>(request, options);
        }



        /// <summary>
        /// Get the metadata for a single report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReportMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReportMetadata service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/GetReportMetadata">REST API Reference for GetReportMetadata Operation</seealso>
        public virtual Task<GetReportMetadataResponse> GetReportMetadataAsync(GetReportMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReportMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReportMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<GetReportMetadataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTermForReport

        internal virtual GetTermForReportResponse GetTermForReport(GetTermForReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTermForReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTermForReportResponseUnmarshaller.Instance;

            return Invoke<GetTermForReportResponse>(request, options);
        }



        /// <summary>
        /// Get the Term content associated with a single report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTermForReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTermForReport service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ConflictException">
        /// Request to create/modify content would result in a conflict.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/GetTermForReport">REST API Reference for GetTermForReport Operation</seealso>
        public virtual Task<GetTermForReportResponse> GetTermForReportAsync(GetTermForReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTermForReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTermForReportResponseUnmarshaller.Instance;

            return InvokeAsync<GetTermForReportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListComplianceInquiries

        internal virtual ListComplianceInquiriesResponse ListComplianceInquiries(ListComplianceInquiriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComplianceInquiriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComplianceInquiriesResponseUnmarshaller.Instance;

            return Invoke<ListComplianceInquiriesResponse>(request, options);
        }



        /// <summary>
        /// List available compliance inquiries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComplianceInquiries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComplianceInquiries service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/ListComplianceInquiries">REST API Reference for ListComplianceInquiries Operation</seealso>
        public virtual Task<ListComplianceInquiriesResponse> ListComplianceInquiriesAsync(ListComplianceInquiriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComplianceInquiriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComplianceInquiriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListComplianceInquiriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListComplianceInquiryQueries

        internal virtual ListComplianceInquiryQueriesResponse ListComplianceInquiryQueries(ListComplianceInquiryQueriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComplianceInquiryQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComplianceInquiryQueriesResponseUnmarshaller.Instance;

            return Invoke<ListComplianceInquiryQueriesResponse>(request, options);
        }



        /// <summary>
        /// List queries within a compliance inquiry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComplianceInquiryQueries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComplianceInquiryQueries service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/ListComplianceInquiryQueries">REST API Reference for ListComplianceInquiryQueries Operation</seealso>
        public virtual Task<ListComplianceInquiryQueriesResponse> ListComplianceInquiryQueriesAsync(ListComplianceInquiryQueriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComplianceInquiryQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComplianceInquiryQueriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListComplianceInquiryQueriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCustomerAgreements

        internal virtual ListCustomerAgreementsResponse ListCustomerAgreements(ListCustomerAgreementsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomerAgreementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomerAgreementsResponseUnmarshaller.Instance;

            return Invoke<ListCustomerAgreementsResponse>(request, options);
        }



        /// <summary>
        /// List active customer-agreements applicable to calling identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomerAgreements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomerAgreements service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/ListCustomerAgreements">REST API Reference for ListCustomerAgreements Operation</seealso>
        public virtual Task<ListCustomerAgreementsResponse> ListCustomerAgreementsAsync(ListCustomerAgreementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomerAgreementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomerAgreementsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCustomerAgreementsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListReports

        internal virtual ListReportsResponse ListReports(ListReportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportsResponseUnmarshaller.Instance;

            return Invoke<ListReportsResponse>(request, options);
        }



        /// <summary>
        /// List available reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReports service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/ListReports">REST API Reference for ListReports Operation</seealso>
        public virtual Task<ListReportsResponse> ListReportsAsync(ListReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReportsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListReportVersions

        internal virtual ListReportVersionsResponse ListReportVersions(ListReportVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReportVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportVersionsResponseUnmarshaller.Instance;

            return Invoke<ListReportVersionsResponse>(request, options);
        }



        /// <summary>
        /// List available report versions for a given report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReportVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReportVersions service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/ListReportVersions">REST API Reference for ListReportVersions Operation</seealso>
        public virtual Task<ListReportVersionsResponse> ListReportVersionsAsync(ListReportVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReportVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReportVersionsResponse>(request, options, cancellationToken);
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
        /// List tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutAccountSettings

        internal virtual PutAccountSettingsResponse PutAccountSettings(PutAccountSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<PutAccountSettingsResponse>(request, options);
        }



        /// <summary>
        /// Put the account settings for Artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountSettings service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ConflictException">
        /// Request to create/modify content would result in a conflict.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/PutAccountSettings">REST API Reference for PutAccountSettings Operation</seealso>
        public virtual Task<PutAccountSettingsResponse> PutAccountSettingsAsync(PutAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<PutAccountSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutComplianceInquiryFeedback

        internal virtual PutComplianceInquiryFeedbackResponse PutComplianceInquiryFeedback(PutComplianceInquiryFeedbackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutComplianceInquiryFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutComplianceInquiryFeedbackResponseUnmarshaller.Instance;

            return Invoke<PutComplianceInquiryFeedbackResponse>(request, options);
        }



        /// <summary>
        /// Submits feedback on a compliance inquiry response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutComplianceInquiryFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutComplianceInquiryFeedback service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ConflictException">
        /// Request to create/modify content would result in a conflict.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/PutComplianceInquiryFeedback">REST API Reference for PutComplianceInquiryFeedback Operation</seealso>
        public virtual Task<PutComplianceInquiryFeedbackResponse> PutComplianceInquiryFeedbackAsync(PutComplianceInquiryFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutComplianceInquiryFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutComplianceInquiryFeedbackResponseUnmarshaller.Instance;

            return InvokeAsync<PutComplianceInquiryFeedbackResponse>(request, options, cancellationToken);
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
        /// Add tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Remove tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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
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
    ///
    /// This reference provides descriptions of the low-level AWS Artifact Service API.
    /// </summary>
    public partial class AmazonArtifactClient : AmazonServiceClient, IAmazonArtifact
    {
        private static IServiceMetadata serviceMetadata = new AmazonArtifactMetadata();
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

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
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


        #region  GetAccountSettings


        /// <summary>
        /// Get the account settings for Artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
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
        public virtual GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request)
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
        
        #region  GetReport


        /// <summary>
        /// Get the content for a single report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReport service method.</param>
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
        public virtual GetReportResponse GetReport(GetReportRequest request)
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


        /// <summary>
        /// Get the metadata for a single report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReportMetadata service method.</param>
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
        public virtual GetReportMetadataResponse GetReportMetadata(GetReportMetadataRequest request)
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


        /// <summary>
        /// Get the Term content associated with a single report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTermForReport service method.</param>
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
        public virtual GetTermForReportResponse GetTermForReport(GetTermForReportRequest request)
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
        
        #region  ListCustomerAgreements


        /// <summary>
        /// List active customer-agreements applicable to calling identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomerAgreements service method.</param>
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
        public virtual ListCustomerAgreementsResponse ListCustomerAgreements(ListCustomerAgreementsRequest request)
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


        /// <summary>
        /// List available reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReports service method.</param>
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
        public virtual ListReportsResponse ListReports(ListReportsRequest request)
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
        
        #region  PutAccountSettings


        /// <summary>
        /// Put the account settings for Artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSettings service method.</param>
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
        public virtual PutAccountSettingsResponse PutAccountSettings(PutAccountSettingsRequest request)
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
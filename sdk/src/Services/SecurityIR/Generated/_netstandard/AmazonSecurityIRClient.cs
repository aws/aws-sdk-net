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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SecurityIR.Model;
using Amazon.SecurityIR.Model.Internal.MarshallTransformations;
using Amazon.SecurityIR.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.SecurityIR
{
    /// <summary>
    /// <para>Implementation for accessing SecurityIR</para>
    ///
    /// This guide documents the action and response elements for use of the service.
    /// </summary>
    public partial class AmazonSecurityIRClient : AmazonServiceClient, IAmazonSecurityIR
    {
        private static IServiceMetadata serviceMetadata = new AmazonSecurityIRMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSecurityIRClient with the credentials loaded from the application's
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
        public AmazonSecurityIRClient()
            : base(new AmazonSecurityIRConfig()) { }

        /// <summary>
        /// Constructs AmazonSecurityIRClient with the credentials loaded from the application's
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
        public AmazonSecurityIRClient(RegionEndpoint region)
            : base(new AmazonSecurityIRConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSecurityIRClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSecurityIRClient Configuration Object</param>
        public AmazonSecurityIRClient(AmazonSecurityIRConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonSecurityIRClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSecurityIRClient(AWSCredentials credentials)
            : this(credentials, new AmazonSecurityIRConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityIRClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityIRClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSecurityIRConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityIRClient with AWS Credentials and an
        /// AmazonSecurityIRClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSecurityIRClient Configuration Object</param>
        public AmazonSecurityIRClient(AWSCredentials credentials, AmazonSecurityIRConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityIRClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSecurityIRClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecurityIRConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityIRClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityIRClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecurityIRConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityIRClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecurityIRClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSecurityIRClient Configuration Object</param>
        public AmazonSecurityIRClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSecurityIRConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityIRClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSecurityIRClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecurityIRConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityIRClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityIRClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecurityIRConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityIRClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecurityIRClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSecurityIRClient Configuration Object</param>
        public AmazonSecurityIRClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSecurityIRConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ISecurityIRPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISecurityIRPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SecurityIRPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSecurityIREndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSecurityIRAuthSchemeHandler());
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


        #region  BatchGetMemberAccountDetails

        internal virtual BatchGetMemberAccountDetailsResponse BatchGetMemberAccountDetails(BatchGetMemberAccountDetailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetMemberAccountDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetMemberAccountDetailsResponseUnmarshaller.Instance;

            return Invoke<BatchGetMemberAccountDetailsResponse>(request, options);
        }



        /// <summary>
        /// Provides information on whether the supplied account IDs are associated with a membership.
        /// 
        ///  <note> 
        /// <para>
        ///  AWS account ID's may appear less than 12 characters and need to be zero-prepended.
        /// An example would be <c>123123123</c> which is nine digits, and with zero-prepend would
        /// be <c>000123123123</c>. Not zero-prepending to 12 digits could result in errors. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetMemberAccountDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetMemberAccountDetails service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/BatchGetMemberAccountDetails">REST API Reference for BatchGetMemberAccountDetails Operation</seealso>
        public virtual Task<BatchGetMemberAccountDetailsResponse> BatchGetMemberAccountDetailsAsync(BatchGetMemberAccountDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetMemberAccountDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetMemberAccountDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetMemberAccountDetailsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelMembership

        internal virtual CancelMembershipResponse CancelMembership(CancelMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMembershipResponseUnmarshaller.Instance;

            return Invoke<CancelMembershipResponse>(request, options);
        }



        /// <summary>
        /// Cancels an existing membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelMembership service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CancelMembership">REST API Reference for CancelMembership Operation</seealso>
        public virtual Task<CancelMembershipResponse> CancelMembershipAsync(CancelMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<CancelMembershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CloseCase

        internal virtual CloseCaseResponse CloseCase(CloseCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CloseCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloseCaseResponseUnmarshaller.Instance;

            return Invoke<CloseCaseResponse>(request, options);
        }



        /// <summary>
        /// Closes an existing case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloseCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CloseCase service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CloseCase">REST API Reference for CloseCase Operation</seealso>
        public virtual Task<CloseCaseResponse> CloseCaseAsync(CloseCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CloseCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloseCaseResponseUnmarshaller.Instance;

            return InvokeAsync<CloseCaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCase

        internal virtual CreateCaseResponse CreateCase(CreateCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCaseResponseUnmarshaller.Instance;

            return Invoke<CreateCaseResponse>(request, options);
        }



        /// <summary>
        /// Creates a new case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCase service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateCase">REST API Reference for CreateCase Operation</seealso>
        public virtual Task<CreateCaseResponse> CreateCaseAsync(CreateCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCaseResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCaseComment

        internal virtual CreateCaseCommentResponse CreateCaseComment(CreateCaseCommentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCaseCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCaseCommentResponseUnmarshaller.Instance;

            return Invoke<CreateCaseCommentResponse>(request, options);
        }



        /// <summary>
        /// Adds a comment to an existing case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCaseComment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCaseComment service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateCaseComment">REST API Reference for CreateCaseComment Operation</seealso>
        public virtual Task<CreateCaseCommentResponse> CreateCaseCommentAsync(CreateCaseCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCaseCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCaseCommentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCaseCommentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateMembership

        internal virtual CreateMembershipResponse CreateMembership(CreateMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMembershipResponseUnmarshaller.Instance;

            return Invoke<CreateMembershipResponse>(request, options);
        }



        /// <summary>
        /// Creates a new membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMembership service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        public virtual Task<CreateMembershipResponse> CreateMembershipAsync(CreateMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMembershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCase

        internal virtual GetCaseResponse GetCase(GetCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCaseResponseUnmarshaller.Instance;

            return Invoke<GetCaseResponse>(request, options);
        }



        /// <summary>
        /// Returns the attributes of a case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCase service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCase">REST API Reference for GetCase Operation</seealso>
        public virtual Task<GetCaseResponse> GetCaseAsync(GetCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCaseResponseUnmarshaller.Instance;

            return InvokeAsync<GetCaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCaseAttachmentDownloadUrl

        internal virtual GetCaseAttachmentDownloadUrlResponse GetCaseAttachmentDownloadUrl(GetCaseAttachmentDownloadUrlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCaseAttachmentDownloadUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCaseAttachmentDownloadUrlResponseUnmarshaller.Instance;

            return Invoke<GetCaseAttachmentDownloadUrlResponse>(request, options);
        }



        /// <summary>
        /// Returns a Pre-Signed URL for uploading attachments into a case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCaseAttachmentDownloadUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCaseAttachmentDownloadUrl service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCaseAttachmentDownloadUrl">REST API Reference for GetCaseAttachmentDownloadUrl Operation</seealso>
        public virtual Task<GetCaseAttachmentDownloadUrlResponse> GetCaseAttachmentDownloadUrlAsync(GetCaseAttachmentDownloadUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCaseAttachmentDownloadUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCaseAttachmentDownloadUrlResponseUnmarshaller.Instance;

            return InvokeAsync<GetCaseAttachmentDownloadUrlResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCaseAttachmentUploadUrl

        internal virtual GetCaseAttachmentUploadUrlResponse GetCaseAttachmentUploadUrl(GetCaseAttachmentUploadUrlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCaseAttachmentUploadUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCaseAttachmentUploadUrlResponseUnmarshaller.Instance;

            return Invoke<GetCaseAttachmentUploadUrlResponse>(request, options);
        }



        /// <summary>
        /// Uploads an attachment to a case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCaseAttachmentUploadUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCaseAttachmentUploadUrl service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetCaseAttachmentUploadUrl">REST API Reference for GetCaseAttachmentUploadUrl Operation</seealso>
        public virtual Task<GetCaseAttachmentUploadUrlResponse> GetCaseAttachmentUploadUrlAsync(GetCaseAttachmentUploadUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCaseAttachmentUploadUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCaseAttachmentUploadUrlResponseUnmarshaller.Instance;

            return InvokeAsync<GetCaseAttachmentUploadUrlResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMembership

        internal virtual GetMembershipResponse GetMembership(GetMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMembershipResponseUnmarshaller.Instance;

            return Invoke<GetMembershipResponse>(request, options);
        }



        /// <summary>
        /// Returns the attributes of a membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMembership service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/GetMembership">REST API Reference for GetMembership Operation</seealso>
        public virtual Task<GetMembershipResponse> GetMembershipAsync(GetMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<GetMembershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCaseEdits

        internal virtual ListCaseEditsResponse ListCaseEdits(ListCaseEditsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCaseEditsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCaseEditsResponseUnmarshaller.Instance;

            return Invoke<ListCaseEditsResponse>(request, options);
        }



        /// <summary>
        /// Views the case history for edits made to a designated case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCaseEdits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCaseEdits service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListCaseEdits">REST API Reference for ListCaseEdits Operation</seealso>
        public virtual Task<ListCaseEditsResponse> ListCaseEditsAsync(ListCaseEditsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCaseEditsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCaseEditsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCaseEditsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCases

        internal virtual ListCasesResponse ListCases(ListCasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCasesResponseUnmarshaller.Instance;

            return Invoke<ListCasesResponse>(request, options);
        }



        /// <summary>
        /// Lists all cases the requester has access to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCases service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListCases">REST API Reference for ListCases Operation</seealso>
        public virtual Task<ListCasesResponse> ListCasesAsync(ListCasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCasesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListComments

        internal virtual ListCommentsResponse ListComments(ListCommentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCommentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCommentsResponseUnmarshaller.Instance;

            return Invoke<ListCommentsResponse>(request, options);
        }



        /// <summary>
        /// Returns comments for a designated case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComments service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListComments">REST API Reference for ListComments Operation</seealso>
        public virtual Task<ListCommentsResponse> ListCommentsAsync(ListCommentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCommentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCommentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCommentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMemberships

        internal virtual ListMembershipsResponse ListMemberships(ListMembershipsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembershipsResponseUnmarshaller.Instance;

            return Invoke<ListMembershipsResponse>(request, options);
        }



        /// <summary>
        /// Returns the memberships that the calling principal can access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMemberships service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        public virtual Task<ListMembershipsResponse> ListMembershipsAsync(ListMembershipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembershipsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMembershipsResponse>(request, options, cancellationToken);
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
        /// Returns currently configured tags on a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
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
        /// Adds a tag(s) to a designated resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes a tag(s) from a designate resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateCase

        internal virtual UpdateCaseResponse UpdateCase(UpdateCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCaseResponseUnmarshaller.Instance;

            return Invoke<UpdateCaseResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing case.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCase service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCase">REST API Reference for UpdateCase Operation</seealso>
        public virtual Task<UpdateCaseResponse> UpdateCaseAsync(UpdateCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCaseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateCaseComment

        internal virtual UpdateCaseCommentResponse UpdateCaseComment(UpdateCaseCommentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCaseCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCaseCommentResponseUnmarshaller.Instance;

            return Invoke<UpdateCaseCommentResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing case comment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCaseComment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCaseComment service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCaseComment">REST API Reference for UpdateCaseComment Operation</seealso>
        public virtual Task<UpdateCaseCommentResponse> UpdateCaseCommentAsync(UpdateCaseCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCaseCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCaseCommentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCaseCommentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateCaseStatus

        internal virtual UpdateCaseStatusResponse UpdateCaseStatus(UpdateCaseStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCaseStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCaseStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateCaseStatusResponse>(request, options);
        }



        /// <summary>
        /// Updates the state transitions for a designated cases.
        /// 
        ///  
        /// <para>
        ///  <b>Self-managed</b>: the following states are available for self-managed cases. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Submitted → Detection and Analysis
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Detection and Analysis → Containment, Eradication, and Recovery
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Detection and Analysis → Post-incident Activities
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Containment, Eradication, and Recovery → Detection and Analysis
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Containment, Eradication, and Recovery → Post-incident Activities
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Post-incident Activities → Containment, Eradication, and Recovery
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Post-incident Activities → Detection and Analysis
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any → Closed
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>AWS supported</b>: You must use the <c>CloseCase</c> API to close. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCaseStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCaseStatus service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateCaseStatus">REST API Reference for UpdateCaseStatus Operation</seealso>
        public virtual Task<UpdateCaseStatusResponse> UpdateCaseStatusAsync(UpdateCaseStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCaseStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCaseStatusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCaseStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateMembership

        internal virtual UpdateMembershipResponse UpdateMembership(UpdateMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMembershipResponseUnmarshaller.Instance;

            return Invoke<UpdateMembershipResponse>(request, options);
        }



        /// <summary>
        /// Updates membership configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMembership service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateMembership">REST API Reference for UpdateMembership Operation</seealso>
        public virtual Task<UpdateMembershipResponse> UpdateMembershipAsync(UpdateMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMembershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateResolverType

        internal virtual UpdateResolverTypeResponse UpdateResolverType(UpdateResolverTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResolverTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverTypeResponseUnmarshaller.Instance;

            return Invoke<UpdateResolverTypeResponse>(request, options);
        }



        /// <summary>
        /// Updates the resolver type for a case.
        /// 
        ///  <important> 
        /// <para>
        /// This is a one-way action and cannot be reversed.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResolverType service method, as returned by SecurityIR.</returns>
        /// <exception cref="Amazon.SecurityIR.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.InvalidTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.SecurityIncidentResponseNotActiveException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SecurityIR.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/security-ir-2018-05-10/UpdateResolverType">REST API Reference for UpdateResolverType Operation</seealso>
        public virtual Task<UpdateResolverTypeResponse> UpdateResolverTypeAsync(UpdateResolverTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResolverTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverTypeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResolverTypeResponse>(request, options, cancellationToken);
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
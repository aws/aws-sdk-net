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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.WellArchitected.Model;
using Amazon.WellArchitected.Model.Internal.MarshallTransformations;
using Amazon.WellArchitected.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.WellArchitected
{
    /// <summary>
    /// Implementation for accessing WellArchitected
    ///
    /// Well-Architected Tool 
    /// <para>
    /// This is the <i>Well-Architected Tool API Reference</i>. The WA Tool API provides programmatic
    /// access to the <a href="http://aws.amazon.com/well-architected-tool">Well-Architected
    /// Tool</a> in the <a href="https://console.aws.amazon.com/wellarchitected">Amazon Web
    /// Services Management Console</a>. For information about the Well-Architected Tool,
    /// see the <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/intro.html">Well-Architected
    /// Tool User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonWellArchitectedClient : AmazonServiceClient, IAmazonWellArchitected
    {
        private static IServiceMetadata serviceMetadata = new AmazonWellArchitectedMetadata();
        private IWellArchitectedPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IWellArchitectedPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new WellArchitectedPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonWellArchitectedClient with the credentials loaded from the application's
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
        public AmazonWellArchitectedClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWellArchitectedConfig()) { }

        /// <summary>
        /// Constructs AmazonWellArchitectedClient with the credentials loaded from the application's
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
        public AmazonWellArchitectedClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWellArchitectedConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonWellArchitectedClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonWellArchitectedClient Configuration Object</param>
        public AmazonWellArchitectedClient(AmazonWellArchitectedConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonWellArchitectedClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonWellArchitectedClient(AWSCredentials credentials)
            : this(credentials, new AmazonWellArchitectedConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWellArchitectedClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWellArchitectedClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonWellArchitectedConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWellArchitectedClient with AWS Credentials and an
        /// AmazonWellArchitectedClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonWellArchitectedClient Configuration Object</param>
        public AmazonWellArchitectedClient(AWSCredentials credentials, AmazonWellArchitectedConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWellArchitectedClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonWellArchitectedClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWellArchitectedConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWellArchitectedClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWellArchitectedClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWellArchitectedConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonWellArchitectedClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWellArchitectedClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonWellArchitectedClient Configuration Object</param>
        public AmazonWellArchitectedClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonWellArchitectedConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWellArchitectedClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonWellArchitectedClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWellArchitectedConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWellArchitectedClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWellArchitectedClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWellArchitectedConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWellArchitectedClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWellArchitectedClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonWellArchitectedClient Configuration Object</param>
        public AmazonWellArchitectedClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonWellArchitectedConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonWellArchitectedEndpointResolver());
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


        #region  AssociateLenses


        /// <summary>
        /// Associate a lens to a workload.
        /// 
        ///  
        /// <para>
        /// Up to 10 lenses can be associated with a workload in a single API operation. A maximum
        /// of 20 lenses can be associated with a workload.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// By accessing and/or applying custom lenses created by another Amazon Web Services
        /// user or account, you acknowledge that custom lenses created by other users and shared
        /// with you are Third Party Content as defined in the Amazon Web Services Customer Agreement.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLenses service method.</param>
        /// 
        /// <returns>The response from the AssociateLenses service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/AssociateLenses">REST API Reference for AssociateLenses Operation</seealso>
        public virtual AssociateLensesResponse AssociateLenses(AssociateLensesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateLensesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateLensesResponseUnmarshaller.Instance;

            return Invoke<AssociateLensesResponse>(request, options);
        }


        /// <summary>
        /// Associate a lens to a workload.
        /// 
        ///  
        /// <para>
        /// Up to 10 lenses can be associated with a workload in a single API operation. A maximum
        /// of 20 lenses can be associated with a workload.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// By accessing and/or applying custom lenses created by another Amazon Web Services
        /// user or account, you acknowledge that custom lenses created by other users and shared
        /// with you are Third Party Content as defined in the Amazon Web Services Customer Agreement.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLenses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateLenses service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/AssociateLenses">REST API Reference for AssociateLenses Operation</seealso>
        public virtual Task<AssociateLensesResponse> AssociateLensesAsync(AssociateLensesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateLensesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateLensesResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateLensesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLensShare


        /// <summary>
        /// Create a lens share.
        /// 
        ///  
        /// <para>
        /// The owner of a lens can share it with other Amazon Web Services accounts, users, an
        /// organization, and organizational units (OUs) in the same Amazon Web Services Region.
        /// Lenses provided by Amazon Web Services (Amazon Web Services Official Content) cannot
        /// be shared.
        /// </para>
        ///  
        /// <para>
        ///  Shared access to a lens is not removed until the lens invitation is deleted.
        /// </para>
        ///  
        /// <para>
        /// If you share a lens with an organization or OU, all accounts in the organization or
        /// OU are granted access to the lens.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/lenses-sharing.html">Sharing
        /// a custom lens</a> in the <i>Well-Architected Tool User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// By sharing your custom lenses with other Amazon Web Services accounts, you acknowledge
        /// that Amazon Web Services will make your custom lenses available to those other accounts.
        /// Those other accounts may continue to access and use your shared custom lenses even
        /// if you delete the custom lenses from your own Amazon Web Services account or terminate
        /// your Amazon Web Services account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLensShare service method.</param>
        /// 
        /// <returns>The response from the CreateLensShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateLensShare">REST API Reference for CreateLensShare Operation</seealso>
        public virtual CreateLensShareResponse CreateLensShare(CreateLensShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLensShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLensShareResponseUnmarshaller.Instance;

            return Invoke<CreateLensShareResponse>(request, options);
        }


        /// <summary>
        /// Create a lens share.
        /// 
        ///  
        /// <para>
        /// The owner of a lens can share it with other Amazon Web Services accounts, users, an
        /// organization, and organizational units (OUs) in the same Amazon Web Services Region.
        /// Lenses provided by Amazon Web Services (Amazon Web Services Official Content) cannot
        /// be shared.
        /// </para>
        ///  
        /// <para>
        ///  Shared access to a lens is not removed until the lens invitation is deleted.
        /// </para>
        ///  
        /// <para>
        /// If you share a lens with an organization or OU, all accounts in the organization or
        /// OU are granted access to the lens.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/lenses-sharing.html">Sharing
        /// a custom lens</a> in the <i>Well-Architected Tool User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// By sharing your custom lenses with other Amazon Web Services accounts, you acknowledge
        /// that Amazon Web Services will make your custom lenses available to those other accounts.
        /// Those other accounts may continue to access and use your shared custom lenses even
        /// if you delete the custom lenses from your own Amazon Web Services account or terminate
        /// your Amazon Web Services account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLensShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLensShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateLensShare">REST API Reference for CreateLensShare Operation</seealso>
        public virtual Task<CreateLensShareResponse> CreateLensShareAsync(CreateLensShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLensShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLensShareResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateLensShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLensVersion


        /// <summary>
        /// Create a new lens version.
        /// 
        ///  
        /// <para>
        /// A lens can have up to 100 versions.
        /// </para>
        ///  
        /// <para>
        /// Use this operation to publish a new lens version after you have imported a lens. The
        /// <code>LensAlias</code> is used to identify the lens to be published. The owner of
        /// a lens can share the lens with other Amazon Web Services accounts and users in the
        /// same Amazon Web Services Region. Only the owner of a lens can delete it. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLensVersion service method.</param>
        /// 
        /// <returns>The response from the CreateLensVersion service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateLensVersion">REST API Reference for CreateLensVersion Operation</seealso>
        public virtual CreateLensVersionResponse CreateLensVersion(CreateLensVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLensVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLensVersionResponseUnmarshaller.Instance;

            return Invoke<CreateLensVersionResponse>(request, options);
        }


        /// <summary>
        /// Create a new lens version.
        /// 
        ///  
        /// <para>
        /// A lens can have up to 100 versions.
        /// </para>
        ///  
        /// <para>
        /// Use this operation to publish a new lens version after you have imported a lens. The
        /// <code>LensAlias</code> is used to identify the lens to be published. The owner of
        /// a lens can share the lens with other Amazon Web Services accounts and users in the
        /// same Amazon Web Services Region. Only the owner of a lens can delete it. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLensVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLensVersion service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateLensVersion">REST API Reference for CreateLensVersion Operation</seealso>
        public virtual Task<CreateLensVersionResponse> CreateLensVersionAsync(CreateLensVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLensVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLensVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateLensVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMilestone


        /// <summary>
        /// Create a milestone for an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMilestone service method.</param>
        /// 
        /// <returns>The response from the CreateMilestone service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateMilestone">REST API Reference for CreateMilestone Operation</seealso>
        public virtual CreateMilestoneResponse CreateMilestone(CreateMilestoneRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMilestoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMilestoneResponseUnmarshaller.Instance;

            return Invoke<CreateMilestoneResponse>(request, options);
        }


        /// <summary>
        /// Create a milestone for an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMilestone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMilestone service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateMilestone">REST API Reference for CreateMilestone Operation</seealso>
        public virtual Task<CreateMilestoneResponse> CreateMilestoneAsync(CreateMilestoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMilestoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMilestoneResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMilestoneResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWorkload


        /// <summary>
        /// Create a new workload.
        /// 
        ///  
        /// <para>
        /// The owner of a workload can share the workload with other Amazon Web Services accounts,
        /// users, an organization, and organizational units (OUs) in the same Amazon Web Services
        /// Region. Only the owner of a workload can delete it.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/define-workload.html">Defining
        /// a Workload</a> in the <i>Well-Architected Tool User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Either <code>AwsRegions</code>, <code>NonAwsRegions</code>, or both must be specified
        /// when creating a workload.
        /// </para>
        ///  
        /// <para>
        /// You also must specify <code>ReviewOwner</code>, even though the parameter is listed
        /// as not being required in the following section. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkload service method.</param>
        /// 
        /// <returns>The response from the CreateWorkload service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateWorkload">REST API Reference for CreateWorkload Operation</seealso>
        public virtual CreateWorkloadResponse CreateWorkload(CreateWorkloadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkloadResponseUnmarshaller.Instance;

            return Invoke<CreateWorkloadResponse>(request, options);
        }


        /// <summary>
        /// Create a new workload.
        /// 
        ///  
        /// <para>
        /// The owner of a workload can share the workload with other Amazon Web Services accounts,
        /// users, an organization, and organizational units (OUs) in the same Amazon Web Services
        /// Region. Only the owner of a workload can delete it.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/define-workload.html">Defining
        /// a Workload</a> in the <i>Well-Architected Tool User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Either <code>AwsRegions</code>, <code>NonAwsRegions</code>, or both must be specified
        /// when creating a workload.
        /// </para>
        ///  
        /// <para>
        /// You also must specify <code>ReviewOwner</code>, even though the parameter is listed
        /// as not being required in the following section. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkload service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateWorkload">REST API Reference for CreateWorkload Operation</seealso>
        public virtual Task<CreateWorkloadResponse> CreateWorkloadAsync(CreateWorkloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkloadResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateWorkloadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWorkloadShare


        /// <summary>
        /// Create a workload share.
        /// 
        ///  
        /// <para>
        /// The owner of a workload can share it with other Amazon Web Services accounts and users
        /// in the same Amazon Web Services Region. Shared access to a workload is not removed
        /// until the workload invitation is deleted.
        /// </para>
        ///  
        /// <para>
        /// If you share a workload with an organization or OU, all accounts in the organization
        /// or OU are granted access to the workload.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/workloads-sharing.html">Sharing
        /// a workload</a> in the <i>Well-Architected Tool User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkloadShare service method.</param>
        /// 
        /// <returns>The response from the CreateWorkloadShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateWorkloadShare">REST API Reference for CreateWorkloadShare Operation</seealso>
        public virtual CreateWorkloadShareResponse CreateWorkloadShare(CreateWorkloadShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkloadShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkloadShareResponseUnmarshaller.Instance;

            return Invoke<CreateWorkloadShareResponse>(request, options);
        }


        /// <summary>
        /// Create a workload share.
        /// 
        ///  
        /// <para>
        /// The owner of a workload can share it with other Amazon Web Services accounts and users
        /// in the same Amazon Web Services Region. Shared access to a workload is not removed
        /// until the workload invitation is deleted.
        /// </para>
        ///  
        /// <para>
        /// If you share a workload with an organization or OU, all accounts in the organization
        /// or OU are granted access to the workload.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/workloads-sharing.html">Sharing
        /// a workload</a> in the <i>Well-Architected Tool User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkloadShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkloadShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateWorkloadShare">REST API Reference for CreateWorkloadShare Operation</seealso>
        public virtual Task<CreateWorkloadShareResponse> CreateWorkloadShareAsync(CreateWorkloadShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkloadShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkloadShareResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateWorkloadShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLens


        /// <summary>
        /// Delete an existing lens.
        /// 
        ///  
        /// <para>
        /// Only the owner of a lens can delete it. After the lens is deleted, Amazon Web Services
        /// accounts and users that you shared the lens with can continue to use it, but they
        /// will no longer be able to apply it to new workloads. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// By sharing your custom lenses with other Amazon Web Services accounts, you acknowledge
        /// that Amazon Web Services will make your custom lenses available to those other accounts.
        /// Those other accounts may continue to access and use your shared custom lenses even
        /// if you delete the custom lenses from your own Amazon Web Services account or terminate
        /// your Amazon Web Services account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLens service method.</param>
        /// 
        /// <returns>The response from the DeleteLens service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteLens">REST API Reference for DeleteLens Operation</seealso>
        public virtual DeleteLensResponse DeleteLens(DeleteLensRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLensRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLensResponseUnmarshaller.Instance;

            return Invoke<DeleteLensResponse>(request, options);
        }


        /// <summary>
        /// Delete an existing lens.
        /// 
        ///  
        /// <para>
        /// Only the owner of a lens can delete it. After the lens is deleted, Amazon Web Services
        /// accounts and users that you shared the lens with can continue to use it, but they
        /// will no longer be able to apply it to new workloads. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// By sharing your custom lenses with other Amazon Web Services accounts, you acknowledge
        /// that Amazon Web Services will make your custom lenses available to those other accounts.
        /// Those other accounts may continue to access and use your shared custom lenses even
        /// if you delete the custom lenses from your own Amazon Web Services account or terminate
        /// your Amazon Web Services account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLens service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLens service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteLens">REST API Reference for DeleteLens Operation</seealso>
        public virtual Task<DeleteLensResponse> DeleteLensAsync(DeleteLensRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLensRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLensResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteLensResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLensShare


        /// <summary>
        /// Delete a lens share.
        /// 
        ///  
        /// <para>
        /// After the lens share is deleted, Amazon Web Services accounts, users, organizations,
        /// and organizational units (OUs) that you shared the lens with can continue to use it,
        /// but they will no longer be able to apply it to new workloads.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// By sharing your custom lenses with other Amazon Web Services accounts, you acknowledge
        /// that Amazon Web Services will make your custom lenses available to those other accounts.
        /// Those other accounts may continue to access and use your shared custom lenses even
        /// if you delete the custom lenses from your own Amazon Web Services account or terminate
        /// your Amazon Web Services account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLensShare service method.</param>
        /// 
        /// <returns>The response from the DeleteLensShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteLensShare">REST API Reference for DeleteLensShare Operation</seealso>
        public virtual DeleteLensShareResponse DeleteLensShare(DeleteLensShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLensShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLensShareResponseUnmarshaller.Instance;

            return Invoke<DeleteLensShareResponse>(request, options);
        }


        /// <summary>
        /// Delete a lens share.
        /// 
        ///  
        /// <para>
        /// After the lens share is deleted, Amazon Web Services accounts, users, organizations,
        /// and organizational units (OUs) that you shared the lens with can continue to use it,
        /// but they will no longer be able to apply it to new workloads.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// By sharing your custom lenses with other Amazon Web Services accounts, you acknowledge
        /// that Amazon Web Services will make your custom lenses available to those other accounts.
        /// Those other accounts may continue to access and use your shared custom lenses even
        /// if you delete the custom lenses from your own Amazon Web Services account or terminate
        /// your Amazon Web Services account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLensShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLensShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteLensShare">REST API Reference for DeleteLensShare Operation</seealso>
        public virtual Task<DeleteLensShareResponse> DeleteLensShareAsync(DeleteLensShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLensShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLensShareResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteLensShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWorkload


        /// <summary>
        /// Delete an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkload service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkload service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteWorkload">REST API Reference for DeleteWorkload Operation</seealso>
        public virtual DeleteWorkloadResponse DeleteWorkload(DeleteWorkloadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkloadResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkloadResponse>(request, options);
        }


        /// <summary>
        /// Delete an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkload service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteWorkload">REST API Reference for DeleteWorkload Operation</seealso>
        public virtual Task<DeleteWorkloadResponse> DeleteWorkloadAsync(DeleteWorkloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkloadResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteWorkloadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWorkloadShare


        /// <summary>
        /// Delete a workload share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkloadShare service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkloadShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteWorkloadShare">REST API Reference for DeleteWorkloadShare Operation</seealso>
        public virtual DeleteWorkloadShareResponse DeleteWorkloadShare(DeleteWorkloadShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkloadShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkloadShareResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkloadShareResponse>(request, options);
        }


        /// <summary>
        /// Delete a workload share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkloadShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkloadShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteWorkloadShare">REST API Reference for DeleteWorkloadShare Operation</seealso>
        public virtual Task<DeleteWorkloadShareResponse> DeleteWorkloadShareAsync(DeleteWorkloadShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkloadShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkloadShareResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteWorkloadShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateLenses


        /// <summary>
        /// Disassociate a lens from a workload.
        /// 
        ///  
        /// <para>
        /// Up to 10 lenses can be disassociated from a workload in a single API operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon Web Services Well-Architected Framework lens (<code>wellarchitected</code>)
        /// cannot be removed from a workload.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLenses service method.</param>
        /// 
        /// <returns>The response from the DisassociateLenses service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DisassociateLenses">REST API Reference for DisassociateLenses Operation</seealso>
        public virtual DisassociateLensesResponse DisassociateLenses(DisassociateLensesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateLensesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateLensesResponseUnmarshaller.Instance;

            return Invoke<DisassociateLensesResponse>(request, options);
        }


        /// <summary>
        /// Disassociate a lens from a workload.
        /// 
        ///  
        /// <para>
        /// Up to 10 lenses can be disassociated from a workload in a single API operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon Web Services Well-Architected Framework lens (<code>wellarchitected</code>)
        /// cannot be removed from a workload.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLenses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateLenses service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DisassociateLenses">REST API Reference for DisassociateLenses Operation</seealso>
        public virtual Task<DisassociateLensesResponse> DisassociateLensesAsync(DisassociateLensesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateLensesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateLensesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateLensesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportLens


        /// <summary>
        /// Export an existing lens.
        /// 
        ///  
        /// <para>
        /// Only the owner of a lens can export it. Lenses provided by Amazon Web Services (Amazon
        /// Web Services Official Content) cannot be exported.
        /// </para>
        ///  
        /// <para>
        /// Lenses are defined in JSON. For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/lenses-format-specification.html">JSON
        /// format specification</a> in the <i>Well-Architected Tool User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// Do not include or gather personal identifiable information (PII) of end users or other
        /// identifiable individuals in or via your custom lenses. If your custom lens or those
        /// shared with you and used in your account do include or collect PII you are responsible
        /// for: ensuring that the included PII is processed in accordance with applicable law,
        /// providing adequate privacy notices, and obtaining necessary consents for processing
        /// such data.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportLens service method.</param>
        /// 
        /// <returns>The response from the ExportLens service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ExportLens">REST API Reference for ExportLens Operation</seealso>
        public virtual ExportLensResponse ExportLens(ExportLensRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportLensRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportLensResponseUnmarshaller.Instance;

            return Invoke<ExportLensResponse>(request, options);
        }


        /// <summary>
        /// Export an existing lens.
        /// 
        ///  
        /// <para>
        /// Only the owner of a lens can export it. Lenses provided by Amazon Web Services (Amazon
        /// Web Services Official Content) cannot be exported.
        /// </para>
        ///  
        /// <para>
        /// Lenses are defined in JSON. For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/lenses-format-specification.html">JSON
        /// format specification</a> in the <i>Well-Architected Tool User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// Do not include or gather personal identifiable information (PII) of end users or other
        /// identifiable individuals in or via your custom lenses. If your custom lens or those
        /// shared with you and used in your account do include or collect PII you are responsible
        /// for: ensuring that the included PII is processed in accordance with applicable law,
        /// providing adequate privacy notices, and obtaining necessary consents for processing
        /// such data.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportLens service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportLens service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ExportLens">REST API Reference for ExportLens Operation</seealso>
        public virtual Task<ExportLensResponse> ExportLensAsync(ExportLensRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportLensRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportLensResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExportLensResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAnswer


        /// <summary>
        /// Get the answer to a specific question in a workload review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnswer service method.</param>
        /// 
        /// <returns>The response from the GetAnswer service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAnswer">REST API Reference for GetAnswer Operation</seealso>
        public virtual GetAnswerResponse GetAnswer(GetAnswerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAnswerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnswerResponseUnmarshaller.Instance;

            return Invoke<GetAnswerResponse>(request, options);
        }


        /// <summary>
        /// Get the answer to a specific question in a workload review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnswer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAnswer service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAnswer">REST API Reference for GetAnswer Operation</seealso>
        public virtual Task<GetAnswerResponse> GetAnswerAsync(GetAnswerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAnswerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnswerResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAnswerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConsolidatedReport


        /// <summary>
        /// Get a consolidated report of your workloads.
        /// 
        ///  
        /// <para>
        /// You can optionally choose to include workloads that have been shared with you.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConsolidatedReport service method.</param>
        /// 
        /// <returns>The response from the GetConsolidatedReport service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetConsolidatedReport">REST API Reference for GetConsolidatedReport Operation</seealso>
        public virtual GetConsolidatedReportResponse GetConsolidatedReport(GetConsolidatedReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConsolidatedReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConsolidatedReportResponseUnmarshaller.Instance;

            return Invoke<GetConsolidatedReportResponse>(request, options);
        }


        /// <summary>
        /// Get a consolidated report of your workloads.
        /// 
        ///  
        /// <para>
        /// You can optionally choose to include workloads that have been shared with you.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConsolidatedReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConsolidatedReport service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetConsolidatedReport">REST API Reference for GetConsolidatedReport Operation</seealso>
        public virtual Task<GetConsolidatedReportResponse> GetConsolidatedReportAsync(GetConsolidatedReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConsolidatedReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConsolidatedReportResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetConsolidatedReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLens


        /// <summary>
        /// Get an existing lens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLens service method.</param>
        /// 
        /// <returns>The response from the GetLens service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLens">REST API Reference for GetLens Operation</seealso>
        public virtual GetLensResponse GetLens(GetLensRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLensRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLensResponseUnmarshaller.Instance;

            return Invoke<GetLensResponse>(request, options);
        }


        /// <summary>
        /// Get an existing lens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLens service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLens service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLens">REST API Reference for GetLens Operation</seealso>
        public virtual Task<GetLensResponse> GetLensAsync(GetLensRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLensRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLensResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLensResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLensReview


        /// <summary>
        /// Get lens review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLensReview service method.</param>
        /// 
        /// <returns>The response from the GetLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensReview">REST API Reference for GetLensReview Operation</seealso>
        public virtual GetLensReviewResponse GetLensReview(GetLensReviewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLensReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLensReviewResponseUnmarshaller.Instance;

            return Invoke<GetLensReviewResponse>(request, options);
        }


        /// <summary>
        /// Get lens review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLensReview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensReview">REST API Reference for GetLensReview Operation</seealso>
        public virtual Task<GetLensReviewResponse> GetLensReviewAsync(GetLensReviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLensReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLensReviewResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLensReviewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLensReviewReport


        /// <summary>
        /// Get lens review report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLensReviewReport service method.</param>
        /// 
        /// <returns>The response from the GetLensReviewReport service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensReviewReport">REST API Reference for GetLensReviewReport Operation</seealso>
        public virtual GetLensReviewReportResponse GetLensReviewReport(GetLensReviewReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLensReviewReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLensReviewReportResponseUnmarshaller.Instance;

            return Invoke<GetLensReviewReportResponse>(request, options);
        }


        /// <summary>
        /// Get lens review report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLensReviewReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLensReviewReport service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensReviewReport">REST API Reference for GetLensReviewReport Operation</seealso>
        public virtual Task<GetLensReviewReportResponse> GetLensReviewReportAsync(GetLensReviewReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLensReviewReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLensReviewReportResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLensReviewReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLensVersionDifference


        /// <summary>
        /// Get lens version differences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLensVersionDifference service method.</param>
        /// 
        /// <returns>The response from the GetLensVersionDifference service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensVersionDifference">REST API Reference for GetLensVersionDifference Operation</seealso>
        public virtual GetLensVersionDifferenceResponse GetLensVersionDifference(GetLensVersionDifferenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLensVersionDifferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLensVersionDifferenceResponseUnmarshaller.Instance;

            return Invoke<GetLensVersionDifferenceResponse>(request, options);
        }


        /// <summary>
        /// Get lens version differences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLensVersionDifference service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLensVersionDifference service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensVersionDifference">REST API Reference for GetLensVersionDifference Operation</seealso>
        public virtual Task<GetLensVersionDifferenceResponse> GetLensVersionDifferenceAsync(GetLensVersionDifferenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLensVersionDifferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLensVersionDifferenceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLensVersionDifferenceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMilestone


        /// <summary>
        /// Get a milestone for an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMilestone service method.</param>
        /// 
        /// <returns>The response from the GetMilestone service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetMilestone">REST API Reference for GetMilestone Operation</seealso>
        public virtual GetMilestoneResponse GetMilestone(GetMilestoneRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMilestoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMilestoneResponseUnmarshaller.Instance;

            return Invoke<GetMilestoneResponse>(request, options);
        }


        /// <summary>
        /// Get a milestone for an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMilestone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMilestone service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetMilestone">REST API Reference for GetMilestone Operation</seealso>
        public virtual Task<GetMilestoneResponse> GetMilestoneAsync(GetMilestoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMilestoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMilestoneResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMilestoneResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWorkload


        /// <summary>
        /// Get an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkload service method.</param>
        /// 
        /// <returns>The response from the GetWorkload service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetWorkload">REST API Reference for GetWorkload Operation</seealso>
        public virtual GetWorkloadResponse GetWorkload(GetWorkloadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkloadResponseUnmarshaller.Instance;

            return Invoke<GetWorkloadResponse>(request, options);
        }


        /// <summary>
        /// Get an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkload service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetWorkload">REST API Reference for GetWorkload Operation</seealso>
        public virtual Task<GetWorkloadResponse> GetWorkloadAsync(GetWorkloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkloadResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetWorkloadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportLens


        /// <summary>
        /// Import a new custom lens or update an existing custom lens.
        /// 
        ///  
        /// <para>
        /// To update an existing custom lens, specify its ARN as the <code>LensAlias</code>.
        /// If no ARN is specified, a new custom lens is created.
        /// </para>
        ///  
        /// <para>
        /// The new or updated lens will have a status of <code>DRAFT</code>. The lens cannot
        /// be applied to workloads or shared with other Amazon Web Services accounts until it's
        /// published with <a>CreateLensVersion</a>.
        /// </para>
        ///  
        /// <para>
        /// Lenses are defined in JSON. For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/lenses-format-specification.html">JSON
        /// format specification</a> in the <i>Well-Architected Tool User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A custom lens cannot exceed 500 KB in size.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// Do not include or gather personal identifiable information (PII) of end users or other
        /// identifiable individuals in or via your custom lenses. If your custom lens or those
        /// shared with you and used in your account do include or collect PII you are responsible
        /// for: ensuring that the included PII is processed in accordance with applicable law,
        /// providing adequate privacy notices, and obtaining necessary consents for processing
        /// such data.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportLens service method.</param>
        /// 
        /// <returns>The response from the ImportLens service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ImportLens">REST API Reference for ImportLens Operation</seealso>
        public virtual ImportLensResponse ImportLens(ImportLensRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportLensRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportLensResponseUnmarshaller.Instance;

            return Invoke<ImportLensResponse>(request, options);
        }


        /// <summary>
        /// Import a new custom lens or update an existing custom lens.
        /// 
        ///  
        /// <para>
        /// To update an existing custom lens, specify its ARN as the <code>LensAlias</code>.
        /// If no ARN is specified, a new custom lens is created.
        /// </para>
        ///  
        /// <para>
        /// The new or updated lens will have a status of <code>DRAFT</code>. The lens cannot
        /// be applied to workloads or shared with other Amazon Web Services accounts until it's
        /// published with <a>CreateLensVersion</a>.
        /// </para>
        ///  
        /// <para>
        /// Lenses are defined in JSON. For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/lenses-format-specification.html">JSON
        /// format specification</a> in the <i>Well-Architected Tool User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A custom lens cannot exceed 500 KB in size.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// Do not include or gather personal identifiable information (PII) of end users or other
        /// identifiable individuals in or via your custom lenses. If your custom lens or those
        /// shared with you and used in your account do include or collect PII you are responsible
        /// for: ensuring that the included PII is processed in accordance with applicable law,
        /// providing adequate privacy notices, and obtaining necessary consents for processing
        /// such data.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportLens service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportLens service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ImportLens">REST API Reference for ImportLens Operation</seealso>
        public virtual Task<ImportLensResponse> ImportLensAsync(ImportLensRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportLensRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportLensResponseUnmarshaller.Instance;
            
            return InvokeAsync<ImportLensResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAnswers


        /// <summary>
        /// List of answers for a particular workload and lens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnswers service method.</param>
        /// 
        /// <returns>The response from the ListAnswers service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAnswers">REST API Reference for ListAnswers Operation</seealso>
        public virtual ListAnswersResponse ListAnswers(ListAnswersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAnswersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnswersResponseUnmarshaller.Instance;

            return Invoke<ListAnswersResponse>(request, options);
        }


        /// <summary>
        /// List of answers for a particular workload and lens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnswers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnswers service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAnswers">REST API Reference for ListAnswers Operation</seealso>
        public virtual Task<ListAnswersResponse> ListAnswersAsync(ListAnswersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAnswersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnswersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAnswersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCheckDetails


        /// <summary>
        /// List of Trusted Advisor check details by account related to the workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCheckDetails service method.</param>
        /// 
        /// <returns>The response from the ListCheckDetails service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListCheckDetails">REST API Reference for ListCheckDetails Operation</seealso>
        public virtual ListCheckDetailsResponse ListCheckDetails(ListCheckDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCheckDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCheckDetailsResponseUnmarshaller.Instance;

            return Invoke<ListCheckDetailsResponse>(request, options);
        }


        /// <summary>
        /// List of Trusted Advisor check details by account related to the workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCheckDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCheckDetails service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListCheckDetails">REST API Reference for ListCheckDetails Operation</seealso>
        public virtual Task<ListCheckDetailsResponse> ListCheckDetailsAsync(ListCheckDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCheckDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCheckDetailsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCheckDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCheckSummaries


        /// <summary>
        /// List of Trusted Advisor checks summarized for all accounts related to the workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCheckSummaries service method.</param>
        /// 
        /// <returns>The response from the ListCheckSummaries service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListCheckSummaries">REST API Reference for ListCheckSummaries Operation</seealso>
        public virtual ListCheckSummariesResponse ListCheckSummaries(ListCheckSummariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCheckSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCheckSummariesResponseUnmarshaller.Instance;

            return Invoke<ListCheckSummariesResponse>(request, options);
        }


        /// <summary>
        /// List of Trusted Advisor checks summarized for all accounts related to the workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCheckSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCheckSummaries service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListCheckSummaries">REST API Reference for ListCheckSummaries Operation</seealso>
        public virtual Task<ListCheckSummariesResponse> ListCheckSummariesAsync(ListCheckSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCheckSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCheckSummariesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCheckSummariesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLenses


        /// <summary>
        /// List the available lenses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLenses service method.</param>
        /// 
        /// <returns>The response from the ListLenses service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLenses">REST API Reference for ListLenses Operation</seealso>
        public virtual ListLensesResponse ListLenses(ListLensesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLensesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLensesResponseUnmarshaller.Instance;

            return Invoke<ListLensesResponse>(request, options);
        }


        /// <summary>
        /// List the available lenses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLenses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLenses service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLenses">REST API Reference for ListLenses Operation</seealso>
        public virtual Task<ListLensesResponse> ListLensesAsync(ListLensesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLensesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLensesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListLensesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLensReviewImprovements


        /// <summary>
        /// List lens review improvements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLensReviewImprovements service method.</param>
        /// 
        /// <returns>The response from the ListLensReviewImprovements service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLensReviewImprovements">REST API Reference for ListLensReviewImprovements Operation</seealso>
        public virtual ListLensReviewImprovementsResponse ListLensReviewImprovements(ListLensReviewImprovementsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLensReviewImprovementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLensReviewImprovementsResponseUnmarshaller.Instance;

            return Invoke<ListLensReviewImprovementsResponse>(request, options);
        }


        /// <summary>
        /// List lens review improvements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLensReviewImprovements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLensReviewImprovements service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLensReviewImprovements">REST API Reference for ListLensReviewImprovements Operation</seealso>
        public virtual Task<ListLensReviewImprovementsResponse> ListLensReviewImprovementsAsync(ListLensReviewImprovementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLensReviewImprovementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLensReviewImprovementsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListLensReviewImprovementsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLensReviews


        /// <summary>
        /// List lens reviews for a particular workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLensReviews service method.</param>
        /// 
        /// <returns>The response from the ListLensReviews service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLensReviews">REST API Reference for ListLensReviews Operation</seealso>
        public virtual ListLensReviewsResponse ListLensReviews(ListLensReviewsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLensReviewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLensReviewsResponseUnmarshaller.Instance;

            return Invoke<ListLensReviewsResponse>(request, options);
        }


        /// <summary>
        /// List lens reviews for a particular workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLensReviews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLensReviews service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLensReviews">REST API Reference for ListLensReviews Operation</seealso>
        public virtual Task<ListLensReviewsResponse> ListLensReviewsAsync(ListLensReviewsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLensReviewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLensReviewsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListLensReviewsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLensShares


        /// <summary>
        /// List the lens shares associated with the lens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLensShares service method.</param>
        /// 
        /// <returns>The response from the ListLensShares service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLensShares">REST API Reference for ListLensShares Operation</seealso>
        public virtual ListLensSharesResponse ListLensShares(ListLensSharesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLensSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLensSharesResponseUnmarshaller.Instance;

            return Invoke<ListLensSharesResponse>(request, options);
        }


        /// <summary>
        /// List the lens shares associated with the lens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLensShares service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLensShares service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLensShares">REST API Reference for ListLensShares Operation</seealso>
        public virtual Task<ListLensSharesResponse> ListLensSharesAsync(ListLensSharesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLensSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLensSharesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListLensSharesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMilestones


        /// <summary>
        /// List all milestones for an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMilestones service method.</param>
        /// 
        /// <returns>The response from the ListMilestones service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListMilestones">REST API Reference for ListMilestones Operation</seealso>
        public virtual ListMilestonesResponse ListMilestones(ListMilestonesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMilestonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMilestonesResponseUnmarshaller.Instance;

            return Invoke<ListMilestonesResponse>(request, options);
        }


        /// <summary>
        /// List all milestones for an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMilestones service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMilestones service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListMilestones">REST API Reference for ListMilestones Operation</seealso>
        public virtual Task<ListMilestonesResponse> ListMilestonesAsync(ListMilestonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMilestonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMilestonesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMilestonesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNotifications


        /// <summary>
        /// List lens notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotifications service method.</param>
        /// 
        /// <returns>The response from the ListNotifications service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        public virtual ListNotificationsResponse ListNotifications(ListNotificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationsResponseUnmarshaller.Instance;

            return Invoke<ListNotificationsResponse>(request, options);
        }


        /// <summary>
        /// List lens notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotifications service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        public virtual Task<ListNotificationsResponse> ListNotificationsAsync(ListNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListNotificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListShareInvitations


        /// <summary>
        /// List the workload invitations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListShareInvitations service method.</param>
        /// 
        /// <returns>The response from the ListShareInvitations service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListShareInvitations">REST API Reference for ListShareInvitations Operation</seealso>
        public virtual ListShareInvitationsResponse ListShareInvitations(ListShareInvitationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListShareInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListShareInvitationsResponseUnmarshaller.Instance;

            return Invoke<ListShareInvitationsResponse>(request, options);
        }


        /// <summary>
        /// List the workload invitations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListShareInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListShareInvitations service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListShareInvitations">REST API Reference for ListShareInvitations Operation</seealso>
        public virtual Task<ListShareInvitationsResponse> ListShareInvitationsAsync(ListShareInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListShareInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListShareInvitationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListShareInvitationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List the tags for a resource.
        /// 
        ///  <note> 
        /// <para>
        /// The WorkloadArn parameter can be either a workload ARN or a custom lens ARN.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// List the tags for a resource.
        /// 
        ///  <note> 
        /// <para>
        /// The WorkloadArn parameter can be either a workload ARN or a custom lens ARN.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkloads


        /// <summary>
        /// Paginated list of workloads.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloads service method.</param>
        /// 
        /// <returns>The response from the ListWorkloads service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListWorkloads">REST API Reference for ListWorkloads Operation</seealso>
        public virtual ListWorkloadsResponse ListWorkloads(ListWorkloadsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkloadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadsResponseUnmarshaller.Instance;

            return Invoke<ListWorkloadsResponse>(request, options);
        }


        /// <summary>
        /// Paginated list of workloads.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloads service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkloads service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListWorkloads">REST API Reference for ListWorkloads Operation</seealso>
        public virtual Task<ListWorkloadsResponse> ListWorkloadsAsync(ListWorkloadsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkloadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListWorkloadsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkloadShares


        /// <summary>
        /// List the workload shares associated with the workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadShares service method.</param>
        /// 
        /// <returns>The response from the ListWorkloadShares service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListWorkloadShares">REST API Reference for ListWorkloadShares Operation</seealso>
        public virtual ListWorkloadSharesResponse ListWorkloadShares(ListWorkloadSharesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkloadSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadSharesResponseUnmarshaller.Instance;

            return Invoke<ListWorkloadSharesResponse>(request, options);
        }


        /// <summary>
        /// List the workload shares associated with the workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadShares service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkloadShares service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListWorkloadShares">REST API Reference for ListWorkloadShares Operation</seealso>
        public virtual Task<ListWorkloadSharesResponse> ListWorkloadSharesAsync(ListWorkloadSharesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkloadSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadSharesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListWorkloadSharesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds one or more tags to the specified resource.
        /// 
        ///  <note> 
        /// <para>
        /// The WorkloadArn parameter can be either a workload ARN or a custom lens ARN.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds one or more tags to the specified resource.
        /// 
        ///  <note> 
        /// <para>
        /// The WorkloadArn parameter can be either a workload ARN or a custom lens ARN.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Deletes specified tags from a resource.
        /// 
        ///  <note> 
        /// <para>
        /// The WorkloadArn parameter can be either a workload ARN or a custom lens ARN.
        /// </para>
        ///  </note> 
        /// <para>
        /// To specify multiple tags, use separate <b>tagKeys</b> parameters, for example:
        /// </para>
        ///  
        /// <para>
        ///  <code>DELETE /tags/WorkloadArn?tagKeys=key1&amp;tagKeys=key2</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Deletes specified tags from a resource.
        /// 
        ///  <note> 
        /// <para>
        /// The WorkloadArn parameter can be either a workload ARN or a custom lens ARN.
        /// </para>
        ///  </note> 
        /// <para>
        /// To specify multiple tags, use separate <b>tagKeys</b> parameters, for example:
        /// </para>
        ///  
        /// <para>
        ///  <code>DELETE /tags/WorkloadArn?tagKeys=key1&amp;tagKeys=key2</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAnswer


        /// <summary>
        /// Update the answer to a specific question in a workload review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnswer service method.</param>
        /// 
        /// <returns>The response from the UpdateAnswer service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateAnswer">REST API Reference for UpdateAnswer Operation</seealso>
        public virtual UpdateAnswerResponse UpdateAnswer(UpdateAnswerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAnswerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnswerResponseUnmarshaller.Instance;

            return Invoke<UpdateAnswerResponse>(request, options);
        }


        /// <summary>
        /// Update the answer to a specific question in a workload review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnswer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAnswer service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateAnswer">REST API Reference for UpdateAnswer Operation</seealso>
        public virtual Task<UpdateAnswerResponse> UpdateAnswerAsync(UpdateAnswerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAnswerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnswerResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAnswerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGlobalSettings


        /// <summary>
        /// Updates whether the Amazon Web Services account is opted into organization sharing
        /// features.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateGlobalSettings service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        public virtual UpdateGlobalSettingsResponse UpdateGlobalSettings(UpdateGlobalSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateGlobalSettingsResponse>(request, options);
        }


        /// <summary>
        /// Updates whether the Amazon Web Services account is opted into organization sharing
        /// features.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGlobalSettings service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        public virtual Task<UpdateGlobalSettingsResponse> UpdateGlobalSettingsAsync(UpdateGlobalSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateGlobalSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLensReview


        /// <summary>
        /// Update lens review for a particular workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLensReview service method.</param>
        /// 
        /// <returns>The response from the UpdateLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateLensReview">REST API Reference for UpdateLensReview Operation</seealso>
        public virtual UpdateLensReviewResponse UpdateLensReview(UpdateLensReviewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLensReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLensReviewResponseUnmarshaller.Instance;

            return Invoke<UpdateLensReviewResponse>(request, options);
        }


        /// <summary>
        /// Update lens review for a particular workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLensReview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateLensReview">REST API Reference for UpdateLensReview Operation</seealso>
        public virtual Task<UpdateLensReviewResponse> UpdateLensReviewAsync(UpdateLensReviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLensReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLensReviewResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateLensReviewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateShareInvitation


        /// <summary>
        /// Update a workload or custom lens share invitation.
        /// 
        ///  <note> 
        /// <para>
        /// This API operation can be called independently of any resource. Previous documentation
        /// implied that a workload ARN must be specified.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateShareInvitation service method.</param>
        /// 
        /// <returns>The response from the UpdateShareInvitation service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateShareInvitation">REST API Reference for UpdateShareInvitation Operation</seealso>
        public virtual UpdateShareInvitationResponse UpdateShareInvitation(UpdateShareInvitationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateShareInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateShareInvitationResponseUnmarshaller.Instance;

            return Invoke<UpdateShareInvitationResponse>(request, options);
        }


        /// <summary>
        /// Update a workload or custom lens share invitation.
        /// 
        ///  <note> 
        /// <para>
        /// This API operation can be called independently of any resource. Previous documentation
        /// implied that a workload ARN must be specified.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateShareInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateShareInvitation service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateShareInvitation">REST API Reference for UpdateShareInvitation Operation</seealso>
        public virtual Task<UpdateShareInvitationResponse> UpdateShareInvitationAsync(UpdateShareInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateShareInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateShareInvitationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateShareInvitationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWorkload


        /// <summary>
        /// Update an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkload service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkload service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateWorkload">REST API Reference for UpdateWorkload Operation</seealso>
        public virtual UpdateWorkloadResponse UpdateWorkload(UpdateWorkloadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkloadResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkloadResponse>(request, options);
        }


        /// <summary>
        /// Update an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkload service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateWorkload">REST API Reference for UpdateWorkload Operation</seealso>
        public virtual Task<UpdateWorkloadResponse> UpdateWorkloadAsync(UpdateWorkloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkloadResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateWorkloadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWorkloadShare


        /// <summary>
        /// Update a workload share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkloadShare service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkloadShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateWorkloadShare">REST API Reference for UpdateWorkloadShare Operation</seealso>
        public virtual UpdateWorkloadShareResponse UpdateWorkloadShare(UpdateWorkloadShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkloadShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkloadShareResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkloadShareResponse>(request, options);
        }


        /// <summary>
        /// Update a workload share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkloadShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkloadShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateWorkloadShare">REST API Reference for UpdateWorkloadShare Operation</seealso>
        public virtual Task<UpdateWorkloadShareResponse> UpdateWorkloadShareAsync(UpdateWorkloadShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkloadShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkloadShareResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateWorkloadShareResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpgradeLensReview


        /// <summary>
        /// Upgrade lens review for a particular workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeLensReview service method.</param>
        /// 
        /// <returns>The response from the UpgradeLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpgradeLensReview">REST API Reference for UpgradeLensReview Operation</seealso>
        public virtual UpgradeLensReviewResponse UpgradeLensReview(UpgradeLensReviewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpgradeLensReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradeLensReviewResponseUnmarshaller.Instance;

            return Invoke<UpgradeLensReviewResponse>(request, options);
        }


        /// <summary>
        /// Upgrade lens review for a particular workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeLensReview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpgradeLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpgradeLensReview">REST API Reference for UpgradeLensReview Operation</seealso>
        public virtual Task<UpgradeLensReviewResponse> UpgradeLensReviewAsync(UpgradeLensReviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpgradeLensReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradeLensReviewResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpgradeLensReviewResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}
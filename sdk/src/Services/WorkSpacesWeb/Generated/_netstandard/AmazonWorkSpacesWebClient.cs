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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.WorkSpacesWeb.Model;
using Amazon.WorkSpacesWeb.Model.Internal.MarshallTransformations;
using Amazon.WorkSpacesWeb.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.WorkSpacesWeb
{
    /// <summary>
    /// <para>Implementation for accessing WorkSpacesWeb</para>
    ///
    /// Amazon WorkSpaces Secure Browser is a low cost, fully managed WorkSpace built specifically
    /// to facilitate secure, web-based workloads. WorkSpaces Secure Browser makes it easy
    /// for customers to safely provide their employees with access to internal websites and
    /// SaaS web applications without the administrative burden of appliances or specialized
    /// client software. WorkSpaces Secure Browser provides simple policy tools tailored for
    /// user interactions, while offloading common tasks like capacity management, scaling,
    /// and maintaining browser images.
    /// </summary>
    public partial class AmazonWorkSpacesWebClient : AmazonServiceClient, IAmazonWorkSpacesWeb
    {
        private static IServiceMetadata serviceMetadata = new AmazonWorkSpacesWebMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with the credentials loaded from the application's
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
        public AmazonWorkSpacesWebClient()
            : base(new AmazonWorkSpacesWebConfig()) { }

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with the credentials loaded from the application's
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
        public AmazonWorkSpacesWebClient(RegionEndpoint region)
            : base(new AmazonWorkSpacesWebConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonWorkSpacesWebClient Configuration Object</param>
        public AmazonWorkSpacesWebClient(AmazonWorkSpacesWebConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonWorkSpacesWebClient(AWSCredentials credentials)
            : this(credentials, new AmazonWorkSpacesWebConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkSpacesWebClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonWorkSpacesWebConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with AWS Credentials and an
        /// AmazonWorkSpacesWebClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonWorkSpacesWebClient Configuration Object</param>
        public AmazonWorkSpacesWebClient(AWSCredentials credentials, AmazonWorkSpacesWebConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonWorkSpacesWebClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkSpacesWebConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkSpacesWebClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkSpacesWebConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkSpacesWebClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonWorkSpacesWebClient Configuration Object</param>
        public AmazonWorkSpacesWebClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonWorkSpacesWebConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonWorkSpacesWebClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkSpacesWebConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkSpacesWebClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkSpacesWebConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesWebClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkSpacesWebClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonWorkSpacesWebClient Configuration Object</param>
        public AmazonWorkSpacesWebClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonWorkSpacesWebConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IWorkSpacesWebPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IWorkSpacesWebPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new WorkSpacesWebPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonWorkSpacesWebEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonWorkSpacesWebAuthSchemeHandler());
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


        #region  AssociateBrowserSettings

        internal virtual AssociateBrowserSettingsResponse AssociateBrowserSettings(AssociateBrowserSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateBrowserSettingsResponseUnmarshaller.Instance;

            return Invoke<AssociateBrowserSettingsResponse>(request, options);
        }



        /// <summary>
        /// Associates a browser settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateBrowserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateBrowserSettings">REST API Reference for AssociateBrowserSettings Operation</seealso>
        public virtual Task<AssociateBrowserSettingsResponse> AssociateBrowserSettingsAsync(AssociateBrowserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateBrowserSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateBrowserSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateDataProtectionSettings

        internal virtual AssociateDataProtectionSettingsResponse AssociateDataProtectionSettings(AssociateDataProtectionSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDataProtectionSettingsResponseUnmarshaller.Instance;

            return Invoke<AssociateDataProtectionSettingsResponse>(request, options);
        }



        /// <summary>
        /// Associates a data protection settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDataProtectionSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateDataProtectionSettings">REST API Reference for AssociateDataProtectionSettings Operation</seealso>
        public virtual Task<AssociateDataProtectionSettingsResponse> AssociateDataProtectionSettingsAsync(AssociateDataProtectionSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDataProtectionSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateDataProtectionSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateIpAccessSettings

        internal virtual AssociateIpAccessSettingsResponse AssociateIpAccessSettings(AssociateIpAccessSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIpAccessSettingsResponseUnmarshaller.Instance;

            return Invoke<AssociateIpAccessSettingsResponse>(request, options);
        }



        /// <summary>
        /// Associates an IP access settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateIpAccessSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateIpAccessSettings">REST API Reference for AssociateIpAccessSettings Operation</seealso>
        public virtual Task<AssociateIpAccessSettingsResponse> AssociateIpAccessSettingsAsync(AssociateIpAccessSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIpAccessSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateIpAccessSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateNetworkSettings

        internal virtual AssociateNetworkSettingsResponse AssociateNetworkSettings(AssociateNetworkSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateNetworkSettingsResponseUnmarshaller.Instance;

            return Invoke<AssociateNetworkSettingsResponse>(request, options);
        }



        /// <summary>
        /// Associates a network settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateNetworkSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateNetworkSettings">REST API Reference for AssociateNetworkSettings Operation</seealso>
        public virtual Task<AssociateNetworkSettingsResponse> AssociateNetworkSettingsAsync(AssociateNetworkSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateNetworkSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateNetworkSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateSessionLogger

        internal virtual AssociateSessionLoggerResponse AssociateSessionLogger(AssociateSessionLoggerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSessionLoggerResponseUnmarshaller.Instance;

            return Invoke<AssociateSessionLoggerResponse>(request, options);
        }



        /// <summary>
        /// Associates a session logger with a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSessionLogger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateSessionLogger service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateSessionLogger">REST API Reference for AssociateSessionLogger Operation</seealso>
        public virtual Task<AssociateSessionLoggerResponse> AssociateSessionLoggerAsync(AssociateSessionLoggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSessionLoggerResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateSessionLoggerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateTrustStore

        internal virtual AssociateTrustStoreResponse AssociateTrustStore(AssociateTrustStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTrustStoreResponseUnmarshaller.Instance;

            return Invoke<AssociateTrustStoreResponse>(request, options);
        }



        /// <summary>
        /// Associates a trust store with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrustStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateTrustStore">REST API Reference for AssociateTrustStore Operation</seealso>
        public virtual Task<AssociateTrustStoreResponse> AssociateTrustStoreAsync(AssociateTrustStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTrustStoreResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateTrustStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateUserAccessLoggingSettings

        internal virtual AssociateUserAccessLoggingSettingsResponse AssociateUserAccessLoggingSettings(AssociateUserAccessLoggingSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return Invoke<AssociateUserAccessLoggingSettingsResponse>(request, options);
        }



        /// <summary>
        /// Associates a user access logging settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateUserAccessLoggingSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateUserAccessLoggingSettings">REST API Reference for AssociateUserAccessLoggingSettings Operation</seealso>
        public virtual Task<AssociateUserAccessLoggingSettingsResponse> AssociateUserAccessLoggingSettingsAsync(AssociateUserAccessLoggingSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateUserAccessLoggingSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateUserSettings

        internal virtual AssociateUserSettingsResponse AssociateUserSettings(AssociateUserSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateUserSettingsResponseUnmarshaller.Instance;

            return Invoke<AssociateUserSettingsResponse>(request, options);
        }



        /// <summary>
        /// Associates a user settings resource with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateUserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/AssociateUserSettings">REST API Reference for AssociateUserSettings Operation</seealso>
        public virtual Task<AssociateUserSettingsResponse> AssociateUserSettingsAsync(AssociateUserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateUserSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateUserSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateBrowserSettings

        internal virtual CreateBrowserSettingsResponse CreateBrowserSettings(CreateBrowserSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBrowserSettingsResponseUnmarshaller.Instance;

            return Invoke<CreateBrowserSettingsResponse>(request, options);
        }



        /// <summary>
        /// Creates a browser settings resource that can be associated with a web portal. Once
        /// associated with a web portal, browser settings control how the browser will behave
        /// once a user starts a streaming session for the web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBrowserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateBrowserSettings">REST API Reference for CreateBrowserSettings Operation</seealso>
        public virtual Task<CreateBrowserSettingsResponse> CreateBrowserSettingsAsync(CreateBrowserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBrowserSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBrowserSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDataProtectionSettings

        internal virtual CreateDataProtectionSettingsResponse CreateDataProtectionSettings(CreateDataProtectionSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataProtectionSettingsResponseUnmarshaller.Instance;

            return Invoke<CreateDataProtectionSettingsResponse>(request, options);
        }



        /// <summary>
        /// Creates a data protection settings resource that can be associated with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataProtectionSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateDataProtectionSettings">REST API Reference for CreateDataProtectionSettings Operation</seealso>
        public virtual Task<CreateDataProtectionSettingsResponse> CreateDataProtectionSettingsAsync(CreateDataProtectionSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataProtectionSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataProtectionSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateIdentityProvider

        internal virtual CreateIdentityProviderResponse CreateIdentityProvider(CreateIdentityProviderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<CreateIdentityProviderResponse>(request, options);
        }



        /// <summary>
        /// Creates an identity provider resource that is then associated with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIdentityProvider service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateIdentityProvider">REST API Reference for CreateIdentityProvider Operation</seealso>
        public virtual Task<CreateIdentityProviderResponse> CreateIdentityProviderAsync(CreateIdentityProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdentityProviderResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIdentityProviderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateIpAccessSettings

        internal virtual CreateIpAccessSettingsResponse CreateIpAccessSettings(CreateIpAccessSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIpAccessSettingsResponseUnmarshaller.Instance;

            return Invoke<CreateIpAccessSettingsResponse>(request, options);
        }



        /// <summary>
        /// Creates an IP access settings resource that can be associated with a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIpAccessSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateIpAccessSettings">REST API Reference for CreateIpAccessSettings Operation</seealso>
        public virtual Task<CreateIpAccessSettingsResponse> CreateIpAccessSettingsAsync(CreateIpAccessSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIpAccessSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIpAccessSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateNetworkSettings

        internal virtual CreateNetworkSettingsResponse CreateNetworkSettings(CreateNetworkSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkSettingsResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkSettingsResponse>(request, options);
        }



        /// <summary>
        /// Creates a network settings resource that can be associated with a web portal. Once
        /// associated with a web portal, network settings define how streaming instances will
        /// connect with your specified VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateNetworkSettings">REST API Reference for CreateNetworkSettings Operation</seealso>
        public virtual Task<CreateNetworkSettingsResponse> CreateNetworkSettingsAsync(CreateNetworkSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePortal

        internal virtual CreatePortalResponse CreatePortal(CreatePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalResponseUnmarshaller.Instance;

            return Invoke<CreatePortalResponse>(request, options);
        }



        /// <summary>
        /// Creates a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePortal service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        public virtual Task<CreatePortalResponse> CreatePortalAsync(CreatePortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePortalResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSessionLogger

        internal virtual CreateSessionLoggerResponse CreateSessionLogger(CreateSessionLoggerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSessionLoggerResponseUnmarshaller.Instance;

            return Invoke<CreateSessionLoggerResponse>(request, options);
        }



        /// <summary>
        /// Creates a session logger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSessionLogger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSessionLogger service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateSessionLogger">REST API Reference for CreateSessionLogger Operation</seealso>
        public virtual Task<CreateSessionLoggerResponse> CreateSessionLoggerAsync(CreateSessionLoggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSessionLoggerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSessionLoggerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTrustStore

        internal virtual CreateTrustStoreResponse CreateTrustStore(CreateTrustStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrustStoreResponseUnmarshaller.Instance;

            return Invoke<CreateTrustStoreResponse>(request, options);
        }



        /// <summary>
        /// Creates a trust store that can be associated with a web portal. A trust store contains
        /// certificate authority (CA) certificates. Once associated with a web portal, the browser
        /// in a streaming session will recognize certificates that have been issued using any
        /// of the CAs in the trust store. If your organization has internal websites that use
        /// certificates issued by private CAs, you should add the private CA certificate to the
        /// trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateTrustStore">REST API Reference for CreateTrustStore Operation</seealso>
        public virtual Task<CreateTrustStoreResponse> CreateTrustStoreAsync(CreateTrustStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrustStoreResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrustStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateUserAccessLoggingSettings

        internal virtual CreateUserAccessLoggingSettingsResponse CreateUserAccessLoggingSettings(CreateUserAccessLoggingSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return Invoke<CreateUserAccessLoggingSettingsResponse>(request, options);
        }



        /// <summary>
        /// Creates a user access logging settings resource that can be associated with a web
        /// portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserAccessLoggingSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateUserAccessLoggingSettings">REST API Reference for CreateUserAccessLoggingSettings Operation</seealso>
        public virtual Task<CreateUserAccessLoggingSettingsResponse> CreateUserAccessLoggingSettingsAsync(CreateUserAccessLoggingSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserAccessLoggingSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateUserSettings

        internal virtual CreateUserSettingsResponse CreateUserSettings(CreateUserSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserSettingsResponseUnmarshaller.Instance;

            return Invoke<CreateUserSettingsResponse>(request, options);
        }



        /// <summary>
        /// Creates a user settings resource that can be associated with a web portal. Once associated
        /// with a web portal, user settings control how users can transfer data between a streaming
        /// session and the their local devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/CreateUserSettings">REST API Reference for CreateUserSettings Operation</seealso>
        public virtual Task<CreateUserSettingsResponse> CreateUserSettingsAsync(CreateUserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteBrowserSettings

        internal virtual DeleteBrowserSettingsResponse DeleteBrowserSettings(DeleteBrowserSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBrowserSettingsResponseUnmarshaller.Instance;

            return Invoke<DeleteBrowserSettingsResponse>(request, options);
        }



        /// <summary>
        /// Deletes browser settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrowserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteBrowserSettings">REST API Reference for DeleteBrowserSettings Operation</seealso>
        public virtual Task<DeleteBrowserSettingsResponse> DeleteBrowserSettingsAsync(DeleteBrowserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBrowserSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBrowserSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDataProtectionSettings

        internal virtual DeleteDataProtectionSettingsResponse DeleteDataProtectionSettings(DeleteDataProtectionSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataProtectionSettingsResponseUnmarshaller.Instance;

            return Invoke<DeleteDataProtectionSettingsResponse>(request, options);
        }



        /// <summary>
        /// Deletes data protection settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataProtectionSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteDataProtectionSettings">REST API Reference for DeleteDataProtectionSettings Operation</seealso>
        public virtual Task<DeleteDataProtectionSettingsResponse> DeleteDataProtectionSettingsAsync(DeleteDataProtectionSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataProtectionSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDataProtectionSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteIdentityProvider

        internal virtual DeleteIdentityProviderResponse DeleteIdentityProvider(DeleteIdentityProviderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentityProviderResponse>(request, options);
        }



        /// <summary>
        /// Deletes the identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIdentityProvider service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteIdentityProvider">REST API Reference for DeleteIdentityProvider Operation</seealso>
        public virtual Task<DeleteIdentityProviderResponse> DeleteIdentityProviderAsync(DeleteIdentityProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentityProviderResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIdentityProviderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteIpAccessSettings

        internal virtual DeleteIpAccessSettingsResponse DeleteIpAccessSettings(DeleteIpAccessSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIpAccessSettingsResponseUnmarshaller.Instance;

            return Invoke<DeleteIpAccessSettingsResponse>(request, options);
        }



        /// <summary>
        /// Deletes IP access settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIpAccessSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteIpAccessSettings">REST API Reference for DeleteIpAccessSettings Operation</seealso>
        public virtual Task<DeleteIpAccessSettingsResponse> DeleteIpAccessSettingsAsync(DeleteIpAccessSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIpAccessSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIpAccessSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteNetworkSettings

        internal virtual DeleteNetworkSettingsResponse DeleteNetworkSettings(DeleteNetworkSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkSettingsResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkSettingsResponse>(request, options);
        }



        /// <summary>
        /// Deletes network settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteNetworkSettings">REST API Reference for DeleteNetworkSettings Operation</seealso>
        public virtual Task<DeleteNetworkSettingsResponse> DeleteNetworkSettingsAsync(DeleteNetworkSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePortal

        internal virtual DeletePortalResponse DeletePortal(DeletePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalResponseUnmarshaller.Instance;

            return Invoke<DeletePortalResponse>(request, options);
        }



        /// <summary>
        /// Deletes a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePortal service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        public virtual Task<DeletePortalResponse> DeletePortalAsync(DeletePortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePortalResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSessionLogger

        internal virtual DeleteSessionLoggerResponse DeleteSessionLogger(DeleteSessionLoggerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSessionLoggerResponseUnmarshaller.Instance;

            return Invoke<DeleteSessionLoggerResponse>(request, options);
        }



        /// <summary>
        /// Deletes a session logger resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSessionLogger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSessionLogger service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteSessionLogger">REST API Reference for DeleteSessionLogger Operation</seealso>
        public virtual Task<DeleteSessionLoggerResponse> DeleteSessionLoggerAsync(DeleteSessionLoggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSessionLoggerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSessionLoggerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTrustStore

        internal virtual DeleteTrustStoreResponse DeleteTrustStore(DeleteTrustStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrustStoreResponseUnmarshaller.Instance;

            return Invoke<DeleteTrustStoreResponse>(request, options);
        }



        /// <summary>
        /// Deletes the trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteTrustStore">REST API Reference for DeleteTrustStore Operation</seealso>
        public virtual Task<DeleteTrustStoreResponse> DeleteTrustStoreAsync(DeleteTrustStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrustStoreResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrustStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteUserAccessLoggingSettings

        internal virtual DeleteUserAccessLoggingSettingsResponse DeleteUserAccessLoggingSettings(DeleteUserAccessLoggingSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return Invoke<DeleteUserAccessLoggingSettingsResponse>(request, options);
        }



        /// <summary>
        /// Deletes user access logging settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserAccessLoggingSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteUserAccessLoggingSettings">REST API Reference for DeleteUserAccessLoggingSettings Operation</seealso>
        public virtual Task<DeleteUserAccessLoggingSettingsResponse> DeleteUserAccessLoggingSettingsAsync(DeleteUserAccessLoggingSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserAccessLoggingSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteUserSettings

        internal virtual DeleteUserSettingsResponse DeleteUserSettings(DeleteUserSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserSettingsResponseUnmarshaller.Instance;

            return Invoke<DeleteUserSettingsResponse>(request, options);
        }



        /// <summary>
        /// Deletes user settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DeleteUserSettings">REST API Reference for DeleteUserSettings Operation</seealso>
        public virtual Task<DeleteUserSettingsResponse> DeleteUserSettingsAsync(DeleteUserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateBrowserSettings

        internal virtual DisassociateBrowserSettingsResponse DisassociateBrowserSettings(DisassociateBrowserSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateBrowserSettingsResponseUnmarshaller.Instance;

            return Invoke<DisassociateBrowserSettingsResponse>(request, options);
        }



        /// <summary>
        /// Disassociates browser settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBrowserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateBrowserSettings">REST API Reference for DisassociateBrowserSettings Operation</seealso>
        public virtual Task<DisassociateBrowserSettingsResponse> DisassociateBrowserSettingsAsync(DisassociateBrowserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateBrowserSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateBrowserSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateDataProtectionSettings

        internal virtual DisassociateDataProtectionSettingsResponse DisassociateDataProtectionSettings(DisassociateDataProtectionSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDataProtectionSettingsResponseUnmarshaller.Instance;

            return Invoke<DisassociateDataProtectionSettingsResponse>(request, options);
        }



        /// <summary>
        /// Disassociates data protection settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDataProtectionSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateDataProtectionSettings">REST API Reference for DisassociateDataProtectionSettings Operation</seealso>
        public virtual Task<DisassociateDataProtectionSettingsResponse> DisassociateDataProtectionSettingsAsync(DisassociateDataProtectionSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDataProtectionSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateDataProtectionSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateIpAccessSettings

        internal virtual DisassociateIpAccessSettingsResponse DisassociateIpAccessSettings(DisassociateIpAccessSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIpAccessSettingsResponseUnmarshaller.Instance;

            return Invoke<DisassociateIpAccessSettingsResponse>(request, options);
        }



        /// <summary>
        /// Disassociates IP access settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIpAccessSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateIpAccessSettings">REST API Reference for DisassociateIpAccessSettings Operation</seealso>
        public virtual Task<DisassociateIpAccessSettingsResponse> DisassociateIpAccessSettingsAsync(DisassociateIpAccessSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIpAccessSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateIpAccessSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateNetworkSettings

        internal virtual DisassociateNetworkSettingsResponse DisassociateNetworkSettings(DisassociateNetworkSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateNetworkSettingsResponseUnmarshaller.Instance;

            return Invoke<DisassociateNetworkSettingsResponse>(request, options);
        }



        /// <summary>
        /// Disassociates network settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateNetworkSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateNetworkSettings">REST API Reference for DisassociateNetworkSettings Operation</seealso>
        public virtual Task<DisassociateNetworkSettingsResponse> DisassociateNetworkSettingsAsync(DisassociateNetworkSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateNetworkSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateNetworkSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateSessionLogger

        internal virtual DisassociateSessionLoggerResponse DisassociateSessionLogger(DisassociateSessionLoggerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSessionLoggerResponseUnmarshaller.Instance;

            return Invoke<DisassociateSessionLoggerResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a session logger from a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSessionLogger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateSessionLogger service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateSessionLogger">REST API Reference for DisassociateSessionLogger Operation</seealso>
        public virtual Task<DisassociateSessionLoggerResponse> DisassociateSessionLoggerAsync(DisassociateSessionLoggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSessionLoggerResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateSessionLoggerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateTrustStore

        internal virtual DisassociateTrustStoreResponse DisassociateTrustStore(DisassociateTrustStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTrustStoreResponseUnmarshaller.Instance;

            return Invoke<DisassociateTrustStoreResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a trust store from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTrustStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateTrustStore">REST API Reference for DisassociateTrustStore Operation</seealso>
        public virtual Task<DisassociateTrustStoreResponse> DisassociateTrustStoreAsync(DisassociateTrustStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTrustStoreResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateTrustStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateUserAccessLoggingSettings

        internal virtual DisassociateUserAccessLoggingSettingsResponse DisassociateUserAccessLoggingSettings(DisassociateUserAccessLoggingSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return Invoke<DisassociateUserAccessLoggingSettingsResponse>(request, options);
        }



        /// <summary>
        /// Disassociates user access logging settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateUserAccessLoggingSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateUserAccessLoggingSettings">REST API Reference for DisassociateUserAccessLoggingSettings Operation</seealso>
        public virtual Task<DisassociateUserAccessLoggingSettingsResponse> DisassociateUserAccessLoggingSettingsAsync(DisassociateUserAccessLoggingSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateUserAccessLoggingSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateUserSettings

        internal virtual DisassociateUserSettingsResponse DisassociateUserSettings(DisassociateUserSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateUserSettingsResponseUnmarshaller.Instance;

            return Invoke<DisassociateUserSettingsResponse>(request, options);
        }



        /// <summary>
        /// Disassociates user settings from a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateUserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/DisassociateUserSettings">REST API Reference for DisassociateUserSettings Operation</seealso>
        public virtual Task<DisassociateUserSettingsResponse> DisassociateUserSettingsAsync(DisassociateUserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateUserSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateUserSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExpireSession

        internal virtual ExpireSessionResponse ExpireSession(ExpireSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExpireSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExpireSessionResponseUnmarshaller.Instance;

            return Invoke<ExpireSessionResponse>(request, options);
        }



        /// <summary>
        /// Expires an active secure browser session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExpireSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExpireSession service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ExpireSession">REST API Reference for ExpireSession Operation</seealso>
        public virtual Task<ExpireSessionResponse> ExpireSessionAsync(ExpireSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExpireSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExpireSessionResponseUnmarshaller.Instance;

            return InvokeAsync<ExpireSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetBrowserSettings

        internal virtual GetBrowserSettingsResponse GetBrowserSettings(GetBrowserSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBrowserSettingsResponseUnmarshaller.Instance;

            return Invoke<GetBrowserSettingsResponse>(request, options);
        }



        /// <summary>
        /// Gets browser settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBrowserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetBrowserSettings">REST API Reference for GetBrowserSettings Operation</seealso>
        public virtual Task<GetBrowserSettingsResponse> GetBrowserSettingsAsync(GetBrowserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBrowserSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBrowserSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDataProtectionSettings

        internal virtual GetDataProtectionSettingsResponse GetDataProtectionSettings(GetDataProtectionSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataProtectionSettingsResponseUnmarshaller.Instance;

            return Invoke<GetDataProtectionSettingsResponse>(request, options);
        }



        /// <summary>
        /// Gets the data protection settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataProtectionSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetDataProtectionSettings">REST API Reference for GetDataProtectionSettings Operation</seealso>
        public virtual Task<GetDataProtectionSettingsResponse> GetDataProtectionSettingsAsync(GetDataProtectionSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataProtectionSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataProtectionSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetIdentityProvider

        internal virtual GetIdentityProviderResponse GetIdentityProvider(GetIdentityProviderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<GetIdentityProviderResponse>(request, options);
        }



        /// <summary>
        /// Gets the identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdentityProvider service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetIdentityProvider">REST API Reference for GetIdentityProvider Operation</seealso>
        public virtual Task<GetIdentityProviderResponse> GetIdentityProviderAsync(GetIdentityProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityProviderResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdentityProviderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetIpAccessSettings

        internal virtual GetIpAccessSettingsResponse GetIpAccessSettings(GetIpAccessSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIpAccessSettingsResponseUnmarshaller.Instance;

            return Invoke<GetIpAccessSettingsResponse>(request, options);
        }



        /// <summary>
        /// Gets the IP access settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIpAccessSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetIpAccessSettings">REST API Reference for GetIpAccessSettings Operation</seealso>
        public virtual Task<GetIpAccessSettingsResponse> GetIpAccessSettingsAsync(GetIpAccessSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIpAccessSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetIpAccessSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetNetworkSettings

        internal virtual GetNetworkSettingsResponse GetNetworkSettings(GetNetworkSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkSettingsResponseUnmarshaller.Instance;

            return Invoke<GetNetworkSettingsResponse>(request, options);
        }



        /// <summary>
        /// Gets the network settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetNetworkSettings">REST API Reference for GetNetworkSettings Operation</seealso>
        public virtual Task<GetNetworkSettingsResponse> GetNetworkSettingsAsync(GetNetworkSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetNetworkSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPortal

        internal virtual GetPortalResponse GetPortal(GetPortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortalResponseUnmarshaller.Instance;

            return Invoke<GetPortalResponse>(request, options);
        }



        /// <summary>
        /// Gets the web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPortal service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetPortal">REST API Reference for GetPortal Operation</seealso>
        public virtual Task<GetPortalResponse> GetPortalAsync(GetPortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortalResponseUnmarshaller.Instance;

            return InvokeAsync<GetPortalResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPortalServiceProviderMetadata

        internal virtual GetPortalServiceProviderMetadataResponse GetPortalServiceProviderMetadata(GetPortalServiceProviderMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPortalServiceProviderMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortalServiceProviderMetadataResponseUnmarshaller.Instance;

            return Invoke<GetPortalServiceProviderMetadataResponse>(request, options);
        }



        /// <summary>
        /// Gets the service provider metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortalServiceProviderMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPortalServiceProviderMetadata service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetPortalServiceProviderMetadata">REST API Reference for GetPortalServiceProviderMetadata Operation</seealso>
        public virtual Task<GetPortalServiceProviderMetadataResponse> GetPortalServiceProviderMetadataAsync(GetPortalServiceProviderMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPortalServiceProviderMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortalServiceProviderMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<GetPortalServiceProviderMetadataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSession

        internal virtual GetSessionResponse GetSession(GetSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;

            return Invoke<GetSessionResponse>(request, options);
        }



        /// <summary>
        /// Gets information for a secure browser session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSession service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual Task<GetSessionResponse> GetSessionAsync(GetSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;

            return InvokeAsync<GetSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSessionLogger

        internal virtual GetSessionLoggerResponse GetSessionLogger(GetSessionLoggerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionLoggerResponseUnmarshaller.Instance;

            return Invoke<GetSessionLoggerResponse>(request, options);
        }



        /// <summary>
        /// Gets details about a specific session logger resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionLogger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSessionLogger service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetSessionLogger">REST API Reference for GetSessionLogger Operation</seealso>
        public virtual Task<GetSessionLoggerResponse> GetSessionLoggerAsync(GetSessionLoggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionLoggerResponseUnmarshaller.Instance;

            return InvokeAsync<GetSessionLoggerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTrustStore

        internal virtual GetTrustStoreResponse GetTrustStore(GetTrustStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrustStoreResponseUnmarshaller.Instance;

            return Invoke<GetTrustStoreResponse>(request, options);
        }



        /// <summary>
        /// Gets the trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrustStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetTrustStore">REST API Reference for GetTrustStore Operation</seealso>
        public virtual Task<GetTrustStoreResponse> GetTrustStoreAsync(GetTrustStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrustStoreResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrustStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTrustStoreCertificate

        internal virtual GetTrustStoreCertificateResponse GetTrustStoreCertificate(GetTrustStoreCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrustStoreCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrustStoreCertificateResponseUnmarshaller.Instance;

            return Invoke<GetTrustStoreCertificateResponse>(request, options);
        }



        /// <summary>
        /// Gets the trust store certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrustStoreCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTrustStoreCertificate service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetTrustStoreCertificate">REST API Reference for GetTrustStoreCertificate Operation</seealso>
        public virtual Task<GetTrustStoreCertificateResponse> GetTrustStoreCertificateAsync(GetTrustStoreCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrustStoreCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrustStoreCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrustStoreCertificateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetUserAccessLoggingSettings

        internal virtual GetUserAccessLoggingSettingsResponse GetUserAccessLoggingSettings(GetUserAccessLoggingSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return Invoke<GetUserAccessLoggingSettingsResponse>(request, options);
        }



        /// <summary>
        /// Gets user access logging settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserAccessLoggingSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetUserAccessLoggingSettings">REST API Reference for GetUserAccessLoggingSettings Operation</seealso>
        public virtual Task<GetUserAccessLoggingSettingsResponse> GetUserAccessLoggingSettingsAsync(GetUserAccessLoggingSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserAccessLoggingSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetUserSettings

        internal virtual GetUserSettingsResponse GetUserSettings(GetUserSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserSettingsResponseUnmarshaller.Instance;

            return Invoke<GetUserSettingsResponse>(request, options);
        }



        /// <summary>
        /// Gets user settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/GetUserSettings">REST API Reference for GetUserSettings Operation</seealso>
        public virtual Task<GetUserSettingsResponse> GetUserSettingsAsync(GetUserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBrowserSettings

        internal virtual ListBrowserSettingsResponse ListBrowserSettings(ListBrowserSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBrowserSettingsResponseUnmarshaller.Instance;

            return Invoke<ListBrowserSettingsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of browser settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrowserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListBrowserSettings">REST API Reference for ListBrowserSettings Operation</seealso>
        public virtual Task<ListBrowserSettingsResponse> ListBrowserSettingsAsync(ListBrowserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBrowserSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBrowserSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDataProtectionSettings

        internal virtual ListDataProtectionSettingsResponse ListDataProtectionSettings(ListDataProtectionSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataProtectionSettingsResponseUnmarshaller.Instance;

            return Invoke<ListDataProtectionSettingsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of data protection settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataProtectionSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListDataProtectionSettings">REST API Reference for ListDataProtectionSettings Operation</seealso>
        public virtual Task<ListDataProtectionSettingsResponse> ListDataProtectionSettingsAsync(ListDataProtectionSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataProtectionSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataProtectionSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIdentityProviders

        internal virtual ListIdentityProvidersResponse ListIdentityProviders(ListIdentityProvidersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdentityProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityProvidersResponseUnmarshaller.Instance;

            return Invoke<ListIdentityProvidersResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of identity providers for a specific web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdentityProviders service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        public virtual Task<ListIdentityProvidersResponse> ListIdentityProvidersAsync(ListIdentityProvidersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdentityProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityProvidersResponseUnmarshaller.Instance;

            return InvokeAsync<ListIdentityProvidersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIpAccessSettings

        internal virtual ListIpAccessSettingsResponse ListIpAccessSettings(ListIpAccessSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIpAccessSettingsResponseUnmarshaller.Instance;

            return Invoke<ListIpAccessSettingsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of IP access settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIpAccessSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListIpAccessSettings">REST API Reference for ListIpAccessSettings Operation</seealso>
        public virtual Task<ListIpAccessSettingsResponse> ListIpAccessSettingsAsync(ListIpAccessSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIpAccessSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIpAccessSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListNetworkSettings

        internal virtual ListNetworkSettingsResponse ListNetworkSettings(ListNetworkSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkSettingsResponseUnmarshaller.Instance;

            return Invoke<ListNetworkSettingsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of network settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListNetworkSettings">REST API Reference for ListNetworkSettings Operation</seealso>
        public virtual Task<ListNetworkSettingsResponse> ListNetworkSettingsAsync(ListNetworkSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNetworkSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListNetworkSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPortals

        internal virtual ListPortalsResponse ListPortals(ListPortalsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPortalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortalsResponseUnmarshaller.Instance;

            return Invoke<ListPortalsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list or web portals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPortals service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListPortals">REST API Reference for ListPortals Operation</seealso>
        public virtual Task<ListPortalsResponse> ListPortalsAsync(ListPortalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPortalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortalsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPortalsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSessionLoggers

        internal virtual ListSessionLoggersResponse ListSessionLoggers(ListSessionLoggersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionLoggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionLoggersResponseUnmarshaller.Instance;

            return Invoke<ListSessionLoggersResponse>(request, options);
        }



        /// <summary>
        /// Lists all available session logger resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessionLoggers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSessionLoggers service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListSessionLoggers">REST API Reference for ListSessionLoggers Operation</seealso>
        public virtual Task<ListSessionLoggersResponse> ListSessionLoggersAsync(ListSessionLoggersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionLoggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionLoggersResponseUnmarshaller.Instance;

            return InvokeAsync<ListSessionLoggersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSessions

        internal virtual ListSessionsResponse ListSessions(ListSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsResponseUnmarshaller.Instance;

            return Invoke<ListSessionsResponse>(request, options);
        }



        /// <summary>
        /// Lists information for multiple secure browser sessions from a specific portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSessions service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual Task<ListSessionsResponse> ListSessionsAsync(ListSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSessionsResponse>(request, options, cancellationToken);
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
        /// <returns>The response from the ListTagsForResource service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTrustStoreCertificates

        internal virtual ListTrustStoreCertificatesResponse ListTrustStoreCertificates(ListTrustStoreCertificatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTrustStoreCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrustStoreCertificatesResponseUnmarshaller.Instance;

            return Invoke<ListTrustStoreCertificatesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of trust store certificates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrustStoreCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrustStoreCertificates service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTrustStoreCertificates">REST API Reference for ListTrustStoreCertificates Operation</seealso>
        public virtual Task<ListTrustStoreCertificatesResponse> ListTrustStoreCertificatesAsync(ListTrustStoreCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTrustStoreCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrustStoreCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrustStoreCertificatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTrustStores

        internal virtual ListTrustStoresResponse ListTrustStores(ListTrustStoresRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTrustStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrustStoresResponseUnmarshaller.Instance;

            return Invoke<ListTrustStoresResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of trust stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrustStores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrustStores service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListTrustStores">REST API Reference for ListTrustStores Operation</seealso>
        public virtual Task<ListTrustStoresResponse> ListTrustStoresAsync(ListTrustStoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTrustStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrustStoresResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrustStoresResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListUserAccessLoggingSettings

        internal virtual ListUserAccessLoggingSettingsResponse ListUserAccessLoggingSettings(ListUserAccessLoggingSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return Invoke<ListUserAccessLoggingSettingsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of user access logging settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserAccessLoggingSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListUserAccessLoggingSettings">REST API Reference for ListUserAccessLoggingSettings Operation</seealso>
        public virtual Task<ListUserAccessLoggingSettingsResponse> ListUserAccessLoggingSettingsAsync(ListUserAccessLoggingSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListUserAccessLoggingSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListUserSettings

        internal virtual ListUserSettingsResponse ListUserSettings(ListUserSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserSettingsResponseUnmarshaller.Instance;

            return Invoke<ListUserSettingsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of user settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/ListUserSettings">REST API Reference for ListUserSettings Operation</seealso>
        public virtual Task<ListUserSettingsResponse> ListUserSettingsAsync(ListUserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListUserSettingsResponse>(request, options, cancellationToken);
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
        /// Adds or overwrites one or more tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.TooManyTagsException">
        /// There are too many tags.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateBrowserSettings

        internal virtual UpdateBrowserSettingsResponse UpdateBrowserSettings(UpdateBrowserSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrowserSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateBrowserSettingsResponse>(request, options);
        }



        /// <summary>
        /// Updates browser settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrowserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBrowserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateBrowserSettings">REST API Reference for UpdateBrowserSettings Operation</seealso>
        public virtual Task<UpdateBrowserSettingsResponse> UpdateBrowserSettingsAsync(UpdateBrowserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBrowserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrowserSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBrowserSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDataProtectionSettings

        internal virtual UpdateDataProtectionSettingsResponse UpdateDataProtectionSettings(UpdateDataProtectionSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataProtectionSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateDataProtectionSettingsResponse>(request, options);
        }



        /// <summary>
        /// Updates data protection settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataProtectionSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataProtectionSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateDataProtectionSettings">REST API Reference for UpdateDataProtectionSettings Operation</seealso>
        public virtual Task<UpdateDataProtectionSettingsResponse> UpdateDataProtectionSettingsAsync(UpdateDataProtectionSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataProtectionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataProtectionSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDataProtectionSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateIdentityProvider

        internal virtual UpdateIdentityProviderResponse UpdateIdentityProvider(UpdateIdentityProviderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<UpdateIdentityProviderResponse>(request, options);
        }



        /// <summary>
        /// Updates the identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIdentityProvider service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateIdentityProvider">REST API Reference for UpdateIdentityProvider Operation</seealso>
        public virtual Task<UpdateIdentityProviderResponse> UpdateIdentityProviderAsync(UpdateIdentityProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityProviderResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIdentityProviderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateIpAccessSettings

        internal virtual UpdateIpAccessSettingsResponse UpdateIpAccessSettings(UpdateIpAccessSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIpAccessSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateIpAccessSettingsResponse>(request, options);
        }



        /// <summary>
        /// Updates IP access settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIpAccessSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIpAccessSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateIpAccessSettings">REST API Reference for UpdateIpAccessSettings Operation</seealso>
        public virtual Task<UpdateIpAccessSettingsResponse> UpdateIpAccessSettingsAsync(UpdateIpAccessSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIpAccessSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIpAccessSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIpAccessSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateNetworkSettings

        internal virtual UpdateNetworkSettingsResponse UpdateNetworkSettings(UpdateNetworkSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateNetworkSettingsResponse>(request, options);
        }



        /// <summary>
        /// Updates network settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNetworkSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateNetworkSettings">REST API Reference for UpdateNetworkSettings Operation</seealso>
        public virtual Task<UpdateNetworkSettingsResponse> UpdateNetworkSettingsAsync(UpdateNetworkSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNetworkSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNetworkSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdatePortal

        internal virtual UpdatePortalResponse UpdatePortal(UpdatePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalResponseUnmarshaller.Instance;

            return Invoke<UpdatePortalResponse>(request, options);
        }



        /// <summary>
        /// Updates a web portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePortal service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ConflictException">
        /// There is a conflict.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        public virtual Task<UpdatePortalResponse> UpdatePortalAsync(UpdatePortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePortalResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSessionLogger

        internal virtual UpdateSessionLoggerResponse UpdateSessionLogger(UpdateSessionLoggerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSessionLoggerResponseUnmarshaller.Instance;

            return Invoke<UpdateSessionLoggerResponse>(request, options);
        }



        /// <summary>
        /// Updates the details of a session logger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSessionLogger service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSessionLogger service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateSessionLogger">REST API Reference for UpdateSessionLogger Operation</seealso>
        public virtual Task<UpdateSessionLoggerResponse> UpdateSessionLoggerAsync(UpdateSessionLoggerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSessionLoggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSessionLoggerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSessionLoggerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTrustStore

        internal virtual UpdateTrustStoreResponse UpdateTrustStore(UpdateTrustStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrustStoreResponseUnmarshaller.Instance;

            return Invoke<UpdateTrustStoreResponse>(request, options);
        }



        /// <summary>
        /// Updates the trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrustStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTrustStore service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateTrustStore">REST API Reference for UpdateTrustStore Operation</seealso>
        public virtual Task<UpdateTrustStoreResponse> UpdateTrustStoreAsync(UpdateTrustStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTrustStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrustStoreResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrustStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateUserAccessLoggingSettings

        internal virtual UpdateUserAccessLoggingSettingsResponse UpdateUserAccessLoggingSettings(UpdateUserAccessLoggingSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateUserAccessLoggingSettingsResponse>(request, options);
        }



        /// <summary>
        /// Updates the user access logging settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserAccessLoggingSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserAccessLoggingSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateUserAccessLoggingSettings">REST API Reference for UpdateUserAccessLoggingSettings Operation</seealso>
        public virtual Task<UpdateUserAccessLoggingSettingsResponse> UpdateUserAccessLoggingSettingsAsync(UpdateUserAccessLoggingSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUserAccessLoggingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserAccessLoggingSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserAccessLoggingSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateUserSettings

        internal virtual UpdateUserSettingsResponse UpdateUserSettings(UpdateUserSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateUserSettingsResponse>(request, options);
        }



        /// <summary>
        /// Updates the user settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserSettings service method, as returned by WorkSpacesWeb.</returns>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.InternalServerException">
        /// There is an internal server error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ThrottlingException">
        /// There is a throttling error.
        /// </exception>
        /// <exception cref="Amazon.WorkSpacesWeb.Model.ValidationException">
        /// There is a validation error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-web-2020-07-08/UpdateUserSettings">REST API Reference for UpdateUserSettings Operation</seealso>
        public virtual Task<UpdateUserSettingsResponse> UpdateUserSettingsAsync(UpdateUserSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserSettingsResponse>(request, options, cancellationToken);
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
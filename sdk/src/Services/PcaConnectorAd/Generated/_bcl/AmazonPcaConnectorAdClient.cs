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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.PcaConnectorAd.Model;
using Amazon.PcaConnectorAd.Model.Internal.MarshallTransformations;
using Amazon.PcaConnectorAd.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.PcaConnectorAd
{
    /// <summary>
    /// <para>Implementation for accessing PcaConnectorAd</para>
    ///
    /// Amazon Web Services Private CA Connector for Active Directory creates a connector
    /// between Amazon Web Services Private CA and Active Directory (AD) that enables you
    /// to provision security certificates for AD signed by a private CA that you own. For
    /// more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/ad-connector.html">Amazon
    /// Web Services Private CA Connector for Active Directory</a>.
    /// </summary>
    public partial class AmazonPcaConnectorAdClient : AmazonServiceClient, IAmazonPcaConnectorAd
    {
        private static IServiceMetadata serviceMetadata = new AmazonPcaConnectorAdMetadata();
        private IPcaConnectorAdPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPcaConnectorAdPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PcaConnectorAdPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with the credentials loaded from the application's
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
        public AmazonPcaConnectorAdClient()
            : base(new AmazonPcaConnectorAdConfig()) { }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with the credentials loaded from the application's
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
        public AmazonPcaConnectorAdClient(RegionEndpoint region)
            : base(new AmazonPcaConnectorAdConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPcaConnectorAdClient Configuration Object</param>
        public AmazonPcaConnectorAdClient(AmazonPcaConnectorAdConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPcaConnectorAdClient(AWSCredentials credentials)
            : this(credentials, new AmazonPcaConnectorAdConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPcaConnectorAdClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPcaConnectorAdConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with AWS Credentials and an
        /// AmazonPcaConnectorAdClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPcaConnectorAdClient Configuration Object</param>
        public AmazonPcaConnectorAdClient(AWSCredentials credentials, AmazonPcaConnectorAdConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPcaConnectorAdClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPcaConnectorAdConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPcaConnectorAdClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPcaConnectorAdConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPcaConnectorAdClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPcaConnectorAdClient Configuration Object</param>
        public AmazonPcaConnectorAdClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPcaConnectorAdConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPcaConnectorAdClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPcaConnectorAdConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPcaConnectorAdClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPcaConnectorAdConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPcaConnectorAdClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPcaConnectorAdClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPcaConnectorAdClient Configuration Object</param>
        public AmazonPcaConnectorAdClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPcaConnectorAdConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPcaConnectorAdEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPcaConnectorAdAuthSchemeHandler());
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


        #region  CreateConnector


        /// <summary>
        /// Creates a connector between Amazon Web Services Private CA and an Active Directory.
        /// You must specify the private CA, directory ID, and security groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector service method.</param>
        /// 
        /// <returns>The response from the CreateConnector service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        public virtual CreateConnectorResponse CreateConnector(CreateConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectorResponseUnmarshaller.Instance;

            return Invoke<CreateConnectorResponse>(request, options);
        }


        /// <summary>
        /// Creates a connector between Amazon Web Services Private CA and an Active Directory.
        /// You must specify the private CA, directory ID, and security groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnector service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        public virtual Task<CreateConnectorResponse> CreateConnectorAsync(CreateConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateConnectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDirectoryRegistration


        /// <summary>
        /// Creates a directory registration that authorizes communication between Amazon Web
        /// Services Private CA and an Active Directory
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectoryRegistration service method.</param>
        /// 
        /// <returns>The response from the CreateDirectoryRegistration service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateDirectoryRegistration">REST API Reference for CreateDirectoryRegistration Operation</seealso>
        public virtual CreateDirectoryRegistrationResponse CreateDirectoryRegistration(CreateDirectoryRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDirectoryRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectoryRegistrationResponseUnmarshaller.Instance;

            return Invoke<CreateDirectoryRegistrationResponse>(request, options);
        }


        /// <summary>
        /// Creates a directory registration that authorizes communication between Amazon Web
        /// Services Private CA and an Active Directory
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectoryRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDirectoryRegistration service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateDirectoryRegistration">REST API Reference for CreateDirectoryRegistration Operation</seealso>
        public virtual Task<CreateDirectoryRegistrationResponse> CreateDirectoryRegistrationAsync(CreateDirectoryRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDirectoryRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectoryRegistrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDirectoryRegistrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateServicePrincipalName


        /// <summary>
        /// Creates a service principal name (SPN) for the service account in Active Directory.
        /// Kerberos authentication uses SPNs to associate a service instance with a service sign-in
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServicePrincipalName service method.</param>
        /// 
        /// <returns>The response from the CreateServicePrincipalName service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateServicePrincipalName">REST API Reference for CreateServicePrincipalName Operation</seealso>
        public virtual CreateServicePrincipalNameResponse CreateServicePrincipalName(CreateServicePrincipalNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateServicePrincipalNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServicePrincipalNameResponseUnmarshaller.Instance;

            return Invoke<CreateServicePrincipalNameResponse>(request, options);
        }


        /// <summary>
        /// Creates a service principal name (SPN) for the service account in Active Directory.
        /// Kerberos authentication uses SPNs to associate a service instance with a service sign-in
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServicePrincipalName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateServicePrincipalName service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateServicePrincipalName">REST API Reference for CreateServicePrincipalName Operation</seealso>
        public virtual Task<CreateServicePrincipalNameResponse> CreateServicePrincipalNameAsync(CreateServicePrincipalNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateServicePrincipalNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServicePrincipalNameResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateServicePrincipalNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTemplate


        /// <summary>
        /// Creates an Active Directory compatible certificate template. The connectors issues
        /// certificates using these templates based on the requester’s Active Directory group
        /// membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        public virtual CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateTemplateResponse>(request, options);
        }


        /// <summary>
        /// Creates an Active Directory compatible certificate template. The connectors issues
        /// certificates using these templates based on the requester’s Active Directory group
        /// membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        public virtual Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTemplateGroupAccessControlEntry


        /// <summary>
        /// Create a group access control entry. Allow or deny Active Directory groups from enrolling
        /// and/or autoenrolling with the template based on the group security identifiers (SIDs).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateGroupAccessControlEntry service method.</param>
        /// 
        /// <returns>The response from the CreateTemplateGroupAccessControlEntry service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateTemplateGroupAccessControlEntry">REST API Reference for CreateTemplateGroupAccessControlEntry Operation</seealso>
        public virtual CreateTemplateGroupAccessControlEntryResponse CreateTemplateGroupAccessControlEntry(CreateTemplateGroupAccessControlEntryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTemplateGroupAccessControlEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateGroupAccessControlEntryResponseUnmarshaller.Instance;

            return Invoke<CreateTemplateGroupAccessControlEntryResponse>(request, options);
        }


        /// <summary>
        /// Create a group access control entry. Allow or deny Active Directory groups from enrolling
        /// and/or autoenrolling with the template based on the group security identifiers (SIDs).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateGroupAccessControlEntry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTemplateGroupAccessControlEntry service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateTemplateGroupAccessControlEntry">REST API Reference for CreateTemplateGroupAccessControlEntry Operation</seealso>
        public virtual Task<CreateTemplateGroupAccessControlEntryResponse> CreateTemplateGroupAccessControlEntryAsync(CreateTemplateGroupAccessControlEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTemplateGroupAccessControlEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateGroupAccessControlEntryResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateTemplateGroupAccessControlEntryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConnector


        /// <summary>
        /// Deletes a connector for Active Directory. You must provide the Amazon Resource Name
        /// (ARN) of the connector that you want to delete. You can find the ARN by calling the
        /// <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_ListConnectors">https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_ListConnectors</a>
        /// action. Deleting a connector does not deregister your directory with Amazon Web Services
        /// Private CA. You can deregister your directory by calling the <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_DeleteDirectoryRegistration">https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_DeleteDirectoryRegistration</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector service method.</param>
        /// 
        /// <returns>The response from the DeleteConnector service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        public virtual DeleteConnectorResponse DeleteConnector(DeleteConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectorResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectorResponse>(request, options);
        }


        /// <summary>
        /// Deletes a connector for Active Directory. You must provide the Amazon Resource Name
        /// (ARN) of the connector that you want to delete. You can find the ARN by calling the
        /// <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_ListConnectors">https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_ListConnectors</a>
        /// action. Deleting a connector does not deregister your directory with Amazon Web Services
        /// Private CA. You can deregister your directory by calling the <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_DeleteDirectoryRegistration">https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_DeleteDirectoryRegistration</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnector service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        public virtual Task<DeleteConnectorResponse> DeleteConnectorAsync(DeleteConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteConnectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDirectoryRegistration


        /// <summary>
        /// Deletes a directory registration. Deleting a directory registration deauthorizes Amazon
        /// Web Services Private CA with the directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectoryRegistration service method.</param>
        /// 
        /// <returns>The response from the DeleteDirectoryRegistration service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteDirectoryRegistration">REST API Reference for DeleteDirectoryRegistration Operation</seealso>
        public virtual DeleteDirectoryRegistrationResponse DeleteDirectoryRegistration(DeleteDirectoryRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDirectoryRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectoryRegistrationResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectoryRegistrationResponse>(request, options);
        }


        /// <summary>
        /// Deletes a directory registration. Deleting a directory registration deauthorizes Amazon
        /// Web Services Private CA with the directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectoryRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDirectoryRegistration service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteDirectoryRegistration">REST API Reference for DeleteDirectoryRegistration Operation</seealso>
        public virtual Task<DeleteDirectoryRegistrationResponse> DeleteDirectoryRegistrationAsync(DeleteDirectoryRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDirectoryRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectoryRegistrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDirectoryRegistrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteServicePrincipalName


        /// <summary>
        /// Deletes the service principal name (SPN) used by a connector to authenticate with
        /// your Active Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServicePrincipalName service method.</param>
        /// 
        /// <returns>The response from the DeleteServicePrincipalName service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteServicePrincipalName">REST API Reference for DeleteServicePrincipalName Operation</seealso>
        public virtual DeleteServicePrincipalNameResponse DeleteServicePrincipalName(DeleteServicePrincipalNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteServicePrincipalNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServicePrincipalNameResponseUnmarshaller.Instance;

            return Invoke<DeleteServicePrincipalNameResponse>(request, options);
        }


        /// <summary>
        /// Deletes the service principal name (SPN) used by a connector to authenticate with
        /// your Active Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServicePrincipalName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServicePrincipalName service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteServicePrincipalName">REST API Reference for DeleteServicePrincipalName Operation</seealso>
        public virtual Task<DeleteServicePrincipalNameResponse> DeleteServicePrincipalNameAsync(DeleteServicePrincipalNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteServicePrincipalNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServicePrincipalNameResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteServicePrincipalNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTemplate


        /// <summary>
        /// Deletes a template. Certificates issued using the template are still valid until they
        /// are revoked or expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteTemplate service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        public virtual DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteTemplateResponse>(request, options);
        }


        /// <summary>
        /// Deletes a template. Certificates issued using the template are still valid until they
        /// are revoked or expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTemplate service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        public virtual Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTemplateGroupAccessControlEntry


        /// <summary>
        /// Deletes a group access control entry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplateGroupAccessControlEntry service method.</param>
        /// 
        /// <returns>The response from the DeleteTemplateGroupAccessControlEntry service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteTemplateGroupAccessControlEntry">REST API Reference for DeleteTemplateGroupAccessControlEntry Operation</seealso>
        public virtual DeleteTemplateGroupAccessControlEntryResponse DeleteTemplateGroupAccessControlEntry(DeleteTemplateGroupAccessControlEntryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTemplateGroupAccessControlEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateGroupAccessControlEntryResponseUnmarshaller.Instance;

            return Invoke<DeleteTemplateGroupAccessControlEntryResponse>(request, options);
        }


        /// <summary>
        /// Deletes a group access control entry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplateGroupAccessControlEntry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTemplateGroupAccessControlEntry service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteTemplateGroupAccessControlEntry">REST API Reference for DeleteTemplateGroupAccessControlEntry Operation</seealso>
        public virtual Task<DeleteTemplateGroupAccessControlEntryResponse> DeleteTemplateGroupAccessControlEntryAsync(DeleteTemplateGroupAccessControlEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTemplateGroupAccessControlEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateGroupAccessControlEntryResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteTemplateGroupAccessControlEntryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConnector


        /// <summary>
        /// Lists information about your connector. You specify the connector on input by its
        /// ARN (Amazon Resource Name).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnector service method.</param>
        /// 
        /// <returns>The response from the GetConnector service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetConnector">REST API Reference for GetConnector Operation</seealso>
        public virtual GetConnectorResponse GetConnector(GetConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectorResponseUnmarshaller.Instance;

            return Invoke<GetConnectorResponse>(request, options);
        }


        /// <summary>
        /// Lists information about your connector. You specify the connector on input by its
        /// ARN (Amazon Resource Name).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnector service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetConnector">REST API Reference for GetConnector Operation</seealso>
        public virtual Task<GetConnectorResponse> GetConnectorAsync(GetConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetConnectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDirectoryRegistration


        /// <summary>
        /// A structure that contains information about your directory registration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDirectoryRegistration service method.</param>
        /// 
        /// <returns>The response from the GetDirectoryRegistration service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetDirectoryRegistration">REST API Reference for GetDirectoryRegistration Operation</seealso>
        public virtual GetDirectoryRegistrationResponse GetDirectoryRegistration(GetDirectoryRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDirectoryRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDirectoryRegistrationResponseUnmarshaller.Instance;

            return Invoke<GetDirectoryRegistrationResponse>(request, options);
        }


        /// <summary>
        /// A structure that contains information about your directory registration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDirectoryRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDirectoryRegistration service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetDirectoryRegistration">REST API Reference for GetDirectoryRegistration Operation</seealso>
        public virtual Task<GetDirectoryRegistrationResponse> GetDirectoryRegistrationAsync(GetDirectoryRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDirectoryRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDirectoryRegistrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDirectoryRegistrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServicePrincipalName


        /// <summary>
        /// Lists the service principal name that the connector uses to authenticate with Active
        /// Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServicePrincipalName service method.</param>
        /// 
        /// <returns>The response from the GetServicePrincipalName service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetServicePrincipalName">REST API Reference for GetServicePrincipalName Operation</seealso>
        public virtual GetServicePrincipalNameResponse GetServicePrincipalName(GetServicePrincipalNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServicePrincipalNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServicePrincipalNameResponseUnmarshaller.Instance;

            return Invoke<GetServicePrincipalNameResponse>(request, options);
        }


        /// <summary>
        /// Lists the service principal name that the connector uses to authenticate with Active
        /// Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServicePrincipalName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServicePrincipalName service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetServicePrincipalName">REST API Reference for GetServicePrincipalName Operation</seealso>
        public virtual Task<GetServicePrincipalNameResponse> GetServicePrincipalNameAsync(GetServicePrincipalNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServicePrincipalNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServicePrincipalNameResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetServicePrincipalNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTemplate


        /// <summary>
        /// Retrieves a certificate template that the connector uses to issue certificates from
        /// a private CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        public virtual GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return Invoke<GetTemplateResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a certificate template that the connector uses to issue certificates from
        /// a private CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        public virtual Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTemplateGroupAccessControlEntry


        /// <summary>
        /// Retrieves the group access control entries for a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateGroupAccessControlEntry service method.</param>
        /// 
        /// <returns>The response from the GetTemplateGroupAccessControlEntry service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetTemplateGroupAccessControlEntry">REST API Reference for GetTemplateGroupAccessControlEntry Operation</seealso>
        public virtual GetTemplateGroupAccessControlEntryResponse GetTemplateGroupAccessControlEntry(GetTemplateGroupAccessControlEntryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemplateGroupAccessControlEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateGroupAccessControlEntryResponseUnmarshaller.Instance;

            return Invoke<GetTemplateGroupAccessControlEntryResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the group access control entries for a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateGroupAccessControlEntry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemplateGroupAccessControlEntry service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetTemplateGroupAccessControlEntry">REST API Reference for GetTemplateGroupAccessControlEntry Operation</seealso>
        public virtual Task<GetTemplateGroupAccessControlEntryResponse> GetTemplateGroupAccessControlEntryAsync(GetTemplateGroupAccessControlEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemplateGroupAccessControlEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateGroupAccessControlEntryResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTemplateGroupAccessControlEntryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConnectors


        /// <summary>
        /// Lists the connectors that you created by using the <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateConnector">https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateConnector</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors service method.</param>
        /// 
        /// <returns>The response from the ListConnectors service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        public virtual ListConnectorsResponse ListConnectors(ListConnectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorsResponseUnmarshaller.Instance;

            return Invoke<ListConnectorsResponse>(request, options);
        }


        /// <summary>
        /// Lists the connectors that you created by using the <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateConnector">https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateConnector</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnectors service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        public virtual Task<ListConnectorsResponse> ListConnectorsAsync(ListConnectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListConnectorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDirectoryRegistrations


        /// <summary>
        /// Lists the directory registrations that you created by using the <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateDirectoryRegistration">https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateDirectoryRegistration</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDirectoryRegistrations service method.</param>
        /// 
        /// <returns>The response from the ListDirectoryRegistrations service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListDirectoryRegistrations">REST API Reference for ListDirectoryRegistrations Operation</seealso>
        public virtual ListDirectoryRegistrationsResponse ListDirectoryRegistrations(ListDirectoryRegistrationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDirectoryRegistrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDirectoryRegistrationsResponseUnmarshaller.Instance;

            return Invoke<ListDirectoryRegistrationsResponse>(request, options);
        }


        /// <summary>
        /// Lists the directory registrations that you created by using the <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateDirectoryRegistration">https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateDirectoryRegistration</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDirectoryRegistrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDirectoryRegistrations service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListDirectoryRegistrations">REST API Reference for ListDirectoryRegistrations Operation</seealso>
        public virtual Task<ListDirectoryRegistrationsResponse> ListDirectoryRegistrationsAsync(ListDirectoryRegistrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDirectoryRegistrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDirectoryRegistrationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDirectoryRegistrationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServicePrincipalNames


        /// <summary>
        /// Lists the service principal names that the connector uses to authenticate with Active
        /// Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServicePrincipalNames service method.</param>
        /// 
        /// <returns>The response from the ListServicePrincipalNames service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListServicePrincipalNames">REST API Reference for ListServicePrincipalNames Operation</seealso>
        public virtual ListServicePrincipalNamesResponse ListServicePrincipalNames(ListServicePrincipalNamesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServicePrincipalNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicePrincipalNamesResponseUnmarshaller.Instance;

            return Invoke<ListServicePrincipalNamesResponse>(request, options);
        }


        /// <summary>
        /// Lists the service principal names that the connector uses to authenticate with Active
        /// Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServicePrincipalNames service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServicePrincipalNames service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListServicePrincipalNames">REST API Reference for ListServicePrincipalNames Operation</seealso>
        public virtual Task<ListServicePrincipalNamesResponse> ListServicePrincipalNamesAsync(ListServicePrincipalNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServicePrincipalNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicePrincipalNamesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServicePrincipalNamesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags, if any, that are associated with your resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags, if any, that are associated with your resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTemplateGroupAccessControlEntries


        /// <summary>
        /// Lists group access control entries you created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateGroupAccessControlEntries service method.</param>
        /// 
        /// <returns>The response from the ListTemplateGroupAccessControlEntries service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTemplateGroupAccessControlEntries">REST API Reference for ListTemplateGroupAccessControlEntries Operation</seealso>
        public virtual ListTemplateGroupAccessControlEntriesResponse ListTemplateGroupAccessControlEntries(ListTemplateGroupAccessControlEntriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplateGroupAccessControlEntriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateGroupAccessControlEntriesResponseUnmarshaller.Instance;

            return Invoke<ListTemplateGroupAccessControlEntriesResponse>(request, options);
        }


        /// <summary>
        /// Lists group access control entries you created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateGroupAccessControlEntries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplateGroupAccessControlEntries service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTemplateGroupAccessControlEntries">REST API Reference for ListTemplateGroupAccessControlEntries Operation</seealso>
        public virtual Task<ListTemplateGroupAccessControlEntriesResponse> ListTemplateGroupAccessControlEntriesAsync(ListTemplateGroupAccessControlEntriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplateGroupAccessControlEntriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateGroupAccessControlEntriesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTemplateGroupAccessControlEntriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTemplates


        /// <summary>
        /// Lists the templates, if any, that are associated with a connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListTemplatesResponse>(request, options);
        }


        /// <summary>
        /// Lists the templates, if any, that are associated with a connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds one or more tags to your resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds one or more tags to your resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from your resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes one or more tags from your resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTemplate


        /// <summary>
        /// Update template configuration to define the information included in certificates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        public virtual UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateTemplateResponse>(request, options);
        }


        /// <summary>
        /// Update template configuration to define the information included in certificates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        public virtual Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTemplateGroupAccessControlEntry


        /// <summary>
        /// Update a group access control entry you created using <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateTemplateGroupAccessControlEntry.html">CreateTemplateGroupAccessControlEntry</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateGroupAccessControlEntry service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplateGroupAccessControlEntry service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UpdateTemplateGroupAccessControlEntry">REST API Reference for UpdateTemplateGroupAccessControlEntry Operation</seealso>
        public virtual UpdateTemplateGroupAccessControlEntryResponse UpdateTemplateGroupAccessControlEntry(UpdateTemplateGroupAccessControlEntryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTemplateGroupAccessControlEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateGroupAccessControlEntryResponseUnmarshaller.Instance;

            return Invoke<UpdateTemplateGroupAccessControlEntryResponse>(request, options);
        }


        /// <summary>
        /// Update a group access control entry you created using <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateTemplateGroupAccessControlEntry.html">CreateTemplateGroupAccessControlEntry</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateGroupAccessControlEntry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTemplateGroupAccessControlEntry service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UpdateTemplateGroupAccessControlEntry">REST API Reference for UpdateTemplateGroupAccessControlEntry Operation</seealso>
        public virtual Task<UpdateTemplateGroupAccessControlEntryResponse> UpdateTemplateGroupAccessControlEntryAsync(UpdateTemplateGroupAccessControlEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTemplateGroupAccessControlEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateGroupAccessControlEntryResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateTemplateGroupAccessControlEntryResponse>(request, options, cancellationToken);
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
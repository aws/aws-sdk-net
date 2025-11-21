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
 * Do not modify this file. This file is generated from the ssm-quicksetup-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SSMQuickSetup.Model;
using Amazon.SSMQuickSetup.Model.Internal.MarshallTransformations;
using Amazon.SSMQuickSetup.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.SSMQuickSetup
{
    /// <summary>
    /// <para>Implementation for accessing SSMQuickSetup</para>
    ///
    /// Quick Setup helps you quickly configure frequently used services and features with
    /// recommended best practices. Quick Setup simplifies setting up services, including
    /// Systems Manager, by automating common or recommended tasks.
    /// </summary>
    public partial class AmazonSSMQuickSetupClient : AmazonServiceClient, IAmazonSSMQuickSetup
    {
        private static IServiceMetadata serviceMetadata = new AmazonSSMQuickSetupMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with the credentials loaded from the application's
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
        public AmazonSSMQuickSetupClient()
            : base(new AmazonSSMQuickSetupConfig()) { }

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with the credentials loaded from the application's
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
        public AmazonSSMQuickSetupClient(RegionEndpoint region)
            : base(new AmazonSSMQuickSetupConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSSMQuickSetupClient Configuration Object</param>
        public AmazonSSMQuickSetupClient(AmazonSSMQuickSetupConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSSMQuickSetupClient(AWSCredentials credentials)
            : this(credentials, new AmazonSSMQuickSetupConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSMQuickSetupClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSSMQuickSetupConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with AWS Credentials and an
        /// AmazonSSMQuickSetupClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSSMQuickSetupClient Configuration Object</param>
        public AmazonSSMQuickSetupClient(AWSCredentials credentials, AmazonSSMQuickSetupConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSSMQuickSetupClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSSMQuickSetupConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSMQuickSetupClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSSMQuickSetupConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSSMQuickSetupClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSSMQuickSetupClient Configuration Object</param>
        public AmazonSSMQuickSetupClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSSMQuickSetupConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSSMQuickSetupClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSSMQuickSetupConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSMQuickSetupClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSSMQuickSetupConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSMQuickSetupClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSSMQuickSetupClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSSMQuickSetupClient Configuration Object</param>
        public AmazonSSMQuickSetupClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSSMQuickSetupConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ISSMQuickSetupPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISSMQuickSetupPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SSMQuickSetupPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSSMQuickSetupEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSSMQuickSetupAuthSchemeHandler());
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


        #region  CreateConfigurationManager

        internal virtual CreateConfigurationManagerResponse CreateConfigurationManager(CreateConfigurationManagerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfigurationManagerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationManagerResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationManagerResponse>(request, options);
        }



        /// <summary>
        /// Creates a Quick Setup configuration manager resource. This object is a collection
        /// of desired state configurations for multiple configuration definitions and summaries
        /// describing the deployments of those definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationManager service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfigurationManager service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/CreateConfigurationManager">REST API Reference for CreateConfigurationManager Operation</seealso>
        public virtual Task<CreateConfigurationManagerResponse> CreateConfigurationManagerAsync(CreateConfigurationManagerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfigurationManagerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationManagerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationManagerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteConfigurationManager

        internal virtual DeleteConfigurationManagerResponse DeleteConfigurationManager(DeleteConfigurationManagerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationManagerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationManagerResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationManagerResponse>(request, options);
        }



        /// <summary>
        /// Deletes a configuration manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationManager service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfigurationManager service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/DeleteConfigurationManager">REST API Reference for DeleteConfigurationManager Operation</seealso>
        public virtual Task<DeleteConfigurationManagerResponse> DeleteConfigurationManagerAsync(DeleteConfigurationManagerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationManagerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationManagerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationManagerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConfiguration

        internal virtual GetConfigurationResponse GetConfiguration(GetConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Returns details about the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfiguration service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        public virtual Task<GetConfigurationResponse> GetConfigurationAsync(GetConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConfigurationManager

        internal virtual GetConfigurationManagerResponse GetConfigurationManager(GetConfigurationManagerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationManagerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationManagerResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationManagerResponse>(request, options);
        }



        /// <summary>
        /// Returns a configuration manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationManager service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfigurationManager service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetConfigurationManager">REST API Reference for GetConfigurationManager Operation</seealso>
        public virtual Task<GetConfigurationManagerResponse> GetConfigurationManagerAsync(GetConfigurationManagerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationManagerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationManagerResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfigurationManagerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetServiceSettings

        internal virtual GetServiceSettingsResponse GetServiceSettings(GetServiceSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceSettingsResponseUnmarshaller.Instance;

            return Invoke<GetServiceSettingsResponse>(request, options);
        }



        /// <summary>
        /// Returns settings configured for Quick Setup in the requesting Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceSettings service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        public virtual Task<GetServiceSettingsResponse> GetServiceSettingsAsync(GetServiceSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListConfigurationManagers

        internal virtual ListConfigurationManagersResponse ListConfigurationManagers(ListConfigurationManagersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationManagersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationManagersResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationManagersResponse>(request, options);
        }



        /// <summary>
        /// Returns Quick Setup configuration managers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationManagers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigurationManagers service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListConfigurationManagers">REST API Reference for ListConfigurationManagers Operation</seealso>
        public virtual Task<ListConfigurationManagersResponse> ListConfigurationManagersAsync(ListConfigurationManagersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationManagersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationManagersResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigurationManagersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListConfigurations

        internal virtual ListConfigurationsResponse ListConfigurations(ListConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Returns configurations deployed by Quick Setup in the requesting Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigurations service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        public virtual Task<ListConfigurationsResponse> ListConfigurationsAsync(ListConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigurationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListQuickSetupTypes

        internal virtual ListQuickSetupTypesResponse ListQuickSetupTypes(ListQuickSetupTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQuickSetupTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQuickSetupTypesResponseUnmarshaller.Instance;

            return Invoke<ListQuickSetupTypesResponse>(request, options);
        }



        /// <summary>
        /// Returns the available Quick Setup types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQuickSetupTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQuickSetupTypes service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListQuickSetupTypes">REST API Reference for ListQuickSetupTypes Operation</seealso>
        public virtual Task<ListQuickSetupTypesResponse> ListQuickSetupTypesAsync(ListQuickSetupTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQuickSetupTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQuickSetupTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListQuickSetupTypesResponse>(request, options, cancellationToken);
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
        /// Returns tags assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// Assigns key-value pairs of metadata to Amazon Web Services resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateConfigurationDefinition

        internal virtual UpdateConfigurationDefinitionResponse UpdateConfigurationDefinition(UpdateConfigurationDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Updates a Quick Setup configuration definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfigurationDefinition service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateConfigurationDefinition">REST API Reference for UpdateConfigurationDefinition Operation</seealso>
        public virtual Task<UpdateConfigurationDefinitionResponse> UpdateConfigurationDefinitionAsync(UpdateConfigurationDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigurationDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateConfigurationManager

        internal virtual UpdateConfigurationManagerResponse UpdateConfigurationManager(UpdateConfigurationManagerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationManagerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationManagerResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationManagerResponse>(request, options);
        }



        /// <summary>
        /// Updates a Quick Setup configuration manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationManager service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfigurationManager service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateConfigurationManager">REST API Reference for UpdateConfigurationManager Operation</seealso>
        public virtual Task<UpdateConfigurationManagerResponse> UpdateConfigurationManagerAsync(UpdateConfigurationManagerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationManagerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationManagerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigurationManagerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateServiceSettings

        internal virtual UpdateServiceSettingsResponse UpdateServiceSettings(UpdateServiceSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateServiceSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceSettingsResponse>(request, options);
        }



        /// <summary>
        /// Updates settings configured for Quick Setup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServiceSettings service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        public virtual Task<UpdateServiceSettingsResponse> UpdateServiceSettingsAsync(UpdateServiceSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateServiceSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServiceSettingsResponse>(request, options, cancellationToken);
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
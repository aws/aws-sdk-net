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
 * Do not modify this file. This file is generated from the migrationhub-config-2019-06-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MigrationHubConfig.Model;
using Amazon.MigrationHubConfig.Model.Internal.MarshallTransformations;
using Amazon.MigrationHubConfig.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.MigrationHubConfig
{
    /// <summary>
    /// <para>Implementation for accessing MigrationHubConfig</para>
    ///
    /// The AWS Migration Hub home region APIs are available specifically for working with
    /// your Migration Hub home region. You can use these APIs to determine a home region,
    /// as well as to create and work with controls that describe the home region.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// You must make API calls for write actions (create, notify, associate, disassociate,
    /// import, or put) while in your home region, or a <c>HomeRegionNotSetException</c> error
    /// is returned.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// API calls for read actions (list, describe, stop, and delete) are permitted outside
    /// of your home region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you call a write API outside the home region, an <c>InvalidInputException</c> is
    /// returned.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can call <c>GetHomeRegion</c> action to obtain the account's Migration Hub home
    /// region.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For specific API usage, see the sections that follow in this AWS Migration Hub Home
    /// Region API reference. 
    /// </para>
    /// </summary>
    public partial class AmazonMigrationHubConfigClient : AmazonServiceClient, IAmazonMigrationHubConfig
    {
        private static IServiceMetadata serviceMetadata = new AmazonMigrationHubConfigMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonMigrationHubConfigClient with the credentials loaded from the application's
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
        public AmazonMigrationHubConfigClient()
            : base(new AmazonMigrationHubConfigConfig()) { }

        /// <summary>
        /// Constructs AmazonMigrationHubConfigClient with the credentials loaded from the application's
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
        public AmazonMigrationHubConfigClient(RegionEndpoint region)
            : base(new AmazonMigrationHubConfigConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMigrationHubConfigClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMigrationHubConfigClient Configuration Object</param>
        public AmazonMigrationHubConfigClient(AmazonMigrationHubConfigConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonMigrationHubConfigClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMigrationHubConfigClient(AWSCredentials credentials)
            : this(credentials, new AmazonMigrationHubConfigConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubConfigClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMigrationHubConfigClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMigrationHubConfigConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubConfigClient with AWS Credentials and an
        /// AmazonMigrationHubConfigClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMigrationHubConfigClient Configuration Object</param>
        public AmazonMigrationHubConfigClient(AWSCredentials credentials, AmazonMigrationHubConfigConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubConfigClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMigrationHubConfigClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMigrationHubConfigConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubConfigClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMigrationHubConfigClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMigrationHubConfigConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubConfigClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMigrationHubConfigClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMigrationHubConfigClient Configuration Object</param>
        public AmazonMigrationHubConfigClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMigrationHubConfigConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubConfigClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMigrationHubConfigClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMigrationHubConfigConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubConfigClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMigrationHubConfigClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMigrationHubConfigConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubConfigClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMigrationHubConfigClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMigrationHubConfigClient Configuration Object</param>
        public AmazonMigrationHubConfigClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMigrationHubConfigConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IMigrationHubConfigPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMigrationHubConfigPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MigrationHubConfigPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMigrationHubConfigEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMigrationHubConfigAuthSchemeHandler());
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


        #region  CreateHomeRegionControl

        internal virtual CreateHomeRegionControlResponse CreateHomeRegionControl(CreateHomeRegionControlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateHomeRegionControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHomeRegionControlResponseUnmarshaller.Instance;

            return Invoke<CreateHomeRegionControlResponse>(request, options);
        }



        /// <summary>
        /// This API sets up the home region for the calling account only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHomeRegionControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHomeRegionControl service method, as returned by MigrationHubConfig.</returns>
        /// <exception cref="Amazon.MigrationHubConfig.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.DryRunOperationException">
        /// Exception raised to indicate that authorization of an action was successful, when
        /// the <c>DryRun</c> flag is set to true.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ServiceUnavailableException">
        /// Exception raised when a request fails due to temporary unavailability of the service.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhub-config-2019-06-30/CreateHomeRegionControl">REST API Reference for CreateHomeRegionControl Operation</seealso>
        public virtual Task<CreateHomeRegionControlResponse> CreateHomeRegionControlAsync(CreateHomeRegionControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateHomeRegionControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHomeRegionControlResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHomeRegionControlResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteHomeRegionControl

        internal virtual DeleteHomeRegionControlResponse DeleteHomeRegionControl(DeleteHomeRegionControlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteHomeRegionControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHomeRegionControlResponseUnmarshaller.Instance;

            return Invoke<DeleteHomeRegionControlResponse>(request, options);
        }



        /// <summary>
        /// This operation deletes the home region configuration for the calling account. The
        /// operation does not delete discovery or migration tracking data in the home region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHomeRegionControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHomeRegionControl service method, as returned by MigrationHubConfig.</returns>
        /// <exception cref="Amazon.MigrationHubConfig.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ServiceUnavailableException">
        /// Exception raised when a request fails due to temporary unavailability of the service.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhub-config-2019-06-30/DeleteHomeRegionControl">REST API Reference for DeleteHomeRegionControl Operation</seealso>
        public virtual Task<DeleteHomeRegionControlResponse> DeleteHomeRegionControlAsync(DeleteHomeRegionControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteHomeRegionControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHomeRegionControlResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHomeRegionControlResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeHomeRegionControls

        internal virtual DescribeHomeRegionControlsResponse DescribeHomeRegionControls(DescribeHomeRegionControlsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeHomeRegionControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHomeRegionControlsResponseUnmarshaller.Instance;

            return Invoke<DescribeHomeRegionControlsResponse>(request, options);
        }



        /// <summary>
        /// This API permits filtering on the <c>ControlId</c> and <c>HomeRegion</c> fields.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHomeRegionControls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHomeRegionControls service method, as returned by MigrationHubConfig.</returns>
        /// <exception cref="Amazon.MigrationHubConfig.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ServiceUnavailableException">
        /// Exception raised when a request fails due to temporary unavailability of the service.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhub-config-2019-06-30/DescribeHomeRegionControls">REST API Reference for DescribeHomeRegionControls Operation</seealso>
        public virtual Task<DescribeHomeRegionControlsResponse> DescribeHomeRegionControlsAsync(DescribeHomeRegionControlsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeHomeRegionControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHomeRegionControlsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHomeRegionControlsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetHomeRegion

        internal virtual GetHomeRegionResponse GetHomeRegion(GetHomeRegionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetHomeRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHomeRegionResponseUnmarshaller.Instance;

            return Invoke<GetHomeRegionResponse>(request, options);
        }



        /// <summary>
        /// Returns the calling account’s home region, if configured. This API is used by other
        /// AWS services to determine the regional endpoint for calling AWS Application Discovery
        /// Service and Migration Hub. You must call <c>GetHomeRegion</c> at least once before
        /// you call any other AWS Application Discovery Service and AWS Migration Hub APIs, to
        /// obtain the account's Migration Hub home region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHomeRegion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHomeRegion service method, as returned by MigrationHubConfig.</returns>
        /// <exception cref="Amazon.MigrationHubConfig.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ServiceUnavailableException">
        /// Exception raised when a request fails due to temporary unavailability of the service.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubConfig.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhub-config-2019-06-30/GetHomeRegion">REST API Reference for GetHomeRegion Operation</seealso>
        public virtual Task<GetHomeRegionResponse> GetHomeRegionAsync(GetHomeRegionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetHomeRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHomeRegionResponseUnmarshaller.Instance;

            return InvokeAsync<GetHomeRegionResponse>(request, options, cancellationToken);
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
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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AppRunner.Model;
using Amazon.AppRunner.Model.Internal.MarshallTransformations;
using Amazon.AppRunner.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.AppRunner
{
    /// <summary>
    /// <para>Implementation for accessing AppRunner</para>
    ///
    /// App Runner 
    /// <para>
    /// App Runner is an application service that provides a fast, simple, and cost-effective
    /// way to go directly from an existing container image or source code to a running service
    /// in the Amazon Web Services Cloud in seconds. You don't need to learn new technologies,
    /// decide which compute service to use, or understand how to provision and configure
    /// Amazon Web Services resources.
    /// </para>
    ///  
    /// <para>
    /// App Runner connects directly to your container registry or source code repository.
    /// It provides an automatic delivery pipeline with fully managed operations, high performance,
    /// scalability, and security.
    /// </para>
    ///  
    /// <para>
    /// For more information about App Runner, see the <a href="https://docs.aws.amazon.com/apprunner/latest/dg/">App
    /// Runner Developer Guide</a>. For release information, see the <a href="https://docs.aws.amazon.com/apprunner/latest/relnotes/">App
    /// Runner Release Notes</a>.
    /// </para>
    ///  
    /// <para>
    ///  To install the Software Development Kits (SDKs), Integrated Development Environment
    /// (IDE) Toolkits, and command line tools that you can use to access the API, see <a
    /// href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Endpoints</b> 
    /// </para>
    ///  
    /// <para>
    /// For a list of Region-specific endpoints that App Runner supports, see <a href="https://docs.aws.amazon.com/general/latest/gr/apprunner.html">App
    /// Runner endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
    /// </para>
    /// </summary>
    public partial class AmazonAppRunnerClient : AmazonServiceClient, IAmazonAppRunner
    {
        private static IServiceMetadata serviceMetadata = new AmazonAppRunnerMetadata();
        private IAppRunnerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAppRunnerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AppRunnerPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonAppRunnerClient with the credentials loaded from the application's
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
        public AmazonAppRunnerClient()
            : base(new AmazonAppRunnerConfig()) { }

        /// <summary>
        /// Constructs AmazonAppRunnerClient with the credentials loaded from the application's
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
        public AmazonAppRunnerClient(RegionEndpoint region)
            : base(new AmazonAppRunnerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAppRunnerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAppRunnerClient Configuration Object</param>
        public AmazonAppRunnerClient(AmazonAppRunnerConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonAppRunnerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAppRunnerClient(AWSCredentials credentials)
            : this(credentials, new AmazonAppRunnerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppRunnerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppRunnerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAppRunnerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppRunnerClient with AWS Credentials and an
        /// AmazonAppRunnerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAppRunnerClient Configuration Object</param>
        public AmazonAppRunnerClient(AWSCredentials credentials, AmazonAppRunnerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppRunnerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAppRunnerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppRunnerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppRunnerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppRunnerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppRunnerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppRunnerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppRunnerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAppRunnerClient Configuration Object</param>
        public AmazonAppRunnerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAppRunnerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppRunnerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAppRunnerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppRunnerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppRunnerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppRunnerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppRunnerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppRunnerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppRunnerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAppRunnerClient Configuration Object</param>
        public AmazonAppRunnerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAppRunnerConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAppRunnerEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAppRunnerAuthSchemeHandler());
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


        #region  AssociateCustomDomain


        /// <summary>
        /// Associate your own domain name with the App Runner subdomain URL of your App Runner
        /// service.
        /// 
        ///  
        /// <para>
        /// After you call <c>AssociateCustomDomain</c> and receive a successful response, use
        /// the information in the <a>CustomDomain</a> record that's returned to add CNAME records
        /// to your Domain Name System (DNS). For each mapped domain name, add a mapping to the
        /// target App Runner subdomain and one or more certificate validation records. App Runner
        /// then performs DNS validation to verify that you own or control the domain name that
        /// you associated. App Runner tracks domain validity in a certificate stored in <a href="https://docs.aws.amazon.com/acm/latest/userguide">AWS
        /// Certificate Manager (ACM)</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateCustomDomain service method.</param>
        /// 
        /// <returns>The response from the AssociateCustomDomain service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/AssociateCustomDomain">REST API Reference for AssociateCustomDomain Operation</seealso>
        public virtual AssociateCustomDomainResponse AssociateCustomDomain(AssociateCustomDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateCustomDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateCustomDomainResponseUnmarshaller.Instance;

            return Invoke<AssociateCustomDomainResponse>(request, options);
        }


        /// <summary>
        /// Associate your own domain name with the App Runner subdomain URL of your App Runner
        /// service.
        /// 
        ///  
        /// <para>
        /// After you call <c>AssociateCustomDomain</c> and receive a successful response, use
        /// the information in the <a>CustomDomain</a> record that's returned to add CNAME records
        /// to your Domain Name System (DNS). For each mapped domain name, add a mapping to the
        /// target App Runner subdomain and one or more certificate validation records. App Runner
        /// then performs DNS validation to verify that you own or control the domain name that
        /// you associated. App Runner tracks domain validity in a certificate stored in <a href="https://docs.aws.amazon.com/acm/latest/userguide">AWS
        /// Certificate Manager (ACM)</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateCustomDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateCustomDomain service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/AssociateCustomDomain">REST API Reference for AssociateCustomDomain Operation</seealso>
        public virtual Task<AssociateCustomDomainResponse> AssociateCustomDomainAsync(AssociateCustomDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateCustomDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateCustomDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateCustomDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAutoScalingConfiguration


        /// <summary>
        /// Create an App Runner automatic scaling configuration resource. App Runner requires
        /// this resource when you create or update App Runner services and you require non-default
        /// auto scaling settings. You can share an auto scaling configuration across multiple
        /// services.
        /// 
        ///  
        /// <para>
        /// Create multiple revisions of a configuration by calling this action multiple times
        /// using the same <c>AutoScalingConfigurationName</c>. The call returns incremental <c>AutoScalingConfigurationRevision</c>
        /// values. When you create a service and configure an auto scaling configuration resource,
        /// the service uses the latest active revision of the auto scaling configuration by default.
        /// You can optionally configure the service to use a specific revision.
        /// </para>
        ///  
        /// <para>
        /// Configure a higher <c>MinSize</c> to increase the spread of your App Runner service
        /// over more Availability Zones in the Amazon Web Services Region. The tradeoff is a
        /// higher minimal cost.
        /// </para>
        ///  
        /// <para>
        /// Configure a lower <c>MaxSize</c> to control your cost. The tradeoff is lower responsiveness
        /// during peak demand.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoScalingConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateAutoScalingConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ServiceQuotaExceededException">
        /// App Runner can't create this resource. You've reached your account quota for this
        /// resource type.
        /// 
        ///  
        /// <para>
        /// For App Runner per-resource quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/apprunner.html">App
        /// Runner endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateAutoScalingConfiguration">REST API Reference for CreateAutoScalingConfiguration Operation</seealso>
        public virtual CreateAutoScalingConfigurationResponse CreateAutoScalingConfiguration(CreateAutoScalingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutoScalingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutoScalingConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateAutoScalingConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Create an App Runner automatic scaling configuration resource. App Runner requires
        /// this resource when you create or update App Runner services and you require non-default
        /// auto scaling settings. You can share an auto scaling configuration across multiple
        /// services.
        /// 
        ///  
        /// <para>
        /// Create multiple revisions of a configuration by calling this action multiple times
        /// using the same <c>AutoScalingConfigurationName</c>. The call returns incremental <c>AutoScalingConfigurationRevision</c>
        /// values. When you create a service and configure an auto scaling configuration resource,
        /// the service uses the latest active revision of the auto scaling configuration by default.
        /// You can optionally configure the service to use a specific revision.
        /// </para>
        ///  
        /// <para>
        /// Configure a higher <c>MinSize</c> to increase the spread of your App Runner service
        /// over more Availability Zones in the Amazon Web Services Region. The tradeoff is a
        /// higher minimal cost.
        /// </para>
        ///  
        /// <para>
        /// Configure a lower <c>MaxSize</c> to control your cost. The tradeoff is lower responsiveness
        /// during peak demand.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoScalingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAutoScalingConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ServiceQuotaExceededException">
        /// App Runner can't create this resource. You've reached your account quota for this
        /// resource type.
        /// 
        ///  
        /// <para>
        /// For App Runner per-resource quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/apprunner.html">App
        /// Runner endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateAutoScalingConfiguration">REST API Reference for CreateAutoScalingConfiguration Operation</seealso>
        public virtual Task<CreateAutoScalingConfigurationResponse> CreateAutoScalingConfigurationAsync(CreateAutoScalingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutoScalingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutoScalingConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAutoScalingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConnection


        /// <summary>
        /// Create an App Runner connection resource. App Runner requires a connection resource
        /// when you create App Runner services that access private repositories from certain
        /// third-party providers. You can share a connection across multiple services.
        /// 
        ///  
        /// <para>
        /// A connection resource is needed to access GitHub and Bitbucket repositories. Both
        /// require a user interface approval process through the App Runner console before you
        /// can use the connection.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ServiceQuotaExceededException">
        /// App Runner can't create this resource. You've reached your account quota for this
        /// resource type.
        /// 
        ///  
        /// <para>
        /// For App Runner per-resource quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/apprunner.html">App
        /// Runner endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual CreateConnectionResponse CreateConnection(CreateConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateConnectionResponse>(request, options);
        }


        /// <summary>
        /// Create an App Runner connection resource. App Runner requires a connection resource
        /// when you create App Runner services that access private repositories from certain
        /// third-party providers. You can share a connection across multiple services.
        /// 
        ///  
        /// <para>
        /// A connection resource is needed to access GitHub and Bitbucket repositories. Both
        /// require a user interface approval process through the App Runner console before you
        /// can use the connection.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ServiceQuotaExceededException">
        /// App Runner can't create this resource. You've reached your account quota for this
        /// resource type.
        /// 
        ///  
        /// <para>
        /// For App Runner per-resource quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/apprunner.html">App
        /// Runner endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateObservabilityConfiguration


        /// <summary>
        /// Create an App Runner observability configuration resource. App Runner requires this
        /// resource when you create or update App Runner services and you want to enable non-default
        /// observability features. You can share an observability configuration across multiple
        /// services.
        /// 
        ///  
        /// <para>
        /// Create multiple revisions of a configuration by calling this action multiple times
        /// using the same <c>ObservabilityConfigurationName</c>. The call returns incremental
        /// <c>ObservabilityConfigurationRevision</c> values. When you create a service and configure
        /// an observability configuration resource, the service uses the latest active revision
        /// of the observability configuration by default. You can optionally configure the service
        /// to use a specific revision.
        /// </para>
        ///  
        /// <para>
        /// The observability configuration resource is designed to configure multiple features
        /// (currently one feature, tracing). This action takes optional parameters that describe
        /// the configuration of these features (currently one parameter, <c>TraceConfiguration</c>).
        /// If you don't specify a feature parameter, App Runner doesn't enable the feature.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateObservabilityConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateObservabilityConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ServiceQuotaExceededException">
        /// App Runner can't create this resource. You've reached your account quota for this
        /// resource type.
        /// 
        ///  
        /// <para>
        /// For App Runner per-resource quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/apprunner.html">App
        /// Runner endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateObservabilityConfiguration">REST API Reference for CreateObservabilityConfiguration Operation</seealso>
        public virtual CreateObservabilityConfigurationResponse CreateObservabilityConfiguration(CreateObservabilityConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateObservabilityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateObservabilityConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateObservabilityConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Create an App Runner observability configuration resource. App Runner requires this
        /// resource when you create or update App Runner services and you want to enable non-default
        /// observability features. You can share an observability configuration across multiple
        /// services.
        /// 
        ///  
        /// <para>
        /// Create multiple revisions of a configuration by calling this action multiple times
        /// using the same <c>ObservabilityConfigurationName</c>. The call returns incremental
        /// <c>ObservabilityConfigurationRevision</c> values. When you create a service and configure
        /// an observability configuration resource, the service uses the latest active revision
        /// of the observability configuration by default. You can optionally configure the service
        /// to use a specific revision.
        /// </para>
        ///  
        /// <para>
        /// The observability configuration resource is designed to configure multiple features
        /// (currently one feature, tracing). This action takes optional parameters that describe
        /// the configuration of these features (currently one parameter, <c>TraceConfiguration</c>).
        /// If you don't specify a feature parameter, App Runner doesn't enable the feature.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateObservabilityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateObservabilityConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ServiceQuotaExceededException">
        /// App Runner can't create this resource. You've reached your account quota for this
        /// resource type.
        /// 
        ///  
        /// <para>
        /// For App Runner per-resource quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/apprunner.html">App
        /// Runner endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateObservabilityConfiguration">REST API Reference for CreateObservabilityConfiguration Operation</seealso>
        public virtual Task<CreateObservabilityConfigurationResponse> CreateObservabilityConfigurationAsync(CreateObservabilityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateObservabilityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateObservabilityConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateObservabilityConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateService


        /// <summary>
        /// Create an App Runner service. After the service is created, the action also automatically
        /// starts a deployment.
        /// 
        ///  
        /// <para>
        /// This is an asynchronous operation. On a successful call, you can use the returned
        /// <c>OperationId</c> and the <a href="https://docs.aws.amazon.com/apprunner/latest/api/API_ListOperations.html">ListOperations</a>
        /// call to track the operation's progress.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// 
        /// <returns>The response from the CreateService service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ServiceQuotaExceededException">
        /// App Runner can't create this resource. You've reached your account quota for this
        /// resource type.
        /// 
        ///  
        /// <para>
        /// For App Runner per-resource quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/apprunner.html">App
        /// Runner endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateService">REST API Reference for CreateService Operation</seealso>
        public virtual CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceResponseUnmarshaller.Instance;

            return Invoke<CreateServiceResponse>(request, options);
        }


        /// <summary>
        /// Create an App Runner service. After the service is created, the action also automatically
        /// starts a deployment.
        /// 
        ///  
        /// <para>
        /// This is an asynchronous operation. On a successful call, you can use the returned
        /// <c>OperationId</c> and the <a href="https://docs.aws.amazon.com/apprunner/latest/api/API_ListOperations.html">ListOperations</a>
        /// call to track the operation's progress.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateService service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ServiceQuotaExceededException">
        /// App Runner can't create this resource. You've reached your account quota for this
        /// resource type.
        /// 
        ///  
        /// <para>
        /// For App Runner per-resource quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/apprunner.html">App
        /// Runner endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateService">REST API Reference for CreateService Operation</seealso>
        public virtual Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcConnector


        /// <summary>
        /// Create an App Runner VPC connector resource. App Runner requires this resource when
        /// you want to associate your App Runner service to a custom Amazon Virtual Private Cloud
        /// (Amazon VPC).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcConnector service method.</param>
        /// 
        /// <returns>The response from the CreateVpcConnector service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ServiceQuotaExceededException">
        /// App Runner can't create this resource. You've reached your account quota for this
        /// resource type.
        /// 
        ///  
        /// <para>
        /// For App Runner per-resource quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/apprunner.html">App
        /// Runner endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateVpcConnector">REST API Reference for CreateVpcConnector Operation</seealso>
        public virtual CreateVpcConnectorResponse CreateVpcConnector(CreateVpcConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcConnectorResponseUnmarshaller.Instance;

            return Invoke<CreateVpcConnectorResponse>(request, options);
        }


        /// <summary>
        /// Create an App Runner VPC connector resource. App Runner requires this resource when
        /// you want to associate your App Runner service to a custom Amazon Virtual Private Cloud
        /// (Amazon VPC).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpcConnector service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ServiceQuotaExceededException">
        /// App Runner can't create this resource. You've reached your account quota for this
        /// resource type.
        /// 
        ///  
        /// <para>
        /// For App Runner per-resource quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/apprunner.html">App
        /// Runner endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateVpcConnector">REST API Reference for CreateVpcConnector Operation</seealso>
        public virtual Task<CreateVpcConnectorResponse> CreateVpcConnectorAsync(CreateVpcConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcConnectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateVpcConnectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcIngressConnection


        /// <summary>
        /// Create an App Runner VPC Ingress Connection resource. App Runner requires this resource
        /// when you want to associate your App Runner service with an Amazon VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcIngressConnection service method.</param>
        /// 
        /// <returns>The response from the CreateVpcIngressConnection service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ServiceQuotaExceededException">
        /// App Runner can't create this resource. You've reached your account quota for this
        /// resource type.
        /// 
        ///  
        /// <para>
        /// For App Runner per-resource quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/apprunner.html">App
        /// Runner endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateVpcIngressConnection">REST API Reference for CreateVpcIngressConnection Operation</seealso>
        public virtual CreateVpcIngressConnectionResponse CreateVpcIngressConnection(CreateVpcIngressConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcIngressConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcIngressConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateVpcIngressConnectionResponse>(request, options);
        }


        /// <summary>
        /// Create an App Runner VPC Ingress Connection resource. App Runner requires this resource
        /// when you want to associate your App Runner service with an Amazon VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcIngressConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpcIngressConnection service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ServiceQuotaExceededException">
        /// App Runner can't create this resource. You've reached your account quota for this
        /// resource type.
        /// 
        ///  
        /// <para>
        /// For App Runner per-resource quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/apprunner.html">App
        /// Runner endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/CreateVpcIngressConnection">REST API Reference for CreateVpcIngressConnection Operation</seealso>
        public virtual Task<CreateVpcIngressConnectionResponse> CreateVpcIngressConnectionAsync(CreateVpcIngressConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcIngressConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcIngressConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateVpcIngressConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAutoScalingConfiguration


        /// <summary>
        /// Delete an App Runner automatic scaling configuration resource. You can delete a top
        /// level auto scaling configuration, a specific revision of one, or all revisions associated
        /// with the top level configuration. You can't delete the default auto scaling configuration
        /// or a configuration that's used by one or more App Runner services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoScalingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteAutoScalingConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteAutoScalingConfiguration">REST API Reference for DeleteAutoScalingConfiguration Operation</seealso>
        public virtual DeleteAutoScalingConfigurationResponse DeleteAutoScalingConfiguration(DeleteAutoScalingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutoScalingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutoScalingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteAutoScalingConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Delete an App Runner automatic scaling configuration resource. You can delete a top
        /// level auto scaling configuration, a specific revision of one, or all revisions associated
        /// with the top level configuration. You can't delete the default auto scaling configuration
        /// or a configuration that's used by one or more App Runner services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoScalingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAutoScalingConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteAutoScalingConfiguration">REST API Reference for DeleteAutoScalingConfiguration Operation</seealso>
        public virtual Task<DeleteAutoScalingConfigurationResponse> DeleteAutoScalingConfigurationAsync(DeleteAutoScalingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutoScalingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutoScalingConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAutoScalingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConnection


        /// <summary>
        /// Delete an App Runner connection. You must first ensure that there are no running App
        /// Runner services that use this connection. If there are any, the <c>DeleteConnection</c>
        /// action fails.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectionResponse>(request, options);
        }


        /// <summary>
        /// Delete an App Runner connection. You must first ensure that there are no running App
        /// Runner services that use this connection. If there are any, the <c>DeleteConnection</c>
        /// action fails.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteObservabilityConfiguration


        /// <summary>
        /// Delete an App Runner observability configuration resource. You can delete a specific
        /// revision or the latest active revision. You can't delete a configuration that's used
        /// by one or more App Runner services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObservabilityConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteObservabilityConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteObservabilityConfiguration">REST API Reference for DeleteObservabilityConfiguration Operation</seealso>
        public virtual DeleteObservabilityConfigurationResponse DeleteObservabilityConfiguration(DeleteObservabilityConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteObservabilityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObservabilityConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteObservabilityConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Delete an App Runner observability configuration resource. You can delete a specific
        /// revision or the latest active revision. You can't delete a configuration that's used
        /// by one or more App Runner services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObservabilityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteObservabilityConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteObservabilityConfiguration">REST API Reference for DeleteObservabilityConfiguration Operation</seealso>
        public virtual Task<DeleteObservabilityConfigurationResponse> DeleteObservabilityConfigurationAsync(DeleteObservabilityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteObservabilityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObservabilityConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteObservabilityConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteService


        /// <summary>
        /// Delete an App Runner service.
        /// 
        ///  
        /// <para>
        /// This is an asynchronous operation. On a successful call, you can use the returned
        /// <c>OperationId</c> and the <a>ListOperations</a> call to track the operation's progress.
        /// </para>
        ///  <note> 
        /// <para>
        /// Make sure that you don't have any active VPCIngressConnections associated with the
        /// service you want to delete. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// 
        /// <returns>The response from the DeleteService service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteService">REST API Reference for DeleteService Operation</seealso>
        public virtual DeleteServiceResponse DeleteService(DeleteServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceResponse>(request, options);
        }


        /// <summary>
        /// Delete an App Runner service.
        /// 
        ///  
        /// <para>
        /// This is an asynchronous operation. On a successful call, you can use the returned
        /// <c>OperationId</c> and the <a>ListOperations</a> call to track the operation's progress.
        /// </para>
        ///  <note> 
        /// <para>
        /// Make sure that you don't have any active VPCIngressConnections associated with the
        /// service you want to delete. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteService service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteService">REST API Reference for DeleteService Operation</seealso>
        public virtual Task<DeleteServiceResponse> DeleteServiceAsync(DeleteServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcConnector


        /// <summary>
        /// Delete an App Runner VPC connector resource. You can't delete a connector that's used
        /// by one or more App Runner services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcConnector service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcConnector service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteVpcConnector">REST API Reference for DeleteVpcConnector Operation</seealso>
        public virtual DeleteVpcConnectorResponse DeleteVpcConnector(DeleteVpcConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcConnectorResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcConnectorResponse>(request, options);
        }


        /// <summary>
        /// Delete an App Runner VPC connector resource. You can't delete a connector that's used
        /// by one or more App Runner services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpcConnector service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteVpcConnector">REST API Reference for DeleteVpcConnector Operation</seealso>
        public virtual Task<DeleteVpcConnectorResponse> DeleteVpcConnectorAsync(DeleteVpcConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcConnectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteVpcConnectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcIngressConnection


        /// <summary>
        /// Delete an App Runner VPC Ingress Connection resource that's associated with an App
        /// Runner service. The VPC Ingress Connection must be in one of the following states
        /// to be deleted: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED_CREATION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED_UPDATE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED_DELETION</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcIngressConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcIngressConnection service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteVpcIngressConnection">REST API Reference for DeleteVpcIngressConnection Operation</seealso>
        public virtual DeleteVpcIngressConnectionResponse DeleteVpcIngressConnection(DeleteVpcIngressConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcIngressConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcIngressConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcIngressConnectionResponse>(request, options);
        }


        /// <summary>
        /// Delete an App Runner VPC Ingress Connection resource that's associated with an App
        /// Runner service. The VPC Ingress Connection must be in one of the following states
        /// to be deleted: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED_CREATION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED_UPDATE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED_DELETION</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcIngressConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpcIngressConnection service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DeleteVpcIngressConnection">REST API Reference for DeleteVpcIngressConnection Operation</seealso>
        public virtual Task<DeleteVpcIngressConnectionResponse> DeleteVpcIngressConnectionAsync(DeleteVpcIngressConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcIngressConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcIngressConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteVpcIngressConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAutoScalingConfiguration


        /// <summary>
        /// Return a full description of an App Runner automatic scaling configuration resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeAutoScalingConfiguration">REST API Reference for DescribeAutoScalingConfiguration Operation</seealso>
        public virtual DescribeAutoScalingConfigurationResponse DescribeAutoScalingConfiguration(DescribeAutoScalingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAutoScalingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoScalingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeAutoScalingConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Return a full description of an App Runner automatic scaling configuration resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutoScalingConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeAutoScalingConfiguration">REST API Reference for DescribeAutoScalingConfiguration Operation</seealso>
        public virtual Task<DescribeAutoScalingConfigurationResponse> DescribeAutoScalingConfigurationAsync(DescribeAutoScalingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAutoScalingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoScalingConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAutoScalingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCustomDomains


        /// <summary>
        /// Return a description of custom domain names that are associated with an App Runner
        /// service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomDomains service method.</param>
        /// 
        /// <returns>The response from the DescribeCustomDomains service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeCustomDomains">REST API Reference for DescribeCustomDomains Operation</seealso>
        public virtual DescribeCustomDomainsResponse DescribeCustomDomains(DescribeCustomDomainsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCustomDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomDomainsResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomDomainsResponse>(request, options);
        }


        /// <summary>
        /// Return a description of custom domain names that are associated with an App Runner
        /// service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomDomains service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeCustomDomains">REST API Reference for DescribeCustomDomains Operation</seealso>
        public virtual Task<DescribeCustomDomainsResponse> DescribeCustomDomainsAsync(DescribeCustomDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCustomDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomDomainsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeCustomDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeObservabilityConfiguration


        /// <summary>
        /// Return a full description of an App Runner observability configuration resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeObservabilityConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeObservabilityConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeObservabilityConfiguration">REST API Reference for DescribeObservabilityConfiguration Operation</seealso>
        public virtual DescribeObservabilityConfigurationResponse DescribeObservabilityConfiguration(DescribeObservabilityConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeObservabilityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeObservabilityConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeObservabilityConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Return a full description of an App Runner observability configuration resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeObservabilityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeObservabilityConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeObservabilityConfiguration">REST API Reference for DescribeObservabilityConfiguration Operation</seealso>
        public virtual Task<DescribeObservabilityConfigurationResponse> DescribeObservabilityConfigurationAsync(DescribeObservabilityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeObservabilityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeObservabilityConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeObservabilityConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeService


        /// <summary>
        /// Return a full description of an App Runner service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeService service method.</param>
        /// 
        /// <returns>The response from the DescribeService service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeService">REST API Reference for DescribeService Operation</seealso>
        public virtual DescribeServiceResponse DescribeService(DescribeServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceResponseUnmarshaller.Instance;

            return Invoke<DescribeServiceResponse>(request, options);
        }


        /// <summary>
        /// Return a full description of an App Runner service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeService service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeService">REST API Reference for DescribeService Operation</seealso>
        public virtual Task<DescribeServiceResponse> DescribeServiceAsync(DescribeServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcConnector


        /// <summary>
        /// Return a description of an App Runner VPC connector resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcConnector service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcConnector service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeVpcConnector">REST API Reference for DescribeVpcConnector Operation</seealso>
        public virtual DescribeVpcConnectorResponse DescribeVpcConnector(DescribeVpcConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVpcConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcConnectorResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcConnectorResponse>(request, options);
        }


        /// <summary>
        /// Return a description of an App Runner VPC connector resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcConnector service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeVpcConnector">REST API Reference for DescribeVpcConnector Operation</seealso>
        public virtual Task<DescribeVpcConnectorResponse> DescribeVpcConnectorAsync(DescribeVpcConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVpcConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcConnectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeVpcConnectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcIngressConnection


        /// <summary>
        /// Return a full description of an App Runner VPC Ingress Connection resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcIngressConnection service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcIngressConnection service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeVpcIngressConnection">REST API Reference for DescribeVpcIngressConnection Operation</seealso>
        public virtual DescribeVpcIngressConnectionResponse DescribeVpcIngressConnection(DescribeVpcIngressConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVpcIngressConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcIngressConnectionResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcIngressConnectionResponse>(request, options);
        }


        /// <summary>
        /// Return a full description of an App Runner VPC Ingress Connection resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcIngressConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcIngressConnection service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DescribeVpcIngressConnection">REST API Reference for DescribeVpcIngressConnection Operation</seealso>
        public virtual Task<DescribeVpcIngressConnectionResponse> DescribeVpcIngressConnectionAsync(DescribeVpcIngressConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVpcIngressConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcIngressConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeVpcIngressConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateCustomDomain


        /// <summary>
        /// Disassociate a custom domain name from an App Runner service.
        /// 
        ///  
        /// <para>
        /// Certificates tracking domain validity are associated with a custom domain and are
        /// stored in <a href="https://docs.aws.amazon.com/acm/latest/userguide">AWS Certificate
        /// Manager (ACM)</a>. These certificates aren't deleted as part of this action. App Runner
        /// delays certificate deletion for 30 days after a domain is disassociated from your
        /// service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCustomDomain service method.</param>
        /// 
        /// <returns>The response from the DisassociateCustomDomain service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DisassociateCustomDomain">REST API Reference for DisassociateCustomDomain Operation</seealso>
        public virtual DisassociateCustomDomainResponse DisassociateCustomDomain(DisassociateCustomDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateCustomDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateCustomDomainResponseUnmarshaller.Instance;

            return Invoke<DisassociateCustomDomainResponse>(request, options);
        }


        /// <summary>
        /// Disassociate a custom domain name from an App Runner service.
        /// 
        ///  
        /// <para>
        /// Certificates tracking domain validity are associated with a custom domain and are
        /// stored in <a href="https://docs.aws.amazon.com/acm/latest/userguide">AWS Certificate
        /// Manager (ACM)</a>. These certificates aren't deleted as part of this action. App Runner
        /// delays certificate deletion for 30 days after a domain is disassociated from your
        /// service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCustomDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateCustomDomain service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/DisassociateCustomDomain">REST API Reference for DisassociateCustomDomain Operation</seealso>
        public virtual Task<DisassociateCustomDomainResponse> DisassociateCustomDomainAsync(DisassociateCustomDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateCustomDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateCustomDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateCustomDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAutoScalingConfigurations


        /// <summary>
        /// Returns a list of active App Runner automatic scaling configurations in your Amazon
        /// Web Services account. You can query the revisions for a specific configuration name
        /// or the revisions for all active configurations in your account. You can optionally
        /// query only the latest revision of each requested name.
        /// 
        ///  
        /// <para>
        /// To retrieve a full description of a particular configuration revision, call and provide
        /// one of the ARNs returned by <c>ListAutoScalingConfigurations</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutoScalingConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListAutoScalingConfigurations service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListAutoScalingConfigurations">REST API Reference for ListAutoScalingConfigurations Operation</seealso>
        public virtual ListAutoScalingConfigurationsResponse ListAutoScalingConfigurations(ListAutoScalingConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutoScalingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutoScalingConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListAutoScalingConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of active App Runner automatic scaling configurations in your Amazon
        /// Web Services account. You can query the revisions for a specific configuration name
        /// or the revisions for all active configurations in your account. You can optionally
        /// query only the latest revision of each requested name.
        /// 
        ///  
        /// <para>
        /// To retrieve a full description of a particular configuration revision, call and provide
        /// one of the ARNs returned by <c>ListAutoScalingConfigurations</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutoScalingConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutoScalingConfigurations service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListAutoScalingConfigurations">REST API Reference for ListAutoScalingConfigurations Operation</seealso>
        public virtual Task<ListAutoScalingConfigurationsResponse> ListAutoScalingConfigurationsAsync(ListAutoScalingConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutoScalingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutoScalingConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAutoScalingConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConnections


        /// <summary>
        /// Returns a list of App Runner connections that are associated with your Amazon Web
        /// Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnections service method.</param>
        /// 
        /// <returns>The response from the ListConnections service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListConnections">REST API Reference for ListConnections Operation</seealso>
        public virtual ListConnectionsResponse ListConnections(ListConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListConnectionsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of App Runner connections that are associated with your Amazon Web
        /// Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnections service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListConnections">REST API Reference for ListConnections Operation</seealso>
        public virtual Task<ListConnectionsResponse> ListConnectionsAsync(ListConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListObservabilityConfigurations


        /// <summary>
        /// Returns a list of active App Runner observability configurations in your Amazon Web
        /// Services account. You can query the revisions for a specific configuration name or
        /// the revisions for all active configurations in your account. You can optionally query
        /// only the latest revision of each requested name.
        /// 
        ///  
        /// <para>
        /// To retrieve a full description of a particular configuration revision, call and provide
        /// one of the ARNs returned by <c>ListObservabilityConfigurations</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObservabilityConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListObservabilityConfigurations service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListObservabilityConfigurations">REST API Reference for ListObservabilityConfigurations Operation</seealso>
        public virtual ListObservabilityConfigurationsResponse ListObservabilityConfigurations(ListObservabilityConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObservabilityConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObservabilityConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListObservabilityConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of active App Runner observability configurations in your Amazon Web
        /// Services account. You can query the revisions for a specific configuration name or
        /// the revisions for all active configurations in your account. You can optionally query
        /// only the latest revision of each requested name.
        /// 
        ///  
        /// <para>
        /// To retrieve a full description of a particular configuration revision, call and provide
        /// one of the ARNs returned by <c>ListObservabilityConfigurations</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObservabilityConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListObservabilityConfigurations service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListObservabilityConfigurations">REST API Reference for ListObservabilityConfigurations Operation</seealso>
        public virtual Task<ListObservabilityConfigurationsResponse> ListObservabilityConfigurationsAsync(ListObservabilityConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObservabilityConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObservabilityConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListObservabilityConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOperations


        /// <summary>
        /// Return a list of operations that occurred on an App Runner service.
        /// 
        ///  
        /// <para>
        /// The resulting list of <a>OperationSummary</a> objects is sorted in reverse chronological
        /// order. The first object on the list represents the last started operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOperations service method.</param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual ListOperationsResponse ListOperations(ListOperationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOperationsResponseUnmarshaller.Instance;

            return Invoke<ListOperationsResponse>(request, options);
        }


        /// <summary>
        /// Return a list of operations that occurred on an App Runner service.
        /// 
        ///  
        /// <para>
        /// The resulting list of <a>OperationSummary</a> objects is sorted in reverse chronological
        /// order. The first object on the list represents the last started operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual Task<ListOperationsResponse> ListOperationsAsync(ListOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOperationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOperationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServices


        /// <summary>
        /// Returns a list of running App Runner services in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual ListServicesResponse ListServices(ListServicesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;

            return Invoke<ListServicesResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of running App Runner services in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServicesForAutoScalingConfiguration


        /// <summary>
        /// Returns a list of the associated App Runner services using an auto scaling configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServicesForAutoScalingConfiguration service method.</param>
        /// 
        /// <returns>The response from the ListServicesForAutoScalingConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListServicesForAutoScalingConfiguration">REST API Reference for ListServicesForAutoScalingConfiguration Operation</seealso>
        public virtual ListServicesForAutoScalingConfigurationResponse ListServicesForAutoScalingConfiguration(ListServicesForAutoScalingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServicesForAutoScalingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesForAutoScalingConfigurationResponseUnmarshaller.Instance;

            return Invoke<ListServicesForAutoScalingConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the associated App Runner services using an auto scaling configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServicesForAutoScalingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServicesForAutoScalingConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListServicesForAutoScalingConfiguration">REST API Reference for ListServicesForAutoScalingConfiguration Operation</seealso>
        public virtual Task<ListServicesForAutoScalingConfigurationResponse> ListServicesForAutoScalingConfigurationAsync(ListServicesForAutoScalingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServicesForAutoScalingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesForAutoScalingConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServicesForAutoScalingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List tags that are associated with for an App Runner resource. The response contains
        /// a list of tag key-value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// List tags that are associated with for an App Runner resource. The response contains
        /// a list of tag key-value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVpcConnectors


        /// <summary>
        /// Returns a list of App Runner VPC connectors in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcConnectors service method.</param>
        /// 
        /// <returns>The response from the ListVpcConnectors service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListVpcConnectors">REST API Reference for ListVpcConnectors Operation</seealso>
        public virtual ListVpcConnectorsResponse ListVpcConnectors(ListVpcConnectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVpcConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcConnectorsResponseUnmarshaller.Instance;

            return Invoke<ListVpcConnectorsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of App Runner VPC connectors in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcConnectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVpcConnectors service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListVpcConnectors">REST API Reference for ListVpcConnectors Operation</seealso>
        public virtual Task<ListVpcConnectorsResponse> ListVpcConnectorsAsync(ListVpcConnectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVpcConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcConnectorsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListVpcConnectorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVpcIngressConnections


        /// <summary>
        /// Return a list of App Runner VPC Ingress Connections in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcIngressConnections service method.</param>
        /// 
        /// <returns>The response from the ListVpcIngressConnections service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListVpcIngressConnections">REST API Reference for ListVpcIngressConnections Operation</seealso>
        public virtual ListVpcIngressConnectionsResponse ListVpcIngressConnections(ListVpcIngressConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVpcIngressConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcIngressConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListVpcIngressConnectionsResponse>(request, options);
        }


        /// <summary>
        /// Return a list of App Runner VPC Ingress Connections in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcIngressConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVpcIngressConnections service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ListVpcIngressConnections">REST API Reference for ListVpcIngressConnections Operation</seealso>
        public virtual Task<ListVpcIngressConnectionsResponse> ListVpcIngressConnectionsAsync(ListVpcIngressConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVpcIngressConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcIngressConnectionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListVpcIngressConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PauseService


        /// <summary>
        /// Pause an active App Runner service. App Runner reduces compute capacity for the service
        /// to zero and loses state (for example, ephemeral storage is removed).
        /// 
        ///  
        /// <para>
        /// This is an asynchronous operation. On a successful call, you can use the returned
        /// <c>OperationId</c> and the <a>ListOperations</a> call to track the operation's progress.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PauseService service method.</param>
        /// 
        /// <returns>The response from the PauseService service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/PauseService">REST API Reference for PauseService Operation</seealso>
        public virtual PauseServiceResponse PauseService(PauseServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PauseServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PauseServiceResponseUnmarshaller.Instance;

            return Invoke<PauseServiceResponse>(request, options);
        }


        /// <summary>
        /// Pause an active App Runner service. App Runner reduces compute capacity for the service
        /// to zero and loses state (for example, ephemeral storage is removed).
        /// 
        ///  
        /// <para>
        /// This is an asynchronous operation. On a successful call, you can use the returned
        /// <c>OperationId</c> and the <a>ListOperations</a> call to track the operation's progress.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PauseService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PauseService service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/PauseService">REST API Reference for PauseService Operation</seealso>
        public virtual Task<PauseServiceResponse> PauseServiceAsync(PauseServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PauseServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PauseServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<PauseServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResumeService


        /// <summary>
        /// Resume an active App Runner service. App Runner provisions compute capacity for the
        /// service.
        /// 
        ///  
        /// <para>
        /// This is an asynchronous operation. On a successful call, you can use the returned
        /// <c>OperationId</c> and the <a>ListOperations</a> call to track the operation's progress.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeService service method.</param>
        /// 
        /// <returns>The response from the ResumeService service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ResumeService">REST API Reference for ResumeService Operation</seealso>
        public virtual ResumeServiceResponse ResumeService(ResumeServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResumeServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeServiceResponseUnmarshaller.Instance;

            return Invoke<ResumeServiceResponse>(request, options);
        }


        /// <summary>
        /// Resume an active App Runner service. App Runner provisions compute capacity for the
        /// service.
        /// 
        ///  
        /// <para>
        /// This is an asynchronous operation. On a successful call, you can use the returned
        /// <c>OperationId</c> and the <a>ListOperations</a> call to track the operation's progress.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResumeService service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/ResumeService">REST API Reference for ResumeService Operation</seealso>
        public virtual Task<ResumeServiceResponse> ResumeServiceAsync(ResumeServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResumeServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ResumeServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDeployment


        /// <summary>
        /// Initiate a manual deployment of the latest commit in a source code repository or the
        /// latest image in a source image repository to an App Runner service.
        /// 
        ///  
        /// <para>
        /// For a source code repository, App Runner retrieves the commit and builds a Docker
        /// image. For a source image repository, App Runner retrieves the latest Docker image.
        /// In both cases, App Runner then deploys the new image to your service and starts a
        /// new container instance.
        /// </para>
        ///  
        /// <para>
        /// This is an asynchronous operation. On a successful call, you can use the returned
        /// <c>OperationId</c> and the <a>ListOperations</a> call to track the operation's progress.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDeployment service method.</param>
        /// 
        /// <returns>The response from the StartDeployment service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/StartDeployment">REST API Reference for StartDeployment Operation</seealso>
        public virtual StartDeploymentResponse StartDeployment(StartDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDeploymentResponseUnmarshaller.Instance;

            return Invoke<StartDeploymentResponse>(request, options);
        }


        /// <summary>
        /// Initiate a manual deployment of the latest commit in a source code repository or the
        /// latest image in a source image repository to an App Runner service.
        /// 
        ///  
        /// <para>
        /// For a source code repository, App Runner retrieves the commit and builds a Docker
        /// image. For a source image repository, App Runner retrieves the latest Docker image.
        /// In both cases, App Runner then deploys the new image to your service and starts a
        /// new container instance.
        /// </para>
        ///  
        /// <para>
        /// This is an asynchronous operation. On a successful call, you can use the returned
        /// <c>OperationId</c> and the <a>ListOperations</a> call to track the operation's progress.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDeployment service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/StartDeployment">REST API Reference for StartDeployment Operation</seealso>
        public virtual Task<StartDeploymentResponse> StartDeploymentAsync(StartDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDeploymentResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Add tags to, or update the tag values of, an App Runner resource. A tag is a key-value
        /// pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Add tags to, or update the tag values of, an App Runner resource. A tag is a key-value
        /// pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Remove tags from an App Runner resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Remove tags from an App Runner resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDefaultAutoScalingConfiguration


        /// <summary>
        /// Update an auto scaling configuration to be the default. The existing default auto
        /// scaling configuration will be set to non-default automatically.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultAutoScalingConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateDefaultAutoScalingConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/UpdateDefaultAutoScalingConfiguration">REST API Reference for UpdateDefaultAutoScalingConfiguration Operation</seealso>
        public virtual UpdateDefaultAutoScalingConfigurationResponse UpdateDefaultAutoScalingConfiguration(UpdateDefaultAutoScalingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDefaultAutoScalingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDefaultAutoScalingConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateDefaultAutoScalingConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Update an auto scaling configuration to be the default. The existing default auto
        /// scaling configuration will be set to non-default automatically.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultAutoScalingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDefaultAutoScalingConfiguration service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/UpdateDefaultAutoScalingConfiguration">REST API Reference for UpdateDefaultAutoScalingConfiguration Operation</seealso>
        public virtual Task<UpdateDefaultAutoScalingConfigurationResponse> UpdateDefaultAutoScalingConfigurationAsync(UpdateDefaultAutoScalingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDefaultAutoScalingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDefaultAutoScalingConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDefaultAutoScalingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateService


        /// <summary>
        /// Update an App Runner service. You can update the source configuration and instance
        /// configuration of the service. You can also update the ARN of the auto scaling configuration
        /// resource that's associated with the service. However, you can't change the name or
        /// the encryption configuration of the service. These can be set only when you create
        /// the service.
        /// 
        ///  
        /// <para>
        /// To update the tags applied to your service, use the separate actions <a>TagResource</a>
        /// and <a>UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// This is an asynchronous operation. On a successful call, you can use the returned
        /// <c>OperationId</c> and the <a>ListOperations</a> call to track the operation's progress.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// 
        /// <returns>The response from the UpdateService service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/UpdateService">REST API Reference for UpdateService Operation</seealso>
        public virtual UpdateServiceResponse UpdateService(UpdateServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceResponse>(request, options);
        }


        /// <summary>
        /// Update an App Runner service. You can update the source configuration and instance
        /// configuration of the service. You can also update the ARN of the auto scaling configuration
        /// resource that's associated with the service. However, you can't change the name or
        /// the encryption configuration of the service. These can be set only when you create
        /// the service.
        /// 
        ///  
        /// <para>
        /// To update the tags applied to your service, use the separate actions <a>TagResource</a>
        /// and <a>UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// This is an asynchronous operation. On a successful call, you can use the returned
        /// <c>OperationId</c> and the <a>ListOperations</a> call to track the operation's progress.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateService service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/UpdateService">REST API Reference for UpdateService Operation</seealso>
        public virtual Task<UpdateServiceResponse> UpdateServiceAsync(UpdateServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateVpcIngressConnection


        /// <summary>
        /// Update an existing App Runner VPC Ingress Connection resource. The VPC Ingress Connection
        /// must be in one of the following states to be updated:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  AVAILABLE 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  FAILED_CREATION 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  FAILED_UPDATE 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcIngressConnection service method.</param>
        /// 
        /// <returns>The response from the UpdateVpcIngressConnection service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/UpdateVpcIngressConnection">REST API Reference for UpdateVpcIngressConnection Operation</seealso>
        public virtual UpdateVpcIngressConnectionResponse UpdateVpcIngressConnection(UpdateVpcIngressConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVpcIngressConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcIngressConnectionResponseUnmarshaller.Instance;

            return Invoke<UpdateVpcIngressConnectionResponse>(request, options);
        }


        /// <summary>
        /// Update an existing App Runner VPC Ingress Connection resource. The VPC Ingress Connection
        /// must be in one of the following states to be updated:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  AVAILABLE 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  FAILED_CREATION 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  FAILED_UPDATE 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcIngressConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVpcIngressConnection service method, as returned by AppRunner.</returns>
        /// <exception cref="Amazon.AppRunner.Model.InternalServiceErrorException">
        /// An unexpected service exception occurred.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidRequestException">
        /// One or more input parameters aren't valid. Refer to the API action's document page,
        /// correct the input parameters, and try the action again.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.InvalidStateException">
        /// You can't perform this action when the resource is in its current state.
        /// </exception>
        /// <exception cref="Amazon.AppRunner.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN) in your Amazon
        /// Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apprunner-2020-05-15/UpdateVpcIngressConnection">REST API Reference for UpdateVpcIngressConnection Operation</seealso>
        public virtual Task<UpdateVpcIngressConnectionResponse> UpdateVpcIngressConnectionAsync(UpdateVpcIngressConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVpcIngressConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcIngressConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateVpcIngressConnectionResponse>(request, options, cancellationToken);
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
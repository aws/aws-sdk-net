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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AppConfig.Model;
using Amazon.AppConfig.Model.Internal.MarshallTransformations;
using Amazon.AppConfig.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.AppConfig
{
    /// <summary>
    /// <para>Implementation for accessing AppConfig</para>
    ///
    /// AppConfig feature flags and dynamic configurations help software builders quickly
    /// and securely adjust application behavior in production environments without full code
    /// deployments. AppConfig speeds up software release frequency, improves application
    /// resiliency, and helps you address emergent issues more quickly. With feature flags,
    /// you can gradually release new capabilities to users and measure the impact of those
    /// changes before fully deploying the new capabilities to all users. With operational
    /// flags and dynamic configurations, you can update block lists, allow lists, throttling
    /// limits, logging verbosity, and perform other operational tuning to quickly respond
    /// to issues in production environments.
    /// 
    ///  <note> 
    /// <para>
    /// AppConfig is a tool in Amazon Web Services Systems Manager.
    /// </para>
    ///  </note> 
    /// <para>
    /// Despite the fact that application configuration content can vary greatly from application
    /// to application, AppConfig supports the following use cases, which cover a broad spectrum
    /// of customer needs:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Feature flags and toggles</b> - Safely release new capabilities to your customers
    /// in a controlled environment. Instantly roll back changes if you experience a problem.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Application tuning</b> - Carefully introduce application changes while testing
    /// the impact of those changes with users in production environments.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Allow list or block list</b> - Control access to premium features or instantly
    /// block specific users without deploying new code. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Centralized configuration storage</b> - Keep your configuration data organized
    /// and consistent across all of your workloads. You can use AppConfig to deploy configuration
    /// data stored in the AppConfig hosted configuration store, Secrets Manager, Systems
    /// Manager, Parameter Store, or Amazon S3.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>How AppConfig works</b> 
    /// </para>
    ///  
    /// <para>
    /// This section provides a high-level description of how AppConfig works and how you
    /// get started.
    /// </para>
    ///  <dl> <dt>1. Identify configuration values in code you want to manage in the cloud</dt>
    /// <dd> 
    /// <para>
    /// Before you start creating AppConfig artifacts, we recommend you identify configuration
    /// data in your code that you want to dynamically manage using AppConfig. Good examples
    /// include feature flags or toggles, allow and block lists, logging verbosity, service
    /// limits, and throttling rules, to name a few.
    /// </para>
    ///  
    /// <para>
    /// If your configuration data already exists in the cloud, you can take advantage of
    /// AppConfig validation, deployment, and extension features to further streamline configuration
    /// data management.
    /// </para>
    ///  </dd> <dt>2. Create an application namespace</dt> <dd> 
    /// <para>
    /// To create a namespace, you create an AppConfig artifact called an application. An
    /// application is simply an organizational construct like a folder.
    /// </para>
    ///  </dd> <dt>3. Create environments</dt> <dd> 
    /// <para>
    /// For each AppConfig application, you define one or more environments. An environment
    /// is a logical grouping of targets, such as applications in a <c>Beta</c> or <c>Production</c>
    /// environment, Lambda functions, or containers. You can also define environments for
    /// application subcomponents, such as the <c>Web</c>, <c>Mobile</c>, and <c>Back-end</c>.
    /// </para>
    ///  
    /// <para>
    /// You can configure Amazon CloudWatch alarms for each environment. The system monitors
    /// alarms during a configuration deployment. If an alarm is triggered, the system rolls
    /// back the configuration.
    /// </para>
    ///  </dd> <dt>4. Create a configuration profile</dt> <dd> 
    /// <para>
    /// A configuration profile includes, among other things, a URI that enables AppConfig
    /// to locate your configuration data in its stored location and a profile type. AppConfig
    /// supports two configuration profile types: feature flags and freeform configurations.
    /// Feature flag configuration profiles store their data in the AppConfig hosted configuration
    /// store and the URI is simply <c>hosted</c>. For freeform configuration profiles, you
    /// can store your data in the AppConfig hosted configuration store or any Amazon Web
    /// Services service that integrates with AppConfig, as described in <a href="http://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-free-form-configurations-creating.html">Creating
    /// a free form configuration profile</a> in the the <i>AppConfig User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// A configuration profile can also include optional validators to ensure your configuration
    /// data is syntactically and semantically correct. AppConfig performs a check using the
    /// validators when you start a deployment. If any errors are detected, the deployment
    /// rolls back to the previous configuration data.
    /// </para>
    ///  </dd> <dt>5. Deploy configuration data</dt> <dd> 
    /// <para>
    /// When you create a new deployment, you specify the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// An application ID
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A configuration profile ID
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A configuration version
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An environment ID where you want to deploy the configuration data
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A deployment strategy ID that defines how fast you want the changes to take effect
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When you call the <a href="https://docs.aws.amazon.com/appconfig/2019-10-09/APIReference/API_StartDeployment.html">StartDeployment</a>
    /// API action, AppConfig performs the following tasks:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Retrieves the configuration data from the underlying data store by using the location
    /// URI in the configuration profile.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Verifies the configuration data is syntactically and semantically correct by using
    /// the validators you specified when you created your configuration profile.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Caches a copy of the data so it is ready to be retrieved by your application. This
    /// cached copy is called the <i>deployed data</i>.
    /// </para>
    ///  </li> </ol> </dd> <dt>6. Retrieve the configuration</dt> <dd> 
    /// <para>
    /// You can configure AppConfig Agent as a local host and have the agent poll AppConfig
    /// for configuration updates. The agent calls the <a href="https://docs.aws.amazon.com/appconfig/2019-10-09/APIReference/API_appconfigdata_StartConfigurationSession.html">StartConfigurationSession</a>
    /// and <a href="https://docs.aws.amazon.com/appconfig/2019-10-09/APIReference/API_appconfigdata_GetLatestConfiguration.html">GetLatestConfiguration</a>
    /// API actions and caches your configuration data locally. To retrieve the data, your
    /// application makes an HTTP call to the localhost server. AppConfig Agent supports several
    /// use cases, as described in <a href="http://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-retrieving-simplified-methods.html">Simplified
    /// retrieval methods</a> in the the <i>AppConfig User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If AppConfig Agent isn't supported for your use case, you can configure your application
    /// to poll AppConfig for configuration updates by directly calling the <a href="https://docs.aws.amazon.com/appconfig/2019-10-09/APIReference/API_appconfigdata_StartConfigurationSession.html">StartConfigurationSession</a>
    /// and <a href="https://docs.aws.amazon.com/appconfig/2019-10-09/APIReference/API_appconfigdata_GetLatestConfiguration.html">GetLatestConfiguration</a>
    /// API actions. 
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// This reference is intended to be used with the <a href="http://docs.aws.amazon.com/appconfig/latest/userguide/what-is-appconfig.html">AppConfig
    /// User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonAppConfigClient : AmazonServiceClient, IAmazonAppConfig
    {
        private static IServiceMetadata serviceMetadata = new AmazonAppConfigMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonAppConfigClient with the credentials loaded from the application's
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
        public AmazonAppConfigClient()
            : base(new AmazonAppConfigConfig()) { }

        /// <summary>
        /// Constructs AmazonAppConfigClient with the credentials loaded from the application's
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
        public AmazonAppConfigClient(RegionEndpoint region)
            : base(new AmazonAppConfigConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAppConfigClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAppConfigClient Configuration Object</param>
        public AmazonAppConfigClient(AmazonAppConfigConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonAppConfigClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAppConfigClient(AWSCredentials credentials)
            : this(credentials, new AmazonAppConfigConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppConfigClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAppConfigConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigClient with AWS Credentials and an
        /// AmazonAppConfigClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAppConfigClient Configuration Object</param>
        public AmazonAppConfigClient(AWSCredentials credentials, AmazonAppConfigConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAppConfigClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppConfigConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppConfigClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppConfigConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppConfigClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAppConfigClient Configuration Object</param>
        public AmazonAppConfigClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAppConfigConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAppConfigClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppConfigConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppConfigClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppConfigConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppConfigClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAppConfigClient Configuration Object</param>
        public AmazonAppConfigClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAppConfigConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IAppConfigPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAppConfigPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AppConfigPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAppConfigEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAppConfigAuthSchemeHandler());
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


        #region  CreateApplication

        internal virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }



        /// <summary>
        /// Creates an application. In AppConfig, an application is simply an organizational construct
        /// like a folder. This organizational construct has a relationship with some unit of
        /// executable code. For example, you could create an application called MyMobileApp to
        /// organize and manage configuration data for a mobile application installed by your
        /// users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ServiceQuotaExceededException">
        /// The number of one more AppConfig resources exceeds the maximum allowed. Verify that
        /// your environment doesn't exceed the following service quotas:
        /// 
        ///  
        /// <para>
        /// Applications: 100 max
        /// </para>
        ///  
        /// <para>
        /// Deployment strategies: 20 max
        /// </para>
        ///  
        /// <para>
        /// Configuration profiles: 100 max per application
        /// </para>
        ///  
        /// <para>
        /// Environments: 20 max per application
        /// </para>
        ///  
        /// <para>
        /// To resolve this issue, you can delete one or more resources and try again. Or, you
        /// can request a quota increase. For more information about quotas and to request an
        /// increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/appconfig.html#limits_appconfig">Service
        /// quotas for AppConfig</a> in the Amazon Web Services General Reference.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateConfigurationProfile

        internal virtual CreateConfigurationProfileResponse CreateConfigurationProfile(CreateConfigurationProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfigurationProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationProfileResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationProfileResponse>(request, options);
        }



        /// <summary>
        /// Creates a configuration profile, which is information that enables AppConfig to access
        /// the configuration source. Valid configuration sources include the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Configuration data in YAML, JSON, and other formats stored in the AppConfig hosted
        /// configuration store
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Configuration data stored as objects in an Amazon Simple Storage Service (Amazon S3)
        /// bucket
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pipelines stored in CodePipeline
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Secrets stored in Secrets Manager
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Standard and secure string parameters stored in Amazon Web Services Systems Manager
        /// Parameter Store
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Configuration data in SSM documents stored in the Systems Manager document store
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A configuration profile includes the following information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The URI location of the configuration data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Identity and Access Management (IAM) role that provides access to the configuration
        /// data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A validator for the configuration data. Available validators include either a JSON
        /// Schema or an Amazon Web Services Lambda function.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-creating-configuration-and-profile.html">Create
        /// a Configuration and a Configuration Profile</a> in the <i>AppConfig User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfigurationProfile service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ServiceQuotaExceededException">
        /// The number of one more AppConfig resources exceeds the maximum allowed. Verify that
        /// your environment doesn't exceed the following service quotas:
        /// 
        ///  
        /// <para>
        /// Applications: 100 max
        /// </para>
        ///  
        /// <para>
        /// Deployment strategies: 20 max
        /// </para>
        ///  
        /// <para>
        /// Configuration profiles: 100 max per application
        /// </para>
        ///  
        /// <para>
        /// Environments: 20 max per application
        /// </para>
        ///  
        /// <para>
        /// To resolve this issue, you can delete one or more resources and try again. Or, you
        /// can request a quota increase. For more information about quotas and to request an
        /// increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/appconfig.html#limits_appconfig">Service
        /// quotas for AppConfig</a> in the Amazon Web Services General Reference.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateConfigurationProfile">REST API Reference for CreateConfigurationProfile Operation</seealso>
        public virtual Task<CreateConfigurationProfileResponse> CreateConfigurationProfileAsync(CreateConfigurationProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfigurationProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDeploymentStrategy

        internal virtual CreateDeploymentStrategyResponse CreateDeploymentStrategy(CreateDeploymentStrategyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentStrategyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentStrategyResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentStrategyResponse>(request, options);
        }



        /// <summary>
        /// Creates a deployment strategy that defines important criteria for rolling out your
        /// configuration to the designated targets. A deployment strategy includes the overall
        /// duration required, a percentage of targets to receive the deployment during each interval,
        /// an algorithm that defines how percentage grows, and bake time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentStrategy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeploymentStrategy service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ServiceQuotaExceededException">
        /// The number of one more AppConfig resources exceeds the maximum allowed. Verify that
        /// your environment doesn't exceed the following service quotas:
        /// 
        ///  
        /// <para>
        /// Applications: 100 max
        /// </para>
        ///  
        /// <para>
        /// Deployment strategies: 20 max
        /// </para>
        ///  
        /// <para>
        /// Configuration profiles: 100 max per application
        /// </para>
        ///  
        /// <para>
        /// Environments: 20 max per application
        /// </para>
        ///  
        /// <para>
        /// To resolve this issue, you can delete one or more resources and try again. Or, you
        /// can request a quota increase. For more information about quotas and to request an
        /// increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/appconfig.html#limits_appconfig">Service
        /// quotas for AppConfig</a> in the Amazon Web Services General Reference.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateDeploymentStrategy">REST API Reference for CreateDeploymentStrategy Operation</seealso>
        public virtual Task<CreateDeploymentStrategyResponse> CreateDeploymentStrategyAsync(CreateDeploymentStrategyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentStrategyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentStrategyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentStrategyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEnvironment

        internal virtual CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Creates an environment. For each application, you define one or more environments.
        /// An environment is a deployment group of AppConfig targets, such as applications in
        /// a <c>Beta</c> or <c>Production</c> environment. You can also define environments for
        /// application subcomponents such as the <c>Web</c>, <c>Mobile</c> and <c>Back-end</c>
        /// components for your application. You can configure Amazon CloudWatch alarms for each
        /// environment. The system monitors alarms during a configuration deployment. If an alarm
        /// is triggered, the system rolls back the configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ServiceQuotaExceededException">
        /// The number of one more AppConfig resources exceeds the maximum allowed. Verify that
        /// your environment doesn't exceed the following service quotas:
        /// 
        ///  
        /// <para>
        /// Applications: 100 max
        /// </para>
        ///  
        /// <para>
        /// Deployment strategies: 20 max
        /// </para>
        ///  
        /// <para>
        /// Configuration profiles: 100 max per application
        /// </para>
        ///  
        /// <para>
        /// Environments: 20 max per application
        /// </para>
        ///  
        /// <para>
        /// To resolve this issue, you can delete one or more resources and try again. Or, you
        /// can request a quota increase. For more information about quotas and to request an
        /// increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/appconfig.html#limits_appconfig">Service
        /// quotas for AppConfig</a> in the Amazon Web Services General Reference.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEnvironmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateExtension

        internal virtual CreateExtensionResponse CreateExtension(CreateExtensionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExtensionResponseUnmarshaller.Instance;

            return Invoke<CreateExtensionResponse>(request, options);
        }



        /// <summary>
        /// Creates an AppConfig extension. An extension augments your ability to inject logic
        /// or behavior at different points during the AppConfig workflow of creating or deploying
        /// a configuration.
        /// 
        ///  
        /// <para>
        /// You can create your own extensions or use the Amazon Web Services authored extensions
        /// provided by AppConfig. For an AppConfig extension that uses Lambda, you must create
        /// a Lambda function to perform any computation and processing defined in the extension.
        /// If you plan to create custom versions of the Amazon Web Services authored notification
        /// extensions, you only need to specify an Amazon Resource Name (ARN) in the <c>Uri</c>
        /// field for the new extension version.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a custom EventBridge notification extension, enter the ARN of the EventBridge
        /// default events in the <c>Uri</c> field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a custom Amazon SNS notification extension, enter the ARN of an Amazon SNS topic
        /// in the <c>Uri</c> field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a custom Amazon SQS notification extension, enter the ARN of an Amazon SQS message
        /// queue in the <c>Uri</c> field. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about extensions, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Extending
        /// workflows</a> in the <i>AppConfig User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExtension service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateExtension service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ServiceQuotaExceededException">
        /// The number of one more AppConfig resources exceeds the maximum allowed. Verify that
        /// your environment doesn't exceed the following service quotas:
        /// 
        ///  
        /// <para>
        /// Applications: 100 max
        /// </para>
        ///  
        /// <para>
        /// Deployment strategies: 20 max
        /// </para>
        ///  
        /// <para>
        /// Configuration profiles: 100 max per application
        /// </para>
        ///  
        /// <para>
        /// Environments: 20 max per application
        /// </para>
        ///  
        /// <para>
        /// To resolve this issue, you can delete one or more resources and try again. Or, you
        /// can request a quota increase. For more information about quotas and to request an
        /// increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/appconfig.html#limits_appconfig">Service
        /// quotas for AppConfig</a> in the Amazon Web Services General Reference.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateExtension">REST API Reference for CreateExtension Operation</seealso>
        public virtual Task<CreateExtensionResponse> CreateExtensionAsync(CreateExtensionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExtensionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateExtensionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateExtensionAssociation

        internal virtual CreateExtensionAssociationResponse CreateExtensionAssociation(CreateExtensionAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExtensionAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExtensionAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateExtensionAssociationResponse>(request, options);
        }



        /// <summary>
        /// When you create an extension or configure an Amazon Web Services authored extension,
        /// you associate the extension with an AppConfig application, environment, or configuration
        /// profile. For example, you can choose to run the <c>AppConfig deployment events to
        /// Amazon SNS</c> Amazon Web Services authored extension and receive notifications on
        /// an Amazon SNS topic anytime a configuration deployment is started for a specific application.
        /// Defining which extension to associate with an AppConfig resource is called an <i>extension
        /// association</i>. An extension association is a specified relationship between an extension
        /// and an AppConfig resource, such as an application or a configuration profile. For
        /// more information about extensions and associations, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Extending
        /// workflows</a> in the <i>AppConfig User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExtensionAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateExtensionAssociation service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ServiceQuotaExceededException">
        /// The number of one more AppConfig resources exceeds the maximum allowed. Verify that
        /// your environment doesn't exceed the following service quotas:
        /// 
        ///  
        /// <para>
        /// Applications: 100 max
        /// </para>
        ///  
        /// <para>
        /// Deployment strategies: 20 max
        /// </para>
        ///  
        /// <para>
        /// Configuration profiles: 100 max per application
        /// </para>
        ///  
        /// <para>
        /// Environments: 20 max per application
        /// </para>
        ///  
        /// <para>
        /// To resolve this issue, you can delete one or more resources and try again. Or, you
        /// can request a quota increase. For more information about quotas and to request an
        /// increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/appconfig.html#limits_appconfig">Service
        /// quotas for AppConfig</a> in the Amazon Web Services General Reference.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateExtensionAssociation">REST API Reference for CreateExtensionAssociation Operation</seealso>
        public virtual Task<CreateExtensionAssociationResponse> CreateExtensionAssociationAsync(CreateExtensionAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExtensionAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExtensionAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateExtensionAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateHostedConfigurationVersion

        internal virtual CreateHostedConfigurationVersionResponse CreateHostedConfigurationVersion(CreateHostedConfigurationVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateHostedConfigurationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHostedConfigurationVersionResponseUnmarshaller.Instance;

            return Invoke<CreateHostedConfigurationVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new configuration in the AppConfig hosted configuration store. If you're
        /// creating a feature flag, we recommend you familiarize yourself with the JSON schema
        /// for feature flag data. For more information, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-creating-configuration-and-profile-feature-flags.html#appconfig-type-reference-feature-flags">Type
        /// reference for AWS.AppConfig.FeatureFlags</a> in the <i>AppConfig User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHostedConfigurationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHostedConfigurationVersion service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.PayloadTooLargeException">
        /// The configuration size is too large.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ServiceQuotaExceededException">
        /// The number of one more AppConfig resources exceeds the maximum allowed. Verify that
        /// your environment doesn't exceed the following service quotas:
        /// 
        ///  
        /// <para>
        /// Applications: 100 max
        /// </para>
        ///  
        /// <para>
        /// Deployment strategies: 20 max
        /// </para>
        ///  
        /// <para>
        /// Configuration profiles: 100 max per application
        /// </para>
        ///  
        /// <para>
        /// Environments: 20 max per application
        /// </para>
        ///  
        /// <para>
        /// To resolve this issue, you can delete one or more resources and try again. Or, you
        /// can request a quota increase. For more information about quotas and to request an
        /// increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/appconfig.html#limits_appconfig">Service
        /// quotas for AppConfig</a> in the Amazon Web Services General Reference.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateHostedConfigurationVersion">REST API Reference for CreateHostedConfigurationVersion Operation</seealso>
        public virtual Task<CreateHostedConfigurationVersionResponse> CreateHostedConfigurationVersionAsync(CreateHostedConfigurationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateHostedConfigurationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHostedConfigurationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHostedConfigurationVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteApplication

        internal virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationResponse>(request, options);
        }



        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteConfigurationProfile

        internal virtual DeleteConfigurationProfileResponse DeleteConfigurationProfile(DeleteConfigurationProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationProfileResponse>(request, options);
        }



        /// <summary>
        /// Deletes a configuration profile.
        /// 
        ///  
        /// <para>
        /// To prevent users from unintentionally deleting actively-used configuration profiles,
        /// enable <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/deletion-protection.html">deletion
        /// protection</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfigurationProfile service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteConfigurationProfile">REST API Reference for DeleteConfigurationProfile Operation</seealso>
        public virtual Task<DeleteConfigurationProfileResponse> DeleteConfigurationProfileAsync(DeleteConfigurationProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDeploymentStrategy

        internal virtual DeleteDeploymentStrategyResponse DeleteDeploymentStrategy(DeleteDeploymentStrategyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentStrategyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentStrategyResponseUnmarshaller.Instance;

            return Invoke<DeleteDeploymentStrategyResponse>(request, options);
        }



        /// <summary>
        /// Deletes a deployment strategy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeploymentStrategy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDeploymentStrategy service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteDeploymentStrategy">REST API Reference for DeleteDeploymentStrategy Operation</seealso>
        public virtual Task<DeleteDeploymentStrategyResponse> DeleteDeploymentStrategyAsync(DeleteDeploymentStrategyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentStrategyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentStrategyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeploymentStrategyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEnvironment

        internal virtual DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Deletes an environment.
        /// 
        ///  
        /// <para>
        /// To prevent users from unintentionally deleting actively-used environments, enable
        /// <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/deletion-protection.html">deletion
        /// protection</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEnvironmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteExtension

        internal virtual DeleteExtensionResponse DeleteExtension(DeleteExtensionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExtensionResponseUnmarshaller.Instance;

            return Invoke<DeleteExtensionResponse>(request, options);
        }



        /// <summary>
        /// Deletes an AppConfig extension. You must delete all associations to an extension before
        /// you delete the extension.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExtension service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteExtension service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteExtension">REST API Reference for DeleteExtension Operation</seealso>
        public virtual Task<DeleteExtensionResponse> DeleteExtensionAsync(DeleteExtensionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExtensionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteExtensionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteExtensionAssociation

        internal virtual DeleteExtensionAssociationResponse DeleteExtensionAssociation(DeleteExtensionAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteExtensionAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExtensionAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteExtensionAssociationResponse>(request, options);
        }



        /// <summary>
        /// Deletes an extension association. This action doesn't delete extensions defined in
        /// the association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExtensionAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteExtensionAssociation service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteExtensionAssociation">REST API Reference for DeleteExtensionAssociation Operation</seealso>
        public virtual Task<DeleteExtensionAssociationResponse> DeleteExtensionAssociationAsync(DeleteExtensionAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteExtensionAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExtensionAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteExtensionAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteHostedConfigurationVersion

        internal virtual DeleteHostedConfigurationVersionResponse DeleteHostedConfigurationVersion(DeleteHostedConfigurationVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteHostedConfigurationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHostedConfigurationVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteHostedConfigurationVersionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a version of a configuration from the AppConfig hosted configuration store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostedConfigurationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHostedConfigurationVersion service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteHostedConfigurationVersion">REST API Reference for DeleteHostedConfigurationVersion Operation</seealso>
        public virtual Task<DeleteHostedConfigurationVersionResponse> DeleteHostedConfigurationVersionAsync(DeleteHostedConfigurationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteHostedConfigurationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHostedConfigurationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHostedConfigurationVersionResponse>(request, options, cancellationToken);
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
        /// Returns information about the status of the <c>DeletionProtection</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual Task<GetAccountSettingsResponse> GetAccountSettingsAsync(GetAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetApplication

        internal virtual GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return Invoke<GetApplicationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<GetApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConfiguration

        [Obsolete("This API has been deprecated in favor of the GetLatestConfiguration API used in conjunction with StartConfigurationSession.")]
        internal virtual GetConfigurationResponse GetConfiguration(GetConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationResponse>(request, options);
        }



        /// <summary>
        /// (Deprecated) Retrieves the latest deployed configuration.
        /// 
        ///  <important> 
        /// <para>
        /// Note the following important information.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// This API action is deprecated. Calls to receive configuration data should use the
        /// <a href="https://docs.aws.amazon.com/appconfig/2019-10-09/APIReference/API_appconfigdata_StartConfigurationSession.html">StartConfigurationSession</a>
        /// and <a href="https://docs.aws.amazon.com/appconfig/2019-10-09/APIReference/API_appconfigdata_GetLatestConfiguration.html">GetLatestConfiguration</a>
        /// APIs instead. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetConfiguration</a> is a priced call. For more information, see <a href="https://aws.amazon.com/systems-manager/pricing/">Pricing</a>.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfiguration service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        [Obsolete("This API has been deprecated in favor of the GetLatestConfiguration API used in conjunction with StartConfigurationSession.")]
        public virtual Task<GetConfigurationResponse> GetConfigurationAsync(GetConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConfigurationProfile

        internal virtual GetConfigurationProfileResponse GetConfigurationProfile(GetConfigurationProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationProfileResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationProfileResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a configuration profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfigurationProfile service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetConfigurationProfile">REST API Reference for GetConfigurationProfile Operation</seealso>
        public virtual Task<GetConfigurationProfileResponse> GetConfigurationProfileAsync(GetConfigurationProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfigurationProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDeployment

        internal virtual GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a configuration deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDeploymentStrategy

        internal virtual GetDeploymentStrategyResponse GetDeploymentStrategy(GetDeploymentStrategyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentStrategyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentStrategyResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentStrategyResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a deployment strategy. A deployment strategy defines important
        /// criteria for rolling out your configuration to the designated targets. A deployment
        /// strategy includes the overall duration required, a percentage of targets to receive
        /// the deployment during each interval, an algorithm that defines how percentage grows,
        /// and bake time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentStrategy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeploymentStrategy service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetDeploymentStrategy">REST API Reference for GetDeploymentStrategy Operation</seealso>
        public virtual Task<GetDeploymentStrategyResponse> GetDeploymentStrategyAsync(GetDeploymentStrategyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentStrategyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentStrategyResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentStrategyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEnvironment

        internal virtual GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about an environment. An environment is a deployment group of
        /// AppConfig applications, such as applications in a <c>Production</c> environment or
        /// in an <c>EU_Region</c> environment. Each configuration deployment targets an environment.
        /// You can enable one or more Amazon CloudWatch alarms for an environment. If an alarm
        /// is triggered during a deployment, AppConfig roles back the configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual Task<GetEnvironmentResponse> GetEnvironmentAsync(GetEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnvironmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetExtension

        internal virtual GetExtensionResponse GetExtension(GetExtensionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExtensionResponseUnmarshaller.Instance;

            return Invoke<GetExtensionResponse>(request, options);
        }



        /// <summary>
        /// Returns information about an AppConfig extension.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExtension service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExtension service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetExtension">REST API Reference for GetExtension Operation</seealso>
        public virtual Task<GetExtensionResponse> GetExtensionAsync(GetExtensionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExtensionResponseUnmarshaller.Instance;

            return InvokeAsync<GetExtensionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetExtensionAssociation

        internal virtual GetExtensionAssociationResponse GetExtensionAssociation(GetExtensionAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExtensionAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExtensionAssociationResponseUnmarshaller.Instance;

            return Invoke<GetExtensionAssociationResponse>(request, options);
        }



        /// <summary>
        /// Returns information about an AppConfig extension association. For more information
        /// about extensions and associations, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Extending
        /// workflows</a> in the <i>AppConfig User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExtensionAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExtensionAssociation service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetExtensionAssociation">REST API Reference for GetExtensionAssociation Operation</seealso>
        public virtual Task<GetExtensionAssociationResponse> GetExtensionAssociationAsync(GetExtensionAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExtensionAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExtensionAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetExtensionAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetHostedConfigurationVersion

        internal virtual GetHostedConfigurationVersionResponse GetHostedConfigurationVersion(GetHostedConfigurationVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetHostedConfigurationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHostedConfigurationVersionResponseUnmarshaller.Instance;

            return Invoke<GetHostedConfigurationVersionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a specific configuration version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostedConfigurationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHostedConfigurationVersion service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetHostedConfigurationVersion">REST API Reference for GetHostedConfigurationVersion Operation</seealso>
        public virtual Task<GetHostedConfigurationVersionResponse> GetHostedConfigurationVersionAsync(GetHostedConfigurationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetHostedConfigurationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHostedConfigurationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetHostedConfigurationVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListApplications

        internal virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsResponse>(request, options);
        }



        /// <summary>
        /// Lists all applications in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListConfigurationProfiles

        internal virtual ListConfigurationProfilesResponse ListConfigurationProfiles(ListConfigurationProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationProfilesResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationProfilesResponse>(request, options);
        }



        /// <summary>
        /// Lists the configuration profiles for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigurationProfiles service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListConfigurationProfiles">REST API Reference for ListConfigurationProfiles Operation</seealso>
        public virtual Task<ListConfigurationProfilesResponse> ListConfigurationProfilesAsync(ListConfigurationProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigurationProfilesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDeployments

        internal virtual ListDeploymentsResponse ListDeployments(ListDeploymentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentsResponse>(request, options);
        }



        /// <summary>
        /// Lists the deployments for an environment in descending deployment number order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        public virtual Task<ListDeploymentsResponse> ListDeploymentsAsync(ListDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDeploymentStrategies

        internal virtual ListDeploymentStrategiesResponse ListDeploymentStrategies(ListDeploymentStrategiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentStrategiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentStrategiesResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentStrategiesResponse>(request, options);
        }



        /// <summary>
        /// Lists deployment strategies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentStrategies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeploymentStrategies service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListDeploymentStrategies">REST API Reference for ListDeploymentStrategies Operation</seealso>
        public virtual Task<ListDeploymentStrategiesResponse> ListDeploymentStrategiesAsync(ListDeploymentStrategiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentStrategiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentStrategiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentStrategiesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEnvironments

        internal virtual ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentsResponse>(request, options);
        }



        /// <summary>
        /// Lists the environments for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnvironmentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListExtensionAssociations

        internal virtual ListExtensionAssociationsResponse ListExtensionAssociations(ListExtensionAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExtensionAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExtensionAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListExtensionAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Lists all AppConfig extension associations in the account. For more information about
        /// extensions and associations, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Extending
        /// workflows</a> in the <i>AppConfig User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExtensionAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExtensionAssociations service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListExtensionAssociations">REST API Reference for ListExtensionAssociations Operation</seealso>
        public virtual Task<ListExtensionAssociationsResponse> ListExtensionAssociationsAsync(ListExtensionAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExtensionAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExtensionAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListExtensionAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListExtensions

        internal virtual ListExtensionsResponse ListExtensions(ListExtensionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExtensionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExtensionsResponseUnmarshaller.Instance;

            return Invoke<ListExtensionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all custom and Amazon Web Services authored AppConfig extensions in the account.
        /// For more information about extensions, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Extending
        /// workflows</a> in the <i>AppConfig User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExtensions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExtensions service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListExtensions">REST API Reference for ListExtensions Operation</seealso>
        public virtual Task<ListExtensionsResponse> ListExtensionsAsync(ListExtensionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExtensionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExtensionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListExtensionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListHostedConfigurationVersions

        internal virtual ListHostedConfigurationVersionsResponse ListHostedConfigurationVersions(ListHostedConfigurationVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListHostedConfigurationVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHostedConfigurationVersionsResponseUnmarshaller.Instance;

            return Invoke<ListHostedConfigurationVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists configurations stored in the AppConfig hosted configuration store by version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostedConfigurationVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHostedConfigurationVersions service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListHostedConfigurationVersions">REST API Reference for ListHostedConfigurationVersions Operation</seealso>
        public virtual Task<ListHostedConfigurationVersionsResponse> ListHostedConfigurationVersionsAsync(ListHostedConfigurationVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListHostedConfigurationVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHostedConfigurationVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListHostedConfigurationVersionsResponse>(request, options, cancellationToken);
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
        /// Retrieves the list of key-value tags assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartDeployment

        internal virtual StartDeploymentResponse StartDeployment(StartDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDeploymentResponseUnmarshaller.Instance;

            return Invoke<StartDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Starts a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDeployment service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/StartDeployment">REST API Reference for StartDeployment Operation</seealso>
        public virtual Task<StartDeploymentResponse> StartDeploymentAsync(StartDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<StartDeploymentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopDeployment

        internal virtual StopDeploymentResponse StopDeployment(StopDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDeploymentResponseUnmarshaller.Instance;

            return Invoke<StopDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Stops a deployment. This API action works only on deployments that have a status of
        /// <c>DEPLOYING</c>, unless an <c>AllowRevert</c> parameter is supplied. If the <c>AllowRevert</c>
        /// parameter is supplied, the status of an in-progress deployment will be <c>ROLLED_BACK</c>.
        /// The status of a completed deployment will be <c>REVERTED</c>. AppConfig only allows
        /// a revert within 72 hours of deployment completion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDeployment service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/StopDeployment">REST API Reference for StopDeployment Operation</seealso>
        public virtual Task<StopDeploymentResponse> StopDeploymentAsync(StopDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<StopDeploymentResponse>(request, options, cancellationToken);
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
        /// Assigns metadata to an AppConfig resource. Tags help organize and categorize your
        /// AppConfig resources. Each tag consists of a key and an optional value, both of which
        /// you define. You can specify a maximum of 50 tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Deletes a tag key and value from an AppConfig resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAccountSettings

        internal virtual UpdateAccountSettingsResponse UpdateAccountSettings(UpdateAccountSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountSettingsResponse>(request, options);
        }



        /// <summary>
        /// Updates the value of the <c>DeletionProtection</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccountSettings service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        public virtual Task<UpdateAccountSettingsResponse> UpdateAccountSettingsAsync(UpdateAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccountSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateApplication

        internal virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResponse>(request, options);
        }



        /// <summary>
        /// Updates an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateConfigurationProfile

        internal virtual UpdateConfigurationProfileResponse UpdateConfigurationProfile(UpdateConfigurationProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationProfileResponse>(request, options);
        }



        /// <summary>
        /// Updates a configuration profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfigurationProfile service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateConfigurationProfile">REST API Reference for UpdateConfigurationProfile Operation</seealso>
        public virtual Task<UpdateConfigurationProfileResponse> UpdateConfigurationProfileAsync(UpdateConfigurationProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigurationProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDeploymentStrategy

        internal virtual UpdateDeploymentStrategyResponse UpdateDeploymentStrategy(UpdateDeploymentStrategyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDeploymentStrategyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeploymentStrategyResponseUnmarshaller.Instance;

            return Invoke<UpdateDeploymentStrategyResponse>(request, options);
        }



        /// <summary>
        /// Updates a deployment strategy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeploymentStrategy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDeploymentStrategy service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateDeploymentStrategy">REST API Reference for UpdateDeploymentStrategy Operation</seealso>
        public virtual Task<UpdateDeploymentStrategyResponse> UpdateDeploymentStrategyAsync(UpdateDeploymentStrategyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDeploymentStrategyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeploymentStrategyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDeploymentStrategyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateEnvironment

        internal virtual UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Updates an environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnvironmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateExtension

        internal virtual UpdateExtensionResponse UpdateExtension(UpdateExtensionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExtensionResponseUnmarshaller.Instance;

            return Invoke<UpdateExtensionResponse>(request, options);
        }



        /// <summary>
        /// Updates an AppConfig extension. For more information about extensions, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Extending
        /// workflows</a> in the <i>AppConfig User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExtension service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateExtension service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateExtension">REST API Reference for UpdateExtension Operation</seealso>
        public virtual Task<UpdateExtensionResponse> UpdateExtensionAsync(UpdateExtensionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExtensionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateExtensionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateExtensionAssociation

        internal virtual UpdateExtensionAssociationResponse UpdateExtensionAssociation(UpdateExtensionAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExtensionAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExtensionAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateExtensionAssociationResponse>(request, options);
        }



        /// <summary>
        /// Updates an association. For more information about extensions and associations, see
        /// <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Extending
        /// workflows</a> in the <i>AppConfig User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExtensionAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateExtensionAssociation service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateExtensionAssociation">REST API Reference for UpdateExtensionAssociation Operation</seealso>
        public virtual Task<UpdateExtensionAssociationResponse> UpdateExtensionAssociationAsync(UpdateExtensionAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExtensionAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExtensionAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateExtensionAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ValidateConfiguration

        internal virtual ValidateConfigurationResponse ValidateConfiguration(ValidateConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ValidateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateConfigurationResponseUnmarshaller.Instance;

            return Invoke<ValidateConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Uses the validators in a configuration profile to validate a configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateConfiguration service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ValidateConfiguration">REST API Reference for ValidateConfiguration Operation</seealso>
        public virtual Task<ValidateConfigurationResponse> ValidateConfigurationAsync(ValidateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ValidateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<ValidateConfigurationResponse>(request, options, cancellationToken);
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
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
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// AppConfig helps you safely change application behavior in production without redeploying
    /// code. Using feature flags and dynamic free-form configurations, you can control how
    /// your application runs in real time. This approach reduces risk, accelerates releases,
    /// and enables faster responses to issues. You can gradually roll out new features to
    /// specific users, monitor their impact, and expand availability with confidence. You
    /// can also update block lists, allow lists, throttling limits, and logging levels instantly,
    /// allowing you to mitigate issues and fine-tune performance without a deployment.
    /// 
    ///  
    /// <para>
    /// AppConfig supports a broad spectrum of use cases:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Feature flags and toggles</b> – Gradually release new capabilities to targeted
    /// users, monitor impact, and instantly roll back changes if issues occur.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Application tuning</b> – Introduce changes safely in production, measure their
    /// effects, and refine behavior without redeploying code.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Allow list or block list</b> – Control access to features or restrict specific
    /// users in real time, without modifying application code. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Centralized configuration storage</b> – Manage configuration data consistently
    /// across workloads. AppConfig can deploy configuration from the AppConfig hosted configuration
    /// store, Secrets Manager, Systems Manager, Systems Manager Parameter Store, or Amazon
    /// S3.
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
    ///  <dl> <dt>1. Identify configuration data to manage in AppConfig</dt> <dd> 
    /// <para>
    /// Before creating a configuration profile, identify the configuration data in your code
    /// that you want to manage dynamically using AppConfig. Common examples include feature
    /// flags, allow and block lists, logging levels, service limits, and throttling rules.
    /// These values tend to change frequently and can cause issues if misconfigured.
    /// </para>
    ///  
    /// <para>
    /// If your configuration data already exists in cloud services such as Systems Manager
    /// Parameter Store or Amazon S3, you can use AppConfig to validate, deploy, and manage
    /// that data more effectively.
    /// </para>
    ///  </dd> <dt>2. Create a configuration profile in AppConfig</dt> <dd> 
    /// <para>
    /// A configuration profile defines how AppConfig locates and manages your configuration
    /// data. It includes a URI that points to the data source and a profile type.
    /// </para>
    ///  
    /// <para>
    /// AppConfig supports two profile types
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Feature flags</b> – Enable controlled feature releases, gradual rollouts, and
    /// testing in production.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Free-form configurations</b> – Store and retrieve configuration data from external
    /// sources and update it without redeploying code.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Both profile types help decouple configuration from code, support continuous delivery,
    /// and reduce deployment risk.
    /// </para>
    ///  
    /// <para>
    /// You can also add optional validators to ensure that configuration data is syntactically
    /// and semantically correct. During deployment, AppConfig evaluates these validators
    /// and automatically rolls back changes if validation fails.
    /// </para>
    ///  
    /// <para>
    /// Each configuration profile is associated with an application, which acts as a logical
    /// container for your configuration resources. For more information about creating a
    /// configuration profile, see <a href="http://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-creating-configuration-profile.html">Creating
    /// a configuration profile in AppConfig</a> in the the <i>AppConfig User Guide</i>.
    /// </para>
    ///  </dd> <dt>3. Deploy configuration data</dt> <dd> 
    /// <para>
    /// When you start a deployment, AppConfig:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Retrieves configuration data from the source defined in the configuration profile
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Validates the data using the configured validators
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Delivers the validated configuration to AppConfig Agent
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// The delivered configuration becomes the deployed version used by your application.
    /// For more information about deploying a configuration, see <a href="http://docs.aws.amazon.com/appconfig/latest/userguide/deploying-feature-flags.html">Deploying
    /// feature flags and configuration data in AppConfig</a>.
    /// </para>
    ///  </dd> <dt>4. Retrieve configuration data</dt> <dd> 
    /// <para>
    /// Your application retrieves configuration data by calling a local endpoint exposed
    /// by AppConfig Agent, which caches the deployed configuration. Retrieving data is a
    /// metered event. AppConfig Agent supports a variety of use cases, as described in <a
    /// href="http://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-agent-how-to-use.html">How
    /// to use AppConfig Agent to retrieve configuration data</a>.
    /// </para>
    ///  
    /// <para>
    /// If the agent is not suitable for your use case, your application can retrieve configuration
    /// data directly from AppConfig by calling the <a href="https://docs.aws.amazon.com/appconfig/2019-10-09/APIReference/API_appconfigdata_StartConfigurationSession.html">StartConfigurationSession</a>
    /// and <a href="https://docs.aws.amazon.com/appconfig/2019-10-09/APIReference/API_appconfigdata_GetLatestConfiguration.html">GetLatestConfiguration</a>
    /// API actions. 
    /// </para>
    ///  
    /// <para>
    /// For more information about retrieving a configuration, see <a href="http://docs.aws.amazon.com/appconfig/latest/userguide/retrieving-feature-flags.html">Retrieving
    /// feature flags and configuration data in AppConfig</a>.
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

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
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


        /// <summary>
        /// Creates an application. In AppConfig, an application is simply an organizational construct
        /// like a folder. This organizational construct has a relationship with some unit of
        /// executable code. For example, you could create an application called MyMobileApp to
        /// organize and manage configuration data for a mobile application installed by your
        /// users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
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
        /// To resolve this issue, you can delete one or more resources and try again. Or, you
        /// can request a quota increase. For more information about quotas and to request an
        /// increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/appconfig.html#limits_appconfig">Service
        /// quotas for AppConfig</a> in the Amazon Web Services General Reference.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
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
        /// To resolve this issue, you can delete one or more resources and try again. Or, you
        /// can request a quota increase. For more information about quotas and to request an
        /// increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/appconfig.html#limits_appconfig">Service
        /// quotas for AppConfig</a> in the Amazon Web Services General Reference.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateConfigurationProfile">REST API Reference for CreateConfigurationProfile Operation</seealso>
        public virtual CreateConfigurationProfileResponse CreateConfigurationProfile(CreateConfigurationProfileRequest request)
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


        /// <summary>
        /// Creates a deployment strategy that defines important criteria for rolling out your
        /// configuration to the designated targets. A deployment strategy includes the overall
        /// duration required, a percentage of targets to receive the deployment during each interval,
        /// an algorithm that defines how percentage grows, and bake time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentStrategy service method.</param>
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
        /// To resolve this issue, you can delete one or more resources and try again. Or, you
        /// can request a quota increase. For more information about quotas and to request an
        /// increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/appconfig.html#limits_appconfig">Service
        /// quotas for AppConfig</a> in the Amazon Web Services General Reference.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateDeploymentStrategy">REST API Reference for CreateDeploymentStrategy Operation</seealso>
        public virtual CreateDeploymentStrategyResponse CreateDeploymentStrategy(CreateDeploymentStrategyRequest request)
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
        /// To resolve this issue, you can delete one or more resources and try again. Or, you
        /// can request a quota increase. For more information about quotas and to request an
        /// increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/appconfig.html#limits_appconfig">Service
        /// quotas for AppConfig</a> in the Amazon Web Services General Reference.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
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
        
        #region  CreateExperimentDefinition


        /// <summary>
        /// Creates an experiment definition in AppConfig. An experiment definition describes
        /// the purpose, scope, and operational configuration of an experiment, including the
        /// target audience, feature flag, and treatment configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExperimentDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateExperimentDefinition service method, as returned by AppConfig.</returns>
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
        /// To resolve this issue, you can delete one or more resources and try again. Or, you
        /// can request a quota increase. For more information about quotas and to request an
        /// increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/appconfig.html#limits_appconfig">Service
        /// quotas for AppConfig</a> in the Amazon Web Services General Reference.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateExperimentDefinition">REST API Reference for CreateExperimentDefinition Operation</seealso>
        public virtual CreateExperimentDefinitionResponse CreateExperimentDefinition(CreateExperimentDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExperimentDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExperimentDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateExperimentDefinitionResponse>(request, options);
        }


        /// <summary>
        /// Creates an experiment definition in AppConfig. An experiment definition describes
        /// the purpose, scope, and operational configuration of an experiment, including the
        /// target audience, feature flag, and treatment configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExperimentDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateExperimentDefinition service method, as returned by AppConfig.</returns>
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
        /// To resolve this issue, you can delete one or more resources and try again. Or, you
        /// can request a quota increase. For more information about quotas and to request an
        /// increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/appconfig.html#limits_appconfig">Service
        /// quotas for AppConfig</a> in the Amazon Web Services General Reference.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateExperimentDefinition">REST API Reference for CreateExperimentDefinition Operation</seealso>
        public virtual Task<CreateExperimentDefinitionResponse> CreateExperimentDefinitionAsync(CreateExperimentDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExperimentDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExperimentDefinitionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateExperimentDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateExtension


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
        /// To resolve this issue, you can delete one or more resources and try again. Or, you
        /// can request a quota increase. For more information about quotas and to request an
        /// increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/appconfig.html#limits_appconfig">Service
        /// quotas for AppConfig</a> in the Amazon Web Services General Reference.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateExtension">REST API Reference for CreateExtension Operation</seealso>
        public virtual CreateExtensionResponse CreateExtension(CreateExtensionRequest request)
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
        /// To resolve this issue, you can delete one or more resources and try again. Or, you
        /// can request a quota increase. For more information about quotas and to request an
        /// increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/appconfig.html#limits_appconfig">Service
        /// quotas for AppConfig</a> in the Amazon Web Services General Reference.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateExtensionAssociation">REST API Reference for CreateExtensionAssociation Operation</seealso>
        public virtual CreateExtensionAssociationResponse CreateExtensionAssociation(CreateExtensionAssociationRequest request)
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


        /// <summary>
        /// Creates a new configuration in the AppConfig hosted configuration store. If you're
        /// creating a feature flag, we recommend you familiarize yourself with the JSON schema
        /// for feature flag data. For more information, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-type-reference-feature-flags.html">Type
        /// reference for AWS.AppConfig.FeatureFlags</a> in the <i>AppConfig User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHostedConfigurationVersion service method.</param>
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
        /// To resolve this issue, you can delete one or more resources and try again. Or, you
        /// can request a quota increase. For more information about quotas and to request an
        /// increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/appconfig.html#limits_appconfig">Service
        /// quotas for AppConfig</a> in the Amazon Web Services General Reference.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateHostedConfigurationVersion">REST API Reference for CreateHostedConfigurationVersion Operation</seealso>
        public virtual CreateHostedConfigurationVersionResponse CreateHostedConfigurationVersion(CreateHostedConfigurationVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateHostedConfigurationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHostedConfigurationVersionResponseUnmarshaller.Instance;

            return Invoke<CreateHostedConfigurationVersionResponse>(request, options);
        }


        /// <summary>
        /// Creates a new configuration in the AppConfig hosted configuration store. If you're
        /// creating a feature flag, we recommend you familiarize yourself with the JSON schema
        /// for feature flag data. For more information, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-type-reference-feature-flags.html">Type
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


        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
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
        public virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
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
        public virtual DeleteConfigurationProfileResponse DeleteConfigurationProfile(DeleteConfigurationProfileRequest request)
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


        /// <summary>
        /// Deletes a deployment strategy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeploymentStrategy service method.</param>
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
        public virtual DeleteDeploymentStrategyResponse DeleteDeploymentStrategy(DeleteDeploymentStrategyRequest request)
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
        public virtual DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request)
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
        
        #region  DeleteExperimentDefinition


        /// <summary>
        /// Deletes an experiment definition. You can archive the definition to hide it from the
        /// active list while preserving it for future reference, or permanently delete it along
        /// with all associated run history.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperimentDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteExperimentDefinition service method, as returned by AppConfig.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteExperimentDefinition">REST API Reference for DeleteExperimentDefinition Operation</seealso>
        public virtual DeleteExperimentDefinitionResponse DeleteExperimentDefinition(DeleteExperimentDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteExperimentDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExperimentDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteExperimentDefinitionResponse>(request, options);
        }


        /// <summary>
        /// Deletes an experiment definition. You can archive the definition to hide it from the
        /// active list while preserving it for future reference, or permanently delete it along
        /// with all associated run history.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperimentDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteExperimentDefinition service method, as returned by AppConfig.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteExperimentDefinition">REST API Reference for DeleteExperimentDefinition Operation</seealso>
        public virtual Task<DeleteExperimentDefinitionResponse> DeleteExperimentDefinitionAsync(DeleteExperimentDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteExperimentDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExperimentDefinitionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteExperimentDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteExtension


        /// <summary>
        /// Deletes an AppConfig extension. You must delete all associations to an extension before
        /// you delete the extension.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExtension service method.</param>
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
        public virtual DeleteExtensionResponse DeleteExtension(DeleteExtensionRequest request)
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


        /// <summary>
        /// Deletes an extension association. This action doesn't delete extensions defined in
        /// the association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExtensionAssociation service method.</param>
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
        public virtual DeleteExtensionAssociationResponse DeleteExtensionAssociation(DeleteExtensionAssociationRequest request)
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


        /// <summary>
        /// Deletes a version of a configuration from the AppConfig hosted configuration store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostedConfigurationVersion service method.</param>
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
        public virtual DeleteHostedConfigurationVersionResponse DeleteHostedConfigurationVersion(DeleteHostedConfigurationVersionRequest request)
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


        /// <summary>
        /// Returns information about the status of the <c>DeletionProtection</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request)
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


        /// <summary>
        /// Retrieves information about an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
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
        public virtual GetApplicationResponse GetApplication(GetApplicationRequest request)
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
        public virtual GetConfigurationResponse GetConfiguration(GetConfigurationRequest request)
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


        /// <summary>
        /// Retrieves information about a configuration profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationProfile service method.</param>
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
        public virtual GetConfigurationProfileResponse GetConfigurationProfile(GetConfigurationProfileRequest request)
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


        /// <summary>
        /// Retrieves information about a configuration deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
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
        public virtual GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
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


        /// <summary>
        /// Retrieves information about a deployment strategy. A deployment strategy defines important
        /// criteria for rolling out your configuration to the designated targets. A deployment
        /// strategy includes the overall duration required, a percentage of targets to receive
        /// the deployment during each interval, an algorithm that defines how percentage grows,
        /// and bake time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentStrategy service method.</param>
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
        public virtual GetDeploymentStrategyResponse GetDeploymentStrategy(GetDeploymentStrategyRequest request)
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


        /// <summary>
        /// Retrieves information about an environment. An environment is a deployment group of
        /// AppConfig applications, such as applications in a <c>Production</c> environment or
        /// in an <c>EU_Region</c> environment. Each configuration deployment targets an environment.
        /// You can enable one or more Amazon CloudWatch alarms for an environment. If an alarm
        /// is triggered during a deployment, AppConfig roles back the configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
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
        public virtual GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request)
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
        
        #region  GetExperimentDefinition


        /// <summary>
        /// Retrieves information about an experiment definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExperimentDefinition service method.</param>
        /// 
        /// <returns>The response from the GetExperimentDefinition service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetExperimentDefinition">REST API Reference for GetExperimentDefinition Operation</seealso>
        public virtual GetExperimentDefinitionResponse GetExperimentDefinition(GetExperimentDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExperimentDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExperimentDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetExperimentDefinitionResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about an experiment definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExperimentDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExperimentDefinition service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetExperimentDefinition">REST API Reference for GetExperimentDefinition Operation</seealso>
        public virtual Task<GetExperimentDefinitionResponse> GetExperimentDefinitionAsync(GetExperimentDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExperimentDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExperimentDefinitionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetExperimentDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetExperimentRun


        /// <summary>
        /// Retrieves information about an experiment run, including its status, start time, and
        /// exposure settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExperimentRun service method.</param>
        /// 
        /// <returns>The response from the GetExperimentRun service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetExperimentRun">REST API Reference for GetExperimentRun Operation</seealso>
        public virtual GetExperimentRunResponse GetExperimentRun(GetExperimentRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExperimentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExperimentRunResponseUnmarshaller.Instance;

            return Invoke<GetExperimentRunResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about an experiment run, including its status, start time, and
        /// exposure settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExperimentRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExperimentRun service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetExperimentRun">REST API Reference for GetExperimentRun Operation</seealso>
        public virtual Task<GetExperimentRunResponse> GetExperimentRunAsync(GetExperimentRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExperimentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExperimentRunResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetExperimentRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetExtension


        /// <summary>
        /// Returns information about an AppConfig extension.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExtension service method.</param>
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
        public virtual GetExtensionResponse GetExtension(GetExtensionRequest request)
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


        /// <summary>
        /// Returns information about an AppConfig extension association. For more information
        /// about extensions and associations, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Extending
        /// workflows</a> in the <i>AppConfig User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExtensionAssociation service method.</param>
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
        public virtual GetExtensionAssociationResponse GetExtensionAssociation(GetExtensionAssociationRequest request)
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


        /// <summary>
        /// Retrieves information about a specific configuration version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostedConfigurationVersion service method.</param>
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
        public virtual GetHostedConfigurationVersionResponse GetHostedConfigurationVersion(GetHostedConfigurationVersionRequest request)
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


        /// <summary>
        /// Lists all applications in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
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


        /// <summary>
        /// Lists the configuration profiles for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationProfiles service method.</param>
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
        public virtual ListConfigurationProfilesResponse ListConfigurationProfiles(ListConfigurationProfilesRequest request)
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


        /// <summary>
        /// Lists the deployments for an environment in descending deployment number order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
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
        public virtual ListDeploymentsResponse ListDeployments(ListDeploymentsRequest request)
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


        /// <summary>
        /// Lists deployment strategies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentStrategies service method.</param>
        /// 
        /// <returns>The response from the ListDeploymentStrategies service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListDeploymentStrategies">REST API Reference for ListDeploymentStrategies Operation</seealso>
        public virtual ListDeploymentStrategiesResponse ListDeploymentStrategies(ListDeploymentStrategiesRequest request)
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


        /// <summary>
        /// Lists the environments for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
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
        public virtual ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request)
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
        
        #region  ListExperimentDefinitions


        /// <summary>
        /// Lists the experiment definitions for an account. You can filter results by application,
        /// configuration profile, environment, or status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperimentDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListExperimentDefinitions service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListExperimentDefinitions">REST API Reference for ListExperimentDefinitions Operation</seealso>
        public virtual ListExperimentDefinitionsResponse ListExperimentDefinitions(ListExperimentDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExperimentDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListExperimentDefinitionsResponse>(request, options);
        }


        /// <summary>
        /// Lists the experiment definitions for an account. You can filter results by application,
        /// configuration profile, environment, or status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperimentDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExperimentDefinitions service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListExperimentDefinitions">REST API Reference for ListExperimentDefinitions Operation</seealso>
        public virtual Task<ListExperimentDefinitionsResponse> ListExperimentDefinitionsAsync(ListExperimentDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExperimentDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentDefinitionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListExperimentDefinitionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListExperimentRunEvents


        /// <summary>
        /// Lists the events for a specified experiment run. Events provide a timeline of actions
        /// and state changes that occurred during the run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperimentRunEvents service method.</param>
        /// 
        /// <returns>The response from the ListExperimentRunEvents service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListExperimentRunEvents">REST API Reference for ListExperimentRunEvents Operation</seealso>
        public virtual ListExperimentRunEventsResponse ListExperimentRunEvents(ListExperimentRunEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExperimentRunEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentRunEventsResponseUnmarshaller.Instance;

            return Invoke<ListExperimentRunEventsResponse>(request, options);
        }


        /// <summary>
        /// Lists the events for a specified experiment run. Events provide a timeline of actions
        /// and state changes that occurred during the run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperimentRunEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExperimentRunEvents service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListExperimentRunEvents">REST API Reference for ListExperimentRunEvents Operation</seealso>
        public virtual Task<ListExperimentRunEventsResponse> ListExperimentRunEventsAsync(ListExperimentRunEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExperimentRunEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentRunEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListExperimentRunEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListExperimentRuns


        /// <summary>
        /// Lists the experiment runs for a specified experiment definition. You can filter by
        /// status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperimentRuns service method.</param>
        /// 
        /// <returns>The response from the ListExperimentRuns service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListExperimentRuns">REST API Reference for ListExperimentRuns Operation</seealso>
        public virtual ListExperimentRunsResponse ListExperimentRuns(ListExperimentRunsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExperimentRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentRunsResponseUnmarshaller.Instance;

            return Invoke<ListExperimentRunsResponse>(request, options);
        }


        /// <summary>
        /// Lists the experiment runs for a specified experiment definition. You can filter by
        /// status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperimentRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExperimentRuns service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListExperimentRuns">REST API Reference for ListExperimentRuns Operation</seealso>
        public virtual Task<ListExperimentRunsResponse> ListExperimentRunsAsync(ListExperimentRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExperimentRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentRunsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListExperimentRunsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListExtensionAssociations


        /// <summary>
        /// Lists all AppConfig extension associations in the account. For more information about
        /// extensions and associations, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Extending
        /// workflows</a> in the <i>AppConfig User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExtensionAssociations service method.</param>
        /// 
        /// <returns>The response from the ListExtensionAssociations service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListExtensionAssociations">REST API Reference for ListExtensionAssociations Operation</seealso>
        public virtual ListExtensionAssociationsResponse ListExtensionAssociations(ListExtensionAssociationsRequest request)
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


        /// <summary>
        /// Lists all custom and Amazon Web Services authored AppConfig extensions in the account.
        /// For more information about extensions, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Extending
        /// workflows</a> in the <i>AppConfig User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExtensions service method.</param>
        /// 
        /// <returns>The response from the ListExtensions service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListExtensions">REST API Reference for ListExtensions Operation</seealso>
        public virtual ListExtensionsResponse ListExtensions(ListExtensionsRequest request)
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


        /// <summary>
        /// Lists configurations stored in the AppConfig hosted configuration store by version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostedConfigurationVersions service method.</param>
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
        public virtual ListHostedConfigurationVersionsResponse ListHostedConfigurationVersions(ListHostedConfigurationVersionsRequest request)
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


        /// <summary>
        /// Retrieves the list of key-value tags assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
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


        /// <summary>
        /// Starts a deployment.
        /// 
        ///  <note> 
        /// <para>
        /// AppConfig Agent supports deploying feature flag or free-form configuration data to
        /// specific segments or individual users during a gradual rollout. Entity-based gradual
        /// deployments ensure that once a user or segment receives a configuration version, they
        /// continue to receive that same version throughout the deployment period, regardless
        /// of which compute resource serves their requests. For more information, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-agent-how-to-use.html#appconfig-entity-based-gradual-deployments">Using
        /// AppConfig Agent for user-based or entity-based gradual deployments</a> 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDeployment service method.</param>
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
        public virtual StartDeploymentResponse StartDeployment(StartDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDeploymentResponseUnmarshaller.Instance;

            return Invoke<StartDeploymentResponse>(request, options);
        }


        /// <summary>
        /// Starts a deployment.
        /// 
        ///  <note> 
        /// <para>
        /// AppConfig Agent supports deploying feature flag or free-form configuration data to
        /// specific segments or individual users during a gradual rollout. Entity-based gradual
        /// deployments ensure that once a user or segment receives a configuration version, they
        /// continue to receive that same version throughout the deployment period, regardless
        /// of which compute resource serves their requests. For more information, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-agent-how-to-use.html#appconfig-entity-based-gradual-deployments">Using
        /// AppConfig Agent for user-based or entity-based gradual deployments</a> 
        /// </para>
        ///  </note>
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
        
        #region  StartExperimentRun


        /// <summary>
        /// Starts an experiment run for the specified experiment definition. An experiment run
        /// delivers treatments to the target audience and collects metrics. You can start multiple
        /// experiment runs from the same experiment definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExperimentRun service method.</param>
        /// 
        /// <returns>The response from the StartExperimentRun service method, as returned by AppConfig.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/StartExperimentRun">REST API Reference for StartExperimentRun Operation</seealso>
        public virtual StartExperimentRunResponse StartExperimentRun(StartExperimentRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartExperimentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExperimentRunResponseUnmarshaller.Instance;

            return Invoke<StartExperimentRunResponse>(request, options);
        }


        /// <summary>
        /// Starts an experiment run for the specified experiment definition. An experiment run
        /// delivers treatments to the target audience and collects metrics. You can start multiple
        /// experiment runs from the same experiment definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExperimentRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartExperimentRun service method, as returned by AppConfig.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/StartExperimentRun">REST API Reference for StartExperimentRun Operation</seealso>
        public virtual Task<StartExperimentRunResponse> StartExperimentRunAsync(StartExperimentRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartExperimentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExperimentRunResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartExperimentRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopDeployment


        /// <summary>
        /// Stops a deployment. This API action works only on deployments that have a status of
        /// <c>DEPLOYING</c>, unless an <c>AllowRevert</c> parameter is supplied. If the <c>AllowRevert</c>
        /// parameter is supplied, the status of an in-progress deployment will be <c>ROLLED_BACK</c>.
        /// The status of a completed deployment will be <c>REVERTED</c>. AppConfig only allows
        /// a revert within 72 hours of deployment completion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDeployment service method.</param>
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
        public virtual StopDeploymentResponse StopDeployment(StopDeploymentRequest request)
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
        
        #region  StopExperimentRun


        /// <summary>
        /// Stops a running experiment. Stopping an experiment run ends audience exposure and
        /// returns users to the currently deployed feature flag configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopExperimentRun service method.</param>
        /// 
        /// <returns>The response from the StopExperimentRun service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/StopExperimentRun">REST API Reference for StopExperimentRun Operation</seealso>
        public virtual StopExperimentRunResponse StopExperimentRun(StopExperimentRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopExperimentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopExperimentRunResponseUnmarshaller.Instance;

            return Invoke<StopExperimentRunResponse>(request, options);
        }


        /// <summary>
        /// Stops a running experiment. Stopping an experiment run ends audience exposure and
        /// returns users to the currently deployed feature flag configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopExperimentRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopExperimentRun service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/StopExperimentRun">REST API Reference for StopExperimentRun Operation</seealso>
        public virtual Task<StopExperimentRunResponse> StopExperimentRunAsync(StopExperimentRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopExperimentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopExperimentRunResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopExperimentRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns metadata to an AppConfig resource. Tags help organize and categorize your
        /// AppConfig resources. Each tag consists of a key and an optional value, both of which
        /// you define. You can specify a maximum of 50 tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
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


        /// <summary>
        /// Deletes a tag key and value from an AppConfig resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
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


        /// <summary>
        /// Updates the value of the <c>DeletionProtection</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountSettings service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        public virtual UpdateAccountSettingsResponse UpdateAccountSettings(UpdateAccountSettingsRequest request)
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


        /// <summary>
        /// Updates an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
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
        public virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
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


        /// <summary>
        /// Updates a configuration profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationProfile service method.</param>
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
        public virtual UpdateConfigurationProfileResponse UpdateConfigurationProfile(UpdateConfigurationProfileRequest request)
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


        /// <summary>
        /// Updates a deployment strategy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeploymentStrategy service method.</param>
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
        public virtual UpdateDeploymentStrategyResponse UpdateDeploymentStrategy(UpdateDeploymentStrategyRequest request)
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


        /// <summary>
        /// Updates an environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
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
        public virtual UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
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
        
        #region  UpdateExperimentDefinition


        /// <summary>
        /// Updates an experiment definition. You can update treatments, the control, audience
        /// rules, and other properties. You cannot update an experiment definition while an experiment
        /// run is active.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperimentDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateExperimentDefinition service method, as returned by AppConfig.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateExperimentDefinition">REST API Reference for UpdateExperimentDefinition Operation</seealso>
        public virtual UpdateExperimentDefinitionResponse UpdateExperimentDefinition(UpdateExperimentDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExperimentDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExperimentDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateExperimentDefinitionResponse>(request, options);
        }


        /// <summary>
        /// Updates an experiment definition. You can update treatments, the control, audience
        /// rules, and other properties. You cannot update an experiment definition while an experiment
        /// run is active.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperimentDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateExperimentDefinition service method, as returned by AppConfig.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateExperimentDefinition">REST API Reference for UpdateExperimentDefinition Operation</seealso>
        public virtual Task<UpdateExperimentDefinitionResponse> UpdateExperimentDefinitionAsync(UpdateExperimentDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExperimentDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExperimentDefinitionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateExperimentDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateExperimentRun


        /// <summary>
        /// Updates a running experiment. Use this operation to increase audience exposure, modify
        /// treatment assignment overrides, or update the description of an active experiment
        /// run. Audience exposure can only be increased, not decreased.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperimentRun service method.</param>
        /// 
        /// <returns>The response from the UpdateExperimentRun service method, as returned by AppConfig.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateExperimentRun">REST API Reference for UpdateExperimentRun Operation</seealso>
        public virtual UpdateExperimentRunResponse UpdateExperimentRun(UpdateExperimentRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExperimentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExperimentRunResponseUnmarshaller.Instance;

            return Invoke<UpdateExperimentRunResponse>(request, options);
        }


        /// <summary>
        /// Updates a running experiment. Use this operation to increase audience exposure, modify
        /// treatment assignment overrides, or update the description of an active experiment
        /// run. Audience exposure can only be increased, not decreased.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperimentRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateExperimentRun service method, as returned by AppConfig.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateExperimentRun">REST API Reference for UpdateExperimentRun Operation</seealso>
        public virtual Task<UpdateExperimentRunResponse> UpdateExperimentRunAsync(UpdateExperimentRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExperimentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExperimentRunResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateExperimentRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateExtension


        /// <summary>
        /// Updates an AppConfig extension. For more information about extensions, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Extending
        /// workflows</a> in the <i>AppConfig User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExtension service method.</param>
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
        public virtual UpdateExtensionResponse UpdateExtension(UpdateExtensionRequest request)
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


        /// <summary>
        /// Updates an association. For more information about extensions and associations, see
        /// <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Extending
        /// workflows</a> in the <i>AppConfig User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExtensionAssociation service method.</param>
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
        public virtual UpdateExtensionAssociationResponse UpdateExtensionAssociation(UpdateExtensionAssociationRequest request)
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


        /// <summary>
        /// Uses the validators in a configuration profile to validate a configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateConfiguration service method.</param>
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
        public virtual ValidateConfigurationResponse ValidateConfiguration(ValidateConfigurationRequest request)
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
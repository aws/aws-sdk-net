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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AppConfig.Model;

namespace Amazon.AppConfig
{
    /// <summary>
    /// Interface for accessing AppConfig
    ///
    /// Use AppConfig, a capability of Amazon Web Services Systems Manager, to create, manage,
    /// and quickly deploy application configurations. AppConfig supports controlled deployments
    /// to applications of any size and includes built-in validation checks and monitoring.
    /// You can use AppConfig with applications hosted on Amazon EC2 instances, Lambda, containers,
    /// mobile applications, or IoT devices.
    /// 
    ///  
    /// <para>
    /// To prevent errors when deploying application configurations, especially for production
    /// systems where a simple typo could cause an unexpected outage, AppConfig includes validators.
    /// A validator provides a syntactic or semantic check to ensure that the configuration
    /// you want to deploy works as intended. To validate your application configuration data,
    /// you provide a schema or an Amazon Web Services Lambda function that runs against the
    /// configuration. The configuration deployment or update can only proceed when the configuration
    /// data is valid.
    /// </para>
    ///  
    /// <para>
    /// During a configuration deployment, AppConfig monitors the application to ensure that
    /// the deployment is successful. If the system encounters an error, AppConfig rolls back
    /// the change to minimize impact for your application users. You can configure a deployment
    /// strategy for each application or environment that includes deployment criteria, including
    /// velocity, bake time, and alarms to monitor. Similar to error monitoring, if a deployment
    /// triggers an alarm, AppConfig automatically rolls back to the previous version. 
    /// </para>
    ///  
    /// <para>
    /// AppConfig supports multiple use cases. Here are some examples:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Feature flags</b>: Use AppConfig to turn on new features that require a timely
    /// deployment, such as a product launch or announcement. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Application tuning</b>: Use AppConfig to carefully introduce changes to your application
    /// that can only be tested with production traffic.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Allow list</b>: Use AppConfig to allow premium subscribers to access paid content.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Operational issues</b>: Use AppConfig to reduce stress on your application when
    /// a dependency or other external factor impacts the system.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This reference is intended to be used with the <a href="http://docs.aws.amazon.com/appconfig/latest/userguide/what-is-appconfig.html">AppConfig
    /// User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonAppConfig : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAppConfigPaginatorFactory Paginators { get; }

        
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse CreateApplication(CreateApplicationRequest request);



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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateConfigurationProfile">REST API Reference for CreateConfigurationProfile Operation</seealso>
        CreateConfigurationProfileResponse CreateConfigurationProfile(CreateConfigurationProfileRequest request);



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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateConfigurationProfile">REST API Reference for CreateConfigurationProfile Operation</seealso>
        Task<CreateConfigurationProfileResponse> CreateConfigurationProfileAsync(CreateConfigurationProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateDeploymentStrategy">REST API Reference for CreateDeploymentStrategy Operation</seealso>
        CreateDeploymentStrategyResponse CreateDeploymentStrategy(CreateDeploymentStrategyRequest request);



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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateDeploymentStrategy">REST API Reference for CreateDeploymentStrategy Operation</seealso>
        Task<CreateDeploymentStrategyResponse> CreateDeploymentStrategyAsync(CreateDeploymentStrategyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateEnvironment


        /// <summary>
        /// Creates an environment. For each application, you define one or more environments.
        /// An environment is a deployment group of AppConfig targets, such as applications in
        /// a <code>Beta</code> or <code>Production</code> environment. You can also define environments
        /// for application subcomponents such as the <code>Web</code>, <code>Mobile</code> and
        /// <code>Back-end</code> components for your application. You can configure Amazon CloudWatch
        /// alarms for each environment. The system monitors alarms during a configuration deployment.
        /// If an alarm is triggered, the system rolls back the configuration.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request);



        /// <summary>
        /// Creates an environment. For each application, you define one or more environments.
        /// An environment is a deployment group of AppConfig targets, such as applications in
        /// a <code>Beta</code> or <code>Production</code> environment. You can also define environments
        /// for application subcomponents such as the <code>Web</code>, <code>Mobile</code> and
        /// <code>Back-end</code> components for your application. You can configure Amazon CloudWatch
        /// alarms for each environment. The system monitors alarms during a configuration deployment.
        /// If an alarm is triggered, the system rolls back the configuration.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// provided by AppConfig. For most use cases, to create your own extension, you must
        /// create an Lambda function to perform any computation and processing defined in the
        /// extension. For more information about extensions, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Working
        /// with AppConfig extensions</a> in the <i>AppConfig User Guide</i>.
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
        /// The number of hosted configuration versions exceeds the limit for the AppConfig hosted
        /// configuration store. Delete one or more versions and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateExtension">REST API Reference for CreateExtension Operation</seealso>
        CreateExtensionResponse CreateExtension(CreateExtensionRequest request);



        /// <summary>
        /// Creates an AppConfig extension. An extension augments your ability to inject logic
        /// or behavior at different points during the AppConfig workflow of creating or deploying
        /// a configuration.
        /// 
        ///  
        /// <para>
        /// You can create your own extensions or use the Amazon Web Services authored extensions
        /// provided by AppConfig. For most use cases, to create your own extension, you must
        /// create an Lambda function to perform any computation and processing defined in the
        /// extension. For more information about extensions, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Working
        /// with AppConfig extensions</a> in the <i>AppConfig User Guide</i>.
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
        /// The number of hosted configuration versions exceeds the limit for the AppConfig hosted
        /// configuration store. Delete one or more versions and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateExtension">REST API Reference for CreateExtension Operation</seealso>
        Task<CreateExtensionResponse> CreateExtensionAsync(CreateExtensionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateExtensionAssociation


        /// <summary>
        /// When you create an extension or configure an Amazon Web Services authored extension,
        /// you associate the extension with an AppConfig application, environment, or configuration
        /// profile. For example, you can choose to run the <code>AppConfig deployment events
        /// to Amazon SNS</code> Amazon Web Services authored extension and receive notifications
        /// on an Amazon SNS topic anytime a configuration deployment is started for a specific
        /// application. Defining which extension to associate with an AppConfig resource is called
        /// an <i>extension association</i>. An extension association is a specified relationship
        /// between an extension and an AppConfig resource, such as an application or a configuration
        /// profile. For more information about extensions and associations, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Working
        /// with AppConfig extensions</a> in the <i>AppConfig User Guide</i>.
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
        /// The number of hosted configuration versions exceeds the limit for the AppConfig hosted
        /// configuration store. Delete one or more versions and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateExtensionAssociation">REST API Reference for CreateExtensionAssociation Operation</seealso>
        CreateExtensionAssociationResponse CreateExtensionAssociation(CreateExtensionAssociationRequest request);



        /// <summary>
        /// When you create an extension or configure an Amazon Web Services authored extension,
        /// you associate the extension with an AppConfig application, environment, or configuration
        /// profile. For example, you can choose to run the <code>AppConfig deployment events
        /// to Amazon SNS</code> Amazon Web Services authored extension and receive notifications
        /// on an Amazon SNS topic anytime a configuration deployment is started for a specific
        /// application. Defining which extension to associate with an AppConfig resource is called
        /// an <i>extension association</i>. An extension association is a specified relationship
        /// between an extension and an AppConfig resource, such as an application or a configuration
        /// profile. For more information about extensions and associations, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Working
        /// with AppConfig extensions</a> in the <i>AppConfig User Guide</i>.
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
        /// The number of hosted configuration versions exceeds the limit for the AppConfig hosted
        /// configuration store. Delete one or more versions and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateExtensionAssociation">REST API Reference for CreateExtensionAssociation Operation</seealso>
        Task<CreateExtensionAssociationResponse> CreateExtensionAssociationAsync(CreateExtensionAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateHostedConfigurationVersion


        /// <summary>
        /// Creates a new configuration in the AppConfig hosted configuration store.
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
        /// The number of hosted configuration versions exceeds the limit for the AppConfig hosted
        /// configuration store. Delete one or more versions and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateHostedConfigurationVersion">REST API Reference for CreateHostedConfigurationVersion Operation</seealso>
        CreateHostedConfigurationVersionResponse CreateHostedConfigurationVersion(CreateHostedConfigurationVersionRequest request);



        /// <summary>
        /// Creates a new configuration in the AppConfig hosted configuration store.
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
        /// The number of hosted configuration versions exceeds the limit for the AppConfig hosted
        /// configuration store. Delete one or more versions and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateHostedConfigurationVersion">REST API Reference for CreateHostedConfigurationVersion Operation</seealso>
        Task<CreateHostedConfigurationVersionResponse> CreateHostedConfigurationVersionAsync(CreateHostedConfigurationVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteApplication


        /// <summary>
        /// Deletes an application. Deleting an application does not delete a configuration from
        /// a host.
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
        DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request);



        /// <summary>
        /// Deletes an application. Deleting an application does not delete a configuration from
        /// a host.
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
        Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConfigurationProfile


        /// <summary>
        /// Deletes a configuration profile. Deleting a configuration profile does not delete
        /// a configuration from a host.
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
        DeleteConfigurationProfileResponse DeleteConfigurationProfile(DeleteConfigurationProfileRequest request);



        /// <summary>
        /// Deletes a configuration profile. Deleting a configuration profile does not delete
        /// a configuration from a host.
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
        Task<DeleteConfigurationProfileResponse> DeleteConfigurationProfileAsync(DeleteConfigurationProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDeploymentStrategy


        /// <summary>
        /// Deletes a deployment strategy. Deleting a deployment strategy does not delete a configuration
        /// from a host.
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
        DeleteDeploymentStrategyResponse DeleteDeploymentStrategy(DeleteDeploymentStrategyRequest request);



        /// <summary>
        /// Deletes a deployment strategy. Deleting a deployment strategy does not delete a configuration
        /// from a host.
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
        Task<DeleteDeploymentStrategyResponse> DeleteDeploymentStrategyAsync(DeleteDeploymentStrategyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEnvironment


        /// <summary>
        /// Deletes an environment. Deleting an environment does not delete a configuration from
        /// a host.
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
        DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request);



        /// <summary>
        /// Deletes an environment. Deleting an environment does not delete a configuration from
        /// a host.
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
        Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteExtensionResponse DeleteExtension(DeleteExtensionRequest request);



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
        Task<DeleteExtensionResponse> DeleteExtensionAsync(DeleteExtensionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteExtensionAssociationResponse DeleteExtensionAssociation(DeleteExtensionAssociationRequest request);



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
        Task<DeleteExtensionAssociationResponse> DeleteExtensionAssociationAsync(DeleteExtensionAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteHostedConfigurationVersionResponse DeleteHostedConfigurationVersion(DeleteHostedConfigurationVersionRequest request);



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
        Task<DeleteHostedConfigurationVersionResponse> DeleteHostedConfigurationVersionAsync(DeleteHostedConfigurationVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetApplicationResponse GetApplication(GetApplicationRequest request);



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
        Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ///  <code>GetConfiguration</code> is a priced call. For more information, see <a href="https://aws.amazon.com/systems-manager/pricing/">Pricing</a>.
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
        GetConfigurationResponse GetConfiguration(GetConfigurationRequest request);



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
        ///  <code>GetConfiguration</code> is a priced call. For more information, see <a href="https://aws.amazon.com/systems-manager/pricing/">Pricing</a>.
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
        Task<GetConfigurationResponse> GetConfigurationAsync(GetConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetConfigurationProfileResponse GetConfigurationProfile(GetConfigurationProfileRequest request);



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
        Task<GetConfigurationProfileResponse> GetConfigurationProfileAsync(GetConfigurationProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetDeploymentResponse GetDeployment(GetDeploymentRequest request);



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
        Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetDeploymentStrategyResponse GetDeploymentStrategy(GetDeploymentStrategyRequest request);



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
        Task<GetDeploymentStrategyResponse> GetDeploymentStrategyAsync(GetDeploymentStrategyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEnvironment


        /// <summary>
        /// Retrieves information about an environment. An environment is a deployment group of
        /// AppConfig applications, such as applications in a <code>Production</code> environment
        /// or in an <code>EU_Region</code> environment. Each configuration deployment targets
        /// an environment. You can enable one or more Amazon CloudWatch alarms for an environment.
        /// If an alarm is triggered during a deployment, AppConfig roles back the configuration.
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
        GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request);



        /// <summary>
        /// Retrieves information about an environment. An environment is a deployment group of
        /// AppConfig applications, such as applications in a <code>Production</code> environment
        /// or in an <code>EU_Region</code> environment. Each configuration deployment targets
        /// an environment. You can enable one or more Amazon CloudWatch alarms for an environment.
        /// If an alarm is triggered during a deployment, AppConfig roles back the configuration.
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
        Task<GetEnvironmentResponse> GetEnvironmentAsync(GetEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetExtensionResponse GetExtension(GetExtensionRequest request);



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
        Task<GetExtensionResponse> GetExtensionAsync(GetExtensionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetExtensionAssociation


        /// <summary>
        /// Returns information about an AppConfig extension association. For more information
        /// about extensions and associations, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Working
        /// with AppConfig extensions</a> in the <i>AppConfig User Guide</i>.
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
        GetExtensionAssociationResponse GetExtensionAssociation(GetExtensionAssociationRequest request);



        /// <summary>
        /// Returns information about an AppConfig extension association. For more information
        /// about extensions and associations, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Working
        /// with AppConfig extensions</a> in the <i>AppConfig User Guide</i>.
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
        Task<GetExtensionAssociationResponse> GetExtensionAssociationAsync(GetExtensionAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetHostedConfigurationVersionResponse GetHostedConfigurationVersion(GetHostedConfigurationVersionRequest request);



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
        Task<GetHostedConfigurationVersionResponse> GetHostedConfigurationVersionAsync(GetHostedConfigurationVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListApplicationsResponse ListApplications(ListApplicationsRequest request);



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
        Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListConfigurationProfilesResponse ListConfigurationProfiles(ListConfigurationProfilesRequest request);



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
        Task<ListConfigurationProfilesResponse> ListConfigurationProfilesAsync(ListConfigurationProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListDeploymentsResponse ListDeployments(ListDeploymentsRequest request);



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
        Task<ListDeploymentsResponse> ListDeploymentsAsync(ListDeploymentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListDeploymentStrategiesResponse ListDeploymentStrategies(ListDeploymentStrategiesRequest request);



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
        Task<ListDeploymentStrategiesResponse> ListDeploymentStrategiesAsync(ListDeploymentStrategiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request);



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
        Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListExtensionAssociations


        /// <summary>
        /// Lists all AppConfig extension associations in the account. For more information about
        /// extensions and associations, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Working
        /// with AppConfig extensions</a> in the <i>AppConfig User Guide</i>.
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
        ListExtensionAssociationsResponse ListExtensionAssociations(ListExtensionAssociationsRequest request);



        /// <summary>
        /// Lists all AppConfig extension associations in the account. For more information about
        /// extensions and associations, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Working
        /// with AppConfig extensions</a> in the <i>AppConfig User Guide</i>.
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
        Task<ListExtensionAssociationsResponse> ListExtensionAssociationsAsync(ListExtensionAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListExtensions


        /// <summary>
        /// Lists all custom and Amazon Web Services authored AppConfig extensions in the account.
        /// For more information about extensions, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Working
        /// with AppConfig extensions</a> in the <i>AppConfig User Guide</i>.
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
        ListExtensionsResponse ListExtensions(ListExtensionsRequest request);



        /// <summary>
        /// Lists all custom and Amazon Web Services authored AppConfig extensions in the account.
        /// For more information about extensions, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Working
        /// with AppConfig extensions</a> in the <i>AppConfig User Guide</i>.
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
        Task<ListExtensionsResponse> ListExtensionsAsync(ListExtensionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListHostedConfigurationVersionsResponse ListHostedConfigurationVersions(ListHostedConfigurationVersionsRequest request);



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
        Task<ListHostedConfigurationVersionsResponse> ListHostedConfigurationVersionsAsync(ListHostedConfigurationVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartDeployment


        /// <summary>
        /// Starts a deployment.
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
        StartDeploymentResponse StartDeployment(StartDeploymentRequest request);



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
        Task<StartDeploymentResponse> StartDeploymentAsync(StartDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopDeployment


        /// <summary>
        /// Stops a deployment. This API action works only on deployments that have a status of
        /// <code>DEPLOYING</code>. This action moves the deployment to a status of <code>ROLLED_BACK</code>.
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
        StopDeploymentResponse StopDeployment(StopDeploymentRequest request);



        /// <summary>
        /// Stops a deployment. This API action works only on deployments that have a status of
        /// <code>DEPLOYING</code>. This action moves the deployment to a status of <code>ROLLED_BACK</code>.
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
        Task<StopDeploymentResponse> StopDeploymentAsync(StopDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        TagResourceResponse TagResource(TagResourceRequest request);



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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UntagResourceResponse UntagResource(UntagResourceRequest request);



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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request);



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
        Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateConfigurationProfileResponse UpdateConfigurationProfile(UpdateConfigurationProfileRequest request);



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
        Task<UpdateConfigurationProfileResponse> UpdateConfigurationProfileAsync(UpdateConfigurationProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateDeploymentStrategyResponse UpdateDeploymentStrategy(UpdateDeploymentStrategyRequest request);



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
        Task<UpdateDeploymentStrategyResponse> UpdateDeploymentStrategyAsync(UpdateDeploymentStrategyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request);



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
        Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateExtension


        /// <summary>
        /// Updates an AppConfig extension. For more information about extensions, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Working
        /// with AppConfig extensions</a> in the <i>AppConfig User Guide</i>.
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
        UpdateExtensionResponse UpdateExtension(UpdateExtensionRequest request);



        /// <summary>
        /// Updates an AppConfig extension. For more information about extensions, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Working
        /// with AppConfig extensions</a> in the <i>AppConfig User Guide</i>.
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
        Task<UpdateExtensionResponse> UpdateExtensionAsync(UpdateExtensionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateExtensionAssociation


        /// <summary>
        /// Updates an association. For more information about extensions and associations, see
        /// <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Working
        /// with AppConfig extensions</a> in the <i>AppConfig User Guide</i>.
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
        UpdateExtensionAssociationResponse UpdateExtensionAssociation(UpdateExtensionAssociationRequest request);



        /// <summary>
        /// Updates an association. For more information about extensions and associations, see
        /// <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Working
        /// with AppConfig extensions</a> in the <i>AppConfig User Guide</i>.
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
        Task<UpdateExtensionAssociationResponse> UpdateExtensionAssociationAsync(UpdateExtensionAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ValidateConfigurationResponse ValidateConfiguration(ValidateConfigurationRequest request);



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
        Task<ValidateConfigurationResponse> ValidateConfigurationAsync(ValidateConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
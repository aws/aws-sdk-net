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
    /// AWS AppConfig 
    /// <para>
    /// Use AWS AppConfig, a capability of AWS Systems Manager, to create, manage, and quickly
    /// deploy application configurations. AppConfig supports controlled deployments to applications
    /// of any size and includes built-in validation checks and monitoring. You can use AppConfig
    /// with applications hosted on Amazon EC2 instances, AWS Lambda, containers, mobile applications,
    /// or IoT devices.
    /// </para>
    ///  
    /// <para>
    /// To prevent errors when deploying application configurations, especially for production
    /// systems where a simple typo could cause an unexpected outage, AppConfig includes validators.
    /// A validator provides a syntactic or semantic check to ensure that the configuration
    /// you want to deploy works as intended. To validate your application configuration data,
    /// you provide a schema or a Lambda function that runs against the configuration. The
    /// configuration deployment or update can only proceed when the configuration data is
    /// valid.
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
    /// AppConfig supports multiple use cases. Here are some examples.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Application tuning</b>: Use AppConfig to carefully introduce changes to your application
    /// that can only be tested with production traffic.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Feature toggle</b>: Use AppConfig to turn on new features that require a timely
    /// deployment, such as a product launch or announcement. 
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
    /// This reference is intended to be used with the <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/appconfig.html">AWS
    /// AppConfig User Guide</a>.
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonAppConfig : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAppConfigPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateApplication



        /// <summary>
        /// An application in AppConfig is a logical unit of code that provides capabilities for
        /// your customers. For example, an application can be a microservice that runs on Amazon
        /// EC2 instances, a mobile application installed by your users, a serverless application
        /// using Amazon API Gateway and AWS Lambda, or any system you run on behalf of others.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateConfigurationProfile



        /// <summary>
        /// Information that enables AppConfig to access the configuration source. Valid configuration
        /// sources include Systems Manager (SSM) documents, SSM Parameter Store parameters, and
        /// Amazon S3 objects. A configuration profile includes the following information.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The Uri location of the configuration data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The AWS Identity and Access Management (IAM) role that provides access to the configuration
        /// data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A validator for the configuration data. Available validators include either a JSON
        /// Schema or an AWS Lambda function.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/appconfig-creating-configuration-and-profile.html">Create
        /// a Configuration and a Configuration Profile</a> in the <i>AWS AppConfig User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfigurationProfile service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateConfigurationProfile">REST API Reference for CreateConfigurationProfile Operation</seealso>
        Task<CreateConfigurationProfileResponse> CreateConfigurationProfileAsync(CreateConfigurationProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDeploymentStrategy



        /// <summary>
        /// A deployment strategy defines important criteria for rolling out your configuration
        /// to the designated targets. A deployment strategy includes: the overall duration required,
        /// a percentage of targets to receive the deployment during each interval, an algorithm
        /// that defines how percentage grows, and bake time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentStrategy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeploymentStrategy service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateDeploymentStrategy">REST API Reference for CreateDeploymentStrategy Operation</seealso>
        Task<CreateDeploymentStrategyResponse> CreateDeploymentStrategyAsync(CreateDeploymentStrategyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEnvironment



        /// <summary>
        /// For each application, you define one or more environments. An environment is a logical
        /// deployment group of AppConfig targets, such as applications in a <code>Beta</code>
        /// or <code>Production</code> environment. You can also define environments for application
        /// subcomponents such as the <code>Web</code>, <code>Mobile</code> and <code>Back-end</code>
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
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHostedConfigurationVersion



        /// <summary>
        /// Create a new configuration in the AppConfig configuration store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHostedConfigurationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHostedConfigurationVersion service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an AWS service.
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
        /// The number of hosted configuration versions exceeds the limit for the AppConfig configuration
        /// store. Delete one or more versions and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateHostedConfigurationVersion">REST API Reference for CreateHostedConfigurationVersion Operation</seealso>
        Task<CreateHostedConfigurationVersionResponse> CreateHostedConfigurationVersionAsync(CreateHostedConfigurationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApplication



        /// <summary>
        /// Delete an application. Deleting an application does not delete a configuration from
        /// a host.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteConfigurationProfile



        /// <summary>
        /// Delete a configuration profile. Deleting a configuration profile does not delete a
        /// configuration from a host.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfigurationProfile service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an AWS service.
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
        Task<DeleteConfigurationProfileResponse> DeleteConfigurationProfileAsync(DeleteConfigurationProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDeploymentStrategy



        /// <summary>
        /// Delete a deployment strategy. Deleting a deployment strategy does not delete a configuration
        /// from a host.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeploymentStrategy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDeploymentStrategy service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteDeploymentStrategy">REST API Reference for DeleteDeploymentStrategy Operation</seealso>
        Task<DeleteDeploymentStrategyResponse> DeleteDeploymentStrategyAsync(DeleteDeploymentStrategyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEnvironment



        /// <summary>
        /// Delete an environment. Deleting an environment does not delete a configuration from
        /// a host.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an AWS service.
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
        Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHostedConfigurationVersion



        /// <summary>
        /// Delete a version of a configuration from the AppConfig configuration store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostedConfigurationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHostedConfigurationVersion service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteHostedConfigurationVersion">REST API Reference for DeleteHostedConfigurationVersion Operation</seealso>
        Task<DeleteHostedConfigurationVersionResponse> DeleteHostedConfigurationVersionAsync(DeleteHostedConfigurationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApplication



        /// <summary>
        /// Retrieve information about an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetApplication">REST API Reference for GetApplication Operation</seealso>
        Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetConfiguration



        /// <summary>
        /// Receive information about a configuration.
        /// 
        ///  <important> 
        /// <para>
        /// AWS AppConfig uses the value of the <code>ClientConfigurationVersion</code> parameter
        /// to identify the configuration version on your clients. If you don’t send <code>ClientConfigurationVersion</code>
        /// with each call to <code>GetConfiguration</code>, your clients receive the current
        /// configuration. You are charged each time your clients receive a configuration.
        /// </para>
        ///  
        /// <para>
        /// To avoid excess charges, we recommend that you include the <code>ClientConfigurationVersion</code>
        /// value with every call to <code>GetConfiguration</code>. This value must be saved on
        /// your client. Subsequent calls to <code>GetConfiguration</code> must pass this value
        /// by using the <code>ClientConfigurationVersion</code> parameter. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfiguration service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        Task<GetConfigurationResponse> GetConfigurationAsync(GetConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetConfigurationProfile



        /// <summary>
        /// Retrieve information about a configuration profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfigurationProfile service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetConfigurationProfile">REST API Reference for GetConfigurationProfile Operation</seealso>
        Task<GetConfigurationProfileResponse> GetConfigurationProfileAsync(GetConfigurationProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDeployment



        /// <summary>
        /// Retrieve information about a configuration deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDeploymentStrategy



        /// <summary>
        /// Retrieve information about a deployment strategy. A deployment strategy defines important
        /// criteria for rolling out your configuration to the designated targets. A deployment
        /// strategy includes: the overall duration required, a percentage of targets to receive
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
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetDeploymentStrategy">REST API Reference for GetDeploymentStrategy Operation</seealso>
        Task<GetDeploymentStrategyResponse> GetDeploymentStrategyAsync(GetDeploymentStrategyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEnvironment



        /// <summary>
        /// Retrieve information about an environment. An environment is a logical deployment
        /// group of AppConfig applications, such as applications in a <code>Production</code>
        /// environment or in an <code>EU_Region</code> environment. Each configuration deployment
        /// targets an environment. You can enable one or more Amazon CloudWatch alarms for an
        /// environment. If an alarm is triggered during a deployment, AppConfig roles back the
        /// configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        Task<GetEnvironmentResponse> GetEnvironmentAsync(GetEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHostedConfigurationVersion



        /// <summary>
        /// Get information about a specific configuration version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostedConfigurationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHostedConfigurationVersion service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetHostedConfigurationVersion">REST API Reference for GetHostedConfigurationVersion Operation</seealso>
        Task<GetHostedConfigurationVersionResponse> GetHostedConfigurationVersionAsync(GetHostedConfigurationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApplications



        /// <summary>
        /// List all applications in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListApplications">REST API Reference for ListApplications Operation</seealso>
        Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListConfigurationProfiles



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
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListConfigurationProfiles">REST API Reference for ListConfigurationProfiles Operation</seealso>
        Task<ListConfigurationProfilesResponse> ListConfigurationProfilesAsync(ListConfigurationProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDeployments



        /// <summary>
        /// Lists the deployments for an environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        Task<ListDeploymentsResponse> ListDeploymentsAsync(ListDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDeploymentStrategies



        /// <summary>
        /// List deployment strategies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentStrategies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeploymentStrategies service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListDeploymentStrategies">REST API Reference for ListDeploymentStrategies Operation</seealso>
        Task<ListDeploymentStrategiesResponse> ListDeploymentStrategiesAsync(ListDeploymentStrategiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEnvironments



        /// <summary>
        /// List the environments for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHostedConfigurationVersions



        /// <summary>
        /// View a list of configurations stored in the AppConfig configuration store by version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostedConfigurationVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHostedConfigurationVersions service method, as returned by AppConfig.</returns>
        /// <exception cref="Amazon.AppConfig.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListHostedConfigurationVersions">REST API Reference for ListHostedConfigurationVersions Operation</seealso>
        Task<ListHostedConfigurationVersionsResponse> ListHostedConfigurationVersionsAsync(ListHostedConfigurationVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



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
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartDeployment



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
        /// The input fails to satisfy the constraints specified by an AWS service.
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
        Task<StartDeploymentResponse> StartDeploymentAsync(StartDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopDeployment



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
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/StopDeployment">REST API Reference for StopDeployment Operation</seealso>
        Task<StopDeploymentResponse> StopDeploymentAsync(StopDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Metadata to assign to an AppConfig resource. Tags help organize and categorize your
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
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



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
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApplication



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
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateConfigurationProfile



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
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateConfigurationProfile">REST API Reference for UpdateConfigurationProfile Operation</seealso>
        Task<UpdateConfigurationProfileResponse> UpdateConfigurationProfileAsync(UpdateConfigurationProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDeploymentStrategy



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
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateDeploymentStrategy">REST API Reference for UpdateDeploymentStrategy Operation</seealso>
        Task<UpdateDeploymentStrategyResponse> UpdateDeploymentStrategyAsync(UpdateDeploymentStrategyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEnvironment



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
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ValidateConfiguration



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
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.InternalServerException">
        /// There was an internal failure in the AppConfig service.
        /// </exception>
        /// <exception cref="Amazon.AppConfig.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ValidateConfiguration">REST API Reference for ValidateConfiguration Operation</seealso>
        Task<ValidateConfigurationResponse> ValidateConfigurationAsync(ValidateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
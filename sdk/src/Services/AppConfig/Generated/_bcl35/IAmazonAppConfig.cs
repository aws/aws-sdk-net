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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAppConfigPaginatorFactory Paginators { get; }
#endif


        
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
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        IAsyncResult BeginCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a  CreateApplicationResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateConfigurationProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationProfile operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfigurationProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateConfigurationProfile">REST API Reference for CreateConfigurationProfile Operation</seealso>
        IAsyncResult BeginCreateConfigurationProfile(CreateConfigurationProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfigurationProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfigurationProfile.</param>
        /// 
        /// <returns>Returns a  CreateConfigurationProfileResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateConfigurationProfile">REST API Reference for CreateConfigurationProfile Operation</seealso>
        CreateConfigurationProfileResponse EndCreateConfigurationProfile(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateDeploymentStrategy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentStrategy operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeploymentStrategy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateDeploymentStrategy">REST API Reference for CreateDeploymentStrategy Operation</seealso>
        IAsyncResult BeginCreateDeploymentStrategy(CreateDeploymentStrategyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeploymentStrategy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeploymentStrategy.</param>
        /// 
        /// <returns>Returns a  CreateDeploymentStrategyResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateDeploymentStrategy">REST API Reference for CreateDeploymentStrategy Operation</seealso>
        CreateDeploymentStrategyResponse EndCreateDeploymentStrategy(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        IAsyncResult BeginCreateEnvironment(CreateEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironment.</param>
        /// 
        /// <returns>Returns a  CreateEnvironmentResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        CreateEnvironmentResponse EndCreateEnvironment(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateExtension operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExtension operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateExtension
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateExtension">REST API Reference for CreateExtension Operation</seealso>
        IAsyncResult BeginCreateExtension(CreateExtensionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExtension operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExtension.</param>
        /// 
        /// <returns>Returns a  CreateExtensionResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateExtension">REST API Reference for CreateExtension Operation</seealso>
        CreateExtensionResponse EndCreateExtension(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateExtensionAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExtensionAssociation operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateExtensionAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateExtensionAssociation">REST API Reference for CreateExtensionAssociation Operation</seealso>
        IAsyncResult BeginCreateExtensionAssociation(CreateExtensionAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExtensionAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExtensionAssociation.</param>
        /// 
        /// <returns>Returns a  CreateExtensionAssociationResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateExtensionAssociation">REST API Reference for CreateExtensionAssociation Operation</seealso>
        CreateExtensionAssociationResponse EndCreateExtensionAssociation(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateHostedConfigurationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHostedConfigurationVersion operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHostedConfigurationVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateHostedConfigurationVersion">REST API Reference for CreateHostedConfigurationVersion Operation</seealso>
        IAsyncResult BeginCreateHostedConfigurationVersion(CreateHostedConfigurationVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHostedConfigurationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHostedConfigurationVersion.</param>
        /// 
        /// <returns>Returns a  CreateHostedConfigurationVersionResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/CreateHostedConfigurationVersion">REST API Reference for CreateHostedConfigurationVersion Operation</seealso>
        CreateHostedConfigurationVersionResponse EndCreateHostedConfigurationVersion(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        IAsyncResult BeginDeleteApplication(DeleteApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteConfigurationProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationProfile operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigurationProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteConfigurationProfile">REST API Reference for DeleteConfigurationProfile Operation</seealso>
        IAsyncResult BeginDeleteConfigurationProfile(DeleteConfigurationProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigurationProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationProfile.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationProfileResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteConfigurationProfile">REST API Reference for DeleteConfigurationProfile Operation</seealso>
        DeleteConfigurationProfileResponse EndDeleteConfigurationProfile(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteDeploymentStrategy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeploymentStrategy operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeploymentStrategy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteDeploymentStrategy">REST API Reference for DeleteDeploymentStrategy Operation</seealso>
        IAsyncResult BeginDeleteDeploymentStrategy(DeleteDeploymentStrategyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeploymentStrategy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeploymentStrategy.</param>
        /// 
        /// <returns>Returns a  DeleteDeploymentStrategyResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteDeploymentStrategy">REST API Reference for DeleteDeploymentStrategy Operation</seealso>
        DeleteDeploymentStrategyResponse EndDeleteDeploymentStrategy(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        IAsyncResult BeginDeleteEnvironment(DeleteEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironment.</param>
        /// 
        /// <returns>Returns a  DeleteEnvironmentResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        DeleteEnvironmentResponse EndDeleteEnvironment(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteExtension operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteExtension operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteExtension
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteExtension">REST API Reference for DeleteExtension Operation</seealso>
        IAsyncResult BeginDeleteExtension(DeleteExtensionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteExtension operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteExtension.</param>
        /// 
        /// <returns>Returns a  DeleteExtensionResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteExtension">REST API Reference for DeleteExtension Operation</seealso>
        DeleteExtensionResponse EndDeleteExtension(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteExtensionAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteExtensionAssociation operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteExtensionAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteExtensionAssociation">REST API Reference for DeleteExtensionAssociation Operation</seealso>
        IAsyncResult BeginDeleteExtensionAssociation(DeleteExtensionAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteExtensionAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteExtensionAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteExtensionAssociationResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteExtensionAssociation">REST API Reference for DeleteExtensionAssociation Operation</seealso>
        DeleteExtensionAssociationResponse EndDeleteExtensionAssociation(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteHostedConfigurationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostedConfigurationVersion operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHostedConfigurationVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteHostedConfigurationVersion">REST API Reference for DeleteHostedConfigurationVersion Operation</seealso>
        IAsyncResult BeginDeleteHostedConfigurationVersion(DeleteHostedConfigurationVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHostedConfigurationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHostedConfigurationVersion.</param>
        /// 
        /// <returns>Returns a  DeleteHostedConfigurationVersionResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/DeleteHostedConfigurationVersion">REST API Reference for DeleteHostedConfigurationVersion Operation</seealso>
        DeleteHostedConfigurationVersionResponse EndDeleteHostedConfigurationVersion(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplication operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetApplication">REST API Reference for GetApplication Operation</seealso>
        IAsyncResult BeginGetApplication(GetApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplication.</param>
        /// 
        /// <returns>Returns a  GetApplicationResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetApplication">REST API Reference for GetApplication Operation</seealso>
        GetApplicationResponse EndGetApplication(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguration operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        [Obsolete("This API has been deprecated in favor of the GetLatestConfiguration API used in conjunction with StartConfigurationSession.")]
        IAsyncResult BeginGetConfiguration(GetConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfiguration.</param>
        /// 
        /// <returns>Returns a  GetConfigurationResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        [Obsolete("This API has been deprecated in favor of the GetLatestConfiguration API used in conjunction with StartConfigurationSession.")]
        GetConfigurationResponse EndGetConfiguration(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetConfigurationProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationProfile operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfigurationProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetConfigurationProfile">REST API Reference for GetConfigurationProfile Operation</seealso>
        IAsyncResult BeginGetConfigurationProfile(GetConfigurationProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfigurationProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfigurationProfile.</param>
        /// 
        /// <returns>Returns a  GetConfigurationProfileResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetConfigurationProfile">REST API Reference for GetConfigurationProfile Operation</seealso>
        GetConfigurationProfileResponse EndGetConfigurationProfile(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        IAsyncResult BeginGetDeployment(GetDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployment.</param>
        /// 
        /// <returns>Returns a  GetDeploymentResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        GetDeploymentResponse EndGetDeployment(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetDeploymentStrategy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentStrategy operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeploymentStrategy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetDeploymentStrategy">REST API Reference for GetDeploymentStrategy Operation</seealso>
        IAsyncResult BeginGetDeploymentStrategy(GetDeploymentStrategyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeploymentStrategy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeploymentStrategy.</param>
        /// 
        /// <returns>Returns a  GetDeploymentStrategyResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetDeploymentStrategy">REST API Reference for GetDeploymentStrategy Operation</seealso>
        GetDeploymentStrategyResponse EndGetDeploymentStrategy(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        IAsyncResult BeginGetEnvironment(GetEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnvironment.</param>
        /// 
        /// <returns>Returns a  GetEnvironmentResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        GetEnvironmentResponse EndGetEnvironment(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetExtension operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExtension operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExtension
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetExtension">REST API Reference for GetExtension Operation</seealso>
        IAsyncResult BeginGetExtension(GetExtensionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetExtension operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExtension.</param>
        /// 
        /// <returns>Returns a  GetExtensionResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetExtension">REST API Reference for GetExtension Operation</seealso>
        GetExtensionResponse EndGetExtension(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetExtensionAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExtensionAssociation operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExtensionAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetExtensionAssociation">REST API Reference for GetExtensionAssociation Operation</seealso>
        IAsyncResult BeginGetExtensionAssociation(GetExtensionAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetExtensionAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExtensionAssociation.</param>
        /// 
        /// <returns>Returns a  GetExtensionAssociationResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetExtensionAssociation">REST API Reference for GetExtensionAssociation Operation</seealso>
        GetExtensionAssociationResponse EndGetExtensionAssociation(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetHostedConfigurationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostedConfigurationVersion operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHostedConfigurationVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetHostedConfigurationVersion">REST API Reference for GetHostedConfigurationVersion Operation</seealso>
        IAsyncResult BeginGetHostedConfigurationVersion(GetHostedConfigurationVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetHostedConfigurationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHostedConfigurationVersion.</param>
        /// 
        /// <returns>Returns a  GetHostedConfigurationVersionResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/GetHostedConfigurationVersion">REST API Reference for GetHostedConfigurationVersion Operation</seealso>
        GetHostedConfigurationVersionResponse EndGetHostedConfigurationVersion(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListApplications">REST API Reference for ListApplications Operation</seealso>
        IAsyncResult BeginListApplications(ListApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplications.</param>
        /// 
        /// <returns>Returns a  ListApplicationsResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse EndListApplications(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListConfigurationProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationProfiles operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurationProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListConfigurationProfiles">REST API Reference for ListConfigurationProfiles Operation</seealso>
        IAsyncResult BeginListConfigurationProfiles(ListConfigurationProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurationProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurationProfiles.</param>
        /// 
        /// <returns>Returns a  ListConfigurationProfilesResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListConfigurationProfiles">REST API Reference for ListConfigurationProfiles Operation</seealso>
        ListConfigurationProfilesResponse EndListConfigurationProfiles(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeployments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        IAsyncResult BeginListDeployments(ListDeploymentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeployments.</param>
        /// 
        /// <returns>Returns a  ListDeploymentsResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        ListDeploymentsResponse EndListDeployments(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListDeploymentStrategies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentStrategies operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeploymentStrategies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListDeploymentStrategies">REST API Reference for ListDeploymentStrategies Operation</seealso>
        IAsyncResult BeginListDeploymentStrategies(ListDeploymentStrategiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeploymentStrategies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeploymentStrategies.</param>
        /// 
        /// <returns>Returns a  ListDeploymentStrategiesResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListDeploymentStrategies">REST API Reference for ListDeploymentStrategies Operation</seealso>
        ListDeploymentStrategiesResponse EndListDeploymentStrategies(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        IAsyncResult BeginListEnvironments(ListEnvironmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnvironments.</param>
        /// 
        /// <returns>Returns a  ListEnvironmentsResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        ListEnvironmentsResponse EndListEnvironments(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListExtensionAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExtensionAssociations operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExtensionAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListExtensionAssociations">REST API Reference for ListExtensionAssociations Operation</seealso>
        IAsyncResult BeginListExtensionAssociations(ListExtensionAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListExtensionAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExtensionAssociations.</param>
        /// 
        /// <returns>Returns a  ListExtensionAssociationsResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListExtensionAssociations">REST API Reference for ListExtensionAssociations Operation</seealso>
        ListExtensionAssociationsResponse EndListExtensionAssociations(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListExtensions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExtensions operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExtensions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListExtensions">REST API Reference for ListExtensions Operation</seealso>
        IAsyncResult BeginListExtensions(ListExtensionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListExtensions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExtensions.</param>
        /// 
        /// <returns>Returns a  ListExtensionsResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListExtensions">REST API Reference for ListExtensions Operation</seealso>
        ListExtensionsResponse EndListExtensions(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListHostedConfigurationVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHostedConfigurationVersions operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHostedConfigurationVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListHostedConfigurationVersions">REST API Reference for ListHostedConfigurationVersions Operation</seealso>
        IAsyncResult BeginListHostedConfigurationVersions(ListHostedConfigurationVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListHostedConfigurationVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHostedConfigurationVersions.</param>
        /// 
        /// <returns>Returns a  ListHostedConfigurationVersionsResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListHostedConfigurationVersions">REST API Reference for ListHostedConfigurationVersions Operation</seealso>
        ListHostedConfigurationVersionsResponse EndListHostedConfigurationVersions(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the StartDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDeployment operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/StartDeployment">REST API Reference for StartDeployment Operation</seealso>
        IAsyncResult BeginStartDeployment(StartDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDeployment.</param>
        /// 
        /// <returns>Returns a  StartDeploymentResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/StartDeployment">REST API Reference for StartDeployment Operation</seealso>
        StartDeploymentResponse EndStartDeployment(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the StopDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDeployment operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/StopDeployment">REST API Reference for StopDeployment Operation</seealso>
        IAsyncResult BeginStopDeployment(StopDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDeployment.</param>
        /// 
        /// <returns>Returns a  StopDeploymentResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/StopDeployment">REST API Reference for StopDeployment Operation</seealso>
        StopDeploymentResponse EndStopDeployment(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        IAsyncResult BeginUpdateApplication(UpdateApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplication.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateConfigurationProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationProfile operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfigurationProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateConfigurationProfile">REST API Reference for UpdateConfigurationProfile Operation</seealso>
        IAsyncResult BeginUpdateConfigurationProfile(UpdateConfigurationProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfigurationProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfigurationProfile.</param>
        /// 
        /// <returns>Returns a  UpdateConfigurationProfileResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateConfigurationProfile">REST API Reference for UpdateConfigurationProfile Operation</seealso>
        UpdateConfigurationProfileResponse EndUpdateConfigurationProfile(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateDeploymentStrategy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeploymentStrategy operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDeploymentStrategy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateDeploymentStrategy">REST API Reference for UpdateDeploymentStrategy Operation</seealso>
        IAsyncResult BeginUpdateDeploymentStrategy(UpdateDeploymentStrategyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDeploymentStrategy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDeploymentStrategy.</param>
        /// 
        /// <returns>Returns a  UpdateDeploymentStrategyResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateDeploymentStrategy">REST API Reference for UpdateDeploymentStrategy Operation</seealso>
        UpdateDeploymentStrategyResponse EndUpdateDeploymentStrategy(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        IAsyncResult BeginUpdateEnvironment(UpdateEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnvironment.</param>
        /// 
        /// <returns>Returns a  UpdateEnvironmentResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        UpdateEnvironmentResponse EndUpdateEnvironment(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateExtension operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateExtension operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateExtension
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateExtension">REST API Reference for UpdateExtension Operation</seealso>
        IAsyncResult BeginUpdateExtension(UpdateExtensionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateExtension operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateExtension.</param>
        /// 
        /// <returns>Returns a  UpdateExtensionResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateExtension">REST API Reference for UpdateExtension Operation</seealso>
        UpdateExtensionResponse EndUpdateExtension(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateExtensionAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateExtensionAssociation operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateExtensionAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateExtensionAssociation">REST API Reference for UpdateExtensionAssociation Operation</seealso>
        IAsyncResult BeginUpdateExtensionAssociation(UpdateExtensionAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateExtensionAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateExtensionAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateExtensionAssociationResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/UpdateExtensionAssociation">REST API Reference for UpdateExtensionAssociation Operation</seealso>
        UpdateExtensionAssociationResponse EndUpdateExtensionAssociation(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ValidateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateConfiguration operation on AmazonAppConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidateConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ValidateConfiguration">REST API Reference for ValidateConfiguration Operation</seealso>
        IAsyncResult BeginValidateConfiguration(ValidateConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ValidateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateConfiguration.</param>
        /// 
        /// <returns>Returns a  ValidateConfigurationResult from AppConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfig-2019-10-09/ValidateConfiguration">REST API Reference for ValidateConfiguration Operation</seealso>
        ValidateConfigurationResponse EndValidateConfiguration(IAsyncResult asyncResult);

        #endregion
        
    }
}
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ElasticBeanstalk.Model;

namespace Amazon.ElasticBeanstalk
{
    /// <summary>
    /// Interface for accessing ElasticBeanstalk
    ///
    /// AWS Elastic Beanstalk 
    /// <para>
    ///  This is the AWS Elastic Beanstalk API Reference. This guide provides detailed information
    /// about AWS Elastic Beanstalk actions, data types, parameters, and errors. 
    /// </para>
    ///  
    /// <para>
    /// AWS Elastic Beanstalk is a tool that makes it easy for you to create, deploy, and
    /// manage scalable, fault-tolerant applications running on Amazon Web Services cloud
    /// resources. 
    /// </para>
    ///  
    /// <para>
    ///  For more information about this product, go to the <a href="http://aws.amazon.com/elasticbeanstalk/">AWS
    /// Elastic Beanstalk</a> details page. The location of the latest AWS Elastic Beanstalk
    /// WSDL is <a href="http://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl">http://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// <b>Endpoints</b>
    /// </para>
    ///  
    /// <para>
    /// For a list of region-specific endpoints that AWS Elastic Beanstalk supports, go to
    /// <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elasticbeanstalk_region">Regions
    /// and Endpoints</a> in the <i>Amazon Web Services Glossary</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonElasticBeanstalk : IDisposable
    {

        
        #region  CheckDNSAvailability

        /// <summary>
        /// Checks if the specified CNAME is available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDNSAvailability service method.</param>
        /// 
        /// <returns>The response from the CheckDNSAvailability service method, as returned by ElasticBeanstalk.</returns>
        CheckDNSAvailabilityResponse CheckDNSAvailability(CheckDNSAvailabilityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CheckDNSAvailability operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckDNSAvailability operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CheckDNSAvailabilityResponse> CheckDNSAvailabilityAsync(CheckDNSAvailabilityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateApplication

        /// <summary>
        /// Creates an application that has one configuration template named <code>default</code>
        /// and no application versions. 
        /// 
        ///  <?oxy_delete author="brussard" timestamp="20131024T142047-0700" content="&lt;note&gt;
        /// The &lt;code&gt;default&lt;/code&gt; configuration template is for a 32-bit version
        /// of the Amazon Linux operating system running the Tomcat 6 application container. &lt;/note&gt;">
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="TooManyApplicationsException">
        /// The caller has exceeded the limit on the number of applications associated with their
        /// account.
        /// </exception>
        CreateApplicationResponse CreateApplication(CreateApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateApplicationVersion

        /// <summary>
        /// Creates an application version for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the CreateApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        /// <exception cref="S3LocationNotInServiceRegionException">
        /// The specified S3 bucket does not belong to the S3 region in which the service is running.
        /// </exception>
        /// <exception cref="TooManyApplicationsException">
        /// The caller has exceeded the limit on the number of applications associated with their
        /// account.
        /// </exception>
        /// <exception cref="TooManyApplicationVersionsException">
        /// The caller has exceeded the limit on the number of application versions associated
        /// with their account.
        /// </exception>
        CreateApplicationVersionResponse CreateApplicationVersion(CreateApplicationVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateApplicationVersionResponse> CreateApplicationVersionAsync(CreateApplicationVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateConfigurationTemplate

        /// <summary>
        /// Creates a configuration template. Templates are associated with a specific application
        /// and are used to deploy different versions of the application with the same configuration
        /// settings.
        /// 
        ///  
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> <a>DescribeConfigurationOptions</a> </li> <li> <a>DescribeConfigurationSettings</a>
        /// </li> <li> <a>ListAvailableSolutionStacks</a> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        /// <exception cref="TooManyConfigurationTemplatesException">
        /// The caller has exceeded the limit on the number of configuration templates associated
        /// with their account.
        /// </exception>
        CreateConfigurationTemplateResponse CreateConfigurationTemplate(CreateConfigurationTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateConfigurationTemplateResponse> CreateConfigurationTemplateAsync(CreateConfigurationTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateEnvironment

        /// <summary>
        /// Launches an environment for the specified application using the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        /// <exception cref="TooManyEnvironmentsException">
        /// The caller has exceeded the limit of allowed environments associated with the account.
        /// </exception>
        CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateStorageLocation

        /// <summary>
        /// Creates the Amazon S3 storage location for the account. 
        /// 
        ///  
        /// <para>
        ///  This location is used to store user log files. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the CreateStorageLocation service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        /// <exception cref="S3SubscriptionRequiredException">
        /// The caller does not have a subscription to Amazon S3.
        /// </exception>
        /// <exception cref="TooManyBucketsException">
        /// The web service attempted to create a bucket in an Amazon S3 account that already
        /// has 100 buckets.
        /// </exception>
        CreateStorageLocationResponse CreateStorageLocation();

        /// <summary>
        /// Creates the Amazon S3 storage location for the account. 
        /// 
        ///  
        /// <para>
        ///  This location is used to store user log files. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageLocation service method.</param>
        /// 
        /// <returns>The response from the CreateStorageLocation service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        /// <exception cref="S3SubscriptionRequiredException">
        /// The caller does not have a subscription to Amazon S3.
        /// </exception>
        /// <exception cref="TooManyBucketsException">
        /// The web service attempted to create a bucket in an Amazon S3 account that already
        /// has 100 buckets.
        /// </exception>
        CreateStorageLocationResponse CreateStorageLocation(CreateStorageLocationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStorageLocation operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageLocation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateStorageLocationResponse> CreateStorageLocationAsync(CreateStorageLocationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteApplication

        /// <summary>
        /// Deletes the specified application along with all associated versions and configurations.
        /// The application versions will not be deleted from your Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="OperationInProgressException">
        /// Unable to perform the specified operation because another operation is already in
        /// progress affecting an an element in this activity.
        /// </exception>
        DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteApplicationVersion

        /// <summary>
        /// Deletes the specified version from the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        /// <exception cref="OperationInProgressException">
        /// Unable to perform the specified operation because another operation is already in
        /// progress affecting an an element in this activity.
        /// </exception>
        /// <exception cref="S3LocationNotInServiceRegionException">
        /// The specified S3 bucket does not belong to the S3 region in which the service is running.
        /// </exception>
        /// <exception cref="SourceBundleDeletionException">
        /// Unable to delete the Amazon S3 source bundle associated with the application version,
        /// although the application version deleted successfully.
        /// </exception>
        DeleteApplicationVersionResponse DeleteApplicationVersion(DeleteApplicationVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteApplicationVersionResponse> DeleteApplicationVersionAsync(DeleteApplicationVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConfigurationTemplate

        /// <summary>
        /// Deletes the specified configuration template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="OperationInProgressException">
        /// Unable to perform the specified operation because another operation is already in
        /// progress affecting an an element in this activity.
        /// </exception>
        DeleteConfigurationTemplateResponse DeleteConfigurationTemplate(DeleteConfigurationTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteConfigurationTemplateResponse> DeleteConfigurationTemplateAsync(DeleteConfigurationTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEnvironmentConfiguration

        /// <summary>
        /// Deletes the draft configuration associated with the running environment. 
        /// 
        ///  
        /// <para>
        ///  Updating a running environment with any configuration changes creates a draft configuration
        /// set. You can get the draft configuration using <a>DescribeConfigurationSettings</a>
        /// while the update is in progress or if the update fails. The <code>DeploymentStatus</code>
        /// for the draft configuration indicates whether the deployment is in process or has
        /// failed. The draft configuration remains in existence until it is deleted with this
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironmentConfiguration service method, as returned by ElasticBeanstalk.</returns>
        DeleteEnvironmentConfigurationResponse DeleteEnvironmentConfiguration(DeleteEnvironmentConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironmentConfiguration operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteEnvironmentConfigurationResponse> DeleteEnvironmentConfigurationAsync(DeleteEnvironmentConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeApplications

        /// <summary>
        /// Returns the descriptions of existing applications.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by ElasticBeanstalk.</returns>
        DescribeApplicationsResponse DescribeApplications();

        /// <summary>
        /// Returns the descriptions of existing applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplications service method.</param>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by ElasticBeanstalk.</returns>
        DescribeApplicationsResponse DescribeApplications(DescribeApplicationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplications operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeApplicationsResponse> DescribeApplicationsAsync(DescribeApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeApplicationVersions

        /// <summary>
        /// Returns descriptions for existing application versions.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by ElasticBeanstalk.</returns>
        DescribeApplicationVersionsResponse DescribeApplicationVersions();

        /// <summary>
        /// Returns descriptions for existing application versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by ElasticBeanstalk.</returns>
        DescribeApplicationVersionsResponse DescribeApplicationVersions(DescribeApplicationVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationVersions operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeApplicationVersionsResponse> DescribeApplicationVersionsAsync(DescribeApplicationVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConfigurationOptions

        /// <summary>
        /// Describes the configuration options that are used in a particular configuration template
        /// or environment, or that a specified solution stack defines. The description includes
        /// the values the options, their default values, and an indication of the required action
        /// on a running environment if an option value is changed.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by ElasticBeanstalk.</returns>
        DescribeConfigurationOptionsResponse DescribeConfigurationOptions();

        /// <summary>
        /// Describes the configuration options that are used in a particular configuration template
        /// or environment, or that a specified solution stack defines. The description includes
        /// the values the options, their default values, and an indication of the required action
        /// on a running environment if an option value is changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by ElasticBeanstalk.</returns>
        DescribeConfigurationOptionsResponse DescribeConfigurationOptions(DescribeConfigurationOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationOptions operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeConfigurationOptionsResponse> DescribeConfigurationOptionsAsync(DescribeConfigurationOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConfigurationSettings

        /// <summary>
        /// Returns a description of the settings for the specified configuration set, that is,
        /// either a configuration template or the configuration set associated with a running
        /// environment. 
        /// 
        ///  
        /// <para>
        ///  When describing the settings for the configuration set associated with a running
        /// environment, it is possible to receive two sets of setting descriptions. One is the
        /// deployed configuration set, and the other is a draft configuration of an environment
        /// that is either in the process of deployment or that failed to deploy. 
        /// </para>
        ///  
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> <a>DeleteEnvironmentConfiguration</a> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationSettings service method, as returned by ElasticBeanstalk.</returns>
        DescribeConfigurationSettingsResponse DescribeConfigurationSettings(DescribeConfigurationSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationSettings operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeConfigurationSettingsResponse> DescribeConfigurationSettingsAsync(DescribeConfigurationSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEnvironmentResources

        /// <summary>
        /// Returns AWS resources for this environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentResources service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentResources service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        DescribeEnvironmentResourcesResponse DescribeEnvironmentResources(DescribeEnvironmentResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentResources operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEnvironmentResourcesResponse> DescribeEnvironmentResourcesAsync(DescribeEnvironmentResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEnvironments

        /// <summary>
        /// Returns descriptions for existing environments.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by ElasticBeanstalk.</returns>
        DescribeEnvironmentsResponse DescribeEnvironments();

        /// <summary>
        /// Returns descriptions for existing environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironments service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by ElasticBeanstalk.</returns>
        DescribeEnvironmentsResponse DescribeEnvironments(DescribeEnvironmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironments operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEnvironmentsResponse> DescribeEnvironmentsAsync(DescribeEnvironmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEvents

        /// <summary>
        /// Returns list of event descriptions matching criteria up to the last 6 weeks.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElasticBeanstalk.</returns>
        DescribeEventsResponse DescribeEvents();

        /// <summary>
        /// Returns list of event descriptions matching criteria up to the last 6 weeks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElasticBeanstalk.</returns>
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAvailableSolutionStacks

        /// <summary>
        /// Returns a list of the available solution stack names.
        /// </summary>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by ElasticBeanstalk.</returns>
        ListAvailableSolutionStacksResponse ListAvailableSolutionStacks();

        /// <summary>
        /// Returns a list of the available solution stack names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableSolutionStacks service method.</param>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by ElasticBeanstalk.</returns>
        ListAvailableSolutionStacksResponse ListAvailableSolutionStacks(ListAvailableSolutionStacksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableSolutionStacks operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableSolutionStacks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListAvailableSolutionStacksResponse> ListAvailableSolutionStacksAsync(ListAvailableSolutionStacksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RebuildEnvironment

        /// <summary>
        /// Deletes and recreates all of the AWS resources (for example: the Auto Scaling group,
        /// load balancer, etc.) for a specified environment and forces a restart.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebuildEnvironment service method.</param>
        /// 
        /// <returns>The response from the RebuildEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        RebuildEnvironmentResponse RebuildEnvironment(RebuildEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RebuildEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebuildEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RebuildEnvironmentResponse> RebuildEnvironmentAsync(RebuildEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RequestEnvironmentInfo

        /// <summary>
        /// Initiates a request to compile the specified type of information of the deployed
        /// environment. 
        /// 
        ///  
        /// <para>
        ///  Setting the <code>InfoType</code> to <code>tail</code> compiles the last lines from
        /// the application server log files of every Amazon EC2 instance in your environment.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Setting the <code>InfoType</code> to <code>bundle</code> compresses the application
        /// server log files for every Amazon EC2 instance into a <code>.zip</code> file. Legacy
        /// and .NET containers do not support bundle logs. 
        /// </para>
        ///  
        /// <para>
        ///  Use <a>RetrieveEnvironmentInfo</a> to obtain the set of logs. 
        /// </para>
        ///  
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> <a>RetrieveEnvironmentInfo</a> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestEnvironmentInfo service method.</param>
        /// 
        /// <returns>The response from the RequestEnvironmentInfo service method, as returned by ElasticBeanstalk.</returns>
        RequestEnvironmentInfoResponse RequestEnvironmentInfo(RequestEnvironmentInfoRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RequestEnvironmentInfo operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestEnvironmentInfo operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RequestEnvironmentInfoResponse> RequestEnvironmentInfoAsync(RequestEnvironmentInfoRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RestartAppServer

        /// <summary>
        /// Causes the environment to restart the application container server running on each
        /// Amazon EC2 instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestartAppServer service method.</param>
        /// 
        /// <returns>The response from the RestartAppServer service method, as returned by ElasticBeanstalk.</returns>
        RestartAppServerResponse RestartAppServer(RestartAppServerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RestartAppServer operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestartAppServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RestartAppServerResponse> RestartAppServerAsync(RestartAppServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RetrieveEnvironmentInfo

        /// <summary>
        /// Retrieves the compiled information from a <a>RequestEnvironmentInfo</a> request.
        /// 
        /// 
        ///  
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> <a>RequestEnvironmentInfo</a> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveEnvironmentInfo service method.</param>
        /// 
        /// <returns>The response from the RetrieveEnvironmentInfo service method, as returned by ElasticBeanstalk.</returns>
        RetrieveEnvironmentInfoResponse RetrieveEnvironmentInfo(RetrieveEnvironmentInfoRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveEnvironmentInfo operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveEnvironmentInfo operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RetrieveEnvironmentInfoResponse> RetrieveEnvironmentInfoAsync(RetrieveEnvironmentInfoRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SwapEnvironmentCNAMEs

        /// <summary>
        /// Swaps the CNAMEs of two environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs service method.</param>
        /// 
        /// <returns>The response from the SwapEnvironmentCNAMEs service method, as returned by ElasticBeanstalk.</returns>
        SwapEnvironmentCNAMEsResponse SwapEnvironmentCNAMEs(SwapEnvironmentCNAMEsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SwapEnvironmentCNAMEs operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SwapEnvironmentCNAMEsResponse> SwapEnvironmentCNAMEsAsync(SwapEnvironmentCNAMEsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TerminateEnvironment

        /// <summary>
        /// Terminates the specified environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateEnvironment service method.</param>
        /// 
        /// <returns>The response from the TerminateEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        TerminateEnvironmentResponse TerminateEnvironment(TerminateEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<TerminateEnvironmentResponse> TerminateEnvironmentAsync(TerminateEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateApplication

        /// <summary>
        /// Updates the specified application to have the specified properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by ElasticBeanstalk.</returns>
        UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateApplicationVersion

        /// <summary>
        /// Updates the specified application version to have the specified properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        UpdateApplicationVersionResponse UpdateApplicationVersion(UpdateApplicationVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateApplicationVersionResponse> UpdateApplicationVersionAsync(UpdateApplicationVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateConfigurationTemplate

        /// <summary>
        /// Updates the specified configuration template to have the specified properties or
        /// configuration option values. 
        /// 
        ///  
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> <a>DescribeConfigurationOptions</a> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        UpdateConfigurationTemplateResponse UpdateConfigurationTemplate(UpdateConfigurationTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateConfigurationTemplateResponse> UpdateConfigurationTemplateAsync(UpdateConfigurationTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEnvironment

        /// <summary>
        /// Updates the environment description, deploys a new application version, updates the
        /// configuration settings to an entirely new configuration template, or updates select
        /// configuration option values in the running environment. 
        /// 
        ///  
        /// <para>
        ///  Attempting to update both the release and configuration is not allowed and AWS Elastic
        /// Beanstalk returns an <code>InvalidParameterCombination</code> error. 
        /// </para>
        ///  
        /// <para>
        ///  When updating the configuration settings to a new template or individual settings,
        /// a draft configuration is created and <a>DescribeConfigurationSettings</a> for this
        /// environment returns two setting descriptions with different <code>DeploymentStatus</code>
        /// values. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ValidateConfigurationSettings

        /// <summary>
        /// Takes a set of configuration settings and either a configuration template or environment,
        /// and determines whether those values are valid. 
        /// 
        ///  
        /// <para>
        ///  This action returns a list of messages indicating any errors or warnings associated
        /// with the selection of option values. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateConfigurationSettings service method.</param>
        /// 
        /// <returns>The response from the ValidateConfigurationSettings service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        ValidateConfigurationSettingsResponse ValidateConfigurationSettings(ValidateConfigurationSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateConfigurationSettings operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateConfigurationSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ValidateConfigurationSettingsResponse> ValidateConfigurationSettingsAsync(ValidateConfigurationSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
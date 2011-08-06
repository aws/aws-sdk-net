/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.ElasticBeanstalk;
using Amazon.ElasticBeanstalk.Model;

namespace Amazon.ElasticBeanstalk
{
    /// <summary>
    /// Interface for accessing AmazonElasticBeanstalk.
    ///  
    ///  AWS Elastic Beanstalk <para> This is the AWS Elastic Beanstalk API Reference. This guide provides detailed information about AWS Elastic
    /// Beanstalk actions, data types, parameters, and errors. </para> <para>AWS Elastic Beanstalk is a tool that makes it easy for you to create,
    /// deploy, and manage scalable, fault-tolerant applications running on Amazon Web Services cloud resources. </para> <para> For more information
    /// about this product, go to the AWS Elastic Beanstalk details page. For specific information about setting up signatures and authorization
    /// through the API, go to the AWS Elastic Beanstalk User Guide. The location of the lastest AWS Elastic Beanstalk WSDL is
    /// http://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl. </para> <para> <b>Endpoints</b> </para> <para>AWS Elastic
    /// Beanstalk supports the following region-specific endpoint:</para>
    /// <ul>
    /// <li> https://elasticbeanstalk.us-east-1.amazonaws.com </li>
    /// 
    /// </ul>
    /// </summary>
    public interface AmazonElasticBeanstalk : IDisposable
    {
        

         /// <summary>
         /// <para> Checks if the specified CNAME is available. </para>
         /// </summary>
         /// 
         /// <param name="checkDNSAvailabilityRequest">Container for the necessary parameters to execute the CheckDNSAvailability service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the CheckDNSAvailability service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        CheckDNSAvailabilityResponse CheckDNSAvailability(CheckDNSAvailabilityRequest checkDNSAvailabilityRequest); 

         /// <summary>
         /// <para> Describes the configuration options that are used in a particular configuration template or environment, or that a specified solution
         /// stack defines. The description includes the values the options, their default values, and an indication of the required action on a running
         /// environment if an option value is changed. </para>
         /// </summary>
         /// 
         /// <param name="describeConfigurationOptionsRequest">Container for the necessary parameters to execute the DescribeConfigurationOptions service
         ///           method on AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the DescribeConfigurationOptions service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        DescribeConfigurationOptionsResponse DescribeConfigurationOptions(DescribeConfigurationOptionsRequest describeConfigurationOptionsRequest); 

         /// <summary>
         /// <para>Deletes the specified configuration template.</para> <para><b>NOTE:</b>When you launch an environment using a configuration template,
         /// the environment gets a copy of the template. You can delete or modify the environment's copy of the template without affecting the running
         /// environment.</para>
         /// </summary>
         /// 
         /// <param name="deleteConfigurationTemplateRequest">Container for the necessary parameters to execute the DeleteConfigurationTemplate service
         ///           method on AmazonElasticBeanstalk.</param>
         /// 
        DeleteConfigurationTemplateResponse DeleteConfigurationTemplate(DeleteConfigurationTemplateRequest deleteConfigurationTemplateRequest); 

         /// <summary>
         /// <para> Launches an environment for the specified application using the specified configuration. </para>
         /// </summary>
         /// 
         /// <param name="createEnvironmentRequest">Container for the necessary parameters to execute the CreateEnvironment service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the CreateEnvironment service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
         /// <exception cref="TooManyEnvironmentsException"/>
        CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest createEnvironmentRequest); 

         /// <summary>
         /// <para> Creates the Amazon S3 storage location for the account. </para> <para> This location is used to store user log files. </para>
         /// </summary>
         /// 
         /// <param name="createStorageLocationRequest">Container for the necessary parameters to execute the CreateStorageLocation service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the CreateStorageLocation service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
         /// <exception cref="S3SubscriptionRequiredException"/>
         /// <exception cref="TooManyBucketsException"/>
        CreateStorageLocationResponse CreateStorageLocation(CreateStorageLocationRequest createStorageLocationRequest); 

         /// <summary>
         /// <para> Initiates a request to compile the specified type of information of the deployed environment. </para> <para> Setting the
         /// <c>InfoType</c> to <c>tail</c> compiles the last lines from the application server log files of every Amazon EC2 instance in your
         /// environment. Use RetrieveEnvironmentInfo to access the compiled information. </para> <para>Related Topics</para>
         /// <ul>
         /// <li> RetrieveEnvironmentInfo </li>
         /// 
         /// </ul>
         /// </summary>
         /// 
         /// <param name="requestEnvironmentInfoRequest">Container for the necessary parameters to execute the RequestEnvironmentInfo service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
        RequestEnvironmentInfoResponse RequestEnvironmentInfo(RequestEnvironmentInfoRequest requestEnvironmentInfoRequest); 

         /// <summary>
         /// <para>Creates an application version for the specified application.</para> <para><b>NOTE:</b>Once you create an application version with a
         /// specified Amazon S3 bucket and key location, you cannot change that Amazon S3 location. If you change the Amazon S3 location, you receive an
         /// exception when you attempt to launch an environment from the application version. </para>
         /// </summary>
         /// 
         /// <param name="createApplicationVersionRequest">Container for the necessary parameters to execute the CreateApplicationVersion service method
         ///           on AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the CreateApplicationVersion service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
         /// <exception cref="TooManyApplicationsException"/>
         /// <exception cref="TooManyApplicationVersionsException"/>
        CreateApplicationVersionResponse CreateApplicationVersion(CreateApplicationVersionRequest createApplicationVersionRequest); 

         /// <summary>
         /// <para> Deletes the specified version from the specified application. </para> <para><b>NOTE:</b>You cannot delete an application version that
         /// is associated with a running environment.</para>
         /// </summary>
         /// 
         /// <param name="deleteApplicationVersionRequest">Container for the necessary parameters to execute the DeleteApplicationVersion service method
         ///           on AmazonElasticBeanstalk.</param>
         /// 
         /// <exception cref="SourceBundleDeletionException"/>
        DeleteApplicationVersionResponse DeleteApplicationVersion(DeleteApplicationVersionRequest deleteApplicationVersionRequest); 

         /// <summary>
         /// <para>Returns descriptions for existing application versions.</para>
         /// </summary>
         /// 
         /// <param name="describeApplicationVersionsRequest">Container for the necessary parameters to execute the DescribeApplicationVersions service
         ///           method on AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the DescribeApplicationVersions service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        DescribeApplicationVersionsResponse DescribeApplicationVersions(DescribeApplicationVersionsRequest describeApplicationVersionsRequest); 

         /// <summary>
         /// <para> Deletes the specified application along with all associated versions and configurations. </para> <para><b>NOTE:</b>You cannot delete
         /// an application that has a running environment. </para>
         /// </summary>
         /// 
         /// <param name="deleteApplicationRequest">Container for the necessary parameters to execute the DeleteApplication service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
        DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest deleteApplicationRequest); 

         /// <summary>
         /// <para> Updates the specified application version to have the specified properties. </para> <para><b>NOTE:</b> If a property (for example,
         /// description) is not provided, the value remains unchanged. To clear properties, specify an empty string. </para>
         /// </summary>
         /// 
         /// <param name="updateApplicationVersionRequest">Container for the necessary parameters to execute the UpdateApplicationVersion service method
         ///           on AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the UpdateApplicationVersion service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        UpdateApplicationVersionResponse UpdateApplicationVersion(UpdateApplicationVersionRequest updateApplicationVersionRequest); 

         /// <summary>
         /// <para> Creates an application that has one configuration template named <c>default</c> and no application versions. </para>
         /// <para><b>NOTE:</b> The default configuration template is for a 32-bit version of the Amazon Linux operating system running the Tomcat 6
         /// application container. </para>
         /// </summary>
         /// 
         /// <param name="createApplicationRequest">Container for the necessary parameters to execute the CreateApplication service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the CreateApplication service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
         /// <exception cref="TooManyApplicationsException"/>
        CreateApplicationResponse CreateApplication(CreateApplicationRequest createApplicationRequest); 

         /// <summary>
         /// </summary>
         /// 
         /// <param name="swapEnvironmentCNAMEsRequest">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
        SwapEnvironmentCNAMEsResponse SwapEnvironmentCNAMEs(SwapEnvironmentCNAMEsRequest swapEnvironmentCNAMEsRequest); 

         /// <summary>
         /// <para> Updates the specified configuration template to have the specified properties or configuration option values. </para>
         /// <para><b>NOTE:</b> If a property (for example, ApplicationName) is not provided, its value remains unchanged. To clear such properties,
         /// specify an empty string. </para> <para>Related Topics</para>
         /// <ul>
         /// <li> DescribeConfigurationOptions </li>
         /// 
         /// </ul>
         /// </summary>
         /// 
         /// <param name="updateConfigurationTemplateRequest">Container for the necessary parameters to execute the UpdateConfigurationTemplate service
         ///           method on AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the UpdateConfigurationTemplate service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        UpdateConfigurationTemplateResponse UpdateConfigurationTemplate(UpdateConfigurationTemplateRequest updateConfigurationTemplateRequest); 

         /// <summary>
         /// <para> Retrieves the compiled information from a RequestEnvironmentInfo request. </para> <para>Related Topics</para>
         /// <ul>
         /// <li> RequestEnvironmentInfo </li>
         /// 
         /// </ul>
         /// </summary>
         /// 
         /// <param name="retrieveEnvironmentInfoRequest">Container for the necessary parameters to execute the RetrieveEnvironmentInfo service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the RetrieveEnvironmentInfo service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        RetrieveEnvironmentInfoResponse RetrieveEnvironmentInfo(RetrieveEnvironmentInfoRequest retrieveEnvironmentInfoRequest); 

         /// <summary>
         /// <para> Returns a list of the available solution stack names. </para>
         /// </summary>
         /// 
         /// <param name="listAvailableSolutionStacksRequest">Container for the necessary parameters to execute the ListAvailableSolutionStacks service
         ///           method on AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        ListAvailableSolutionStacksResponse ListAvailableSolutionStacks(ListAvailableSolutionStacksRequest listAvailableSolutionStacksRequest); 

         /// <summary>
         /// <para>Updates the specified application to have the specified properties. </para> <para><b>NOTE:</b> If a property (for example,
         /// description) is not provided, the value remains unchanged. To clear these properties, specify an empty string. </para>
         /// </summary>
         /// 
         /// <param name="updateApplicationRequest">Container for the necessary parameters to execute the UpdateApplication service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the UpdateApplication service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest updateApplicationRequest); 

         /// <summary>
         /// <para>Returns descriptions for existing environments.</para>
         /// </summary>
         /// 
         /// <param name="describeEnvironmentsRequest">Container for the necessary parameters to execute the DescribeEnvironments service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the DescribeEnvironments service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        DescribeEnvironmentsResponse DescribeEnvironments(DescribeEnvironmentsRequest describeEnvironmentsRequest); 

         /// <summary>
         /// <para>Returns AWS resources for this environment.</para>
         /// </summary>
         /// 
         /// <param name="describeEnvironmentResourcesRequest">Container for the necessary parameters to execute the DescribeEnvironmentResources service
         ///           method on AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the DescribeEnvironmentResources service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        DescribeEnvironmentResourcesResponse DescribeEnvironmentResources(DescribeEnvironmentResourcesRequest describeEnvironmentResourcesRequest); 

         /// <summary>
         /// <para> Terminates the specified environment. </para>
         /// </summary>
         /// 
         /// <param name="terminateEnvironmentRequest">Container for the necessary parameters to execute the TerminateEnvironment service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the TerminateEnvironment service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        TerminateEnvironmentResponse TerminateEnvironment(TerminateEnvironmentRequest terminateEnvironmentRequest); 

         /// <summary>
         /// <para> Takes a set of configuration settings and either a configuration template or environment, and determines whether those values are
         /// valid. </para> <para> This action returns a list of messages indicating any errors or warnings associated with the selection of option
         /// values. </para>
         /// </summary>
         /// 
         /// <param name="validateConfigurationSettingsRequest">Container for the necessary parameters to execute the ValidateConfigurationSettings
         ///           service method on AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the ValidateConfigurationSettings service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        ValidateConfigurationSettingsResponse ValidateConfigurationSettings(ValidateConfigurationSettingsRequest validateConfigurationSettingsRequest); 

         /// <summary>
         /// <para> Causes the environment to restart the application container server running on each Amazon EC2 instance. </para>
         /// </summary>
         /// 
         /// <param name="restartAppServerRequest">Container for the necessary parameters to execute the RestartAppServer service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
        RestartAppServerResponse RestartAppServer(RestartAppServerRequest restartAppServerRequest); 

         /// <summary>
         /// <para> Deletes the draft configuration associated with the running environment. </para> <para> Updating a running environment with any
         /// configuration changes creates a draft configuration set. You can get the draft configuration using DescribeConfigurationSettings while the
         /// update is in progress or if the update fails. The <c>DeploymentStatus</c> for the draft configuration indicates whether the deployment is in
         /// process or has failed. The draft configuration remains in existence until it is deleted with this action. </para>
         /// </summary>
         /// 
         /// <param name="deleteEnvironmentConfigurationRequest">Container for the necessary parameters to execute the DeleteEnvironmentConfiguration
         ///           service method on AmazonElasticBeanstalk.</param>
         /// 
        DeleteEnvironmentConfigurationResponse DeleteEnvironmentConfiguration(DeleteEnvironmentConfigurationRequest deleteEnvironmentConfigurationRequest); 

         /// <summary>
         /// <para> Updates the environment description, deploys a new application version, updates the configuration settings to an entirely new
         /// configuration template, or updates select configuration option values in the running environment. </para> <para> Attempting to update both
         /// the release and configuration is not allowed and AWS Elastic Beanstalk returns an <c>InvalidParameterCombination</c> error. </para> <para>
         /// When updating the configuration settings to a new template or individual settings, a draft configuration is created and
         /// DescribeConfigurationSettings for this environment returns two setting descriptions with different <c>DeploymentStatus</c> values. </para>
         /// </summary>
         /// 
         /// <param name="updateEnvironmentRequest">Container for the necessary parameters to execute the UpdateEnvironment service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the UpdateEnvironment service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest updateEnvironmentRequest); 

         /// <summary>
         /// <para>Creates a configuration template. Templates are associated with a specific application and are used to deploy different versions of
         /// the application with the same configuration settings.</para> <para>Related Topics</para>
         /// <ul>
         /// <li> DescribeConfigurationOptions </li>
         /// <li> DescribeConfigurationSettings </li>
         /// <li> ListAvailableSolutionStacks </li>
         /// 
         /// </ul>
         /// </summary>
         /// 
         /// <param name="createConfigurationTemplateRequest">Container for the necessary parameters to execute the CreateConfigurationTemplate service
         ///           method on AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the CreateConfigurationTemplate service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
         /// <exception cref="TooManyConfigurationTemplatesException"/>
        CreateConfigurationTemplateResponse CreateConfigurationTemplate(CreateConfigurationTemplateRequest createConfigurationTemplateRequest); 

         /// <summary>
         /// <para> Returns a description of the settings for the specified configuration set, that is, either a configuration template or the
         /// configuration set associated with a running environment. </para> <para> When describing the settings for the configuration set associated
         /// with a running environment, it is possible to receive two sets of setting descriptions. One is the deployed configuration set, and the other
         /// is a draft configuration of an environment that is either in the process of deployment or that failed to deploy. </para> <para>Related
         /// Topics</para>
         /// <ul>
         /// <li> DeleteEnvironmentConfiguration </li>
         /// 
         /// </ul>
         /// </summary>
         /// 
         /// <param name="describeConfigurationSettingsRequest">Container for the necessary parameters to execute the DescribeConfigurationSettings
         ///           service method on AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the DescribeConfigurationSettings service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        DescribeConfigurationSettingsResponse DescribeConfigurationSettings(DescribeConfigurationSettingsRequest describeConfigurationSettingsRequest); 

         /// <summary>
         /// <para>Returns the descriptions of existing applications.</para>
         /// </summary>
         /// 
         /// <param name="describeApplicationsRequest">Container for the necessary parameters to execute the DescribeApplications service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the DescribeApplications service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        DescribeApplicationsResponse DescribeApplications(DescribeApplicationsRequest describeApplicationsRequest); 

         /// <summary>
         /// <para> Deletes and recreates all of the AWS resources (for example: the Auto Scaling group, load balancer, etc.) for a specified environment
         /// and forces a restart. </para>
         /// </summary>
         /// 
         /// <param name="rebuildEnvironmentRequest">Container for the necessary parameters to execute the RebuildEnvironment service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
        RebuildEnvironmentResponse RebuildEnvironment(RebuildEnvironmentRequest rebuildEnvironmentRequest); 

         /// <summary>
         /// <para>Returns list of event descriptions matching criteria up to the last 6 weeks.</para> <para><b>NOTE:</b> This action returns the most
         /// recent 1,000 events from the specified NextToken. </para>
         /// </summary>
         /// 
         /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the DescribeEvents service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest describeEventsRequest); 
    }
}
    

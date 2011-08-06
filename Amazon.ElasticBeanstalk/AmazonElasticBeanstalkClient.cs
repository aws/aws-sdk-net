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

using Amazon.ElasticBeanstalk.Model;
using Amazon.ElasticBeanstalk.Model.Transform;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.ElasticBeanstalk
{
    /// <summary>
    /// Implemenation for accessing AmazonElasticBeanstalk.
    ///  
    /// AWS Elastic Beanstalk <para> This is the AWS Elastic Beanstalk API Reference. This guide provides detailed information about AWS Elastic
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
    public class AmazonElasticBeanstalkClient : AmazonWebServiceClient, AmazonElasticBeanstalk
    {
    
    
        AbstractAWSSigner signer = new QueryStringSigner();

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticBeanstalkClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticBeanstalkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticBeanstalkClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticBeanstalkClient Configuration Object</param>
        public AmazonElasticBeanstalkClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticBeanstalkConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }
        
   

         /// <summary>
         /// <para> Checks if the specified CNAME is available. </para>
         /// </summary>
         /// 
         /// <param name="checkDNSAvailabilityRequest">Container for the necessary parameters to execute the CheckDNSAvailability service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the CheckDNSAvailability service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        public CheckDNSAvailabilityResponse CheckDNSAvailability(CheckDNSAvailabilityRequest checkDNSAvailabilityRequest) 
        {           
            IRequest<CheckDNSAvailabilityRequest> request = new CheckDNSAvailabilityRequestMarshaller().Marshall(checkDNSAvailabilityRequest);
            CheckDNSAvailabilityResponse response = Invoke<CheckDNSAvailabilityRequest, CheckDNSAvailabilityResponse> (request, this.signer, CheckDNSAvailabilityResponseUnmarshaller.GetInstance());
            return response;
        }
    

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
        public DescribeConfigurationOptionsResponse DescribeConfigurationOptions(DescribeConfigurationOptionsRequest describeConfigurationOptionsRequest) 
        {           
            IRequest<DescribeConfigurationOptionsRequest> request = new DescribeConfigurationOptionsRequestMarshaller().Marshall(describeConfigurationOptionsRequest);
            DescribeConfigurationOptionsResponse response = Invoke<DescribeConfigurationOptionsRequest, DescribeConfigurationOptionsResponse> (request, this.signer, DescribeConfigurationOptionsResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Deletes the specified configuration template.</para> <para><b>NOTE:</b>When you launch an environment using a configuration template,
         /// the environment gets a copy of the template. You can delete or modify the environment's copy of the template without affecting the running
         /// environment.</para>
         /// </summary>
         /// 
         /// <param name="deleteConfigurationTemplateRequest">Container for the necessary parameters to execute the DeleteConfigurationTemplate service
         ///           method on AmazonElasticBeanstalk.</param>
         /// 
        public DeleteConfigurationTemplateResponse DeleteConfigurationTemplate(DeleteConfigurationTemplateRequest deleteConfigurationTemplateRequest) 
        {           
            IRequest<DeleteConfigurationTemplateRequest> request = new DeleteConfigurationTemplateRequestMarshaller().Marshall(deleteConfigurationTemplateRequest);
            DeleteConfigurationTemplateResponse response = Invoke<DeleteConfigurationTemplateRequest, DeleteConfigurationTemplateResponse> (request, this.signer, DeleteConfigurationTemplateResponseUnmarshaller.GetInstance());
            return response;
        }
    

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
        public CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest createEnvironmentRequest) 
        {           
            IRequest<CreateEnvironmentRequest> request = new CreateEnvironmentRequestMarshaller().Marshall(createEnvironmentRequest);
            CreateEnvironmentResponse response = Invoke<CreateEnvironmentRequest, CreateEnvironmentResponse> (request, this.signer, CreateEnvironmentResponseUnmarshaller.GetInstance());
            return response;
        }
    

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
        public CreateStorageLocationResponse CreateStorageLocation(CreateStorageLocationRequest createStorageLocationRequest) 
        {           
            IRequest<CreateStorageLocationRequest> request = new CreateStorageLocationRequestMarshaller().Marshall(createStorageLocationRequest);
            CreateStorageLocationResponse response = Invoke<CreateStorageLocationRequest, CreateStorageLocationResponse> (request, this.signer, CreateStorageLocationResponseUnmarshaller.GetInstance());
            return response;
        }
    

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
        public RequestEnvironmentInfoResponse RequestEnvironmentInfo(RequestEnvironmentInfoRequest requestEnvironmentInfoRequest) 
        {           
            IRequest<RequestEnvironmentInfoRequest> request = new RequestEnvironmentInfoRequestMarshaller().Marshall(requestEnvironmentInfoRequest);
            RequestEnvironmentInfoResponse response = Invoke<RequestEnvironmentInfoRequest, RequestEnvironmentInfoResponse> (request, this.signer, RequestEnvironmentInfoResponseUnmarshaller.GetInstance());
            return response;
        }
    

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
        public CreateApplicationVersionResponse CreateApplicationVersion(CreateApplicationVersionRequest createApplicationVersionRequest) 
        {           
            IRequest<CreateApplicationVersionRequest> request = new CreateApplicationVersionRequestMarshaller().Marshall(createApplicationVersionRequest);
            CreateApplicationVersionResponse response = Invoke<CreateApplicationVersionRequest, CreateApplicationVersionResponse> (request, this.signer, CreateApplicationVersionResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Deletes the specified version from the specified application. </para> <para><b>NOTE:</b>You cannot delete an application version that
         /// is associated with a running environment.</para>
         /// </summary>
         /// 
         /// <param name="deleteApplicationVersionRequest">Container for the necessary parameters to execute the DeleteApplicationVersion service method
         ///           on AmazonElasticBeanstalk.</param>
         /// 
         /// <exception cref="SourceBundleDeletionException"/>
        public DeleteApplicationVersionResponse DeleteApplicationVersion(DeleteApplicationVersionRequest deleteApplicationVersionRequest) 
        {           
            IRequest<DeleteApplicationVersionRequest> request = new DeleteApplicationVersionRequestMarshaller().Marshall(deleteApplicationVersionRequest);
            DeleteApplicationVersionResponse response = Invoke<DeleteApplicationVersionRequest, DeleteApplicationVersionResponse> (request, this.signer, DeleteApplicationVersionResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Returns descriptions for existing application versions.</para>
         /// </summary>
         /// 
         /// <param name="describeApplicationVersionsRequest">Container for the necessary parameters to execute the DescribeApplicationVersions service
         ///           method on AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the DescribeApplicationVersions service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        public DescribeApplicationVersionsResponse DescribeApplicationVersions(DescribeApplicationVersionsRequest describeApplicationVersionsRequest) 
        {           
            IRequest<DescribeApplicationVersionsRequest> request = new DescribeApplicationVersionsRequestMarshaller().Marshall(describeApplicationVersionsRequest);
            DescribeApplicationVersionsResponse response = Invoke<DescribeApplicationVersionsRequest, DescribeApplicationVersionsResponse> (request, this.signer, DescribeApplicationVersionsResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Deletes the specified application along with all associated versions and configurations. </para> <para><b>NOTE:</b>You cannot delete
         /// an application that has a running environment. </para>
         /// </summary>
         /// 
         /// <param name="deleteApplicationRequest">Container for the necessary parameters to execute the DeleteApplication service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest deleteApplicationRequest) 
        {           
            IRequest<DeleteApplicationRequest> request = new DeleteApplicationRequestMarshaller().Marshall(deleteApplicationRequest);
            DeleteApplicationResponse response = Invoke<DeleteApplicationRequest, DeleteApplicationResponse> (request, this.signer, DeleteApplicationResponseUnmarshaller.GetInstance());
            return response;
        }
    

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
        public UpdateApplicationVersionResponse UpdateApplicationVersion(UpdateApplicationVersionRequest updateApplicationVersionRequest) 
        {           
            IRequest<UpdateApplicationVersionRequest> request = new UpdateApplicationVersionRequestMarshaller().Marshall(updateApplicationVersionRequest);
            UpdateApplicationVersionResponse response = Invoke<UpdateApplicationVersionRequest, UpdateApplicationVersionResponse> (request, this.signer, UpdateApplicationVersionResponseUnmarshaller.GetInstance());
            return response;
        }
    

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
        public CreateApplicationResponse CreateApplication(CreateApplicationRequest createApplicationRequest) 
        {           
            IRequest<CreateApplicationRequest> request = new CreateApplicationRequestMarshaller().Marshall(createApplicationRequest);
            CreateApplicationResponse response = Invoke<CreateApplicationRequest, CreateApplicationResponse> (request, this.signer, CreateApplicationResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// </summary>
         /// 
         /// <param name="swapEnvironmentCNAMEsRequest">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
        public SwapEnvironmentCNAMEsResponse SwapEnvironmentCNAMEs(SwapEnvironmentCNAMEsRequest swapEnvironmentCNAMEsRequest) 
        {           
            IRequest<SwapEnvironmentCNAMEsRequest> request = new SwapEnvironmentCNAMEsRequestMarshaller().Marshall(swapEnvironmentCNAMEsRequest);
            SwapEnvironmentCNAMEsResponse response = Invoke<SwapEnvironmentCNAMEsRequest, SwapEnvironmentCNAMEsResponse> (request, this.signer, SwapEnvironmentCNAMEsResponseUnmarshaller.GetInstance());
            return response;
        }
    

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
        public UpdateConfigurationTemplateResponse UpdateConfigurationTemplate(UpdateConfigurationTemplateRequest updateConfigurationTemplateRequest) 
        {           
            IRequest<UpdateConfigurationTemplateRequest> request = new UpdateConfigurationTemplateRequestMarshaller().Marshall(updateConfigurationTemplateRequest);
            UpdateConfigurationTemplateResponse response = Invoke<UpdateConfigurationTemplateRequest, UpdateConfigurationTemplateResponse> (request, this.signer, UpdateConfigurationTemplateResponseUnmarshaller.GetInstance());
            return response;
        }
    

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
        public RetrieveEnvironmentInfoResponse RetrieveEnvironmentInfo(RetrieveEnvironmentInfoRequest retrieveEnvironmentInfoRequest) 
        {           
            IRequest<RetrieveEnvironmentInfoRequest> request = new RetrieveEnvironmentInfoRequestMarshaller().Marshall(retrieveEnvironmentInfoRequest);
            RetrieveEnvironmentInfoResponse response = Invoke<RetrieveEnvironmentInfoRequest, RetrieveEnvironmentInfoResponse> (request, this.signer, RetrieveEnvironmentInfoResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Returns a list of the available solution stack names. </para>
         /// </summary>
         /// 
         /// <param name="listAvailableSolutionStacksRequest">Container for the necessary parameters to execute the ListAvailableSolutionStacks service
         ///           method on AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        public ListAvailableSolutionStacksResponse ListAvailableSolutionStacks(ListAvailableSolutionStacksRequest listAvailableSolutionStacksRequest) 
        {           
            IRequest<ListAvailableSolutionStacksRequest> request = new ListAvailableSolutionStacksRequestMarshaller().Marshall(listAvailableSolutionStacksRequest);
            ListAvailableSolutionStacksResponse response = Invoke<ListAvailableSolutionStacksRequest, ListAvailableSolutionStacksResponse> (request, this.signer, ListAvailableSolutionStacksResponseUnmarshaller.GetInstance());
            return response;
        }
    

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
        public UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest updateApplicationRequest) 
        {           
            IRequest<UpdateApplicationRequest> request = new UpdateApplicationRequestMarshaller().Marshall(updateApplicationRequest);
            UpdateApplicationResponse response = Invoke<UpdateApplicationRequest, UpdateApplicationResponse> (request, this.signer, UpdateApplicationResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Returns descriptions for existing environments.</para>
         /// </summary>
         /// 
         /// <param name="describeEnvironmentsRequest">Container for the necessary parameters to execute the DescribeEnvironments service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the DescribeEnvironments service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        public DescribeEnvironmentsResponse DescribeEnvironments(DescribeEnvironmentsRequest describeEnvironmentsRequest) 
        {           
            IRequest<DescribeEnvironmentsRequest> request = new DescribeEnvironmentsRequestMarshaller().Marshall(describeEnvironmentsRequest);
            DescribeEnvironmentsResponse response = Invoke<DescribeEnvironmentsRequest, DescribeEnvironmentsResponse> (request, this.signer, DescribeEnvironmentsResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Returns AWS resources for this environment.</para>
         /// </summary>
         /// 
         /// <param name="describeEnvironmentResourcesRequest">Container for the necessary parameters to execute the DescribeEnvironmentResources service
         ///           method on AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the DescribeEnvironmentResources service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        public DescribeEnvironmentResourcesResponse DescribeEnvironmentResources(DescribeEnvironmentResourcesRequest describeEnvironmentResourcesRequest) 
        {           
            IRequest<DescribeEnvironmentResourcesRequest> request = new DescribeEnvironmentResourcesRequestMarshaller().Marshall(describeEnvironmentResourcesRequest);
            DescribeEnvironmentResourcesResponse response = Invoke<DescribeEnvironmentResourcesRequest, DescribeEnvironmentResourcesResponse> (request, this.signer, DescribeEnvironmentResourcesResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Terminates the specified environment. </para>
         /// </summary>
         /// 
         /// <param name="terminateEnvironmentRequest">Container for the necessary parameters to execute the TerminateEnvironment service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the TerminateEnvironment service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        public TerminateEnvironmentResponse TerminateEnvironment(TerminateEnvironmentRequest terminateEnvironmentRequest) 
        {           
            IRequest<TerminateEnvironmentRequest> request = new TerminateEnvironmentRequestMarshaller().Marshall(terminateEnvironmentRequest);
            TerminateEnvironmentResponse response = Invoke<TerminateEnvironmentRequest, TerminateEnvironmentResponse> (request, this.signer, TerminateEnvironmentResponseUnmarshaller.GetInstance());
            return response;
        }
    

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
        public ValidateConfigurationSettingsResponse ValidateConfigurationSettings(ValidateConfigurationSettingsRequest validateConfigurationSettingsRequest) 
        {           
            IRequest<ValidateConfigurationSettingsRequest> request = new ValidateConfigurationSettingsRequestMarshaller().Marshall(validateConfigurationSettingsRequest);
            ValidateConfigurationSettingsResponse response = Invoke<ValidateConfigurationSettingsRequest, ValidateConfigurationSettingsResponse> (request, this.signer, ValidateConfigurationSettingsResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Causes the environment to restart the application container server running on each Amazon EC2 instance. </para>
         /// </summary>
         /// 
         /// <param name="restartAppServerRequest">Container for the necessary parameters to execute the RestartAppServer service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
        public RestartAppServerResponse RestartAppServer(RestartAppServerRequest restartAppServerRequest) 
        {           
            IRequest<RestartAppServerRequest> request = new RestartAppServerRequestMarshaller().Marshall(restartAppServerRequest);
            RestartAppServerResponse response = Invoke<RestartAppServerRequest, RestartAppServerResponse> (request, this.signer, RestartAppServerResponseUnmarshaller.GetInstance());
            return response;
        }
    

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
        public DeleteEnvironmentConfigurationResponse DeleteEnvironmentConfiguration(DeleteEnvironmentConfigurationRequest deleteEnvironmentConfigurationRequest) 
        {           
            IRequest<DeleteEnvironmentConfigurationRequest> request = new DeleteEnvironmentConfigurationRequestMarshaller().Marshall(deleteEnvironmentConfigurationRequest);
            DeleteEnvironmentConfigurationResponse response = Invoke<DeleteEnvironmentConfigurationRequest, DeleteEnvironmentConfigurationResponse> (request, this.signer, DeleteEnvironmentConfigurationResponseUnmarshaller.GetInstance());
            return response;
        }
    

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
        public UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest updateEnvironmentRequest) 
        {           
            IRequest<UpdateEnvironmentRequest> request = new UpdateEnvironmentRequestMarshaller().Marshall(updateEnvironmentRequest);
            UpdateEnvironmentResponse response = Invoke<UpdateEnvironmentRequest, UpdateEnvironmentResponse> (request, this.signer, UpdateEnvironmentResponseUnmarshaller.GetInstance());
            return response;
        }
    

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
        public CreateConfigurationTemplateResponse CreateConfigurationTemplate(CreateConfigurationTemplateRequest createConfigurationTemplateRequest) 
        {           
            IRequest<CreateConfigurationTemplateRequest> request = new CreateConfigurationTemplateRequestMarshaller().Marshall(createConfigurationTemplateRequest);
            CreateConfigurationTemplateResponse response = Invoke<CreateConfigurationTemplateRequest, CreateConfigurationTemplateResponse> (request, this.signer, CreateConfigurationTemplateResponseUnmarshaller.GetInstance());
            return response;
        }
    

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
        public DescribeConfigurationSettingsResponse DescribeConfigurationSettings(DescribeConfigurationSettingsRequest describeConfigurationSettingsRequest) 
        {           
            IRequest<DescribeConfigurationSettingsRequest> request = new DescribeConfigurationSettingsRequestMarshaller().Marshall(describeConfigurationSettingsRequest);
            DescribeConfigurationSettingsResponse response = Invoke<DescribeConfigurationSettingsRequest, DescribeConfigurationSettingsResponse> (request, this.signer, DescribeConfigurationSettingsResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Returns the descriptions of existing applications.</para>
         /// </summary>
         /// 
         /// <param name="describeApplicationsRequest">Container for the necessary parameters to execute the DescribeApplications service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
         /// <returns>The response from the DescribeApplications service method, as returned by AmazonElasticBeanstalk.</returns>
         /// 
        public DescribeApplicationsResponse DescribeApplications(DescribeApplicationsRequest describeApplicationsRequest) 
        {           
            IRequest<DescribeApplicationsRequest> request = new DescribeApplicationsRequestMarshaller().Marshall(describeApplicationsRequest);
            DescribeApplicationsResponse response = Invoke<DescribeApplicationsRequest, DescribeApplicationsResponse> (request, this.signer, DescribeApplicationsResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Deletes and recreates all of the AWS resources (for example: the Auto Scaling group, load balancer, etc.) for a specified environment
         /// and forces a restart. </para>
         /// </summary>
         /// 
         /// <param name="rebuildEnvironmentRequest">Container for the necessary parameters to execute the RebuildEnvironment service method on
         ///           AmazonElasticBeanstalk.</param>
         /// 
        public RebuildEnvironmentResponse RebuildEnvironment(RebuildEnvironmentRequest rebuildEnvironmentRequest) 
        {           
            IRequest<RebuildEnvironmentRequest> request = new RebuildEnvironmentRequestMarshaller().Marshall(rebuildEnvironmentRequest);
            RebuildEnvironmentResponse response = Invoke<RebuildEnvironmentRequest, RebuildEnvironmentResponse> (request, this.signer, RebuildEnvironmentResponseUnmarshaller.GetInstance());
            return response;
        }
    

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
        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest describeEventsRequest) 
        {           
            IRequest<DescribeEventsRequest> request = new DescribeEventsRequestMarshaller().Marshall(describeEventsRequest);
            DescribeEventsResponse response = Invoke<DescribeEventsRequest, DescribeEventsResponse> (request, this.signer, DescribeEventsResponseUnmarshaller.GetInstance());
            return response;
        }
    
    }
}   
    

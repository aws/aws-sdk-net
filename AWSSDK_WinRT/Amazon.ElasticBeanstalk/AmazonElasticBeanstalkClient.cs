/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Threading;
using System.Threading.Tasks;

using Amazon.ElasticBeanstalk.Model;
using Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticBeanstalk
{
    /// <summary>
    /// Implementation for accessing AmazonElasticBeanstalk.
    /// 
    /// AWS Elastic Beanstalk <para> This is the AWS Elastic Beanstalk API Reference. This guide provides detailed information about AWS Elastic
    /// Beanstalk actions, data types, parameters, and errors. </para> <para>AWS Elastic Beanstalk is a tool that makes it easy for you to create,
    /// deploy, and manage scalable, fault-tolerant applications running on Amazon Web Services cloud resources. </para> <para> For more information
    /// about this product, go to the <a href="http://aws.amazon.com/elasticbeanstalk/">AWS Elastic Beanstalk</a> details page. The location of the
    /// latest AWS Elastic Beanstalk WSDL is <a href="http://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl">http://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl</a> .
    /// </para> <para> <b>Endpoints</b> </para> <para>For a list of region-specific endpoints that AWS Elastic Beanstalk supports, go to <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elasticbeanstalk_region">Regions and Endpoints</a> in the <i>Amazon Web
    /// Services Glossary</i> .</para>
    /// </summary>
	public partial class AmazonElasticBeanstalkClient : AmazonWebServiceClient, Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk
    {

        AWS4Signer signer = new AWS4Signer();
        #region Constructors

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticBeanstalkClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticBeanstalkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticBeanstalkClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticBeanstalkConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Credentials and an
        /// AmazonElasticBeanstalkClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticBeanstalkClient Configuration Object</param>
        public AmazonElasticBeanstalkClient(AWSCredentials credentials, AmazonElasticBeanstalkConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

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
        /// Constructs AmazonElasticBeanstalkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticBeanstalkClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticBeanstalkConfig() {RegionEndpoint=region})
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticBeanstalkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticBeanstalkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticBeanstalkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticBeanstalkConfig(){RegionEndpoint = region})
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
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticBeanstalkClient Configuration Object</param>
        public AmazonElasticBeanstalkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticBeanstalkConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
		internal CheckDNSAvailabilityResponse CheckDNSAvailability(CheckDNSAvailabilityRequest request)
        {
            var task = CheckDNSAvailabilityAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para> Checks if the specified CNAME is available. </para>
        /// </summary>
        /// 
        /// <param name="checkDNSAvailabilityRequest">Container for the necessary parameters to execute the CheckDNSAvailability service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CheckDNSAvailability service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CheckDNSAvailabilityResponse> CheckDNSAvailabilityAsync(CheckDNSAvailabilityRequest checkDNSAvailabilityRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CheckDNSAvailabilityRequestMarshaller();
            var unmarshaller = CheckDNSAvailabilityResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CheckDNSAvailabilityRequest, CheckDNSAvailabilityResponse>(checkDNSAvailabilityRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var task = CreateApplicationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para> Creates an application that has one configuration template named <c>default</c> and no application versions. </para>
        /// </summary>
        /// 
        /// <param name="createApplicationRequest">Container for the necessary parameters to execute the CreateApplication service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.TooManyApplicationsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest createApplicationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateApplicationRequestMarshaller();
            var unmarshaller = CreateApplicationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateApplicationRequest, CreateApplicationResponse>(createApplicationRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateApplicationVersionResponse CreateApplicationVersion(CreateApplicationVersionRequest request)
        {
            var task = CreateApplicationVersionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates an application version for the specified application.</para> <para><b>NOTE:</b>Once you create an application version with a
        /// specified Amazon S3 bucket and key location, you cannot change that Amazon S3 location. If you change the Amazon S3 location, you receive an
        /// exception when you attempt to launch an environment from the application version. </para>
        /// </summary>
        /// 
        /// <param name="createApplicationVersionRequest">Container for the necessary parameters to execute the CreateApplicationVersion service method
        /// on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CreateApplicationVersion service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.TooManyApplicationsException" />
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.TooManyApplicationVersionsException" />
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.S3LocationNotInServiceRegionException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateApplicationVersionResponse> CreateApplicationVersionAsync(CreateApplicationVersionRequest createApplicationVersionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateApplicationVersionRequestMarshaller();
            var unmarshaller = CreateApplicationVersionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateApplicationVersionRequest, CreateApplicationVersionResponse>(createApplicationVersionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateConfigurationTemplateResponse CreateConfigurationTemplate(CreateConfigurationTemplateRequest request)
        {
            var task = CreateConfigurationTemplateAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
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
        /// method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CreateConfigurationTemplate service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.TooManyConfigurationTemplatesException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateConfigurationTemplateResponse> CreateConfigurationTemplateAsync(CreateConfigurationTemplateRequest createConfigurationTemplateRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateConfigurationTemplateRequestMarshaller();
            var unmarshaller = CreateConfigurationTemplateResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateConfigurationTemplateRequest, CreateConfigurationTemplateResponse>(createConfigurationTemplateRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            var task = CreateEnvironmentAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para> Launches an environment for the specified application using the specified configuration. </para>
        /// </summary>
        /// 
        /// <param name="createEnvironmentRequest">Container for the necessary parameters to execute the CreateEnvironment service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.TooManyEnvironmentsException" />
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest createEnvironmentRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateEnvironmentRequestMarshaller();
            var unmarshaller = CreateEnvironmentResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateEnvironmentRequest, CreateEnvironmentResponse>(createEnvironmentRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateStorageLocationResponse CreateStorageLocation(CreateStorageLocationRequest request)
        {
            var task = CreateStorageLocationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para> Creates the Amazon S3 storage location for the account. </para> <para> This location is used to store user log files. </para>
        /// </summary>
        /// 
        /// <param name="createStorageLocationRequest">Container for the necessary parameters to execute the CreateStorageLocation service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CreateStorageLocation service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.S3SubscriptionRequiredException" />
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.TooManyBucketsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateStorageLocationResponse> CreateStorageLocationAsync(CreateStorageLocationRequest createStorageLocationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStorageLocationRequestMarshaller();
            var unmarshaller = CreateStorageLocationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateStorageLocationRequest, CreateStorageLocationResponse>(createStorageLocationRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var task = DeleteApplicationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para> Deletes the specified application along with all associated versions and configurations. The application versions will not be deleted
        /// from your Amazon S3 bucket. </para> <para><b>NOTE:</b>You cannot delete an application that has a running environment. </para>
        /// </summary>
        /// 
        /// <param name="deleteApplicationRequest">Container for the necessary parameters to execute the DeleteApplication service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.OperationInProgressException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest deleteApplicationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteApplicationRequestMarshaller();
            var unmarshaller = DeleteApplicationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteApplicationRequest, DeleteApplicationResponse>(deleteApplicationRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteApplicationVersionResponse DeleteApplicationVersion(DeleteApplicationVersionRequest request)
        {
            var task = DeleteApplicationVersionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para> Deletes the specified version from the specified application. </para> <para><b>NOTE:</b>You cannot delete an application version that
        /// is associated with a running environment.</para>
        /// </summary>
        /// 
        /// <param name="deleteApplicationVersionRequest">Container for the necessary parameters to execute the DeleteApplicationVersion service method
        /// on AmazonElasticBeanstalk.</param>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.OperationInProgressException" />
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.SourceBundleDeletionException" />
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.S3LocationNotInServiceRegionException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteApplicationVersionResponse> DeleteApplicationVersionAsync(DeleteApplicationVersionRequest deleteApplicationVersionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteApplicationVersionRequestMarshaller();
            var unmarshaller = DeleteApplicationVersionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteApplicationVersionRequest, DeleteApplicationVersionResponse>(deleteApplicationVersionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteConfigurationTemplateResponse DeleteConfigurationTemplate(DeleteConfigurationTemplateRequest request)
        {
            var task = DeleteConfigurationTemplateAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes the specified configuration template.</para> <para><b>NOTE:</b>When you launch an environment using a configuration template,
        /// the environment gets a copy of the template. You can delete or modify the environment's copy of the template without affecting the running
        /// environment.</para>
        /// </summary>
        /// 
        /// <param name="deleteConfigurationTemplateRequest">Container for the necessary parameters to execute the DeleteConfigurationTemplate service
        /// method on AmazonElasticBeanstalk.</param>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.OperationInProgressException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteConfigurationTemplateResponse> DeleteConfigurationTemplateAsync(DeleteConfigurationTemplateRequest deleteConfigurationTemplateRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteConfigurationTemplateRequestMarshaller();
            var unmarshaller = DeleteConfigurationTemplateResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteConfigurationTemplateRequest, DeleteConfigurationTemplateResponse>(deleteConfigurationTemplateRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteEnvironmentConfigurationResponse DeleteEnvironmentConfiguration(DeleteEnvironmentConfigurationRequest request)
        {
            var task = DeleteEnvironmentConfigurationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para> Deletes the draft configuration associated with the running environment. </para> <para> Updating a running environment with any
        /// configuration changes creates a draft configuration set. You can get the draft configuration using DescribeConfigurationSettings while the
        /// update is in progress or if the update fails. The <c>DeploymentStatus</c> for the draft configuration indicates whether the deployment is in
        /// process or has failed. The draft configuration remains in existence until it is deleted with this action. </para>
        /// </summary>
        /// 
        /// <param name="deleteEnvironmentConfigurationRequest">Container for the necessary parameters to execute the DeleteEnvironmentConfiguration
        /// service method on AmazonElasticBeanstalk.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteEnvironmentConfigurationResponse> DeleteEnvironmentConfigurationAsync(DeleteEnvironmentConfigurationRequest deleteEnvironmentConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteEnvironmentConfigurationRequestMarshaller();
            var unmarshaller = DeleteEnvironmentConfigurationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteEnvironmentConfigurationRequest, DeleteEnvironmentConfigurationResponse>(deleteEnvironmentConfigurationRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeApplicationsResponse DescribeApplications(DescribeApplicationsRequest request)
        {
            var task = DescribeApplicationsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Returns the descriptions of existing applications.</para>
        /// </summary>
        /// 
        /// <param name="describeApplicationsRequest">Container for the necessary parameters to execute the DescribeApplications service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeApplicationsResponse> DescribeApplicationsAsync(DescribeApplicationsRequest describeApplicationsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeApplicationsRequestMarshaller();
            var unmarshaller = DescribeApplicationsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeApplicationsRequest, DescribeApplicationsResponse>(describeApplicationsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeApplicationVersionsResponse DescribeApplicationVersions(DescribeApplicationVersionsRequest request)
        {
            var task = DescribeApplicationVersionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Returns descriptions for existing application versions.</para>
        /// </summary>
        /// 
        /// <param name="describeApplicationVersionsRequest">Container for the necessary parameters to execute the DescribeApplicationVersions service
        /// method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeApplicationVersionsResponse> DescribeApplicationVersionsAsync(DescribeApplicationVersionsRequest describeApplicationVersionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeApplicationVersionsRequestMarshaller();
            var unmarshaller = DescribeApplicationVersionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeApplicationVersionsRequest, DescribeApplicationVersionsResponse>(describeApplicationVersionsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeConfigurationOptionsResponse DescribeConfigurationOptions(DescribeConfigurationOptionsRequest request)
        {
            var task = DescribeConfigurationOptionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para> Describes the configuration options that are used in a particular configuration template or environment, or that a specified solution
        /// stack defines. The description includes the values the options, their default values, and an indication of the required action on a running
        /// environment if an option value is changed. </para>
        /// </summary>
        /// 
        /// <param name="describeConfigurationOptionsRequest">Container for the necessary parameters to execute the DescribeConfigurationOptions service
        /// method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeConfigurationOptionsResponse> DescribeConfigurationOptionsAsync(DescribeConfigurationOptionsRequest describeConfigurationOptionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeConfigurationOptionsRequestMarshaller();
            var unmarshaller = DescribeConfigurationOptionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeConfigurationOptionsRequest, DescribeConfigurationOptionsResponse>(describeConfigurationOptionsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeConfigurationSettingsResponse DescribeConfigurationSettings(DescribeConfigurationSettingsRequest request)
        {
            var task = DescribeConfigurationSettingsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
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
        /// service method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationSettings service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeConfigurationSettingsResponse> DescribeConfigurationSettingsAsync(DescribeConfigurationSettingsRequest describeConfigurationSettingsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeConfigurationSettingsRequestMarshaller();
            var unmarshaller = DescribeConfigurationSettingsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeConfigurationSettingsRequest, DescribeConfigurationSettingsResponse>(describeConfigurationSettingsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeEnvironmentResourcesResponse DescribeEnvironmentResources(DescribeEnvironmentResourcesRequest request)
        {
            var task = DescribeEnvironmentResourcesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Returns AWS resources for this environment.</para>
        /// </summary>
        /// 
        /// <param name="describeEnvironmentResourcesRequest">Container for the necessary parameters to execute the DescribeEnvironmentResources service
        /// method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentResources service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeEnvironmentResourcesResponse> DescribeEnvironmentResourcesAsync(DescribeEnvironmentResourcesRequest describeEnvironmentResourcesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEnvironmentResourcesRequestMarshaller();
            var unmarshaller = DescribeEnvironmentResourcesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeEnvironmentResourcesRequest, DescribeEnvironmentResourcesResponse>(describeEnvironmentResourcesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeEnvironmentsResponse DescribeEnvironments(DescribeEnvironmentsRequest request)
        {
            var task = DescribeEnvironmentsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Returns descriptions for existing environments.</para>
        /// </summary>
        /// 
        /// <param name="describeEnvironmentsRequest">Container for the necessary parameters to execute the DescribeEnvironments service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeEnvironmentsResponse> DescribeEnvironmentsAsync(DescribeEnvironmentsRequest describeEnvironmentsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEnvironmentsRequestMarshaller();
            var unmarshaller = DescribeEnvironmentsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeEnvironmentsRequest, DescribeEnvironmentsResponse>(describeEnvironmentsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var task = DescribeEventsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Returns list of event descriptions matching criteria up to the last 6 weeks.</para> <para><b>NOTE:</b> This action returns the most
        /// recent 1,000 events from the specified NextToken. </para>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest describeEventsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeEventsRequest, DescribeEventsResponse>(describeEventsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListAvailableSolutionStacksResponse ListAvailableSolutionStacks(ListAvailableSolutionStacksRequest request)
        {
            var task = ListAvailableSolutionStacksAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para> Returns a list of the available solution stack names. </para>
        /// </summary>
        /// 
        /// <param name="listAvailableSolutionStacksRequest">Container for the necessary parameters to execute the ListAvailableSolutionStacks service
        /// method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListAvailableSolutionStacksResponse> ListAvailableSolutionStacksAsync(ListAvailableSolutionStacksRequest listAvailableSolutionStacksRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAvailableSolutionStacksRequestMarshaller();
            var unmarshaller = ListAvailableSolutionStacksResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListAvailableSolutionStacksRequest, ListAvailableSolutionStacksResponse>(listAvailableSolutionStacksRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal RebuildEnvironmentResponse RebuildEnvironment(RebuildEnvironmentRequest request)
        {
            var task = RebuildEnvironmentAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para> Deletes and recreates all of the AWS resources (for example: the Auto Scaling group, load balancer, etc.) for a specified environment
        /// and forces a restart. </para>
        /// </summary>
        /// 
        /// <param name="rebuildEnvironmentRequest">Container for the necessary parameters to execute the RebuildEnvironment service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<RebuildEnvironmentResponse> RebuildEnvironmentAsync(RebuildEnvironmentRequest rebuildEnvironmentRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebuildEnvironmentRequestMarshaller();
            var unmarshaller = RebuildEnvironmentResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RebuildEnvironmentRequest, RebuildEnvironmentResponse>(rebuildEnvironmentRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal RequestEnvironmentInfoResponse RequestEnvironmentInfo(RequestEnvironmentInfoRequest request)
        {
            var task = RequestEnvironmentInfoAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
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
        /// AmazonElasticBeanstalk.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<RequestEnvironmentInfoResponse> RequestEnvironmentInfoAsync(RequestEnvironmentInfoRequest requestEnvironmentInfoRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RequestEnvironmentInfoRequestMarshaller();
            var unmarshaller = RequestEnvironmentInfoResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RequestEnvironmentInfoRequest, RequestEnvironmentInfoResponse>(requestEnvironmentInfoRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal RestartAppServerResponse RestartAppServer(RestartAppServerRequest request)
        {
            var task = RestartAppServerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para> Causes the environment to restart the application container server running on each Amazon EC2 instance. </para>
        /// </summary>
        /// 
        /// <param name="restartAppServerRequest">Container for the necessary parameters to execute the RestartAppServer service method on
        /// AmazonElasticBeanstalk.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<RestartAppServerResponse> RestartAppServerAsync(RestartAppServerRequest restartAppServerRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestartAppServerRequestMarshaller();
            var unmarshaller = RestartAppServerResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RestartAppServerRequest, RestartAppServerResponse>(restartAppServerRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal RetrieveEnvironmentInfoResponse RetrieveEnvironmentInfo(RetrieveEnvironmentInfoRequest request)
        {
            var task = RetrieveEnvironmentInfoAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
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
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the RetrieveEnvironmentInfo service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<RetrieveEnvironmentInfoResponse> RetrieveEnvironmentInfoAsync(RetrieveEnvironmentInfoRequest retrieveEnvironmentInfoRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RetrieveEnvironmentInfoRequestMarshaller();
            var unmarshaller = RetrieveEnvironmentInfoResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RetrieveEnvironmentInfoRequest, RetrieveEnvironmentInfoResponse>(retrieveEnvironmentInfoRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal SwapEnvironmentCNAMEsResponse SwapEnvironmentCNAMEs(SwapEnvironmentCNAMEsRequest request)
        {
            var task = SwapEnvironmentCNAMEsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para> Swaps the CNAMEs of two environments. </para>
        /// </summary>
        /// 
        /// <param name="swapEnvironmentCNAMEsRequest">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs service method on
        /// AmazonElasticBeanstalk.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<SwapEnvironmentCNAMEsResponse> SwapEnvironmentCNAMEsAsync(SwapEnvironmentCNAMEsRequest swapEnvironmentCNAMEsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SwapEnvironmentCNAMEsRequestMarshaller();
            var unmarshaller = SwapEnvironmentCNAMEsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SwapEnvironmentCNAMEsRequest, SwapEnvironmentCNAMEsResponse>(swapEnvironmentCNAMEsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal TerminateEnvironmentResponse TerminateEnvironment(TerminateEnvironmentRequest request)
        {
            var task = TerminateEnvironmentAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para> Terminates the specified environment. </para>
        /// </summary>
        /// 
        /// <param name="terminateEnvironmentRequest">Container for the necessary parameters to execute the TerminateEnvironment service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the TerminateEnvironment service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<TerminateEnvironmentResponse> TerminateEnvironmentAsync(TerminateEnvironmentRequest terminateEnvironmentRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TerminateEnvironmentRequestMarshaller();
            var unmarshaller = TerminateEnvironmentResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, TerminateEnvironmentRequest, TerminateEnvironmentResponse>(terminateEnvironmentRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var task = UpdateApplicationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Updates the specified application to have the specified properties. </para> <para><b>NOTE:</b> If a property (for example,
        /// description) is not provided, the value remains unchanged. To clear these properties, specify an empty string. </para>
        /// </summary>
        /// 
        /// <param name="updateApplicationRequest">Container for the necessary parameters to execute the UpdateApplication service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest updateApplicationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateApplicationRequestMarshaller();
            var unmarshaller = UpdateApplicationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UpdateApplicationRequest, UpdateApplicationResponse>(updateApplicationRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal UpdateApplicationVersionResponse UpdateApplicationVersion(UpdateApplicationVersionRequest request)
        {
            var task = UpdateApplicationVersionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para> Updates the specified application version to have the specified properties. </para> <para><b>NOTE:</b> If a property (for example,
        /// description) is not provided, the value remains unchanged. To clear properties, specify an empty string. </para>
        /// </summary>
        /// 
        /// <param name="updateApplicationVersionRequest">Container for the necessary parameters to execute the UpdateApplicationVersion service method
        /// on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the UpdateApplicationVersion service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<UpdateApplicationVersionResponse> UpdateApplicationVersionAsync(UpdateApplicationVersionRequest updateApplicationVersionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateApplicationVersionRequestMarshaller();
            var unmarshaller = UpdateApplicationVersionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UpdateApplicationVersionRequest, UpdateApplicationVersionResponse>(updateApplicationVersionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal UpdateConfigurationTemplateResponse UpdateConfigurationTemplate(UpdateConfigurationTemplateRequest request)
        {
            var task = UpdateConfigurationTemplateAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
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
        /// method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationTemplate service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<UpdateConfigurationTemplateResponse> UpdateConfigurationTemplateAsync(UpdateConfigurationTemplateRequest updateConfigurationTemplateRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateConfigurationTemplateRequestMarshaller();
            var unmarshaller = UpdateConfigurationTemplateResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UpdateConfigurationTemplateRequest, UpdateConfigurationTemplateResponse>(updateConfigurationTemplateRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
        {
            var task = UpdateEnvironmentAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
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
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest updateEnvironmentRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateEnvironmentRequestMarshaller();
            var unmarshaller = UpdateEnvironmentResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UpdateEnvironmentRequest, UpdateEnvironmentResponse>(updateEnvironmentRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ValidateConfigurationSettingsResponse ValidateConfigurationSettings(ValidateConfigurationSettingsRequest request)
        {
            var task = ValidateConfigurationSettingsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para> Takes a set of configuration settings and either a configuration template or environment, and determines whether those values are
        /// valid. </para> <para> This action returns a list of messages indicating any errors or warnings associated with the selection of option
        /// values. </para>
        /// </summary>
        /// 
        /// <param name="validateConfigurationSettingsRequest">Container for the necessary parameters to execute the ValidateConfigurationSettings
        /// service method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the ValidateConfigurationSettings service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ValidateConfigurationSettingsResponse> ValidateConfigurationSettingsAsync(ValidateConfigurationSettingsRequest validateConfigurationSettingsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ValidateConfigurationSettingsRequestMarshaller();
            var unmarshaller = ValidateConfigurationSettingsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ValidateConfigurationSettingsRequest, ValidateConfigurationSettingsResponse>(validateConfigurationSettingsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
    }
}

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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ElasticBeanstalk.Model;
using Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticBeanstalk
{
    /// <summary>
    /// Implementation for accessing ElasticBeanstalk
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
    /// To install the Software Development Kits (SDKs), Integrated Development Environment
    /// (IDE) Toolkits, and command line tools that enable you to access the API, go to <a
    /// href="https://aws.amazon.com/tools/">Tools for Amazon Web Services</a>. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Endpoints</b> 
    /// </para>
    ///  
    /// <para>
    /// For a list of region-specific endpoints that AWS Elastic Beanstalk supports, go to
    /// <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elasticbeanstalk_region">Regions
    /// and Endpoints</a> in the <i>Amazon Web Services Glossary</i>.
    /// </para>
    /// </summary>
    public partial class AmazonElasticBeanstalkClient : AmazonServiceClient, IAmazonElasticBeanstalk
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with the credentials loaded from the application's
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
        public AmazonElasticBeanstalkClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticBeanstalkConfig()) { }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with the credentials loaded from the application's
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
        public AmazonElasticBeanstalkClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticBeanstalkConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElasticBeanstalkClient Configuration Object</param>
        public AmazonElasticBeanstalkClient(AmazonElasticBeanstalkConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
            : this(credentials, new AmazonElasticBeanstalkConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Credentials and an
        /// AmazonElasticBeanstalkClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticBeanstalkClient Configuration Object</param>
        public AmazonElasticBeanstalkClient(AWSCredentials credentials, AmazonElasticBeanstalkConfig clientConfig)
            : base(credentials, clientConfig)
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
        /// AmazonElasticBeanstalkClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticBeanstalkClient Configuration Object</param>
        public AmazonElasticBeanstalkClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticBeanstalkConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticBeanstalkConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticBeanstalkClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticBeanstalkClient Configuration Object</param>
        public AmazonElasticBeanstalkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticBeanstalkConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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

        
        #region  AbortEnvironmentUpdate


        /// <summary>
        /// Cancels in-progress environment configuration update or application version deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AbortEnvironmentUpdate service method.</param>
        /// 
        /// <returns>The response from the AbortEnvironmentUpdate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        public AbortEnvironmentUpdateResponse AbortEnvironmentUpdate(AbortEnvironmentUpdateRequest request)
        {
            var marshaller = new AbortEnvironmentUpdateRequestMarshaller();
            var unmarshaller = AbortEnvironmentUpdateResponseUnmarshaller.Instance;

            return Invoke<AbortEnvironmentUpdateRequest,AbortEnvironmentUpdateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AbortEnvironmentUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AbortEnvironmentUpdate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AbortEnvironmentUpdateResponse> AbortEnvironmentUpdateAsync(AbortEnvironmentUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AbortEnvironmentUpdateRequestMarshaller();
            var unmarshaller = AbortEnvironmentUpdateResponseUnmarshaller.Instance;

            return InvokeAsync<AbortEnvironmentUpdateRequest,AbortEnvironmentUpdateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CheckDNSAvailability


        /// <summary>
        /// Checks if the specified CNAME is available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDNSAvailability service method.</param>
        /// 
        /// <returns>The response from the CheckDNSAvailability service method, as returned by ElasticBeanstalk.</returns>
        public CheckDNSAvailabilityResponse CheckDNSAvailability(CheckDNSAvailabilityRequest request)
        {
            var marshaller = new CheckDNSAvailabilityRequestMarshaller();
            var unmarshaller = CheckDNSAvailabilityResponseUnmarshaller.Instance;

            return Invoke<CheckDNSAvailabilityRequest,CheckDNSAvailabilityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CheckDNSAvailability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckDNSAvailability operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CheckDNSAvailabilityResponse> CheckDNSAvailabilityAsync(CheckDNSAvailabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CheckDNSAvailabilityRequestMarshaller();
            var unmarshaller = CheckDNSAvailabilityResponseUnmarshaller.Instance;

            return InvokeAsync<CheckDNSAvailabilityRequest,CheckDNSAvailabilityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ComposeEnvironments


        /// <summary>
        /// Create or update a group of environments that each run a separate component of a single
        /// application. Takes a list of version labels that specify application source bundles
        /// for each of the environments to create or update. The name of each environment and
        /// other required information must be included in the source bundles in an environment
        /// manifest named <code>env.yaml</code>. See <a href="http://docs.aws.amazon.com/elasticbeanstalk/latest/dg/environment-mgmt-compose.html">Compose
        /// Environments</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ComposeEnvironments service method.</param>
        /// 
        /// <returns>The response from the ComposeEnvironments service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyEnvironmentsException">
        /// The specified account has reached its limit of environments.
        /// </exception>
        public ComposeEnvironmentsResponse ComposeEnvironments(ComposeEnvironmentsRequest request)
        {
            var marshaller = new ComposeEnvironmentsRequestMarshaller();
            var unmarshaller = ComposeEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ComposeEnvironmentsRequest,ComposeEnvironmentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ComposeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ComposeEnvironments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ComposeEnvironmentsResponse> ComposeEnvironmentsAsync(ComposeEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ComposeEnvironmentsRequestMarshaller();
            var unmarshaller = ComposeEnvironmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ComposeEnvironmentsRequest,ComposeEnvironmentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateApplication


        /// <summary>
        /// Creates an application that has one configuration template named <code>default</code>
        /// and no application versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyApplicationsException">
        /// The specified account has reached its limit of applications.
        /// </exception>
        public CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var marshaller = new CreateApplicationRequestMarshaller();
            var unmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationRequest,CreateApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateApplicationRequestMarshaller();
            var unmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationRequest,CreateApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateApplicationVersion


        /// <summary>
        /// Creates an application version for the specified application.
        /// 
        ///  <note>Once you create an application version with a specified Amazon S3 bucket and
        /// key location, you cannot change that Amazon S3 location. If you change the Amazon
        /// S3 location, you receive an exception when you attempt to launch an environment from
        /// the application version. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the CreateApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3LocationNotInServiceRegionException">
        /// The specified S3 bucket does not belong to the S3 region in which the service is running.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyApplicationsException">
        /// The specified account has reached its limit of applications.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyApplicationVersionsException">
        /// The specified account has reached its limit of application versions.
        /// </exception>
        public CreateApplicationVersionResponse CreateApplicationVersion(CreateApplicationVersionRequest request)
        {
            var marshaller = new CreateApplicationVersionRequestMarshaller();
            var unmarshaller = CreateApplicationVersionResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationVersionRequest,CreateApplicationVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateApplicationVersionResponse> CreateApplicationVersionAsync(CreateApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateApplicationVersionRequestMarshaller();
            var unmarshaller = CreateApplicationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationVersionRequest,CreateApplicationVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyConfigurationTemplatesException">
        /// The specified account has reached its limit of configuration templates.
        /// </exception>
        public CreateConfigurationTemplateResponse CreateConfigurationTemplate(CreateConfigurationTemplateRequest request)
        {
            var marshaller = new CreateConfigurationTemplateRequestMarshaller();
            var unmarshaller = CreateConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationTemplateRequest,CreateConfigurationTemplateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateConfigurationTemplateResponse> CreateConfigurationTemplateAsync(CreateConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateConfigurationTemplateRequestMarshaller();
            var unmarshaller = CreateConfigurationTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationTemplateRequest,CreateConfigurationTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateEnvironment


        /// <summary>
        /// Launches an environment for the specified application using the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyEnvironmentsException">
        /// The specified account has reached its limit of environments.
        /// </exception>
        public CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            var marshaller = new CreateEnvironmentRequestMarshaller();
            var unmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentRequest,CreateEnvironmentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateEnvironmentRequestMarshaller();
            var unmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEnvironmentRequest,CreateEnvironmentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3SubscriptionRequiredException">
        /// The specified account does not have a subscription to Amazon S3.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        public CreateStorageLocationResponse CreateStorageLocation()
        {
            return CreateStorageLocation(new CreateStorageLocationRequest());
        }


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
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3SubscriptionRequiredException">
        /// The specified account does not have a subscription to Amazon S3.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        public CreateStorageLocationResponse CreateStorageLocation(CreateStorageLocationRequest request)
        {
            var marshaller = new CreateStorageLocationRequestMarshaller();
            var unmarshaller = CreateStorageLocationResponseUnmarshaller.Instance;

            return Invoke<CreateStorageLocationRequest,CreateStorageLocationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Creates the Amazon S3 storage location for the account. 
        /// 
        ///  
        /// <para>
        ///  This location is used to store user log files. 
        /// </para>
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStorageLocation service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3SubscriptionRequiredException">
        /// The specified account does not have a subscription to Amazon S3.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        public Task<CreateStorageLocationResponse> CreateStorageLocationAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return CreateStorageLocationAsync(new CreateStorageLocationRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the CreateStorageLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageLocation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateStorageLocationResponse> CreateStorageLocationAsync(CreateStorageLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStorageLocationRequestMarshaller();
            var unmarshaller = CreateStorageLocationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStorageLocationRequest,CreateStorageLocationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplication


        /// <summary>
        /// Deletes the specified application along with all associated versions and configurations.
        /// The application versions will not be deleted from your Amazon S3 bucket. 
        /// 
        ///  <note>You cannot delete an application that has a running environment. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var marshaller = new DeleteApplicationRequestMarshaller();
            var unmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationRequest,DeleteApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteApplicationRequestMarshaller();
            var unmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationRequest,DeleteApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplicationVersion


        /// <summary>
        /// Deletes the specified version from the specified application. 
        /// 
        ///  <note>You cannot delete an application version that is associated with a running
        /// environment.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3LocationNotInServiceRegionException">
        /// The specified S3 bucket does not belong to the S3 region in which the service is running.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.SourceBundleDeletionException">
        /// Unable to delete the Amazon S3 source bundle associated with the application version.
        /// The application version was deleted successfully.
        /// </exception>
        public DeleteApplicationVersionResponse DeleteApplicationVersion(DeleteApplicationVersionRequest request)
        {
            var marshaller = new DeleteApplicationVersionRequestMarshaller();
            var unmarshaller = DeleteApplicationVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationVersionRequest,DeleteApplicationVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteApplicationVersionResponse> DeleteApplicationVersionAsync(DeleteApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteApplicationVersionRequestMarshaller();
            var unmarshaller = DeleteApplicationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationVersionRequest,DeleteApplicationVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfigurationTemplate


        /// <summary>
        /// Deletes the specified configuration template.
        /// 
        ///  <note>When you launch an environment using a configuration template, the environment
        /// gets a copy of the template. You can delete or modify the environment's copy of the
        /// template without affecting the running environment.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        public DeleteConfigurationTemplateResponse DeleteConfigurationTemplate(DeleteConfigurationTemplateRequest request)
        {
            var marshaller = new DeleteConfigurationTemplateRequestMarshaller();
            var unmarshaller = DeleteConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationTemplateRequest,DeleteConfigurationTemplateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteConfigurationTemplateResponse> DeleteConfigurationTemplateAsync(DeleteConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteConfigurationTemplateRequestMarshaller();
            var unmarshaller = DeleteConfigurationTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationTemplateRequest,DeleteConfigurationTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DeleteEnvironmentConfigurationResponse DeleteEnvironmentConfiguration(DeleteEnvironmentConfigurationRequest request)
        {
            var marshaller = new DeleteEnvironmentConfigurationRequestMarshaller();
            var unmarshaller = DeleteEnvironmentConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentConfigurationRequest,DeleteEnvironmentConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironmentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteEnvironmentConfigurationResponse> DeleteEnvironmentConfigurationAsync(DeleteEnvironmentConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteEnvironmentConfigurationRequestMarshaller();
            var unmarshaller = DeleteEnvironmentConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEnvironmentConfigurationRequest,DeleteEnvironmentConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeApplications


        /// <summary>
        /// Returns the descriptions of existing applications.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by ElasticBeanstalk.</returns>
        public DescribeApplicationsResponse DescribeApplications()
        {
            return DescribeApplications(new DescribeApplicationsRequest());
        }


        /// <summary>
        /// Returns the descriptions of existing applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplications service method.</param>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by ElasticBeanstalk.</returns>
        public DescribeApplicationsResponse DescribeApplications(DescribeApplicationsRequest request)
        {
            var marshaller = new DescribeApplicationsRequestMarshaller();
            var unmarshaller = DescribeApplicationsResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationsRequest,DescribeApplicationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the descriptions of existing applications.
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by ElasticBeanstalk.</returns>
        public Task<DescribeApplicationsResponse> DescribeApplicationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeApplicationsAsync(new DescribeApplicationsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeApplicationsResponse> DescribeApplicationsAsync(DescribeApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeApplicationsRequestMarshaller();
            var unmarshaller = DescribeApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationsRequest,DescribeApplicationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeApplicationVersions


        /// <summary>
        /// Retrieve a list of application versions stored in your AWS Elastic Beanstalk storage
        /// bucket.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by ElasticBeanstalk.</returns>
        public DescribeApplicationVersionsResponse DescribeApplicationVersions()
        {
            return DescribeApplicationVersions(new DescribeApplicationVersionsRequest());
        }


        /// <summary>
        /// Retrieve a list of application versions stored in your AWS Elastic Beanstalk storage
        /// bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by ElasticBeanstalk.</returns>
        public DescribeApplicationVersionsResponse DescribeApplicationVersions(DescribeApplicationVersionsRequest request)
        {
            var marshaller = new DescribeApplicationVersionsRequestMarshaller();
            var unmarshaller = DescribeApplicationVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationVersionsRequest,DescribeApplicationVersionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieve a list of application versions stored in your AWS Elastic Beanstalk storage
        /// bucket.
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by ElasticBeanstalk.</returns>
        public Task<DescribeApplicationVersionsResponse> DescribeApplicationVersionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeApplicationVersionsAsync(new DescribeApplicationVersionsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeApplicationVersionsResponse> DescribeApplicationVersionsAsync(DescribeApplicationVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeApplicationVersionsRequestMarshaller();
            var unmarshaller = DescribeApplicationVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationVersionsRequest,DescribeApplicationVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeConfigurationOptionsResponse DescribeConfigurationOptions()
        {
            return DescribeConfigurationOptions(new DescribeConfigurationOptionsRequest());
        }


        /// <summary>
        /// Describes the configuration options that are used in a particular configuration template
        /// or environment, or that a specified solution stack defines. The description includes
        /// the values the options, their default values, and an indication of the required action
        /// on a running environment if an option value is changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by ElasticBeanstalk.</returns>
        public DescribeConfigurationOptionsResponse DescribeConfigurationOptions(DescribeConfigurationOptionsRequest request)
        {
            var marshaller = new DescribeConfigurationOptionsRequestMarshaller();
            var unmarshaller = DescribeConfigurationOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationOptionsRequest,DescribeConfigurationOptionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the configuration options that are used in a particular configuration template
        /// or environment, or that a specified solution stack defines. The description includes
        /// the values the options, their default values, and an indication of the required action
        /// on a running environment if an option value is changed.
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by ElasticBeanstalk.</returns>
        public Task<DescribeConfigurationOptionsResponse> DescribeConfigurationOptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeConfigurationOptionsAsync(new DescribeConfigurationOptionsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeConfigurationOptionsResponse> DescribeConfigurationOptionsAsync(DescribeConfigurationOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeConfigurationOptionsRequestMarshaller();
            var unmarshaller = DescribeConfigurationOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConfigurationOptionsRequest,DescribeConfigurationOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeConfigurationSettingsResponse DescribeConfigurationSettings(DescribeConfigurationSettingsRequest request)
        {
            var marshaller = new DescribeConfigurationSettingsRequestMarshaller();
            var unmarshaller = DescribeConfigurationSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationSettingsRequest,DescribeConfigurationSettingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeConfigurationSettingsResponse> DescribeConfigurationSettingsAsync(DescribeConfigurationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeConfigurationSettingsRequestMarshaller();
            var unmarshaller = DescribeConfigurationSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConfigurationSettingsRequest,DescribeConfigurationSettingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEnvironmentHealth


        /// <summary>
        /// Returns information about the overall health of the specified environment. The <b>DescribeEnvironmentHealth</b>
        /// operation is only available with AWS Elastic Beanstalk Enhanced Health.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentHealth service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentHealth service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InvalidRequestException">
        /// One or more input parameters is not valid. Please correct the input parameters and
        /// try the operation again.
        /// </exception>
        public DescribeEnvironmentHealthResponse DescribeEnvironmentHealth(DescribeEnvironmentHealthRequest request)
        {
            var marshaller = new DescribeEnvironmentHealthRequestMarshaller();
            var unmarshaller = DescribeEnvironmentHealthResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentHealthRequest,DescribeEnvironmentHealthResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentHealth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeEnvironmentHealthResponse> DescribeEnvironmentHealthAsync(DescribeEnvironmentHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEnvironmentHealthRequestMarshaller();
            var unmarshaller = DescribeEnvironmentHealthResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEnvironmentHealthRequest,DescribeEnvironmentHealthResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEnvironmentResources


        /// <summary>
        /// Returns AWS resources for this environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentResources service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentResources service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        public DescribeEnvironmentResourcesResponse DescribeEnvironmentResources(DescribeEnvironmentResourcesRequest request)
        {
            var marshaller = new DescribeEnvironmentResourcesRequestMarshaller();
            var unmarshaller = DescribeEnvironmentResourcesResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentResourcesRequest,DescribeEnvironmentResourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeEnvironmentResourcesResponse> DescribeEnvironmentResourcesAsync(DescribeEnvironmentResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEnvironmentResourcesRequestMarshaller();
            var unmarshaller = DescribeEnvironmentResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEnvironmentResourcesRequest,DescribeEnvironmentResourcesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEnvironments


        /// <summary>
        /// Returns descriptions for existing environments.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by ElasticBeanstalk.</returns>
        public DescribeEnvironmentsResponse DescribeEnvironments()
        {
            return DescribeEnvironments(new DescribeEnvironmentsRequest());
        }


        /// <summary>
        /// Returns descriptions for existing environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironments service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by ElasticBeanstalk.</returns>
        public DescribeEnvironmentsResponse DescribeEnvironments(DescribeEnvironmentsRequest request)
        {
            var marshaller = new DescribeEnvironmentsRequestMarshaller();
            var unmarshaller = DescribeEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentsRequest,DescribeEnvironmentsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns descriptions for existing environments.
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by ElasticBeanstalk.</returns>
        public Task<DescribeEnvironmentsResponse> DescribeEnvironmentsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeEnvironmentsAsync(new DescribeEnvironmentsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeEnvironmentsResponse> DescribeEnvironmentsAsync(DescribeEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEnvironmentsRequestMarshaller();
            var unmarshaller = DescribeEnvironmentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEnvironmentsRequest,DescribeEnvironmentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEvents


        /// <summary>
        /// Returns list of event descriptions matching criteria up to the last 6 weeks.
        /// 
        ///  <note> This action returns the most recent 1,000 events from the specified <code>NextToken</code>.
        /// </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElasticBeanstalk.</returns>
        public DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }


        /// <summary>
        /// Returns list of event descriptions matching criteria up to the last 6 weeks.
        /// 
        ///  <note> This action returns the most recent 1,000 events from the specified <code>NextToken</code>.
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElasticBeanstalk.</returns>
        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsRequest,DescribeEventsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns list of event descriptions matching criteria up to the last 6 weeks.
        /// 
        ///  <note> This action returns the most recent 1,000 events from the specified <code>NextToken</code>.
        /// </note>
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElasticBeanstalk.</returns>
        public Task<DescribeEventsResponse> DescribeEventsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeEventsAsync(new DescribeEventsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventsRequest,DescribeEventsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstancesHealth


        /// <summary>
        /// Returns more detailed information about the health of the specified instances (for
        /// example, CPU utilization, load average, and causes). The <b>DescribeInstancesHealth</b>
        /// operation is only available with AWS Elastic Beanstalk Enhanced Health.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancesHealth service method.</param>
        /// 
        /// <returns>The response from the DescribeInstancesHealth service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InvalidRequestException">
        /// One or more input parameters is not valid. Please correct the input parameters and
        /// try the operation again.
        /// </exception>
        public DescribeInstancesHealthResponse DescribeInstancesHealth(DescribeInstancesHealthRequest request)
        {
            var marshaller = new DescribeInstancesHealthRequestMarshaller();
            var unmarshaller = DescribeInstancesHealthResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancesHealthRequest,DescribeInstancesHealthResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstancesHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancesHealth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeInstancesHealthResponse> DescribeInstancesHealthAsync(DescribeInstancesHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstancesHealthRequestMarshaller();
            var unmarshaller = DescribeInstancesHealthResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstancesHealthRequest,DescribeInstancesHealthResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAvailableSolutionStacks


        /// <summary>
        /// Returns a list of the available solution stack names.
        /// </summary>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by ElasticBeanstalk.</returns>
        public ListAvailableSolutionStacksResponse ListAvailableSolutionStacks()
        {
            return ListAvailableSolutionStacks(new ListAvailableSolutionStacksRequest());
        }


        /// <summary>
        /// Returns a list of the available solution stack names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableSolutionStacks service method.</param>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by ElasticBeanstalk.</returns>
        public ListAvailableSolutionStacksResponse ListAvailableSolutionStacks(ListAvailableSolutionStacksRequest request)
        {
            var marshaller = new ListAvailableSolutionStacksRequestMarshaller();
            var unmarshaller = ListAvailableSolutionStacksResponseUnmarshaller.Instance;

            return Invoke<ListAvailableSolutionStacksRequest,ListAvailableSolutionStacksResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns a list of the available solution stack names.
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by ElasticBeanstalk.</returns>
        public Task<ListAvailableSolutionStacksResponse> ListAvailableSolutionStacksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListAvailableSolutionStacksAsync(new ListAvailableSolutionStacksRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableSolutionStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableSolutionStacks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListAvailableSolutionStacksResponse> ListAvailableSolutionStacksAsync(ListAvailableSolutionStacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAvailableSolutionStacksRequestMarshaller();
            var unmarshaller = ListAvailableSolutionStacksResponseUnmarshaller.Instance;

            return InvokeAsync<ListAvailableSolutionStacksRequest,ListAvailableSolutionStacksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RebuildEnvironment


        /// <summary>
        /// Deletes and recreates all of the AWS resources (for example: the Auto Scaling group,
        /// load balancer, etc.) for a specified environment and forces a restart.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebuildEnvironment service method.</param>
        /// 
        /// <returns>The response from the RebuildEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        public RebuildEnvironmentResponse RebuildEnvironment(RebuildEnvironmentRequest request)
        {
            var marshaller = new RebuildEnvironmentRequestMarshaller();
            var unmarshaller = RebuildEnvironmentResponseUnmarshaller.Instance;

            return Invoke<RebuildEnvironmentRequest,RebuildEnvironmentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebuildEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebuildEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RebuildEnvironmentResponse> RebuildEnvironmentAsync(RebuildEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebuildEnvironmentRequestMarshaller();
            var unmarshaller = RebuildEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<RebuildEnvironmentRequest,RebuildEnvironmentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public RequestEnvironmentInfoResponse RequestEnvironmentInfo(RequestEnvironmentInfoRequest request)
        {
            var marshaller = new RequestEnvironmentInfoRequestMarshaller();
            var unmarshaller = RequestEnvironmentInfoResponseUnmarshaller.Instance;

            return Invoke<RequestEnvironmentInfoRequest,RequestEnvironmentInfoResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RequestEnvironmentInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestEnvironmentInfo operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RequestEnvironmentInfoResponse> RequestEnvironmentInfoAsync(RequestEnvironmentInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RequestEnvironmentInfoRequestMarshaller();
            var unmarshaller = RequestEnvironmentInfoResponseUnmarshaller.Instance;

            return InvokeAsync<RequestEnvironmentInfoRequest,RequestEnvironmentInfoResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestartAppServer


        /// <summary>
        /// Causes the environment to restart the application container server running on each
        /// Amazon EC2 instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestartAppServer service method.</param>
        /// 
        /// <returns>The response from the RestartAppServer service method, as returned by ElasticBeanstalk.</returns>
        public RestartAppServerResponse RestartAppServer(RestartAppServerRequest request)
        {
            var marshaller = new RestartAppServerRequestMarshaller();
            var unmarshaller = RestartAppServerResponseUnmarshaller.Instance;

            return Invoke<RestartAppServerRequest,RestartAppServerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestartAppServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestartAppServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RestartAppServerResponse> RestartAppServerAsync(RestartAppServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestartAppServerRequestMarshaller();
            var unmarshaller = RestartAppServerResponseUnmarshaller.Instance;

            return InvokeAsync<RestartAppServerRequest,RestartAppServerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public RetrieveEnvironmentInfoResponse RetrieveEnvironmentInfo(RetrieveEnvironmentInfoRequest request)
        {
            var marshaller = new RetrieveEnvironmentInfoRequestMarshaller();
            var unmarshaller = RetrieveEnvironmentInfoResponseUnmarshaller.Instance;

            return Invoke<RetrieveEnvironmentInfoRequest,RetrieveEnvironmentInfoResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveEnvironmentInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveEnvironmentInfo operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RetrieveEnvironmentInfoResponse> RetrieveEnvironmentInfoAsync(RetrieveEnvironmentInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RetrieveEnvironmentInfoRequestMarshaller();
            var unmarshaller = RetrieveEnvironmentInfoResponseUnmarshaller.Instance;

            return InvokeAsync<RetrieveEnvironmentInfoRequest,RetrieveEnvironmentInfoResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SwapEnvironmentCNAMEs


        /// <summary>
        /// Swaps the CNAMEs of two environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs service method.</param>
        /// 
        /// <returns>The response from the SwapEnvironmentCNAMEs service method, as returned by ElasticBeanstalk.</returns>
        public SwapEnvironmentCNAMEsResponse SwapEnvironmentCNAMEs(SwapEnvironmentCNAMEsRequest request)
        {
            var marshaller = new SwapEnvironmentCNAMEsRequestMarshaller();
            var unmarshaller = SwapEnvironmentCNAMEsResponseUnmarshaller.Instance;

            return Invoke<SwapEnvironmentCNAMEsRequest,SwapEnvironmentCNAMEsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SwapEnvironmentCNAMEs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SwapEnvironmentCNAMEsResponse> SwapEnvironmentCNAMEsAsync(SwapEnvironmentCNAMEsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SwapEnvironmentCNAMEsRequestMarshaller();
            var unmarshaller = SwapEnvironmentCNAMEsResponseUnmarshaller.Instance;

            return InvokeAsync<SwapEnvironmentCNAMEsRequest,SwapEnvironmentCNAMEsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TerminateEnvironment


        /// <summary>
        /// Terminates the specified environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateEnvironment service method.</param>
        /// 
        /// <returns>The response from the TerminateEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        public TerminateEnvironmentResponse TerminateEnvironment(TerminateEnvironmentRequest request)
        {
            var marshaller = new TerminateEnvironmentRequestMarshaller();
            var unmarshaller = TerminateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<TerminateEnvironmentRequest,TerminateEnvironmentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<TerminateEnvironmentResponse> TerminateEnvironmentAsync(TerminateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TerminateEnvironmentRequestMarshaller();
            var unmarshaller = TerminateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateEnvironmentRequest,TerminateEnvironmentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplication


        /// <summary>
        /// Updates the specified application to have the specified properties. 
        /// 
        ///  <note> If a property (for example, <code>description</code>) is not provided, the
        /// value remains unchanged. To clear these properties, specify an empty string. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by ElasticBeanstalk.</returns>
        public UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var marshaller = new UpdateApplicationRequestMarshaller();
            var unmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationRequest,UpdateApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateApplicationRequestMarshaller();
            var unmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationRequest,UpdateApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplicationVersion


        /// <summary>
        /// Updates the specified application version to have the specified properties. 
        /// 
        ///  <note> If a property (for example, <code>description</code>) is not provided, the
        /// value remains unchanged. To clear properties, specify an empty string. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        public UpdateApplicationVersionResponse UpdateApplicationVersion(UpdateApplicationVersionRequest request)
        {
            var marshaller = new UpdateApplicationVersionRequestMarshaller();
            var unmarshaller = UpdateApplicationVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationVersionRequest,UpdateApplicationVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateApplicationVersionResponse> UpdateApplicationVersionAsync(UpdateApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateApplicationVersionRequestMarshaller();
            var unmarshaller = UpdateApplicationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationVersionRequest,UpdateApplicationVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfigurationTemplate


        /// <summary>
        /// Updates the specified configuration template to have the specified properties or
        /// configuration option values. 
        /// 
        ///  <note> If a property (for example, <code>ApplicationName</code>) is not provided,
        /// its value remains unchanged. To clear such properties, specify an empty string. </note>
        /// 
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> <a>DescribeConfigurationOptions</a> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        public UpdateConfigurationTemplateResponse UpdateConfigurationTemplate(UpdateConfigurationTemplateRequest request)
        {
            var marshaller = new UpdateConfigurationTemplateRequestMarshaller();
            var unmarshaller = UpdateConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationTemplateRequest,UpdateConfigurationTemplateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateConfigurationTemplateResponse> UpdateConfigurationTemplateAsync(UpdateConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateConfigurationTemplateRequestMarshaller();
            var unmarshaller = UpdateConfigurationTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigurationTemplateRequest,UpdateConfigurationTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        public UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
        {
            var marshaller = new UpdateEnvironmentRequestMarshaller();
            var unmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentRequest,UpdateEnvironmentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateEnvironmentRequestMarshaller();
            var unmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnvironmentRequest,UpdateEnvironmentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        public ValidateConfigurationSettingsResponse ValidateConfigurationSettings(ValidateConfigurationSettingsRequest request)
        {
            var marshaller = new ValidateConfigurationSettingsRequestMarshaller();
            var unmarshaller = ValidateConfigurationSettingsResponseUnmarshaller.Instance;

            return Invoke<ValidateConfigurationSettingsRequest,ValidateConfigurationSettingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateConfigurationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateConfigurationSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ValidateConfigurationSettingsResponse> ValidateConfigurationSettingsAsync(ValidateConfigurationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ValidateConfigurationSettingsRequestMarshaller();
            var unmarshaller = ValidateConfigurationSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<ValidateConfigurationSettingsRequest,ValidateConfigurationSettingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}
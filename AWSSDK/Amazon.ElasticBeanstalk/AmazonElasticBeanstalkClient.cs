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


using System;
using System.Threading;

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
    ///          This is the AWS Elastic Beanstalk API Reference. This guide provides detailed
    /// information          about AWS Elastic Beanstalk actions, data types, parameters,
    /// and errors.      
    /// </para>
    ///       
    /// <para>
    /// AWS Elastic Beanstalk         is a tool that makes it easy for you to create,    
    ///     deploy, and manage scalable, fault-tolerant applications running on         Amazon
    /// Web Services cloud resources.      
    /// </para>
    ///       
    /// <para>
    ///          For more information about this product, go to the <a href="http://aws.amazon.com/elasticbeanstalk/">AWS
    /// Elastic Beanstalk</a> details page.           The location of the latest AWS Elastic
    /// Beanstalk WSDL is          <a href="http://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl">http://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl</a>.
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
    public partial class AmazonElasticBeanstalkClient : AmazonWebServiceClient, AmazonElasticBeanstalk
    {
        AbstractAWSSigner signer = new AWS4Signer();
        
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
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonElasticBeanstalkClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticBeanstalkConfig(), true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticBeanstalkClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticBeanstalkConfig{RegionEndpoint = region}, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonElasticBeanstalkClient Configuration Object</param>
        public AmazonElasticBeanstalkClient(AmazonElasticBeanstalkConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
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
            IAsyncResult asyncResult = invokeCheckDNSAvailability(request, null, null, true);
            return EndCheckDNSAvailability(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CheckDNSAvailability operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckDNSAvailability operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCheckDNSAvailability
        ///         operation.</returns>
        public IAsyncResult BeginCheckDNSAvailability(CheckDNSAvailabilityRequest request, AsyncCallback callback, object state)
        {
            return invokeCheckDNSAvailability(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CheckDNSAvailability operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckDNSAvailability.</param>
        /// 
        /// <returns>Returns a  CheckDNSAvailabilityResult from ElasticBeanstalk.</returns>
        public  CheckDNSAvailabilityResponse EndCheckDNSAvailability(IAsyncResult asyncResult)
        {
            return endOperation< CheckDNSAvailabilityResponse>(asyncResult);
        }

        IAsyncResult invokeCheckDNSAvailability(CheckDNSAvailabilityRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CheckDNSAvailabilityRequestMarshaller().Marshall(request);
            var unmarshaller = CheckDNSAvailabilityResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  CreateApplication


        /// <summary>
        /// Creates an application that has one configuration         template named
        ///         <code>default</code>         and no application versions.      
        /// 
        ///       The         &lt;code&gt;default&lt;/code&gt;         configuration template
        /// is for a 32-bit version of the         Amazon Linux         operating system running
        /// the Tomcat 6 application container.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="TooManyApplicationsException">
        /// The caller has exceeded the limit on the number of applications associated with their
        /// account.
        /// </exception>
        public CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            IAsyncResult asyncResult = invokeCreateApplication(request, null, null, true);
            return EndCreateApplication(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        public IAsyncResult BeginCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateApplication(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a  CreateApplicationResult from ElasticBeanstalk.</returns>
        public  CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult)
        {
            return endOperation< CreateApplicationResponse>(asyncResult);
        }

        IAsyncResult invokeCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateApplicationRequestMarshaller().Marshall(request);
            var unmarshaller = CreateApplicationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  CreateApplicationVersion


        /// <summary>
        /// Creates an application version for the specified         application.
        /// 
        ///       <note>Once you create an application version with a specified Amazon S3    
        ///     bucket         and key location, you cannot change that Amazon S3 location. If
        /// you change the         Amazon S3 location,         you receive an exception when you
        /// attempt to launch an environment from the         application version. </note>
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
        public CreateApplicationVersionResponse CreateApplicationVersion(CreateApplicationVersionRequest request)
        {
            IAsyncResult asyncResult = invokeCreateApplicationVersion(request, null, null, true);
            return EndCreateApplicationVersion(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationVersion operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplicationVersion
        ///         operation.</returns>
        public IAsyncResult BeginCreateApplicationVersion(CreateApplicationVersionRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateApplicationVersion(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplicationVersion.</param>
        /// 
        /// <returns>Returns a  CreateApplicationVersionResult from ElasticBeanstalk.</returns>
        public  CreateApplicationVersionResponse EndCreateApplicationVersion(IAsyncResult asyncResult)
        {
            return endOperation< CreateApplicationVersionResponse>(asyncResult);
        }

        IAsyncResult invokeCreateApplicationVersion(CreateApplicationVersionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateApplicationVersionRequestMarshaller().Marshall(request);
            var unmarshaller = CreateApplicationVersionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  CreateConfigurationTemplate


        /// <summary>
        /// Creates a configuration template. Templates are associated with a         specific
        /// application         and are used to deploy different versions of the         application
        /// with         the same configuration settings.
        /// 
        ///       
        /// <para>
        /// Related Topics
        /// </para>
        ///       <ul>         <li>            <a>DescribeConfigurationOptions</a>         </li>
        ///         <li>            <a>DescribeConfigurationSettings</a>         </li>       
        ///  <li>            <a>ListAvailableSolutionStacks</a>         </li>      </ul>
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
        public CreateConfigurationTemplateResponse CreateConfigurationTemplate(CreateConfigurationTemplateRequest request)
        {
            IAsyncResult asyncResult = invokeCreateConfigurationTemplate(request, null, null, true);
            return EndCreateConfigurationTemplate(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationTemplate operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfigurationTemplate
        ///         operation.</returns>
        public IAsyncResult BeginCreateConfigurationTemplate(CreateConfigurationTemplateRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateConfigurationTemplate(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  CreateConfigurationTemplateResult from ElasticBeanstalk.</returns>
        public  CreateConfigurationTemplateResponse EndCreateConfigurationTemplate(IAsyncResult asyncResult)
        {
            return endOperation< CreateConfigurationTemplateResponse>(asyncResult);
        }

        IAsyncResult invokeCreateConfigurationTemplate(CreateConfigurationTemplateRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateConfigurationTemplateRequestMarshaller().Marshall(request);
            var unmarshaller = CreateConfigurationTemplateResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  CreateEnvironment


        /// <summary>
        /// Launches an environment for the specified application using         the specified
        /// configuration.
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
        public CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            IAsyncResult asyncResult = invokeCreateEnvironment(request, null, null, true);
            return EndCreateEnvironment(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironment
        ///         operation.</returns>
        public IAsyncResult BeginCreateEnvironment(CreateEnvironmentRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateEnvironment(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironment.</param>
        /// 
        /// <returns>Returns a  CreateEnvironmentResult from ElasticBeanstalk.</returns>
        public  CreateEnvironmentResponse EndCreateEnvironment(IAsyncResult asyncResult)
        {
            return endOperation< CreateEnvironmentResponse>(asyncResult);
        }

        IAsyncResult invokeCreateEnvironment(CreateEnvironmentRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateEnvironmentRequestMarshaller().Marshall(request);
            var unmarshaller = CreateEnvironmentResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  CreateStorageLocation

        /// <summary>
        /// Creates the Amazon S3 storage location for the account.        
        /// 
        ///       
        /// <para>
        ///          This location is used to store user log files.        
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
        public CreateStorageLocationResponse CreateStorageLocation()
        {
            return CreateStorageLocation(new CreateStorageLocationRequest());
        }

        /// <summary>
        /// Creates the Amazon S3 storage location for the account.        
        /// 
        ///       
        /// <para>
        ///          This location is used to store user log files.        
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
        public CreateStorageLocationResponse CreateStorageLocation(CreateStorageLocationRequest request)
        {
            IAsyncResult asyncResult = invokeCreateStorageLocation(request, null, null, true);
            return EndCreateStorageLocation(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStorageLocation operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageLocation operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStorageLocation
        ///         operation.</returns>
        public IAsyncResult BeginCreateStorageLocation(CreateStorageLocationRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateStorageLocation(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStorageLocation operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStorageLocation.</param>
        /// 
        /// <returns>Returns a  CreateStorageLocationResult from ElasticBeanstalk.</returns>
        public  CreateStorageLocationResponse EndCreateStorageLocation(IAsyncResult asyncResult)
        {
            return endOperation< CreateStorageLocationResponse>(asyncResult);
        }

        IAsyncResult invokeCreateStorageLocation(CreateStorageLocationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateStorageLocationRequestMarshaller().Marshall(request);
            var unmarshaller = CreateStorageLocationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DeleteApplication


        /// <summary>
        /// Deletes the specified application along with all         associated versions
        /// and         configurations. The application versions will not be deleted from your
        /// Amazon S3 bucket.      
        /// 
        ///       <note>You cannot delete an application that has a running environment.     
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="OperationInProgressException">
        /// Unable to perform the specified operation because another operation is already in
        /// progress affecting an an element in this activity.
        /// </exception>
        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteApplication(request, null, null, true);
            return EndDeleteApplication(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplication
        ///         operation.</returns>
        public IAsyncResult BeginDeleteApplication(DeleteApplicationRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteApplication(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationResult from ElasticBeanstalk.</returns>
        public  DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult)
        {
            return endOperation< DeleteApplicationResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteApplication(DeleteApplicationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteApplicationRequestMarshaller().Marshall(request);
            var unmarshaller = DeleteApplicationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DeleteApplicationVersion


        /// <summary>
        /// Deletes the specified version from the specified         application.   
        ///   
        /// 
        ///       <note>You cannot delete an application version that is associated with a   
        ///      running environment.</note>
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
        public DeleteApplicationVersionResponse DeleteApplicationVersion(DeleteApplicationVersionRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteApplicationVersion(request, null, null, true);
            return EndDeleteApplicationVersion(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationVersion operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplicationVersion
        ///         operation.</returns>
        public IAsyncResult BeginDeleteApplicationVersion(DeleteApplicationVersionRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteApplicationVersion(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplicationVersion.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationVersionResult from ElasticBeanstalk.</returns>
        public  DeleteApplicationVersionResponse EndDeleteApplicationVersion(IAsyncResult asyncResult)
        {
            return endOperation< DeleteApplicationVersionResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteApplicationVersion(DeleteApplicationVersionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteApplicationVersionRequestMarshaller().Marshall(request);
            var unmarshaller = DeleteApplicationVersionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DeleteConfigurationTemplate


        /// <summary>
        /// Deletes the specified configuration template.
        /// 
        ///       <note>When you launch an environment using a configuration template, the   
        ///      environment         gets a copy of the template. You can delete or modify the
        /// environment's copy of         the template without         affecting the running environment.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="OperationInProgressException">
        /// Unable to perform the specified operation because another operation is already in
        /// progress affecting an an element in this activity.
        /// </exception>
        public DeleteConfigurationTemplateResponse DeleteConfigurationTemplate(DeleteConfigurationTemplateRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteConfigurationTemplate(request, null, null, true);
            return EndDeleteConfigurationTemplate(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationTemplate operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigurationTemplate
        ///         operation.</returns>
        public IAsyncResult BeginDeleteConfigurationTemplate(DeleteConfigurationTemplateRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteConfigurationTemplate(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationTemplateResult from ElasticBeanstalk.</returns>
        public  DeleteConfigurationTemplateResponse EndDeleteConfigurationTemplate(IAsyncResult asyncResult)
        {
            return endOperation< DeleteConfigurationTemplateResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteConfigurationTemplate(DeleteConfigurationTemplateRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteConfigurationTemplateRequestMarshaller().Marshall(request);
            var unmarshaller = DeleteConfigurationTemplateResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DeleteEnvironmentConfiguration


        /// <summary>
        /// Deletes the draft configuration associated with the running environment.        
        /// 
        ///       
        /// <para>
        ///          Updating a running environment with any configuration changes creates a 
        ///        draft configuration set. You can get the draft configuration using        
        /// <a>DescribeConfigurationSettings</a> while the update is in progress          or if
        /// the update fails. The <code>DeploymentStatus</code> for the draft          configuration
        /// indicates whether the deployment is in process or has failed.         The draft configuration
        /// remains in existence until it is deleted with this action.      
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironmentConfiguration service method, as returned by ElasticBeanstalk.</returns>
        public DeleteEnvironmentConfigurationResponse DeleteEnvironmentConfiguration(DeleteEnvironmentConfigurationRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteEnvironmentConfiguration(request, null, null, true);
            return EndDeleteEnvironmentConfiguration(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironmentConfiguration operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentConfiguration operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironmentConfiguration
        ///         operation.</returns>
        public IAsyncResult BeginDeleteEnvironmentConfiguration(DeleteEnvironmentConfigurationRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteEnvironmentConfiguration(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnvironmentConfiguration operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironmentConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteEnvironmentConfigurationResult from ElasticBeanstalk.</returns>
        public  DeleteEnvironmentConfigurationResponse EndDeleteEnvironmentConfiguration(IAsyncResult asyncResult)
        {
            return endOperation< DeleteEnvironmentConfigurationResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteEnvironmentConfiguration(DeleteEnvironmentConfigurationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteEnvironmentConfigurationRequestMarshaller().Marshall(request);
            var unmarshaller = DeleteEnvironmentConfigurationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
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
            IAsyncResult asyncResult = invokeDescribeApplications(request, null, null, true);
            return EndDescribeApplications(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplications operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplications operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplications
        ///         operation.</returns>
        public IAsyncResult BeginDescribeApplications(DescribeApplicationsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeApplications(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplications operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplications.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationsResult from ElasticBeanstalk.</returns>
        public  DescribeApplicationsResponse EndDescribeApplications(IAsyncResult asyncResult)
        {
            return endOperation< DescribeApplicationsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeApplications(DescribeApplicationsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeApplicationsRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeApplicationsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeApplicationVersions

        /// <summary>
        /// Returns descriptions for existing application versions.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by ElasticBeanstalk.</returns>
        public DescribeApplicationVersionsResponse DescribeApplicationVersions()
        {
            return DescribeApplicationVersions(new DescribeApplicationVersionsRequest());
        }

        /// <summary>
        /// Returns descriptions for existing application versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by ElasticBeanstalk.</returns>
        public DescribeApplicationVersionsResponse DescribeApplicationVersions(DescribeApplicationVersionsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeApplicationVersions(request, null, null, true);
            return EndDescribeApplicationVersions(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationVersions operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationVersions operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplicationVersions
        ///         operation.</returns>
        public IAsyncResult BeginDescribeApplicationVersions(DescribeApplicationVersionsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeApplicationVersions(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplicationVersions operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplicationVersions.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationVersionsResult from ElasticBeanstalk.</returns>
        public  DescribeApplicationVersionsResponse EndDescribeApplicationVersions(IAsyncResult asyncResult)
        {
            return endOperation< DescribeApplicationVersionsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeApplicationVersions(DescribeApplicationVersionsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeApplicationVersionsRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeApplicationVersionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeConfigurationOptions

        /// <summary>
        /// Describes the configuration options that are used in a         particular
        /// configuration template or environment, or that          a specified solution stack
        /// defines. The description includes the values the         options, their default values,
        /// and an indication of         the required action on a running environment if an option
        /// value is changed.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by ElasticBeanstalk.</returns>
        public DescribeConfigurationOptionsResponse DescribeConfigurationOptions()
        {
            return DescribeConfigurationOptions(new DescribeConfigurationOptionsRequest());
        }

        /// <summary>
        /// Describes the configuration options that are used in a         particular
        /// configuration template or environment, or that          a specified solution stack
        /// defines. The description includes the values the         options, their default values,
        /// and an indication of         the required action on a running environment if an option
        /// value is changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by ElasticBeanstalk.</returns>
        public DescribeConfigurationOptionsResponse DescribeConfigurationOptions(DescribeConfigurationOptionsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeConfigurationOptions(request, null, null, true);
            return EndDescribeConfigurationOptions(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationOptions operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationOptions operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigurationOptions
        ///         operation.</returns>
        public IAsyncResult BeginDescribeConfigurationOptions(DescribeConfigurationOptionsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeConfigurationOptions(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigurationOptions operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationOptions.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationOptionsResult from ElasticBeanstalk.</returns>
        public  DescribeConfigurationOptionsResponse EndDescribeConfigurationOptions(IAsyncResult asyncResult)
        {
            return endOperation< DescribeConfigurationOptionsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeConfigurationOptions(DescribeConfigurationOptionsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeConfigurationOptionsRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeConfigurationOptionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeConfigurationSettings


        /// <summary>
        /// Returns a description of the settings for the specified         configuration
        /// set, that is, either a configuration template or the         configuration set associated
        /// with a running environment.        
        /// 
        ///       
        /// <para>
        ///          When describing the settings for the configuration set associated with a
        ///         running environment, it is possible to receive two sets of setting descriptions.
        ///         One is the deployed configuration set, and the other is a draft configuration
        ///         of an environment that is either in the process of deployment or that failed
        /// to         deploy.         
        /// </para>
        ///       
        /// <para>
        /// Related Topics
        /// </para>
        ///       <ul>         <li>            <a>DeleteEnvironmentConfiguration</a>         </li>
        ///      </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationSettings service method, as returned by ElasticBeanstalk.</returns>
        public DescribeConfigurationSettingsResponse DescribeConfigurationSettings(DescribeConfigurationSettingsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeConfigurationSettings(request, null, null, true);
            return EndDescribeConfigurationSettings(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationSettings operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSettings operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigurationSettings
        ///         operation.</returns>
        public IAsyncResult BeginDescribeConfigurationSettings(DescribeConfigurationSettingsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeConfigurationSettings(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigurationSettings operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationSettings.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationSettingsResult from ElasticBeanstalk.</returns>
        public  DescribeConfigurationSettingsResponse EndDescribeConfigurationSettings(IAsyncResult asyncResult)
        {
            return endOperation< DescribeConfigurationSettingsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeConfigurationSettings(DescribeConfigurationSettingsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeConfigurationSettingsRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeConfigurationSettingsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DescribeEnvironmentResourcesResponse DescribeEnvironmentResources(DescribeEnvironmentResourcesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeEnvironmentResources(request, null, null, true);
            return EndDescribeEnvironmentResources(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentResources operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentResources operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEnvironmentResources
        ///         operation.</returns>
        public IAsyncResult BeginDescribeEnvironmentResources(DescribeEnvironmentResourcesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeEnvironmentResources(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEnvironmentResources operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEnvironmentResources.</param>
        /// 
        /// <returns>Returns a  DescribeEnvironmentResourcesResult from ElasticBeanstalk.</returns>
        public  DescribeEnvironmentResourcesResponse EndDescribeEnvironmentResources(IAsyncResult asyncResult)
        {
            return endOperation< DescribeEnvironmentResourcesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeEnvironmentResources(DescribeEnvironmentResourcesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeEnvironmentResourcesRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeEnvironmentResourcesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
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
            IAsyncResult asyncResult = invokeDescribeEnvironments(request, null, null, true);
            return EndDescribeEnvironments(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironments operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironments operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEnvironments
        ///         operation.</returns>
        public IAsyncResult BeginDescribeEnvironments(DescribeEnvironmentsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeEnvironments(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEnvironments operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEnvironments.</param>
        /// 
        /// <returns>Returns a  DescribeEnvironmentsResult from ElasticBeanstalk.</returns>
        public  DescribeEnvironmentsResponse EndDescribeEnvironments(IAsyncResult asyncResult)
        {
            return endOperation< DescribeEnvironmentsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeEnvironments(DescribeEnvironmentsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeEnvironmentsRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeEnvironmentsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeEvents

        /// <summary>
        /// Returns list of event descriptions matching criteria up to the last 6 weeks.
        /// 
        ///       <note>         This action returns the most recent 1,000 events from the specified
        ///         <code>NextToken</code>.      </note>
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
        ///       <note>         This action returns the most recent 1,000 events from the specified
        ///         <code>NextToken</code>.      </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElasticBeanstalk.</returns>
        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeEvents(request, null, null, true);
            return EndDescribeEvents(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        public IAsyncResult BeginDescribeEvents(DescribeEventsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeEvents(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEvents operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a  DescribeEventsResult from ElasticBeanstalk.</returns>
        public  DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult)
        {
            return endOperation< DescribeEventsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeEvents(DescribeEventsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeEventsRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeEventsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
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
            IAsyncResult asyncResult = invokeListAvailableSolutionStacks(request, null, null, true);
            return EndListAvailableSolutionStacks(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableSolutionStacks operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableSolutionStacks operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAvailableSolutionStacks
        ///         operation.</returns>
        public IAsyncResult BeginListAvailableSolutionStacks(ListAvailableSolutionStacksRequest request, AsyncCallback callback, object state)
        {
            return invokeListAvailableSolutionStacks(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAvailableSolutionStacks operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailableSolutionStacks.</param>
        /// 
        /// <returns>Returns a  ListAvailableSolutionStacksResult from ElasticBeanstalk.</returns>
        public  ListAvailableSolutionStacksResponse EndListAvailableSolutionStacks(IAsyncResult asyncResult)
        {
            return endOperation< ListAvailableSolutionStacksResponse>(asyncResult);
        }

        IAsyncResult invokeListAvailableSolutionStacks(ListAvailableSolutionStacksRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListAvailableSolutionStacksRequestMarshaller().Marshall(request);
            var unmarshaller = ListAvailableSolutionStacksResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  RebuildEnvironment


        /// <summary>
        /// Deletes and recreates all of the AWS resources (for example: the Auto Scaling
        /// group, load         balancer, etc.)         for a specified environment and forces
        /// a restart.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebuildEnvironment service method.</param>
        /// 
        /// <returns>The response from the RebuildEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        public RebuildEnvironmentResponse RebuildEnvironment(RebuildEnvironmentRequest request)
        {
            IAsyncResult asyncResult = invokeRebuildEnvironment(request, null, null, true);
            return EndRebuildEnvironment(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebuildEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebuildEnvironment operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebuildEnvironment
        ///         operation.</returns>
        public IAsyncResult BeginRebuildEnvironment(RebuildEnvironmentRequest request, AsyncCallback callback, object state)
        {
            return invokeRebuildEnvironment(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RebuildEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebuildEnvironment.</param>
        /// 
        /// <returns>Returns a  RebuildEnvironmentResult from ElasticBeanstalk.</returns>
        public  RebuildEnvironmentResponse EndRebuildEnvironment(IAsyncResult asyncResult)
        {
            return endOperation< RebuildEnvironmentResponse>(asyncResult);
        }

        IAsyncResult invokeRebuildEnvironment(RebuildEnvironmentRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RebuildEnvironmentRequestMarshaller().Marshall(request);
            var unmarshaller = RebuildEnvironmentResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  RequestEnvironmentInfo


        /// <summary>
        /// Initiates a request to compile the specified type of         information
        /// of the deployed environment.      
        /// 
        ///       
        /// <para>
        ///          Setting the <code>InfoType</code> to <code>tail</code>         compiles the
        /// last lines from the application server log files of every         Amazon EC2 instance
        /// in your environment. Use <a>RetrieveEnvironmentInfo</a>         to access the compiled
        /// information.      
        /// </para>
        ///        
        /// <para>
        /// Related Topics
        /// </para>
        ///       <ul>                <li>            <a>RetrieveEnvironmentInfo</a>         </li>
        ///      </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestEnvironmentInfo service method.</param>
        /// 
        /// <returns>The response from the RequestEnvironmentInfo service method, as returned by ElasticBeanstalk.</returns>
        public RequestEnvironmentInfoResponse RequestEnvironmentInfo(RequestEnvironmentInfoRequest request)
        {
            IAsyncResult asyncResult = invokeRequestEnvironmentInfo(request, null, null, true);
            return EndRequestEnvironmentInfo(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RequestEnvironmentInfo operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestEnvironmentInfo operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRequestEnvironmentInfo
        ///         operation.</returns>
        public IAsyncResult BeginRequestEnvironmentInfo(RequestEnvironmentInfoRequest request, AsyncCallback callback, object state)
        {
            return invokeRequestEnvironmentInfo(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RequestEnvironmentInfo operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestEnvironmentInfo.</param>
        /// 
        /// <returns>Returns a  RequestEnvironmentInfoResult from ElasticBeanstalk.</returns>
        public  RequestEnvironmentInfoResponse EndRequestEnvironmentInfo(IAsyncResult asyncResult)
        {
            return endOperation< RequestEnvironmentInfoResponse>(asyncResult);
        }

        IAsyncResult invokeRequestEnvironmentInfo(RequestEnvironmentInfoRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RequestEnvironmentInfoRequestMarshaller().Marshall(request);
            var unmarshaller = RequestEnvironmentInfoResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  RestartAppServer


        /// <summary>
        /// Causes the environment to restart the application         container server
        /// running on each Amazon EC2 instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestartAppServer service method.</param>
        /// 
        /// <returns>The response from the RestartAppServer service method, as returned by ElasticBeanstalk.</returns>
        public RestartAppServerResponse RestartAppServer(RestartAppServerRequest request)
        {
            IAsyncResult asyncResult = invokeRestartAppServer(request, null, null, true);
            return EndRestartAppServer(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestartAppServer operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestartAppServer operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestartAppServer
        ///         operation.</returns>
        public IAsyncResult BeginRestartAppServer(RestartAppServerRequest request, AsyncCallback callback, object state)
        {
            return invokeRestartAppServer(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RestartAppServer operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestartAppServer.</param>
        /// 
        /// <returns>Returns a  RestartAppServerResult from ElasticBeanstalk.</returns>
        public  RestartAppServerResponse EndRestartAppServer(IAsyncResult asyncResult)
        {
            return endOperation< RestartAppServerResponse>(asyncResult);
        }

        IAsyncResult invokeRestartAppServer(RestartAppServerRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RestartAppServerRequestMarshaller().Marshall(request);
            var unmarshaller = RestartAppServerResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  RetrieveEnvironmentInfo


        /// <summary>
        /// Retrieves the compiled information from a         <a>RequestEnvironmentInfo</a>
        ///         request.      
        /// 
        ///        
        /// <para>
        /// Related Topics
        /// </para>
        ///       <ul>             <li>            <a>RequestEnvironmentInfo</a>         </li>
        ///      </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveEnvironmentInfo service method.</param>
        /// 
        /// <returns>The response from the RetrieveEnvironmentInfo service method, as returned by ElasticBeanstalk.</returns>
        public RetrieveEnvironmentInfoResponse RetrieveEnvironmentInfo(RetrieveEnvironmentInfoRequest request)
        {
            IAsyncResult asyncResult = invokeRetrieveEnvironmentInfo(request, null, null, true);
            return EndRetrieveEnvironmentInfo(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveEnvironmentInfo operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveEnvironmentInfo operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetrieveEnvironmentInfo
        ///         operation.</returns>
        public IAsyncResult BeginRetrieveEnvironmentInfo(RetrieveEnvironmentInfoRequest request, AsyncCallback callback, object state)
        {
            return invokeRetrieveEnvironmentInfo(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RetrieveEnvironmentInfo operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetrieveEnvironmentInfo.</param>
        /// 
        /// <returns>Returns a  RetrieveEnvironmentInfoResult from ElasticBeanstalk.</returns>
        public  RetrieveEnvironmentInfoResponse EndRetrieveEnvironmentInfo(IAsyncResult asyncResult)
        {
            return endOperation< RetrieveEnvironmentInfoResponse>(asyncResult);
        }

        IAsyncResult invokeRetrieveEnvironmentInfo(RetrieveEnvironmentInfoRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RetrieveEnvironmentInfoRequestMarshaller().Marshall(request);
            var unmarshaller = RetrieveEnvironmentInfoResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
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
            IAsyncResult asyncResult = invokeSwapEnvironmentCNAMEs(request, null, null, true);
            return EndSwapEnvironmentCNAMEs(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SwapEnvironmentCNAMEs operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSwapEnvironmentCNAMEs
        ///         operation.</returns>
        public IAsyncResult BeginSwapEnvironmentCNAMEs(SwapEnvironmentCNAMEsRequest request, AsyncCallback callback, object state)
        {
            return invokeSwapEnvironmentCNAMEs(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  SwapEnvironmentCNAMEs operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSwapEnvironmentCNAMEs.</param>
        /// 
        /// <returns>Returns a  SwapEnvironmentCNAMEsResult from ElasticBeanstalk.</returns>
        public  SwapEnvironmentCNAMEsResponse EndSwapEnvironmentCNAMEs(IAsyncResult asyncResult)
        {
            return endOperation< SwapEnvironmentCNAMEsResponse>(asyncResult);
        }

        IAsyncResult invokeSwapEnvironmentCNAMEs(SwapEnvironmentCNAMEsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SwapEnvironmentCNAMEsRequestMarshaller().Marshall(request);
            var unmarshaller = SwapEnvironmentCNAMEsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public TerminateEnvironmentResponse TerminateEnvironment(TerminateEnvironmentRequest request)
        {
            IAsyncResult asyncResult = invokeTerminateEnvironment(request, null, null, true);
            return EndTerminateEnvironment(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateEnvironment operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateEnvironment
        ///         operation.</returns>
        public IAsyncResult BeginTerminateEnvironment(TerminateEnvironmentRequest request, AsyncCallback callback, object state)
        {
            return invokeTerminateEnvironment(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateEnvironment.</param>
        /// 
        /// <returns>Returns a  TerminateEnvironmentResult from ElasticBeanstalk.</returns>
        public  TerminateEnvironmentResponse EndTerminateEnvironment(IAsyncResult asyncResult)
        {
            return endOperation< TerminateEnvironmentResponse>(asyncResult);
        }

        IAsyncResult invokeTerminateEnvironment(TerminateEnvironmentRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new TerminateEnvironmentRequestMarshaller().Marshall(request);
            var unmarshaller = TerminateEnvironmentResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  UpdateApplication


        /// <summary>
        /// Updates the specified application to have the specified         properties.      
        /// 
        ///       <note>         If a property (for example, <code>description</code>) is not
        /// provided, the         value         remains unchanged. To clear these properties,
        /// specify an empty string.      </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by ElasticBeanstalk.</returns>
        public UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateApplication(request, null, null, true);
            return EndUpdateApplication(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        public IAsyncResult BeginUpdateApplication(UpdateApplicationRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateApplication(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplication.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationResult from ElasticBeanstalk.</returns>
        public  UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult)
        {
            return endOperation< UpdateApplicationResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateApplication(UpdateApplicationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateApplicationRequestMarshaller().Marshall(request);
            var unmarshaller = UpdateApplicationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  UpdateApplicationVersion


        /// <summary>
        /// Updates the specified application version to have the specified         properties.
        ///               
        /// 
        ///       <note>         If a property (for example,         <code>description</code>)
        /// is not provided, the         value remains unchanged. To clear properties,       
        ///  specify an empty string.      </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        public UpdateApplicationVersionResponse UpdateApplicationVersion(UpdateApplicationVersionRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateApplicationVersion(request, null, null, true);
            return EndUpdateApplicationVersion(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationVersion operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplicationVersion
        ///         operation.</returns>
        public IAsyncResult BeginUpdateApplicationVersion(UpdateApplicationVersionRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateApplicationVersion(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplicationVersion.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationVersionResult from ElasticBeanstalk.</returns>
        public  UpdateApplicationVersionResponse EndUpdateApplicationVersion(IAsyncResult asyncResult)
        {
            return endOperation< UpdateApplicationVersionResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateApplicationVersion(UpdateApplicationVersionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateApplicationVersionRequestMarshaller().Marshall(request);
            var unmarshaller = UpdateApplicationVersionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  UpdateConfigurationTemplate


        /// <summary>
        /// Updates the specified configuration template to have the specified      
        ///   properties or configuration option values.      
        /// 
        ///       <note>         If a property (for example,         <code>ApplicationName</code>)
        /// is not provided, its         value remains unchanged. To clear such         properties,
        /// specify an empty string.      </note>      
        /// <para>
        /// Related Topics
        /// </para>
        ///       <ul>         <li>            <a>DescribeConfigurationOptions</a>         </li>
        ///      </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        public UpdateConfigurationTemplateResponse UpdateConfigurationTemplate(UpdateConfigurationTemplateRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateConfigurationTemplate(request, null, null, true);
            return EndUpdateConfigurationTemplate(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationTemplate operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfigurationTemplate
        ///         operation.</returns>
        public IAsyncResult BeginUpdateConfigurationTemplate(UpdateConfigurationTemplateRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateConfigurationTemplate(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateConfigurationTemplateResult from ElasticBeanstalk.</returns>
        public  UpdateConfigurationTemplateResponse EndUpdateConfigurationTemplate(IAsyncResult asyncResult)
        {
            return endOperation< UpdateConfigurationTemplateResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateConfigurationTemplate(UpdateConfigurationTemplateRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateConfigurationTemplateRequestMarshaller().Marshall(request);
            var unmarshaller = UpdateConfigurationTemplateResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  UpdateEnvironment


        /// <summary>
        /// Updates the environment description, deploys a new application         version,
        /// updates the configuration settings to an entirely new configuration         template,
        /// or updates select configuration option values in the running         environment.        
        /// 
        ///       
        /// <para>
        ///          Attempting to update both the release and configuration is         not allowed
        /// and AWS Elastic Beanstalk         returns an         <code>InvalidParameterCombination</code>
        ///         error.      
        /// </para>
        ///       
        /// <para>
        ///          When updating the configuration settings to a new template or         individual
        /// settings,         a draft configuration is created and         <a>DescribeConfigurationSettings</a>
        ///         for this         environment returns two setting descriptions with different
        ///         <code>DeploymentStatus</code>         values.      
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        public UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateEnvironment(request, null, null, true);
            return EndUpdateEnvironment(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnvironment
        ///         operation.</returns>
        public IAsyncResult BeginUpdateEnvironment(UpdateEnvironmentRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateEnvironment(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnvironment.</param>
        /// 
        /// <returns>Returns a  UpdateEnvironmentResult from ElasticBeanstalk.</returns>
        public  UpdateEnvironmentResponse EndUpdateEnvironment(IAsyncResult asyncResult)
        {
            return endOperation< UpdateEnvironmentResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateEnvironment(UpdateEnvironmentRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateEnvironmentRequestMarshaller().Marshall(request);
            var unmarshaller = UpdateEnvironmentResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ValidateConfigurationSettings


        /// <summary>
        /// Takes a set of configuration settings and either a configuration        
        /// template or environment, and determines whether those values are valid.        
        /// 
        ///       
        /// <para>
        ///          This action returns a list of messages indicating any errors or warnings
        ///         associated         with the selection of option values.        
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateConfigurationSettings service method.</param>
        /// 
        /// <returns>The response from the ValidateConfigurationSettings service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="InsufficientPrivilegesException">
        /// Unable to perform the specified operation because the user does not have enough privileges
        /// for one of more downstream aws services
        /// </exception>
        public ValidateConfigurationSettingsResponse ValidateConfigurationSettings(ValidateConfigurationSettingsRequest request)
        {
            IAsyncResult asyncResult = invokeValidateConfigurationSettings(request, null, null, true);
            return EndValidateConfigurationSettings(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateConfigurationSettings operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateConfigurationSettings operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidateConfigurationSettings
        ///         operation.</returns>
        public IAsyncResult BeginValidateConfigurationSettings(ValidateConfigurationSettingsRequest request, AsyncCallback callback, object state)
        {
            return invokeValidateConfigurationSettings(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ValidateConfigurationSettings operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateConfigurationSettings.</param>
        /// 
        /// <returns>Returns a  ValidateConfigurationSettingsResult from ElasticBeanstalk.</returns>
        public  ValidateConfigurationSettingsResponse EndValidateConfigurationSettings(IAsyncResult asyncResult)
        {
            return endOperation< ValidateConfigurationSettingsResponse>(asyncResult);
        }

        IAsyncResult invokeValidateConfigurationSettings(ValidateConfigurationSettingsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ValidateConfigurationSettingsRequestMarshaller().Marshall(request);
            var unmarshaller = ValidateConfigurationSettingsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
    }
}
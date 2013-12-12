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
    /// about this product, go to the <a href="http://aws.amazon.com/elasticbeanstalk/" >AWS Elastic Beanstalk</a> details page. The location of the
    /// latest AWS Elastic Beanstalk WSDL is <a href="http://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl"
    /// >http://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl</a> .
    /// </para> <para> <b>Endpoints</b> </para> <para>For a list of region-specific endpoints that AWS Elastic Beanstalk supports, go to <a
    /// href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elasticbeanstalk_region" >Regions and Endpoints</a> in the <i>Amazon Web
    /// Services Glossary</i> .</para>
    /// </summary>
    public partial class AmazonElasticBeanstalkClient : AmazonWebServiceClient, IAmazonElasticBeanstalk
    {
    AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticBeanstalkConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticBeanstalkConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
        /// <param name="config">The AmazonElasticBeanstalk Configuration Object</param>
        public AmazonElasticBeanstalkClient(AmazonElasticBeanstalkConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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


        #region CheckDNSAvailability

        /// <summary>
        /// <para> Checks if the specified CNAME is available. </para>
        /// </summary>
        /// 
        /// <param name="checkDNSAvailabilityRequest">Container for the necessary parameters to execute the CheckDNSAvailability service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CheckDNSAvailability service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        public CheckDNSAvailabilityResponse CheckDNSAvailability(CheckDNSAvailabilityRequest checkDNSAvailabilityRequest)
        {
            IAsyncResult asyncResult = invokeCheckDNSAvailability(checkDNSAvailabilityRequest, null, null, true);
            return EndCheckDNSAvailability(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CheckDNSAvailability operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.CheckDNSAvailability"/>
        /// </summary>
        /// 
        /// <param name="checkDNSAvailabilityRequest">Container for the necessary parameters to execute the CheckDNSAvailability operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCheckDNSAvailability operation.</returns>
        public IAsyncResult BeginCheckDNSAvailability(CheckDNSAvailabilityRequest checkDNSAvailabilityRequest, AsyncCallback callback, object state)
        {
            return invokeCheckDNSAvailability(checkDNSAvailabilityRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CheckDNSAvailability operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.CheckDNSAvailability"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckDNSAvailability.</param>
        /// 
        /// <returns>Returns a CheckDNSAvailabilityResult from AmazonElasticBeanstalk.</returns>
        public CheckDNSAvailabilityResponse EndCheckDNSAvailability(IAsyncResult asyncResult)
        {
            return endOperation<CheckDNSAvailabilityResponse>(asyncResult);
        }
        
        IAsyncResult invokeCheckDNSAvailability(CheckDNSAvailabilityRequest checkDNSAvailabilityRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CheckDNSAvailabilityRequestMarshaller().Marshall(checkDNSAvailabilityRequest);
            var unmarshaller = CheckDNSAvailabilityResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateApplication

        /// <summary>
        /// <para> Creates an application that has one configuration template named <c>default</c> and no application versions. </para>
        /// </summary>
        /// 
        /// <param name="createApplicationRequest">Container for the necessary parameters to execute the CreateApplication service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="TooManyApplicationsException"/>
        public CreateApplicationResponse CreateApplication(CreateApplicationRequest createApplicationRequest)
        {
            IAsyncResult asyncResult = invokeCreateApplication(createApplicationRequest, null, null, true);
            return EndCreateApplication(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.CreateApplication"/>
        /// </summary>
        /// 
        /// <param name="createApplicationRequest">Container for the necessary parameters to execute the CreateApplication operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        public IAsyncResult BeginCreateApplication(CreateApplicationRequest createApplicationRequest, AsyncCallback callback, object state)
        {
            return invokeCreateApplication(createApplicationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.CreateApplication"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a CreateApplicationResult from AmazonElasticBeanstalk.</returns>
        public CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult)
        {
            return endOperation<CreateApplicationResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateApplication(CreateApplicationRequest createApplicationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateApplicationRequestMarshaller().Marshall(createApplicationRequest);
            var unmarshaller = CreateApplicationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateApplicationVersion

        /// <summary>
        /// <para>Creates an application version for the specified application.</para> <para><b>NOTE:</b>Once you create an application version with a
        /// specified Amazon S3 bucket and key location, you cannot change that Amazon S3 location. If you change the Amazon S3 location, you receive an
        /// exception when you attempt to launch an environment from the application version. </para>
        /// </summary>
        /// 
        /// <param name="createApplicationVersionRequest">Container for the necessary parameters to execute the CreateApplicationVersion service method
        ///          on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CreateApplicationVersion service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="TooManyApplicationsException"/>
        /// <exception cref="InsufficientPrivilegesException"/>
        /// <exception cref="TooManyApplicationVersionsException"/>
        /// <exception cref="S3LocationNotInServiceRegionException"/>
        public CreateApplicationVersionResponse CreateApplicationVersion(CreateApplicationVersionRequest createApplicationVersionRequest)
        {
            IAsyncResult asyncResult = invokeCreateApplicationVersion(createApplicationVersionRequest, null, null, true);
            return EndCreateApplicationVersion(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.CreateApplicationVersion"/>
        /// </summary>
        /// 
        /// <param name="createApplicationVersionRequest">Container for the necessary parameters to execute the CreateApplicationVersion operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateApplicationVersion operation.</returns>
        public IAsyncResult BeginCreateApplicationVersion(CreateApplicationVersionRequest createApplicationVersionRequest, AsyncCallback callback, object state)
        {
            return invokeCreateApplicationVersion(createApplicationVersionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.CreateApplicationVersion"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplicationVersion.</param>
        /// 
        /// <returns>Returns a CreateApplicationVersionResult from AmazonElasticBeanstalk.</returns>
        public CreateApplicationVersionResponse EndCreateApplicationVersion(IAsyncResult asyncResult)
        {
            return endOperation<CreateApplicationVersionResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateApplicationVersion(CreateApplicationVersionRequest createApplicationVersionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateApplicationVersionRequestMarshaller().Marshall(createApplicationVersionRequest);
            var unmarshaller = CreateApplicationVersionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateConfigurationTemplate

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
        ///          method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CreateConfigurationTemplate service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="InsufficientPrivilegesException"/>
        /// <exception cref="TooManyConfigurationTemplatesException"/>
        public CreateConfigurationTemplateResponse CreateConfigurationTemplate(CreateConfigurationTemplateRequest createConfigurationTemplateRequest)
        {
            IAsyncResult asyncResult = invokeCreateConfigurationTemplate(createConfigurationTemplateRequest, null, null, true);
            return EndCreateConfigurationTemplate(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.CreateConfigurationTemplate"/>
        /// </summary>
        /// 
        /// <param name="createConfigurationTemplateRequest">Container for the necessary parameters to execute the CreateConfigurationTemplate operation
        ///          on AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateConfigurationTemplate operation.</returns>
        public IAsyncResult BeginCreateConfigurationTemplate(CreateConfigurationTemplateRequest createConfigurationTemplateRequest, AsyncCallback callback, object state)
        {
            return invokeCreateConfigurationTemplate(createConfigurationTemplateRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.CreateConfigurationTemplate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a CreateConfigurationTemplateResult from AmazonElasticBeanstalk.</returns>
        public CreateConfigurationTemplateResponse EndCreateConfigurationTemplate(IAsyncResult asyncResult)
        {
            return endOperation<CreateConfigurationTemplateResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateConfigurationTemplate(CreateConfigurationTemplateRequest createConfigurationTemplateRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateConfigurationTemplateRequestMarshaller().Marshall(createConfigurationTemplateRequest);
            var unmarshaller = CreateConfigurationTemplateResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateEnvironment

        /// <summary>
        /// <para> Launches an environment for the specified application using the specified configuration. </para>
        /// </summary>
        /// 
        /// <param name="createEnvironmentRequest">Container for the necessary parameters to execute the CreateEnvironment service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="TooManyEnvironmentsException"/>
        /// <exception cref="InsufficientPrivilegesException"/>
        public CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest createEnvironmentRequest)
        {
            IAsyncResult asyncResult = invokeCreateEnvironment(createEnvironmentRequest, null, null, true);
            return EndCreateEnvironment(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.CreateEnvironment"/>
        /// </summary>
        /// 
        /// <param name="createEnvironmentRequest">Container for the necessary parameters to execute the CreateEnvironment operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironment
        ///         operation.</returns>
        public IAsyncResult BeginCreateEnvironment(CreateEnvironmentRequest createEnvironmentRequest, AsyncCallback callback, object state)
        {
            return invokeCreateEnvironment(createEnvironmentRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.CreateEnvironment"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironment.</param>
        /// 
        /// <returns>Returns a CreateEnvironmentResult from AmazonElasticBeanstalk.</returns>
        public CreateEnvironmentResponse EndCreateEnvironment(IAsyncResult asyncResult)
        {
            return endOperation<CreateEnvironmentResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateEnvironment(CreateEnvironmentRequest createEnvironmentRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateEnvironmentRequestMarshaller().Marshall(createEnvironmentRequest);
            var unmarshaller = CreateEnvironmentResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateStorageLocation

        /// <summary>
        /// <para> Creates the Amazon S3 storage location for the account. </para> <para> This location is used to store user log files. </para>
        /// </summary>
        /// 
        /// <param name="createStorageLocationRequest">Container for the necessary parameters to execute the CreateStorageLocation service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CreateStorageLocation service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="InsufficientPrivilegesException"/>
        /// <exception cref="S3SubscriptionRequiredException"/>
        /// <exception cref="TooManyBucketsException"/>
        public CreateStorageLocationResponse CreateStorageLocation(CreateStorageLocationRequest createStorageLocationRequest)
        {
            IAsyncResult asyncResult = invokeCreateStorageLocation(createStorageLocationRequest, null, null, true);
            return EndCreateStorageLocation(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStorageLocation operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.CreateStorageLocation"/>
        /// </summary>
        /// 
        /// <param name="createStorageLocationRequest">Container for the necessary parameters to execute the CreateStorageLocation operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateStorageLocation operation.</returns>
        public IAsyncResult BeginCreateStorageLocation(CreateStorageLocationRequest createStorageLocationRequest, AsyncCallback callback, object state)
        {
            return invokeCreateStorageLocation(createStorageLocationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateStorageLocation operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.CreateStorageLocation"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStorageLocation.</param>
        /// 
        /// <returns>Returns a CreateStorageLocationResult from AmazonElasticBeanstalk.</returns>
        public CreateStorageLocationResponse EndCreateStorageLocation(IAsyncResult asyncResult)
        {
            return endOperation<CreateStorageLocationResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateStorageLocation(CreateStorageLocationRequest createStorageLocationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateStorageLocationRequestMarshaller().Marshall(createStorageLocationRequest);
            var unmarshaller = CreateStorageLocationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Creates the Amazon S3 storage location for the account. </para> <para> This location is used to store user log files. </para>
        /// </summary>
        /// 
        /// <returns>The response from the CreateStorageLocation service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="InsufficientPrivilegesException"/>
        /// <exception cref="S3SubscriptionRequiredException"/>
        /// <exception cref="TooManyBucketsException"/>
        public CreateStorageLocationResponse CreateStorageLocation()
        {
            return CreateStorageLocation(new CreateStorageLocationRequest());
        }
        

        #endregion
    
        #region DeleteApplication

        /// <summary>
        /// <para> Deletes the specified application along with all associated versions and configurations. The application versions will not be deleted
        /// from your Amazon S3 bucket. </para> <para><b>NOTE:</b>You cannot delete an application that has a running environment. </para>
        /// </summary>
        /// 
        /// <param name="deleteApplicationRequest">Container for the necessary parameters to execute the DeleteApplication service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <exception cref="OperationInProgressException"/>
        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest deleteApplicationRequest)
        {
            IAsyncResult asyncResult = invokeDeleteApplication(deleteApplicationRequest, null, null, true);
            return EndDeleteApplication(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DeleteApplication"/>
        /// </summary>
        /// 
        /// <param name="deleteApplicationRequest">Container for the necessary parameters to execute the DeleteApplication operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteApplication(DeleteApplicationRequest deleteApplicationRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteApplication(deleteApplicationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DeleteApplication"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        public DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult)
        {
            return endOperation<DeleteApplicationResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteApplication(DeleteApplicationRequest deleteApplicationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteApplicationRequestMarshaller().Marshall(deleteApplicationRequest);
            var unmarshaller = DeleteApplicationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteApplicationVersion

        /// <summary>
        /// <para> Deletes the specified version from the specified application. </para> <para><b>NOTE:</b>You cannot delete an application version that
        /// is associated with a running environment.</para>
        /// </summary>
        /// 
        /// <param name="deleteApplicationVersionRequest">Container for the necessary parameters to execute the DeleteApplicationVersion service method
        ///          on AmazonElasticBeanstalk.</param>
        /// 
        /// <exception cref="OperationInProgressException"/>
        /// <exception cref="InsufficientPrivilegesException"/>
        /// <exception cref="SourceBundleDeletionException"/>
        /// <exception cref="S3LocationNotInServiceRegionException"/>
        public DeleteApplicationVersionResponse DeleteApplicationVersion(DeleteApplicationVersionRequest deleteApplicationVersionRequest)
        {
            IAsyncResult asyncResult = invokeDeleteApplicationVersion(deleteApplicationVersionRequest, null, null, true);
            return EndDeleteApplicationVersion(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DeleteApplicationVersion"/>
        /// </summary>
        /// 
        /// <param name="deleteApplicationVersionRequest">Container for the necessary parameters to execute the DeleteApplicationVersion operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteApplicationVersion(DeleteApplicationVersionRequest deleteApplicationVersionRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteApplicationVersion(deleteApplicationVersionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DeleteApplicationVersion"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplicationVersion.</param>
        public DeleteApplicationVersionResponse EndDeleteApplicationVersion(IAsyncResult asyncResult)
        {
            return endOperation<DeleteApplicationVersionResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteApplicationVersion(DeleteApplicationVersionRequest deleteApplicationVersionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteApplicationVersionRequestMarshaller().Marshall(deleteApplicationVersionRequest);
            var unmarshaller = DeleteApplicationVersionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteConfigurationTemplate

        /// <summary>
        /// <para>Deletes the specified configuration template.</para> <para><b>NOTE:</b>When you launch an environment using a configuration template,
        /// the environment gets a copy of the template. You can delete or modify the environment's copy of the template without affecting the running
        /// environment.</para>
        /// </summary>
        /// 
        /// <param name="deleteConfigurationTemplateRequest">Container for the necessary parameters to execute the DeleteConfigurationTemplate service
        ///          method on AmazonElasticBeanstalk.</param>
        /// 
        /// <exception cref="OperationInProgressException"/>
        public DeleteConfigurationTemplateResponse DeleteConfigurationTemplate(DeleteConfigurationTemplateRequest deleteConfigurationTemplateRequest)
        {
            IAsyncResult asyncResult = invokeDeleteConfigurationTemplate(deleteConfigurationTemplateRequest, null, null, true);
            return EndDeleteConfigurationTemplate(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DeleteConfigurationTemplate"/>
        /// </summary>
        /// 
        /// <param name="deleteConfigurationTemplateRequest">Container for the necessary parameters to execute the DeleteConfigurationTemplate operation
        ///          on AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteConfigurationTemplate(DeleteConfigurationTemplateRequest deleteConfigurationTemplateRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteConfigurationTemplate(deleteConfigurationTemplateRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DeleteConfigurationTemplate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationTemplate.</param>
        public DeleteConfigurationTemplateResponse EndDeleteConfigurationTemplate(IAsyncResult asyncResult)
        {
            return endOperation<DeleteConfigurationTemplateResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteConfigurationTemplate(DeleteConfigurationTemplateRequest deleteConfigurationTemplateRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteConfigurationTemplateRequestMarshaller().Marshall(deleteConfigurationTemplateRequest);
            var unmarshaller = DeleteConfigurationTemplateResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteEnvironmentConfiguration

        /// <summary>
        /// <para> Deletes the draft configuration associated with the running environment. </para> <para> Updating a running environment with any
        /// configuration changes creates a draft configuration set. You can get the draft configuration using DescribeConfigurationSettings while the
        /// update is in progress or if the update fails. The <c>DeploymentStatus</c> for the draft configuration indicates whether the deployment is in
        /// process or has failed. The draft configuration remains in existence until it is deleted with this action. </para>
        /// </summary>
        /// 
        /// <param name="deleteEnvironmentConfigurationRequest">Container for the necessary parameters to execute the DeleteEnvironmentConfiguration
        ///          service method on AmazonElasticBeanstalk.</param>
        /// 
        public DeleteEnvironmentConfigurationResponse DeleteEnvironmentConfiguration(DeleteEnvironmentConfigurationRequest deleteEnvironmentConfigurationRequest)
        {
            IAsyncResult asyncResult = invokeDeleteEnvironmentConfiguration(deleteEnvironmentConfigurationRequest, null, null, true);
            return EndDeleteEnvironmentConfiguration(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironmentConfiguration operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DeleteEnvironmentConfiguration"/>
        /// </summary>
        /// 
        /// <param name="deleteEnvironmentConfigurationRequest">Container for the necessary parameters to execute the DeleteEnvironmentConfiguration
        ///          operation on AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteEnvironmentConfiguration(DeleteEnvironmentConfigurationRequest deleteEnvironmentConfigurationRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteEnvironmentConfiguration(deleteEnvironmentConfigurationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteEnvironmentConfiguration operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DeleteEnvironmentConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironmentConfiguration.</param>
        public DeleteEnvironmentConfigurationResponse EndDeleteEnvironmentConfiguration(IAsyncResult asyncResult)
        {
            return endOperation<DeleteEnvironmentConfigurationResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteEnvironmentConfiguration(DeleteEnvironmentConfigurationRequest deleteEnvironmentConfigurationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteEnvironmentConfigurationRequestMarshaller().Marshall(deleteEnvironmentConfigurationRequest);
            var unmarshaller = DeleteEnvironmentConfigurationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeApplicationVersions

        /// <summary>
        /// <para>Returns descriptions for existing application versions.</para>
        /// </summary>
        /// 
        /// <param name="describeApplicationVersionsRequest">Container for the necessary parameters to execute the DescribeApplicationVersions service
        ///          method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        public DescribeApplicationVersionsResponse DescribeApplicationVersions(DescribeApplicationVersionsRequest describeApplicationVersionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeApplicationVersions(describeApplicationVersionsRequest, null, null, true);
            return EndDescribeApplicationVersions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationVersions operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DescribeApplicationVersions"/>
        /// </summary>
        /// 
        /// <param name="describeApplicationVersionsRequest">Container for the necessary parameters to execute the DescribeApplicationVersions operation
        ///          on AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeApplicationVersions operation.</returns>
        public IAsyncResult BeginDescribeApplicationVersions(DescribeApplicationVersionsRequest describeApplicationVersionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeApplicationVersions(describeApplicationVersionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeApplicationVersions operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DescribeApplicationVersions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplicationVersions.</param>
        /// 
        /// <returns>Returns a DescribeApplicationVersionsResult from AmazonElasticBeanstalk.</returns>
        public DescribeApplicationVersionsResponse EndDescribeApplicationVersions(IAsyncResult asyncResult)
        {
            return endOperation<DescribeApplicationVersionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeApplicationVersions(DescribeApplicationVersionsRequest describeApplicationVersionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeApplicationVersionsRequestMarshaller().Marshall(describeApplicationVersionsRequest);
            var unmarshaller = DescribeApplicationVersionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns descriptions for existing application versions.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        public DescribeApplicationVersionsResponse DescribeApplicationVersions()
        {
            return DescribeApplicationVersions(new DescribeApplicationVersionsRequest());
        }
        

        #endregion
    
        #region DescribeApplications

        /// <summary>
        /// <para>Returns the descriptions of existing applications.</para>
        /// </summary>
        /// 
        /// <param name="describeApplicationsRequest">Container for the necessary parameters to execute the DescribeApplications service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        public DescribeApplicationsResponse DescribeApplications(DescribeApplicationsRequest describeApplicationsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeApplications(describeApplicationsRequest, null, null, true);
            return EndDescribeApplications(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplications operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DescribeApplications"/>
        /// </summary>
        /// 
        /// <param name="describeApplicationsRequest">Container for the necessary parameters to execute the DescribeApplications operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeApplications operation.</returns>
        public IAsyncResult BeginDescribeApplications(DescribeApplicationsRequest describeApplicationsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeApplications(describeApplicationsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeApplications operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DescribeApplications"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplications.</param>
        /// 
        /// <returns>Returns a DescribeApplicationsResult from AmazonElasticBeanstalk.</returns>
        public DescribeApplicationsResponse EndDescribeApplications(IAsyncResult asyncResult)
        {
            return endOperation<DescribeApplicationsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeApplications(DescribeApplicationsRequest describeApplicationsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeApplicationsRequestMarshaller().Marshall(describeApplicationsRequest);
            var unmarshaller = DescribeApplicationsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns the descriptions of existing applications.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        public DescribeApplicationsResponse DescribeApplications()
        {
            return DescribeApplications(new DescribeApplicationsRequest());
        }
        

        #endregion
    
        #region DescribeConfigurationOptions

        /// <summary>
        /// <para> Describes the configuration options that are used in a particular configuration template or environment, or that a specified solution
        /// stack defines. The description includes the values the options, their default values, and an indication of the required action on a running
        /// environment if an option value is changed. </para>
        /// </summary>
        /// 
        /// <param name="describeConfigurationOptionsRequest">Container for the necessary parameters to execute the DescribeConfigurationOptions service
        ///          method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        public DescribeConfigurationOptionsResponse DescribeConfigurationOptions(DescribeConfigurationOptionsRequest describeConfigurationOptionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeConfigurationOptions(describeConfigurationOptionsRequest, null, null, true);
            return EndDescribeConfigurationOptions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationOptions operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DescribeConfigurationOptions"/>
        /// </summary>
        /// 
        /// <param name="describeConfigurationOptionsRequest">Container for the necessary parameters to execute the DescribeConfigurationOptions
        ///          operation on AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeConfigurationOptions operation.</returns>
        public IAsyncResult BeginDescribeConfigurationOptions(DescribeConfigurationOptionsRequest describeConfigurationOptionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeConfigurationOptions(describeConfigurationOptionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeConfigurationOptions operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DescribeConfigurationOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationOptions.</param>
        /// 
        /// <returns>Returns a DescribeConfigurationOptionsResult from AmazonElasticBeanstalk.</returns>
        public DescribeConfigurationOptionsResponse EndDescribeConfigurationOptions(IAsyncResult asyncResult)
        {
            return endOperation<DescribeConfigurationOptionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeConfigurationOptions(DescribeConfigurationOptionsRequest describeConfigurationOptionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeConfigurationOptionsRequestMarshaller().Marshall(describeConfigurationOptionsRequest);
            var unmarshaller = DescribeConfigurationOptionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Describes the configuration options that are used in a particular configuration template or environment, or that a specified solution
        /// stack defines. The description includes the values the options, their default values, and an indication of the required action on a running
        /// environment if an option value is changed. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        public DescribeConfigurationOptionsResponse DescribeConfigurationOptions()
        {
            return DescribeConfigurationOptions(new DescribeConfigurationOptionsRequest());
        }
        

        #endregion
    
        #region DescribeConfigurationSettings

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
        ///          service method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationSettings service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        public DescribeConfigurationSettingsResponse DescribeConfigurationSettings(DescribeConfigurationSettingsRequest describeConfigurationSettingsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeConfigurationSettings(describeConfigurationSettingsRequest, null, null, true);
            return EndDescribeConfigurationSettings(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationSettings operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DescribeConfigurationSettings"/>
        /// </summary>
        /// 
        /// <param name="describeConfigurationSettingsRequest">Container for the necessary parameters to execute the DescribeConfigurationSettings
        ///          operation on AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeConfigurationSettings operation.</returns>
        public IAsyncResult BeginDescribeConfigurationSettings(DescribeConfigurationSettingsRequest describeConfigurationSettingsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeConfigurationSettings(describeConfigurationSettingsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeConfigurationSettings operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DescribeConfigurationSettings"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationSettings.</param>
        /// 
        /// <returns>Returns a DescribeConfigurationSettingsResult from AmazonElasticBeanstalk.</returns>
        public DescribeConfigurationSettingsResponse EndDescribeConfigurationSettings(IAsyncResult asyncResult)
        {
            return endOperation<DescribeConfigurationSettingsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeConfigurationSettings(DescribeConfigurationSettingsRequest describeConfigurationSettingsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeConfigurationSettingsRequestMarshaller().Marshall(describeConfigurationSettingsRequest);
            var unmarshaller = DescribeConfigurationSettingsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeEnvironmentResources

        /// <summary>
        /// <para>Returns AWS resources for this environment.</para>
        /// </summary>
        /// 
        /// <param name="describeEnvironmentResourcesRequest">Container for the necessary parameters to execute the DescribeEnvironmentResources service
        ///          method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentResources service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="InsufficientPrivilegesException"/>
        public DescribeEnvironmentResourcesResponse DescribeEnvironmentResources(DescribeEnvironmentResourcesRequest describeEnvironmentResourcesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeEnvironmentResources(describeEnvironmentResourcesRequest, null, null, true);
            return EndDescribeEnvironmentResources(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentResources operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DescribeEnvironmentResources"/>
        /// </summary>
        /// 
        /// <param name="describeEnvironmentResourcesRequest">Container for the necessary parameters to execute the DescribeEnvironmentResources
        ///          operation on AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeEnvironmentResources operation.</returns>
        public IAsyncResult BeginDescribeEnvironmentResources(DescribeEnvironmentResourcesRequest describeEnvironmentResourcesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeEnvironmentResources(describeEnvironmentResourcesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeEnvironmentResources operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DescribeEnvironmentResources"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEnvironmentResources.</param>
        /// 
        /// <returns>Returns a DescribeEnvironmentResourcesResult from AmazonElasticBeanstalk.</returns>
        public DescribeEnvironmentResourcesResponse EndDescribeEnvironmentResources(IAsyncResult asyncResult)
        {
            return endOperation<DescribeEnvironmentResourcesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeEnvironmentResources(DescribeEnvironmentResourcesRequest describeEnvironmentResourcesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeEnvironmentResourcesRequestMarshaller().Marshall(describeEnvironmentResourcesRequest);
            var unmarshaller = DescribeEnvironmentResourcesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeEnvironments

        /// <summary>
        /// <para>Returns descriptions for existing environments.</para>
        /// </summary>
        /// 
        /// <param name="describeEnvironmentsRequest">Container for the necessary parameters to execute the DescribeEnvironments service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        public DescribeEnvironmentsResponse DescribeEnvironments(DescribeEnvironmentsRequest describeEnvironmentsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeEnvironments(describeEnvironmentsRequest, null, null, true);
            return EndDescribeEnvironments(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironments operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DescribeEnvironments"/>
        /// </summary>
        /// 
        /// <param name="describeEnvironmentsRequest">Container for the necessary parameters to execute the DescribeEnvironments operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeEnvironments operation.</returns>
        public IAsyncResult BeginDescribeEnvironments(DescribeEnvironmentsRequest describeEnvironmentsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeEnvironments(describeEnvironmentsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeEnvironments operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DescribeEnvironments"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEnvironments.</param>
        /// 
        /// <returns>Returns a DescribeEnvironmentsResult from AmazonElasticBeanstalk.</returns>
        public DescribeEnvironmentsResponse EndDescribeEnvironments(IAsyncResult asyncResult)
        {
            return endOperation<DescribeEnvironmentsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeEnvironments(DescribeEnvironmentsRequest describeEnvironmentsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeEnvironmentsRequestMarshaller().Marshall(describeEnvironmentsRequest);
            var unmarshaller = DescribeEnvironmentsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns descriptions for existing environments.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        public DescribeEnvironmentsResponse DescribeEnvironments()
        {
            return DescribeEnvironments(new DescribeEnvironmentsRequest());
        }
        

        #endregion
    
        #region DescribeEvents

        /// <summary>
        /// <para>Returns list of event descriptions matching criteria up to the last 6 weeks.</para> <para><b>NOTE:</b> This action returns the most
        /// recent 1,000 events from the specified NextToken. </para>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest describeEventsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeEvents(describeEventsRequest, null, null, true);
            return EndDescribeEvents(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DescribeEvents"/>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        public IAsyncResult BeginDescribeEvents(DescribeEventsRequest describeEventsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeEvents(describeEventsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.DescribeEvents"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a DescribeEventsResult from AmazonElasticBeanstalk.</returns>
        public DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult)
        {
            return endOperation<DescribeEventsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeEvents(DescribeEventsRequest describeEventsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeEventsRequestMarshaller().Marshall(describeEventsRequest);
            var unmarshaller = DescribeEventsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns list of event descriptions matching criteria up to the last 6 weeks.</para> <para><b>NOTE:</b> This action returns the most
        /// recent 1,000 events from the specified NextToken. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        public DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }
        

        #endregion
    
        #region ListAvailableSolutionStacks

        /// <summary>
        /// <para> Returns a list of the available solution stack names. </para>
        /// </summary>
        /// 
        /// <param name="listAvailableSolutionStacksRequest">Container for the necessary parameters to execute the ListAvailableSolutionStacks service
        ///          method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        public ListAvailableSolutionStacksResponse ListAvailableSolutionStacks(ListAvailableSolutionStacksRequest listAvailableSolutionStacksRequest)
        {
            IAsyncResult asyncResult = invokeListAvailableSolutionStacks(listAvailableSolutionStacksRequest, null, null, true);
            return EndListAvailableSolutionStacks(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableSolutionStacks operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.ListAvailableSolutionStacks"/>
        /// </summary>
        /// 
        /// <param name="listAvailableSolutionStacksRequest">Container for the necessary parameters to execute the ListAvailableSolutionStacks operation
        ///          on AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListAvailableSolutionStacks operation.</returns>
        public IAsyncResult BeginListAvailableSolutionStacks(ListAvailableSolutionStacksRequest listAvailableSolutionStacksRequest, AsyncCallback callback, object state)
        {
            return invokeListAvailableSolutionStacks(listAvailableSolutionStacksRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListAvailableSolutionStacks operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.ListAvailableSolutionStacks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailableSolutionStacks.</param>
        /// 
        /// <returns>Returns a ListAvailableSolutionStacksResult from AmazonElasticBeanstalk.</returns>
        public ListAvailableSolutionStacksResponse EndListAvailableSolutionStacks(IAsyncResult asyncResult)
        {
            return endOperation<ListAvailableSolutionStacksResponse>(asyncResult);
        }
        
        IAsyncResult invokeListAvailableSolutionStacks(ListAvailableSolutionStacksRequest listAvailableSolutionStacksRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListAvailableSolutionStacksRequestMarshaller().Marshall(listAvailableSolutionStacksRequest);
            var unmarshaller = ListAvailableSolutionStacksResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns a list of the available solution stack names. </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        public ListAvailableSolutionStacksResponse ListAvailableSolutionStacks()
        {
            return ListAvailableSolutionStacks(new ListAvailableSolutionStacksRequest());
        }
        

        #endregion
    
        #region RebuildEnvironment

        /// <summary>
        /// <para> Deletes and recreates all of the AWS resources (for example: the Auto Scaling group, load balancer, etc.) for a specified environment
        /// and forces a restart. </para>
        /// </summary>
        /// 
        /// <param name="rebuildEnvironmentRequest">Container for the necessary parameters to execute the RebuildEnvironment service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <exception cref="InsufficientPrivilegesException"/>
        public RebuildEnvironmentResponse RebuildEnvironment(RebuildEnvironmentRequest rebuildEnvironmentRequest)
        {
            IAsyncResult asyncResult = invokeRebuildEnvironment(rebuildEnvironmentRequest, null, null, true);
            return EndRebuildEnvironment(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RebuildEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.RebuildEnvironment"/>
        /// </summary>
        /// 
        /// <param name="rebuildEnvironmentRequest">Container for the necessary parameters to execute the RebuildEnvironment operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRebuildEnvironment(RebuildEnvironmentRequest rebuildEnvironmentRequest, AsyncCallback callback, object state)
        {
            return invokeRebuildEnvironment(rebuildEnvironmentRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RebuildEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.RebuildEnvironment"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebuildEnvironment.</param>
        public RebuildEnvironmentResponse EndRebuildEnvironment(IAsyncResult asyncResult)
        {
            return endOperation<RebuildEnvironmentResponse>(asyncResult);
        }
        
        IAsyncResult invokeRebuildEnvironment(RebuildEnvironmentRequest rebuildEnvironmentRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RebuildEnvironmentRequestMarshaller().Marshall(rebuildEnvironmentRequest);
            var unmarshaller = RebuildEnvironmentResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RequestEnvironmentInfo

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
        ///          AmazonElasticBeanstalk.</param>
        /// 
        public RequestEnvironmentInfoResponse RequestEnvironmentInfo(RequestEnvironmentInfoRequest requestEnvironmentInfoRequest)
        {
            IAsyncResult asyncResult = invokeRequestEnvironmentInfo(requestEnvironmentInfoRequest, null, null, true);
            return EndRequestEnvironmentInfo(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RequestEnvironmentInfo operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.RequestEnvironmentInfo"/>
        /// </summary>
        /// 
        /// <param name="requestEnvironmentInfoRequest">Container for the necessary parameters to execute the RequestEnvironmentInfo operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRequestEnvironmentInfo(RequestEnvironmentInfoRequest requestEnvironmentInfoRequest, AsyncCallback callback, object state)
        {
            return invokeRequestEnvironmentInfo(requestEnvironmentInfoRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RequestEnvironmentInfo operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.RequestEnvironmentInfo"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestEnvironmentInfo.</param>
        public RequestEnvironmentInfoResponse EndRequestEnvironmentInfo(IAsyncResult asyncResult)
        {
            return endOperation<RequestEnvironmentInfoResponse>(asyncResult);
        }
        
        IAsyncResult invokeRequestEnvironmentInfo(RequestEnvironmentInfoRequest requestEnvironmentInfoRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RequestEnvironmentInfoRequestMarshaller().Marshall(requestEnvironmentInfoRequest);
            var unmarshaller = RequestEnvironmentInfoResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RestartAppServer

        /// <summary>
        /// <para> Causes the environment to restart the application container server running on each Amazon EC2 instance. </para>
        /// </summary>
        /// 
        /// <param name="restartAppServerRequest">Container for the necessary parameters to execute the RestartAppServer service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        public RestartAppServerResponse RestartAppServer(RestartAppServerRequest restartAppServerRequest)
        {
            IAsyncResult asyncResult = invokeRestartAppServer(restartAppServerRequest, null, null, true);
            return EndRestartAppServer(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RestartAppServer operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.RestartAppServer"/>
        /// </summary>
        /// 
        /// <param name="restartAppServerRequest">Container for the necessary parameters to execute the RestartAppServer operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRestartAppServer(RestartAppServerRequest restartAppServerRequest, AsyncCallback callback, object state)
        {
            return invokeRestartAppServer(restartAppServerRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RestartAppServer operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.RestartAppServer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestartAppServer.</param>
        public RestartAppServerResponse EndRestartAppServer(IAsyncResult asyncResult)
        {
            return endOperation<RestartAppServerResponse>(asyncResult);
        }
        
        IAsyncResult invokeRestartAppServer(RestartAppServerRequest restartAppServerRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RestartAppServerRequestMarshaller().Marshall(restartAppServerRequest);
            var unmarshaller = RestartAppServerResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RetrieveEnvironmentInfo

        /// <summary>
        /// <para> Retrieves the compiled information from a RequestEnvironmentInfo request. </para> <para>Related Topics</para>
        /// <ul>
        /// <li> RequestEnvironmentInfo </li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// <param name="retrieveEnvironmentInfoRequest">Container for the necessary parameters to execute the RetrieveEnvironmentInfo service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the RetrieveEnvironmentInfo service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        public RetrieveEnvironmentInfoResponse RetrieveEnvironmentInfo(RetrieveEnvironmentInfoRequest retrieveEnvironmentInfoRequest)
        {
            IAsyncResult asyncResult = invokeRetrieveEnvironmentInfo(retrieveEnvironmentInfoRequest, null, null, true);
            return EndRetrieveEnvironmentInfo(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveEnvironmentInfo operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.RetrieveEnvironmentInfo"/>
        /// </summary>
        /// 
        /// <param name="retrieveEnvironmentInfoRequest">Container for the necessary parameters to execute the RetrieveEnvironmentInfo operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRetrieveEnvironmentInfo operation.</returns>
        public IAsyncResult BeginRetrieveEnvironmentInfo(RetrieveEnvironmentInfoRequest retrieveEnvironmentInfoRequest, AsyncCallback callback, object state)
        {
            return invokeRetrieveEnvironmentInfo(retrieveEnvironmentInfoRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RetrieveEnvironmentInfo operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.RetrieveEnvironmentInfo"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetrieveEnvironmentInfo.</param>
        /// 
        /// <returns>Returns a RetrieveEnvironmentInfoResult from AmazonElasticBeanstalk.</returns>
        public RetrieveEnvironmentInfoResponse EndRetrieveEnvironmentInfo(IAsyncResult asyncResult)
        {
            return endOperation<RetrieveEnvironmentInfoResponse>(asyncResult);
        }
        
        IAsyncResult invokeRetrieveEnvironmentInfo(RetrieveEnvironmentInfoRequest retrieveEnvironmentInfoRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RetrieveEnvironmentInfoRequestMarshaller().Marshall(retrieveEnvironmentInfoRequest);
            var unmarshaller = RetrieveEnvironmentInfoResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SwapEnvironmentCNAMEs

        /// <summary>
        /// <para> Swaps the CNAMEs of two environments. </para>
        /// </summary>
        /// 
        /// <param name="swapEnvironmentCNAMEsRequest">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        public SwapEnvironmentCNAMEsResponse SwapEnvironmentCNAMEs(SwapEnvironmentCNAMEsRequest swapEnvironmentCNAMEsRequest)
        {
            IAsyncResult asyncResult = invokeSwapEnvironmentCNAMEs(swapEnvironmentCNAMEsRequest, null, null, true);
            return EndSwapEnvironmentCNAMEs(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SwapEnvironmentCNAMEs operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.SwapEnvironmentCNAMEs"/>
        /// </summary>
        /// 
        /// <param name="swapEnvironmentCNAMEsRequest">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginSwapEnvironmentCNAMEs(SwapEnvironmentCNAMEsRequest swapEnvironmentCNAMEsRequest, AsyncCallback callback, object state)
        {
            return invokeSwapEnvironmentCNAMEs(swapEnvironmentCNAMEsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SwapEnvironmentCNAMEs operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.SwapEnvironmentCNAMEs"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSwapEnvironmentCNAMEs.</param>
        public SwapEnvironmentCNAMEsResponse EndSwapEnvironmentCNAMEs(IAsyncResult asyncResult)
        {
            return endOperation<SwapEnvironmentCNAMEsResponse>(asyncResult);
        }
        
        IAsyncResult invokeSwapEnvironmentCNAMEs(SwapEnvironmentCNAMEsRequest swapEnvironmentCNAMEsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SwapEnvironmentCNAMEsRequestMarshaller().Marshall(swapEnvironmentCNAMEsRequest);
            var unmarshaller = SwapEnvironmentCNAMEsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region TerminateEnvironment

        /// <summary>
        /// <para> Terminates the specified environment. </para>
        /// </summary>
        /// 
        /// <param name="terminateEnvironmentRequest">Container for the necessary parameters to execute the TerminateEnvironment service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the TerminateEnvironment service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="InsufficientPrivilegesException"/>
        public TerminateEnvironmentResponse TerminateEnvironment(TerminateEnvironmentRequest terminateEnvironmentRequest)
        {
            IAsyncResult asyncResult = invokeTerminateEnvironment(terminateEnvironmentRequest, null, null, true);
            return EndTerminateEnvironment(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.TerminateEnvironment"/>
        /// </summary>
        /// 
        /// <param name="terminateEnvironmentRequest">Container for the necessary parameters to execute the TerminateEnvironment operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndTerminateEnvironment operation.</returns>
        public IAsyncResult BeginTerminateEnvironment(TerminateEnvironmentRequest terminateEnvironmentRequest, AsyncCallback callback, object state)
        {
            return invokeTerminateEnvironment(terminateEnvironmentRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the TerminateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.TerminateEnvironment"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateEnvironment.</param>
        /// 
        /// <returns>Returns a TerminateEnvironmentResult from AmazonElasticBeanstalk.</returns>
        public TerminateEnvironmentResponse EndTerminateEnvironment(IAsyncResult asyncResult)
        {
            return endOperation<TerminateEnvironmentResponse>(asyncResult);
        }
        
        IAsyncResult invokeTerminateEnvironment(TerminateEnvironmentRequest terminateEnvironmentRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new TerminateEnvironmentRequestMarshaller().Marshall(terminateEnvironmentRequest);
            var unmarshaller = TerminateEnvironmentResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateApplication

        /// <summary>
        /// <para>Updates the specified application to have the specified properties. </para> <para><b>NOTE:</b> If a property (for example,
        /// description) is not provided, the value remains unchanged. To clear these properties, specify an empty string. </para>
        /// </summary>
        /// 
        /// <param name="updateApplicationRequest">Container for the necessary parameters to execute the UpdateApplication service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        public UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest updateApplicationRequest)
        {
            IAsyncResult asyncResult = invokeUpdateApplication(updateApplicationRequest, null, null, true);
            return EndUpdateApplication(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.UpdateApplication"/>
        /// </summary>
        /// 
        /// <param name="updateApplicationRequest">Container for the necessary parameters to execute the UpdateApplication operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        public IAsyncResult BeginUpdateApplication(UpdateApplicationRequest updateApplicationRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateApplication(updateApplicationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateApplication operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.UpdateApplication"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplication.</param>
        /// 
        /// <returns>Returns a UpdateApplicationResult from AmazonElasticBeanstalk.</returns>
        public UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult)
        {
            return endOperation<UpdateApplicationResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateApplication(UpdateApplicationRequest updateApplicationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateApplicationRequestMarshaller().Marshall(updateApplicationRequest);
            var unmarshaller = UpdateApplicationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateApplicationVersion

        /// <summary>
        /// <para> Updates the specified application version to have the specified properties. </para> <para><b>NOTE:</b> If a property (for example,
        /// description) is not provided, the value remains unchanged. To clear properties, specify an empty string. </para>
        /// </summary>
        /// 
        /// <param name="updateApplicationVersionRequest">Container for the necessary parameters to execute the UpdateApplicationVersion service method
        ///          on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the UpdateApplicationVersion service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        public UpdateApplicationVersionResponse UpdateApplicationVersion(UpdateApplicationVersionRequest updateApplicationVersionRequest)
        {
            IAsyncResult asyncResult = invokeUpdateApplicationVersion(updateApplicationVersionRequest, null, null, true);
            return EndUpdateApplicationVersion(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.UpdateApplicationVersion"/>
        /// </summary>
        /// 
        /// <param name="updateApplicationVersionRequest">Container for the necessary parameters to execute the UpdateApplicationVersion operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateApplicationVersion operation.</returns>
        public IAsyncResult BeginUpdateApplicationVersion(UpdateApplicationVersionRequest updateApplicationVersionRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateApplicationVersion(updateApplicationVersionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateApplicationVersion operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.UpdateApplicationVersion"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplicationVersion.</param>
        /// 
        /// <returns>Returns a UpdateApplicationVersionResult from AmazonElasticBeanstalk.</returns>
        public UpdateApplicationVersionResponse EndUpdateApplicationVersion(IAsyncResult asyncResult)
        {
            return endOperation<UpdateApplicationVersionResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateApplicationVersion(UpdateApplicationVersionRequest updateApplicationVersionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateApplicationVersionRequestMarshaller().Marshall(updateApplicationVersionRequest);
            var unmarshaller = UpdateApplicationVersionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateConfigurationTemplate

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
        ///          method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationTemplate service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="InsufficientPrivilegesException"/>
        public UpdateConfigurationTemplateResponse UpdateConfigurationTemplate(UpdateConfigurationTemplateRequest updateConfigurationTemplateRequest)
        {
            IAsyncResult asyncResult = invokeUpdateConfigurationTemplate(updateConfigurationTemplateRequest, null, null, true);
            return EndUpdateConfigurationTemplate(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.UpdateConfigurationTemplate"/>
        /// </summary>
        /// 
        /// <param name="updateConfigurationTemplateRequest">Container for the necessary parameters to execute the UpdateConfigurationTemplate operation
        ///          on AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateConfigurationTemplate operation.</returns>
        public IAsyncResult BeginUpdateConfigurationTemplate(UpdateConfigurationTemplateRequest updateConfigurationTemplateRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateConfigurationTemplate(updateConfigurationTemplateRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateConfigurationTemplate operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.UpdateConfigurationTemplate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a UpdateConfigurationTemplateResult from AmazonElasticBeanstalk.</returns>
        public UpdateConfigurationTemplateResponse EndUpdateConfigurationTemplate(IAsyncResult asyncResult)
        {
            return endOperation<UpdateConfigurationTemplateResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateConfigurationTemplate(UpdateConfigurationTemplateRequest updateConfigurationTemplateRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateConfigurationTemplateRequestMarshaller().Marshall(updateConfigurationTemplateRequest);
            var unmarshaller = UpdateConfigurationTemplateResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateEnvironment

        /// <summary>
        /// <para> Updates the environment description, deploys a new application version, updates the configuration settings to an entirely new
        /// configuration template, or updates select configuration option values in the running environment. </para> <para> Attempting to update both
        /// the release and configuration is not allowed and AWS Elastic Beanstalk returns an <c>InvalidParameterCombination</c> error. </para> <para>
        /// When updating the configuration settings to a new template or individual settings, a draft configuration is created and
        /// DescribeConfigurationSettings for this environment returns two setting descriptions with different <c>DeploymentStatus</c> values. </para>
        /// </summary>
        /// 
        /// <param name="updateEnvironmentRequest">Container for the necessary parameters to execute the UpdateEnvironment service method on
        ///          AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="InsufficientPrivilegesException"/>
        public UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest updateEnvironmentRequest)
        {
            IAsyncResult asyncResult = invokeUpdateEnvironment(updateEnvironmentRequest, null, null, true);
            return EndUpdateEnvironment(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.UpdateEnvironment"/>
        /// </summary>
        /// 
        /// <param name="updateEnvironmentRequest">Container for the necessary parameters to execute the UpdateEnvironment operation on
        ///          AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnvironment
        ///         operation.</returns>
        public IAsyncResult BeginUpdateEnvironment(UpdateEnvironmentRequest updateEnvironmentRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateEnvironment(updateEnvironmentRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateEnvironment operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.UpdateEnvironment"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnvironment.</param>
        /// 
        /// <returns>Returns a UpdateEnvironmentResult from AmazonElasticBeanstalk.</returns>
        public UpdateEnvironmentResponse EndUpdateEnvironment(IAsyncResult asyncResult)
        {
            return endOperation<UpdateEnvironmentResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateEnvironment(UpdateEnvironmentRequest updateEnvironmentRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateEnvironmentRequestMarshaller().Marshall(updateEnvironmentRequest);
            var unmarshaller = UpdateEnvironmentResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ValidateConfigurationSettings

        /// <summary>
        /// <para> Takes a set of configuration settings and either a configuration template or environment, and determines whether those values are
        /// valid. </para> <para> This action returns a list of messages indicating any errors or warnings associated with the selection of option
        /// values. </para>
        /// </summary>
        /// 
        /// <param name="validateConfigurationSettingsRequest">Container for the necessary parameters to execute the ValidateConfigurationSettings
        ///          service method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the ValidateConfigurationSettings service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="InsufficientPrivilegesException"/>
        public ValidateConfigurationSettingsResponse ValidateConfigurationSettings(ValidateConfigurationSettingsRequest validateConfigurationSettingsRequest)
        {
            IAsyncResult asyncResult = invokeValidateConfigurationSettings(validateConfigurationSettingsRequest, null, null, true);
            return EndValidateConfigurationSettings(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateConfigurationSettings operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.ValidateConfigurationSettings"/>
        /// </summary>
        /// 
        /// <param name="validateConfigurationSettingsRequest">Container for the necessary parameters to execute the ValidateConfigurationSettings
        ///          operation on AmazonElasticBeanstalk.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndValidateConfigurationSettings operation.</returns>
        public IAsyncResult BeginValidateConfigurationSettings(ValidateConfigurationSettingsRequest validateConfigurationSettingsRequest, AsyncCallback callback, object state)
        {
            return invokeValidateConfigurationSettings(validateConfigurationSettingsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ValidateConfigurationSettings operation.
        /// <seealso cref="Amazon.ElasticBeanstalk.IAmazonElasticBeanstalk.ValidateConfigurationSettings"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateConfigurationSettings.</param>
        /// 
        /// <returns>Returns a ValidateConfigurationSettingsResult from AmazonElasticBeanstalk.</returns>
        public ValidateConfigurationSettingsResponse EndValidateConfigurationSettings(IAsyncResult asyncResult)
        {
            return endOperation<ValidateConfigurationSettingsResponse>(asyncResult);
        }
        
        IAsyncResult invokeValidateConfigurationSettings(ValidateConfigurationSettingsRequest validateConfigurationSettingsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ValidateConfigurationSettingsRequestMarshaller().Marshall(validateConfigurationSettingsRequest);
            var unmarshaller = ValidateConfigurationSettingsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    

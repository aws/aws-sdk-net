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
    /// AWS Elastic Beanstalk makes it easy for you to create, deploy, and manage scalable,
    /// fault-tolerant applications running on the Amazon Web Services cloud.
    /// </para>
    ///  
    /// <para>
    /// For more information about this product, go to the <a href="http://aws.amazon.com/elasticbeanstalk/">AWS
    /// Elastic Beanstalk</a> details page. The location of the latest AWS Elastic Beanstalk
    /// WSDL is <a href="http://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl">http://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl</a>.
    /// To install the Software Development Kits (SDKs), Integrated Development Environment
    /// (IDE) Toolkits, and command line tools that enable you to access the API, go to <a
    /// href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a>.
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
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/AbortEnvironmentUpdate">REST API Reference for AbortEnvironmentUpdate Operation</seealso>
        public virtual AbortEnvironmentUpdateResponse AbortEnvironmentUpdate(AbortEnvironmentUpdateRequest request)
        {
            var marshaller = AbortEnvironmentUpdateRequestMarshaller.Instance;
            var unmarshaller = AbortEnvironmentUpdateResponseUnmarshaller.Instance;

            return Invoke<AbortEnvironmentUpdateRequest,AbortEnvironmentUpdateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AbortEnvironmentUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AbortEnvironmentUpdate operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAbortEnvironmentUpdate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/AbortEnvironmentUpdate">REST API Reference for AbortEnvironmentUpdate Operation</seealso>
        public virtual IAsyncResult BeginAbortEnvironmentUpdate(AbortEnvironmentUpdateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AbortEnvironmentUpdateRequestMarshaller.Instance;
            var unmarshaller = AbortEnvironmentUpdateResponseUnmarshaller.Instance;

            return BeginInvoke<AbortEnvironmentUpdateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AbortEnvironmentUpdate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAbortEnvironmentUpdate.</param>
        /// 
        /// <returns>Returns a  AbortEnvironmentUpdateResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/AbortEnvironmentUpdate">REST API Reference for AbortEnvironmentUpdate Operation</seealso>
        public virtual AbortEnvironmentUpdateResponse EndAbortEnvironmentUpdate(IAsyncResult asyncResult)
        {
            return EndInvoke<AbortEnvironmentUpdateResponse>(asyncResult);
        }

        #endregion
        
        #region  ApplyEnvironmentManagedAction

        /// <summary>
        /// Applies a scheduled managed action immediately. A managed action can be applied only
        /// if its status is <code>Scheduled</code>. Get the status and action ID of a managed
        /// action with <a>DescribeEnvironmentManagedActions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyEnvironmentManagedAction service method.</param>
        /// 
        /// <returns>The response from the ApplyEnvironmentManagedAction service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ManagedActionInvalidStateException">
        /// Cannot modify the managed action in its current state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ApplyEnvironmentManagedAction">REST API Reference for ApplyEnvironmentManagedAction Operation</seealso>
        public virtual ApplyEnvironmentManagedActionResponse ApplyEnvironmentManagedAction(ApplyEnvironmentManagedActionRequest request)
        {
            var marshaller = ApplyEnvironmentManagedActionRequestMarshaller.Instance;
            var unmarshaller = ApplyEnvironmentManagedActionResponseUnmarshaller.Instance;

            return Invoke<ApplyEnvironmentManagedActionRequest,ApplyEnvironmentManagedActionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ApplyEnvironmentManagedAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplyEnvironmentManagedAction operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndApplyEnvironmentManagedAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ApplyEnvironmentManagedAction">REST API Reference for ApplyEnvironmentManagedAction Operation</seealso>
        public virtual IAsyncResult BeginApplyEnvironmentManagedAction(ApplyEnvironmentManagedActionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ApplyEnvironmentManagedActionRequestMarshaller.Instance;
            var unmarshaller = ApplyEnvironmentManagedActionResponseUnmarshaller.Instance;

            return BeginInvoke<ApplyEnvironmentManagedActionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ApplyEnvironmentManagedAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginApplyEnvironmentManagedAction.</param>
        /// 
        /// <returns>Returns a  ApplyEnvironmentManagedActionResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ApplyEnvironmentManagedAction">REST API Reference for ApplyEnvironmentManagedAction Operation</seealso>
        public virtual ApplyEnvironmentManagedActionResponse EndApplyEnvironmentManagedAction(IAsyncResult asyncResult)
        {
            return EndInvoke<ApplyEnvironmentManagedActionResponse>(asyncResult);
        }

        #endregion
        
        #region  CheckDNSAvailability

        /// <summary>
        /// Checks if the specified CNAME is available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDNSAvailability service method.</param>
        /// 
        /// <returns>The response from the CheckDNSAvailability service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CheckDNSAvailability">REST API Reference for CheckDNSAvailability Operation</seealso>
        public virtual CheckDNSAvailabilityResponse CheckDNSAvailability(CheckDNSAvailabilityRequest request)
        {
            var marshaller = CheckDNSAvailabilityRequestMarshaller.Instance;
            var unmarshaller = CheckDNSAvailabilityResponseUnmarshaller.Instance;

            return Invoke<CheckDNSAvailabilityRequest,CheckDNSAvailabilityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CheckDNSAvailability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckDNSAvailability operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCheckDNSAvailability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CheckDNSAvailability">REST API Reference for CheckDNSAvailability Operation</seealso>
        public virtual IAsyncResult BeginCheckDNSAvailability(CheckDNSAvailabilityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CheckDNSAvailabilityRequestMarshaller.Instance;
            var unmarshaller = CheckDNSAvailabilityResponseUnmarshaller.Instance;

            return BeginInvoke<CheckDNSAvailabilityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CheckDNSAvailability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckDNSAvailability.</param>
        /// 
        /// <returns>Returns a  CheckDNSAvailabilityResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CheckDNSAvailability">REST API Reference for CheckDNSAvailability Operation</seealso>
        public virtual CheckDNSAvailabilityResponse EndCheckDNSAvailability(IAsyncResult asyncResult)
        {
            return EndInvoke<CheckDNSAvailabilityResponse>(asyncResult);
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
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyEnvironmentsException">
        /// The specified account has reached its limit of environments.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ComposeEnvironments">REST API Reference for ComposeEnvironments Operation</seealso>
        public virtual ComposeEnvironmentsResponse ComposeEnvironments(ComposeEnvironmentsRequest request)
        {
            var marshaller = ComposeEnvironmentsRequestMarshaller.Instance;
            var unmarshaller = ComposeEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ComposeEnvironmentsRequest,ComposeEnvironmentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ComposeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ComposeEnvironments operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndComposeEnvironments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ComposeEnvironments">REST API Reference for ComposeEnvironments Operation</seealso>
        public virtual IAsyncResult BeginComposeEnvironments(ComposeEnvironmentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ComposeEnvironmentsRequestMarshaller.Instance;
            var unmarshaller = ComposeEnvironmentsResponseUnmarshaller.Instance;

            return BeginInvoke<ComposeEnvironmentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ComposeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginComposeEnvironments.</param>
        /// 
        /// <returns>Returns a  ComposeEnvironmentsResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ComposeEnvironments">REST API Reference for ComposeEnvironments Operation</seealso>
        public virtual ComposeEnvironmentsResponse EndComposeEnvironments(IAsyncResult asyncResult)
        {
            return EndInvoke<ComposeEnvironmentsResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var marshaller = CreateApplicationRequestMarshaller.Instance;
            var unmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationRequest,CreateApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual IAsyncResult BeginCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateApplicationRequestMarshaller.Instance;
            var unmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return BeginInvoke<CreateApplicationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a  CreateApplicationResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateApplicationVersion

        /// <summary>
        /// Creates an application version for the specified application. You can create an application
        /// version from a source bundle in Amazon S3, a commit in AWS CodeCommit, or the output
        /// of an AWS CodeBuild build as follows:
        /// 
        ///  
        /// <para>
        /// Specify a commit in an AWS CodeCommit repository with <code>SourceBuildInformation</code>.
        /// </para>
        ///  
        /// <para>
        /// Specify a build in an AWS CodeBuild with <code>SourceBuildInformation</code> and <code>BuildConfiguration</code>.
        /// </para>
        ///  
        /// <para>
        /// Specify a source bundle in S3 with <code>SourceBundle</code> 
        /// </para>
        ///  
        /// <para>
        /// Omit both <code>SourceBuildInformation</code> and <code>SourceBundle</code> to use
        /// the default sample application.
        /// </para>
        ///  <note> 
        /// <para>
        /// Once you create an application version with a specified Amazon S3 bucket and key location,
        /// you cannot change that Amazon S3 location. If you change the Amazon S3 location, you
        /// receive an exception when you attempt to launch an environment from the application
        /// version.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the CreateApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.CodeBuildNotInServiceRegionException">
        /// AWS CodeBuild is not available in the specified region.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3LocationNotInServiceRegionException">
        /// The specified S3 bucket does not belong to the S3 region in which the service is running.
        /// The following regions are supported:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// IAD/us-east-1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PDX/us-west-2
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DUB/eu-west-1
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyApplicationsException">
        /// The specified account has reached its limit of applications.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyApplicationVersionsException">
        /// The specified account has reached its limit of application versions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateApplicationVersion">REST API Reference for CreateApplicationVersion Operation</seealso>
        public virtual CreateApplicationVersionResponse CreateApplicationVersion(CreateApplicationVersionRequest request)
        {
            var marshaller = CreateApplicationVersionRequestMarshaller.Instance;
            var unmarshaller = CreateApplicationVersionResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationVersionRequest,CreateApplicationVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationVersion operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplicationVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateApplicationVersion">REST API Reference for CreateApplicationVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateApplicationVersion(CreateApplicationVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateApplicationVersionRequestMarshaller.Instance;
            var unmarshaller = CreateApplicationVersionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateApplicationVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplicationVersion.</param>
        /// 
        /// <returns>Returns a  CreateApplicationVersionResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateApplicationVersion">REST API Reference for CreateApplicationVersion Operation</seealso>
        public virtual CreateApplicationVersionResponse EndCreateApplicationVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApplicationVersionResponse>(asyncResult);
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
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeConfigurationOptions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeConfigurationSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAvailableSolutionStacks</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyConfigurationTemplatesException">
        /// The specified account has reached its limit of configuration templates.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateConfigurationTemplate">REST API Reference for CreateConfigurationTemplate Operation</seealso>
        public virtual CreateConfigurationTemplateResponse CreateConfigurationTemplate(CreateConfigurationTemplateRequest request)
        {
            var marshaller = CreateConfigurationTemplateRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationTemplateRequest,CreateConfigurationTemplateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationTemplate operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfigurationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateConfigurationTemplate">REST API Reference for CreateConfigurationTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateConfigurationTemplate(CreateConfigurationTemplateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateConfigurationTemplateRequestMarshaller.Instance;
            var unmarshaller = CreateConfigurationTemplateResponseUnmarshaller.Instance;

            return BeginInvoke<CreateConfigurationTemplateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  CreateConfigurationTemplateResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateConfigurationTemplate">REST API Reference for CreateConfigurationTemplate Operation</seealso>
        public virtual CreateConfigurationTemplateResponse EndCreateConfigurationTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConfigurationTemplateResponse>(asyncResult);
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
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyEnvironmentsException">
        /// The specified account has reached its limit of environments.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            var marshaller = CreateEnvironmentRequestMarshaller.Instance;
            var unmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentRequest,CreateEnvironmentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual IAsyncResult BeginCreateEnvironment(CreateEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateEnvironmentRequestMarshaller.Instance;
            var unmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke<CreateEnvironmentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironment.</param>
        /// 
        /// <returns>Returns a  CreateEnvironmentResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual CreateEnvironmentResponse EndCreateEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePlatformVersion

        /// <summary>
        /// Create a new version of your custom platform.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformVersion service method.</param>
        /// 
        /// <returns>The response from the CreatePlatformVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyPlatformsException">
        /// You have exceeded the maximum number of allowed platforms associated with the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreatePlatformVersion">REST API Reference for CreatePlatformVersion Operation</seealso>
        public virtual CreatePlatformVersionResponse CreatePlatformVersion(CreatePlatformVersionRequest request)
        {
            var marshaller = CreatePlatformVersionRequestMarshaller.Instance;
            var unmarshaller = CreatePlatformVersionResponseUnmarshaller.Instance;

            return Invoke<CreatePlatformVersionRequest,CreatePlatformVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlatformVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformVersion operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePlatformVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreatePlatformVersion">REST API Reference for CreatePlatformVersion Operation</seealso>
        public virtual IAsyncResult BeginCreatePlatformVersion(CreatePlatformVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreatePlatformVersionRequestMarshaller.Instance;
            var unmarshaller = CreatePlatformVersionResponseUnmarshaller.Instance;

            return BeginInvoke<CreatePlatformVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlatformVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlatformVersion.</param>
        /// 
        /// <returns>Returns a  CreatePlatformVersionResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreatePlatformVersion">REST API Reference for CreatePlatformVersion Operation</seealso>
        public virtual CreatePlatformVersionResponse EndCreatePlatformVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePlatformVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStorageLocation

        /// <summary>
        /// Creates a bucket in Amazon S3 to store application versions, logs, and other files
        /// used by Elastic Beanstalk environments. The Elastic Beanstalk console and EB CLI call
        /// this API the first time you create an environment in a region. If the storage location
        /// already exists, <code>CreateStorageLocation</code> still returns the bucket name but
        /// does not create a new bucket.
        /// </summary>
        /// 
        /// <returns>The response from the CreateStorageLocation service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3SubscriptionRequiredException">
        /// The specified account does not have a subscription to Amazon S3.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateStorageLocation">REST API Reference for CreateStorageLocation Operation</seealso>
        public virtual CreateStorageLocationResponse CreateStorageLocation()
        {
            return CreateStorageLocation(new CreateStorageLocationRequest());
        }

        /// <summary>
        /// Creates a bucket in Amazon S3 to store application versions, logs, and other files
        /// used by Elastic Beanstalk environments. The Elastic Beanstalk console and EB CLI call
        /// this API the first time you create an environment in a region. If the storage location
        /// already exists, <code>CreateStorageLocation</code> still returns the bucket name but
        /// does not create a new bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageLocation service method.</param>
        /// 
        /// <returns>The response from the CreateStorageLocation service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3SubscriptionRequiredException">
        /// The specified account does not have a subscription to Amazon S3.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateStorageLocation">REST API Reference for CreateStorageLocation Operation</seealso>
        public virtual CreateStorageLocationResponse CreateStorageLocation(CreateStorageLocationRequest request)
        {
            var marshaller = CreateStorageLocationRequestMarshaller.Instance;
            var unmarshaller = CreateStorageLocationResponseUnmarshaller.Instance;

            return Invoke<CreateStorageLocationRequest,CreateStorageLocationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStorageLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageLocation operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStorageLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateStorageLocation">REST API Reference for CreateStorageLocation Operation</seealso>
        public virtual IAsyncResult BeginCreateStorageLocation(CreateStorageLocationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateStorageLocationRequestMarshaller.Instance;
            var unmarshaller = CreateStorageLocationResponseUnmarshaller.Instance;

            return BeginInvoke<CreateStorageLocationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStorageLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStorageLocation.</param>
        /// 
        /// <returns>Returns a  CreateStorageLocationResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateStorageLocation">REST API Reference for CreateStorageLocation Operation</seealso>
        public virtual CreateStorageLocationResponse EndCreateStorageLocation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStorageLocationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApplication

        /// <summary>
        /// Deletes the specified application along with all associated versions and configurations.
        /// The application versions will not be deleted from your Amazon S3 bucket.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an application that has a running environment.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var marshaller = DeleteApplicationRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationRequest,DeleteApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual IAsyncResult BeginDeleteApplication(DeleteApplicationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteApplicationRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteApplicationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApplicationVersion

        /// <summary>
        /// Deletes the specified version from the specified application.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an application version that is associated with a running environment.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3LocationNotInServiceRegionException">
        /// The specified S3 bucket does not belong to the S3 region in which the service is running.
        /// The following regions are supported:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// IAD/us-east-1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PDX/us-west-2
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DUB/eu-west-1
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.SourceBundleDeletionException">
        /// Unable to delete the Amazon S3 source bundle associated with the application version.
        /// The application version was deleted successfully.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteApplicationVersion">REST API Reference for DeleteApplicationVersion Operation</seealso>
        public virtual DeleteApplicationVersionResponse DeleteApplicationVersion(DeleteApplicationVersionRequest request)
        {
            var marshaller = DeleteApplicationVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationVersionRequest,DeleteApplicationVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationVersion operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplicationVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteApplicationVersion">REST API Reference for DeleteApplicationVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteApplicationVersion(DeleteApplicationVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteApplicationVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationVersionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteApplicationVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplicationVersion.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationVersionResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteApplicationVersion">REST API Reference for DeleteApplicationVersion Operation</seealso>
        public virtual DeleteApplicationVersionResponse EndDeleteApplicationVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApplicationVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConfigurationTemplate

        /// <summary>
        /// Deletes the specified configuration template.
        /// 
        ///  <note> 
        /// <para>
        /// When you launch an environment using a configuration template, the environment gets
        /// a copy of the template. You can delete or modify the environment's copy of the template
        /// without affecting the running environment.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteConfigurationTemplate">REST API Reference for DeleteConfigurationTemplate Operation</seealso>
        public virtual DeleteConfigurationTemplateResponse DeleteConfigurationTemplate(DeleteConfigurationTemplateRequest request)
        {
            var marshaller = DeleteConfigurationTemplateRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationTemplateRequest,DeleteConfigurationTemplateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationTemplate operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigurationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteConfigurationTemplate">REST API Reference for DeleteConfigurationTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfigurationTemplate(DeleteConfigurationTemplateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteConfigurationTemplateRequestMarshaller.Instance;
            var unmarshaller = DeleteConfigurationTemplateResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteConfigurationTemplateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationTemplateResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteConfigurationTemplate">REST API Reference for DeleteConfigurationTemplate Operation</seealso>
        public virtual DeleteConfigurationTemplateResponse EndDeleteConfigurationTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfigurationTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEnvironmentConfiguration

        /// <summary>
        /// Deletes the draft configuration associated with the running environment.
        /// 
        ///  
        /// <para>
        /// Updating a running environment with any configuration changes creates a draft configuration
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteEnvironmentConfiguration">REST API Reference for DeleteEnvironmentConfiguration Operation</seealso>
        public virtual DeleteEnvironmentConfigurationResponse DeleteEnvironmentConfiguration(DeleteEnvironmentConfigurationRequest request)
        {
            var marshaller = DeleteEnvironmentConfigurationRequestMarshaller.Instance;
            var unmarshaller = DeleteEnvironmentConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentConfigurationRequest,DeleteEnvironmentConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironmentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentConfiguration operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironmentConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteEnvironmentConfiguration">REST API Reference for DeleteEnvironmentConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteEnvironmentConfiguration(DeleteEnvironmentConfigurationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteEnvironmentConfigurationRequestMarshaller.Instance;
            var unmarshaller = DeleteEnvironmentConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteEnvironmentConfigurationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnvironmentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironmentConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteEnvironmentConfigurationResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteEnvironmentConfiguration">REST API Reference for DeleteEnvironmentConfiguration Operation</seealso>
        public virtual DeleteEnvironmentConfigurationResponse EndDeleteEnvironmentConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEnvironmentConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePlatformVersion

        /// <summary>
        /// Deletes the specified version of a custom platform.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlatformVersion service method.</param>
        /// 
        /// <returns>The response from the DeletePlatformVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.PlatformVersionStillReferencedException">
        /// You cannot delete the platform version because there are still environments running
        /// on it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeletePlatformVersion">REST API Reference for DeletePlatformVersion Operation</seealso>
        public virtual DeletePlatformVersionResponse DeletePlatformVersion(DeletePlatformVersionRequest request)
        {
            var marshaller = DeletePlatformVersionRequestMarshaller.Instance;
            var unmarshaller = DeletePlatformVersionResponseUnmarshaller.Instance;

            return Invoke<DeletePlatformVersionRequest,DeletePlatformVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlatformVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlatformVersion operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePlatformVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeletePlatformVersion">REST API Reference for DeletePlatformVersion Operation</seealso>
        public virtual IAsyncResult BeginDeletePlatformVersion(DeletePlatformVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeletePlatformVersionRequestMarshaller.Instance;
            var unmarshaller = DeletePlatformVersionResponseUnmarshaller.Instance;

            return BeginInvoke<DeletePlatformVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePlatformVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePlatformVersion.</param>
        /// 
        /// <returns>Returns a  DeletePlatformVersionResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeletePlatformVersion">REST API Reference for DeletePlatformVersion Operation</seealso>
        public virtual DeletePlatformVersionResponse EndDeletePlatformVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePlatformVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccountAttributes

        /// <summary>
        /// Returns attributes related to AWS Elastic Beanstalk that are associated with the calling
        /// AWS account.
        /// 
        ///  
        /// <para>
        /// The result currently has one set of attributes—resource quotas.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var marshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesRequest,DescribeAccountAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual IAsyncResult BeginDescribeAccountAttributes(DescribeAccountAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAccountAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeAccountAttributesResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual DescribeAccountAttributesResponse EndDescribeAccountAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccountAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeApplications

        /// <summary>
        /// Returns the descriptions of existing applications.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeApplications">REST API Reference for DescribeApplications Operation</seealso>
        public virtual DescribeApplicationsResponse DescribeApplications()
        {
            return DescribeApplications(new DescribeApplicationsRequest());
        }

        /// <summary>
        /// Returns the descriptions of existing applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplications service method.</param>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeApplications">REST API Reference for DescribeApplications Operation</seealso>
        public virtual DescribeApplicationsResponse DescribeApplications(DescribeApplicationsRequest request)
        {
            var marshaller = DescribeApplicationsRequestMarshaller.Instance;
            var unmarshaller = DescribeApplicationsResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationsRequest,DescribeApplicationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplications operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeApplications">REST API Reference for DescribeApplications Operation</seealso>
        public virtual IAsyncResult BeginDescribeApplications(DescribeApplicationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeApplicationsRequestMarshaller.Instance;
            var unmarshaller = DescribeApplicationsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeApplicationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplications.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationsResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeApplications">REST API Reference for DescribeApplications Operation</seealso>
        public virtual DescribeApplicationsResponse EndDescribeApplications(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeApplicationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeApplicationVersions

        /// <summary>
        /// Retrieve a list of application versions.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeApplicationVersions">REST API Reference for DescribeApplicationVersions Operation</seealso>
        public virtual DescribeApplicationVersionsResponse DescribeApplicationVersions()
        {
            return DescribeApplicationVersions(new DescribeApplicationVersionsRequest());
        }

        /// <summary>
        /// Retrieve a list of application versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeApplicationVersions">REST API Reference for DescribeApplicationVersions Operation</seealso>
        public virtual DescribeApplicationVersionsResponse DescribeApplicationVersions(DescribeApplicationVersionsRequest request)
        {
            var marshaller = DescribeApplicationVersionsRequestMarshaller.Instance;
            var unmarshaller = DescribeApplicationVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationVersionsRequest,DescribeApplicationVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationVersions operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplicationVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeApplicationVersions">REST API Reference for DescribeApplicationVersions Operation</seealso>
        public virtual IAsyncResult BeginDescribeApplicationVersions(DescribeApplicationVersionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeApplicationVersionsRequestMarshaller.Instance;
            var unmarshaller = DescribeApplicationVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeApplicationVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplicationVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplicationVersions.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationVersionsResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeApplicationVersions">REST API Reference for DescribeApplicationVersions Operation</seealso>
        public virtual DescribeApplicationVersionsResponse EndDescribeApplicationVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeApplicationVersionsResponse>(asyncResult);
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
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeConfigurationOptions">REST API Reference for DescribeConfigurationOptions Operation</seealso>
        public virtual DescribeConfigurationOptionsResponse DescribeConfigurationOptions()
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
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeConfigurationOptions">REST API Reference for DescribeConfigurationOptions Operation</seealso>
        public virtual DescribeConfigurationOptionsResponse DescribeConfigurationOptions(DescribeConfigurationOptionsRequest request)
        {
            var marshaller = DescribeConfigurationOptionsRequestMarshaller.Instance;
            var unmarshaller = DescribeConfigurationOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationOptionsRequest,DescribeConfigurationOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationOptions operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigurationOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeConfigurationOptions">REST API Reference for DescribeConfigurationOptions Operation</seealso>
        public virtual IAsyncResult BeginDescribeConfigurationOptions(DescribeConfigurationOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeConfigurationOptionsRequestMarshaller.Instance;
            var unmarshaller = DescribeConfigurationOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeConfigurationOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigurationOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationOptions.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationOptionsResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeConfigurationOptions">REST API Reference for DescribeConfigurationOptions Operation</seealso>
        public virtual DescribeConfigurationOptionsResponse EndDescribeConfigurationOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConfigurationOptionsResponse>(asyncResult);
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
        /// When describing the settings for the configuration set associated with a running environment,
        /// it is possible to receive two sets of setting descriptions. One is the deployed configuration
        /// set, and the other is a draft configuration of an environment that is either in the
        /// process of deployment or that failed to deploy.
        /// </para>
        ///  
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DeleteEnvironmentConfiguration</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationSettings service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeConfigurationSettings">REST API Reference for DescribeConfigurationSettings Operation</seealso>
        public virtual DescribeConfigurationSettingsResponse DescribeConfigurationSettings(DescribeConfigurationSettingsRequest request)
        {
            var marshaller = DescribeConfigurationSettingsRequestMarshaller.Instance;
            var unmarshaller = DescribeConfigurationSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationSettingsRequest,DescribeConfigurationSettingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSettings operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigurationSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeConfigurationSettings">REST API Reference for DescribeConfigurationSettings Operation</seealso>
        public virtual IAsyncResult BeginDescribeConfigurationSettings(DescribeConfigurationSettingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeConfigurationSettingsRequestMarshaller.Instance;
            var unmarshaller = DescribeConfigurationSettingsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeConfigurationSettingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigurationSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationSettings.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationSettingsResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeConfigurationSettings">REST API Reference for DescribeConfigurationSettings Operation</seealso>
        public virtual DescribeConfigurationSettingsResponse EndDescribeConfigurationSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConfigurationSettingsResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentHealth">REST API Reference for DescribeEnvironmentHealth Operation</seealso>
        public virtual DescribeEnvironmentHealthResponse DescribeEnvironmentHealth(DescribeEnvironmentHealthRequest request)
        {
            var marshaller = DescribeEnvironmentHealthRequestMarshaller.Instance;
            var unmarshaller = DescribeEnvironmentHealthResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentHealthRequest,DescribeEnvironmentHealthResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentHealth operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEnvironmentHealth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentHealth">REST API Reference for DescribeEnvironmentHealth Operation</seealso>
        public virtual IAsyncResult BeginDescribeEnvironmentHealth(DescribeEnvironmentHealthRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeEnvironmentHealthRequestMarshaller.Instance;
            var unmarshaller = DescribeEnvironmentHealthResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeEnvironmentHealthRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEnvironmentHealth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEnvironmentHealth.</param>
        /// 
        /// <returns>Returns a  DescribeEnvironmentHealthResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentHealth">REST API Reference for DescribeEnvironmentHealth Operation</seealso>
        public virtual DescribeEnvironmentHealthResponse EndDescribeEnvironmentHealth(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEnvironmentHealthResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEnvironmentManagedActionHistory

        /// <summary>
        /// Lists an environment's completed and failed managed actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentManagedActionHistory service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentManagedActionHistory service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentManagedActionHistory">REST API Reference for DescribeEnvironmentManagedActionHistory Operation</seealso>
        public virtual DescribeEnvironmentManagedActionHistoryResponse DescribeEnvironmentManagedActionHistory(DescribeEnvironmentManagedActionHistoryRequest request)
        {
            var marshaller = DescribeEnvironmentManagedActionHistoryRequestMarshaller.Instance;
            var unmarshaller = DescribeEnvironmentManagedActionHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentManagedActionHistoryRequest,DescribeEnvironmentManagedActionHistoryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentManagedActionHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentManagedActionHistory operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEnvironmentManagedActionHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentManagedActionHistory">REST API Reference for DescribeEnvironmentManagedActionHistory Operation</seealso>
        public virtual IAsyncResult BeginDescribeEnvironmentManagedActionHistory(DescribeEnvironmentManagedActionHistoryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeEnvironmentManagedActionHistoryRequestMarshaller.Instance;
            var unmarshaller = DescribeEnvironmentManagedActionHistoryResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeEnvironmentManagedActionHistoryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEnvironmentManagedActionHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEnvironmentManagedActionHistory.</param>
        /// 
        /// <returns>Returns a  DescribeEnvironmentManagedActionHistoryResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentManagedActionHistory">REST API Reference for DescribeEnvironmentManagedActionHistory Operation</seealso>
        public virtual DescribeEnvironmentManagedActionHistoryResponse EndDescribeEnvironmentManagedActionHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEnvironmentManagedActionHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEnvironmentManagedActions

        /// <summary>
        /// Lists an environment's upcoming and in-progress managed actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentManagedActions service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentManagedActions service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentManagedActions">REST API Reference for DescribeEnvironmentManagedActions Operation</seealso>
        public virtual DescribeEnvironmentManagedActionsResponse DescribeEnvironmentManagedActions(DescribeEnvironmentManagedActionsRequest request)
        {
            var marshaller = DescribeEnvironmentManagedActionsRequestMarshaller.Instance;
            var unmarshaller = DescribeEnvironmentManagedActionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentManagedActionsRequest,DescribeEnvironmentManagedActionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentManagedActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentManagedActions operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEnvironmentManagedActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentManagedActions">REST API Reference for DescribeEnvironmentManagedActions Operation</seealso>
        public virtual IAsyncResult BeginDescribeEnvironmentManagedActions(DescribeEnvironmentManagedActionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeEnvironmentManagedActionsRequestMarshaller.Instance;
            var unmarshaller = DescribeEnvironmentManagedActionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeEnvironmentManagedActionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEnvironmentManagedActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEnvironmentManagedActions.</param>
        /// 
        /// <returns>Returns a  DescribeEnvironmentManagedActionsResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentManagedActions">REST API Reference for DescribeEnvironmentManagedActions Operation</seealso>
        public virtual DescribeEnvironmentManagedActionsResponse EndDescribeEnvironmentManagedActions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEnvironmentManagedActionsResponse>(asyncResult);
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
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentResources">REST API Reference for DescribeEnvironmentResources Operation</seealso>
        public virtual DescribeEnvironmentResourcesResponse DescribeEnvironmentResources(DescribeEnvironmentResourcesRequest request)
        {
            var marshaller = DescribeEnvironmentResourcesRequestMarshaller.Instance;
            var unmarshaller = DescribeEnvironmentResourcesResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentResourcesRequest,DescribeEnvironmentResourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentResources operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEnvironmentResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentResources">REST API Reference for DescribeEnvironmentResources Operation</seealso>
        public virtual IAsyncResult BeginDescribeEnvironmentResources(DescribeEnvironmentResourcesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeEnvironmentResourcesRequestMarshaller.Instance;
            var unmarshaller = DescribeEnvironmentResourcesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeEnvironmentResourcesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEnvironmentResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEnvironmentResources.</param>
        /// 
        /// <returns>Returns a  DescribeEnvironmentResourcesResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentResources">REST API Reference for DescribeEnvironmentResources Operation</seealso>
        public virtual DescribeEnvironmentResourcesResponse EndDescribeEnvironmentResources(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEnvironmentResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEnvironments

        /// <summary>
        /// Returns descriptions for existing environments.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironments">REST API Reference for DescribeEnvironments Operation</seealso>
        public virtual DescribeEnvironmentsResponse DescribeEnvironments()
        {
            return DescribeEnvironments(new DescribeEnvironmentsRequest());
        }

        /// <summary>
        /// Returns descriptions for existing environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironments service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironments">REST API Reference for DescribeEnvironments Operation</seealso>
        public virtual DescribeEnvironmentsResponse DescribeEnvironments(DescribeEnvironmentsRequest request)
        {
            var marshaller = DescribeEnvironmentsRequestMarshaller.Instance;
            var unmarshaller = DescribeEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentsRequest,DescribeEnvironmentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironments operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEnvironments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironments">REST API Reference for DescribeEnvironments Operation</seealso>
        public virtual IAsyncResult BeginDescribeEnvironments(DescribeEnvironmentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeEnvironmentsRequestMarshaller.Instance;
            var unmarshaller = DescribeEnvironmentsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeEnvironmentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEnvironments.</param>
        /// 
        /// <returns>Returns a  DescribeEnvironmentsResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironments">REST API Reference for DescribeEnvironments Operation</seealso>
        public virtual DescribeEnvironmentsResponse EndDescribeEnvironments(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEnvironmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEvents

        /// <summary>
        /// Returns list of event descriptions matching criteria up to the last 6 weeks.
        /// 
        ///  <note> 
        /// <para>
        /// This action returns the most recent 1,000 events from the specified <code>NextToken</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }

        /// <summary>
        /// Returns list of event descriptions matching criteria up to the last 6 weeks.
        /// 
        ///  <note> 
        /// <para>
        /// This action returns the most recent 1,000 events from the specified <code>NextToken</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var marshaller = DescribeEventsRequestMarshaller.Instance;
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsRequest,DescribeEventsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual IAsyncResult BeginDescribeEvents(DescribeEventsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeEventsRequestMarshaller.Instance;
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeEventsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a  DescribeEventsResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInstancesHealth

        /// <summary>
        /// Retrives detailed information about the health of instances in your AWS Elastic Beanstalk.
        /// This operation requires <a href="http://docs.aws.amazon.com/elasticbeanstalk/latest/dg/health-enhanced.html">enhanced
        /// health reporting</a>.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeInstancesHealth">REST API Reference for DescribeInstancesHealth Operation</seealso>
        public virtual DescribeInstancesHealthResponse DescribeInstancesHealth(DescribeInstancesHealthRequest request)
        {
            var marshaller = DescribeInstancesHealthRequestMarshaller.Instance;
            var unmarshaller = DescribeInstancesHealthResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancesHealthRequest,DescribeInstancesHealthResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstancesHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancesHealth operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstancesHealth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeInstancesHealth">REST API Reference for DescribeInstancesHealth Operation</seealso>
        public virtual IAsyncResult BeginDescribeInstancesHealth(DescribeInstancesHealthRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeInstancesHealthRequestMarshaller.Instance;
            var unmarshaller = DescribeInstancesHealthResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeInstancesHealthRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstancesHealth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstancesHealth.</param>
        /// 
        /// <returns>Returns a  DescribeInstancesHealthResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeInstancesHealth">REST API Reference for DescribeInstancesHealth Operation</seealso>
        public virtual DescribeInstancesHealthResponse EndDescribeInstancesHealth(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstancesHealthResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePlatformVersion

        /// <summary>
        /// Describes the version of the platform.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePlatformVersion service method.</param>
        /// 
        /// <returns>The response from the DescribePlatformVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribePlatformVersion">REST API Reference for DescribePlatformVersion Operation</seealso>
        public virtual DescribePlatformVersionResponse DescribePlatformVersion(DescribePlatformVersionRequest request)
        {
            var marshaller = DescribePlatformVersionRequestMarshaller.Instance;
            var unmarshaller = DescribePlatformVersionResponseUnmarshaller.Instance;

            return Invoke<DescribePlatformVersionRequest,DescribePlatformVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePlatformVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlatformVersion operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePlatformVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribePlatformVersion">REST API Reference for DescribePlatformVersion Operation</seealso>
        public virtual IAsyncResult BeginDescribePlatformVersion(DescribePlatformVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribePlatformVersionRequestMarshaller.Instance;
            var unmarshaller = DescribePlatformVersionResponseUnmarshaller.Instance;

            return BeginInvoke<DescribePlatformVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePlatformVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePlatformVersion.</param>
        /// 
        /// <returns>Returns a  DescribePlatformVersionResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribePlatformVersion">REST API Reference for DescribePlatformVersion Operation</seealso>
        public virtual DescribePlatformVersionResponse EndDescribePlatformVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePlatformVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAvailableSolutionStacks

        /// <summary>
        /// Returns a list of the available solution stack names, with the public version first
        /// and then in reverse chronological order.
        /// </summary>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListAvailableSolutionStacks">REST API Reference for ListAvailableSolutionStacks Operation</seealso>
        public virtual ListAvailableSolutionStacksResponse ListAvailableSolutionStacks()
        {
            return ListAvailableSolutionStacks(new ListAvailableSolutionStacksRequest());
        }

        /// <summary>
        /// Returns a list of the available solution stack names, with the public version first
        /// and then in reverse chronological order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableSolutionStacks service method.</param>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListAvailableSolutionStacks">REST API Reference for ListAvailableSolutionStacks Operation</seealso>
        public virtual ListAvailableSolutionStacksResponse ListAvailableSolutionStacks(ListAvailableSolutionStacksRequest request)
        {
            var marshaller = ListAvailableSolutionStacksRequestMarshaller.Instance;
            var unmarshaller = ListAvailableSolutionStacksResponseUnmarshaller.Instance;

            return Invoke<ListAvailableSolutionStacksRequest,ListAvailableSolutionStacksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableSolutionStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableSolutionStacks operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAvailableSolutionStacks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListAvailableSolutionStacks">REST API Reference for ListAvailableSolutionStacks Operation</seealso>
        public virtual IAsyncResult BeginListAvailableSolutionStacks(ListAvailableSolutionStacksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListAvailableSolutionStacksRequestMarshaller.Instance;
            var unmarshaller = ListAvailableSolutionStacksResponseUnmarshaller.Instance;

            return BeginInvoke<ListAvailableSolutionStacksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAvailableSolutionStacks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailableSolutionStacks.</param>
        /// 
        /// <returns>Returns a  ListAvailableSolutionStacksResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListAvailableSolutionStacks">REST API Reference for ListAvailableSolutionStacks Operation</seealso>
        public virtual ListAvailableSolutionStacksResponse EndListAvailableSolutionStacks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAvailableSolutionStacksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPlatformVersions

        /// <summary>
        /// Lists the available platforms.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlatformVersions service method.</param>
        /// 
        /// <returns>The response from the ListPlatformVersions service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListPlatformVersions">REST API Reference for ListPlatformVersions Operation</seealso>
        public virtual ListPlatformVersionsResponse ListPlatformVersions(ListPlatformVersionsRequest request)
        {
            var marshaller = ListPlatformVersionsRequestMarshaller.Instance;
            var unmarshaller = ListPlatformVersionsResponseUnmarshaller.Instance;

            return Invoke<ListPlatformVersionsRequest,ListPlatformVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPlatformVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlatformVersions operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPlatformVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListPlatformVersions">REST API Reference for ListPlatformVersions Operation</seealso>
        public virtual IAsyncResult BeginListPlatformVersions(ListPlatformVersionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListPlatformVersionsRequestMarshaller.Instance;
            var unmarshaller = ListPlatformVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListPlatformVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPlatformVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPlatformVersions.</param>
        /// 
        /// <returns>Returns a  ListPlatformVersionsResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListPlatformVersions">REST API Reference for ListPlatformVersions Operation</seealso>
        public virtual ListPlatformVersionsResponse EndListPlatformVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPlatformVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns the tags applied to an AWS Elastic Beanstalk resource. The response contains
        /// a list of tag key-value pairs.
        /// 
        ///  
        /// <para>
        /// Currently, Elastic Beanstalk only supports tagging of Elastic Beanstalk environments.
        /// For details about environment tagging, see <a href="http://docs.aws.amazon.com/elasticbeanstalk/latest/dg/using-features.tagging.html">Tagging
        /// Resources in Your Elastic Beanstalk Environment</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN).
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ResourceTypeNotSupportedException">
        /// The type of the specified Amazon Resource Name (ARN) isn't supported for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke<ListTagsForResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
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
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RebuildEnvironment">REST API Reference for RebuildEnvironment Operation</seealso>
        public virtual RebuildEnvironmentResponse RebuildEnvironment(RebuildEnvironmentRequest request)
        {
            var marshaller = RebuildEnvironmentRequestMarshaller.Instance;
            var unmarshaller = RebuildEnvironmentResponseUnmarshaller.Instance;

            return Invoke<RebuildEnvironmentRequest,RebuildEnvironmentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebuildEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebuildEnvironment operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebuildEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RebuildEnvironment">REST API Reference for RebuildEnvironment Operation</seealso>
        public virtual IAsyncResult BeginRebuildEnvironment(RebuildEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RebuildEnvironmentRequestMarshaller.Instance;
            var unmarshaller = RebuildEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke<RebuildEnvironmentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RebuildEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebuildEnvironment.</param>
        /// 
        /// <returns>Returns a  RebuildEnvironmentResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RebuildEnvironment">REST API Reference for RebuildEnvironment Operation</seealso>
        public virtual RebuildEnvironmentResponse EndRebuildEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<RebuildEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  RequestEnvironmentInfo

        /// <summary>
        /// Initiates a request to compile the specified type of information of the deployed environment.
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
        ///  <ul> <li> 
        /// <para>
        ///  <a>RetrieveEnvironmentInfo</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestEnvironmentInfo service method.</param>
        /// 
        /// <returns>The response from the RequestEnvironmentInfo service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RequestEnvironmentInfo">REST API Reference for RequestEnvironmentInfo Operation</seealso>
        public virtual RequestEnvironmentInfoResponse RequestEnvironmentInfo(RequestEnvironmentInfoRequest request)
        {
            var marshaller = RequestEnvironmentInfoRequestMarshaller.Instance;
            var unmarshaller = RequestEnvironmentInfoResponseUnmarshaller.Instance;

            return Invoke<RequestEnvironmentInfoRequest,RequestEnvironmentInfoResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RequestEnvironmentInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestEnvironmentInfo operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRequestEnvironmentInfo
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RequestEnvironmentInfo">REST API Reference for RequestEnvironmentInfo Operation</seealso>
        public virtual IAsyncResult BeginRequestEnvironmentInfo(RequestEnvironmentInfoRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RequestEnvironmentInfoRequestMarshaller.Instance;
            var unmarshaller = RequestEnvironmentInfoResponseUnmarshaller.Instance;

            return BeginInvoke<RequestEnvironmentInfoRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RequestEnvironmentInfo operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestEnvironmentInfo.</param>
        /// 
        /// <returns>Returns a  RequestEnvironmentInfoResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RequestEnvironmentInfo">REST API Reference for RequestEnvironmentInfo Operation</seealso>
        public virtual RequestEnvironmentInfoResponse EndRequestEnvironmentInfo(IAsyncResult asyncResult)
        {
            return EndInvoke<RequestEnvironmentInfoResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RestartAppServer">REST API Reference for RestartAppServer Operation</seealso>
        public virtual RestartAppServerResponse RestartAppServer(RestartAppServerRequest request)
        {
            var marshaller = RestartAppServerRequestMarshaller.Instance;
            var unmarshaller = RestartAppServerResponseUnmarshaller.Instance;

            return Invoke<RestartAppServerRequest,RestartAppServerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestartAppServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestartAppServer operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestartAppServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RestartAppServer">REST API Reference for RestartAppServer Operation</seealso>
        public virtual IAsyncResult BeginRestartAppServer(RestartAppServerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RestartAppServerRequestMarshaller.Instance;
            var unmarshaller = RestartAppServerResponseUnmarshaller.Instance;

            return BeginInvoke<RestartAppServerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestartAppServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestartAppServer.</param>
        /// 
        /// <returns>Returns a  RestartAppServerResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RestartAppServer">REST API Reference for RestartAppServer Operation</seealso>
        public virtual RestartAppServerResponse EndRestartAppServer(IAsyncResult asyncResult)
        {
            return EndInvoke<RestartAppServerResponse>(asyncResult);
        }

        #endregion
        
        #region  RetrieveEnvironmentInfo

        /// <summary>
        /// Retrieves the compiled information from a <a>RequestEnvironmentInfo</a> request.
        /// 
        ///  
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RequestEnvironmentInfo</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveEnvironmentInfo service method.</param>
        /// 
        /// <returns>The response from the RetrieveEnvironmentInfo service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RetrieveEnvironmentInfo">REST API Reference for RetrieveEnvironmentInfo Operation</seealso>
        public virtual RetrieveEnvironmentInfoResponse RetrieveEnvironmentInfo(RetrieveEnvironmentInfoRequest request)
        {
            var marshaller = RetrieveEnvironmentInfoRequestMarshaller.Instance;
            var unmarshaller = RetrieveEnvironmentInfoResponseUnmarshaller.Instance;

            return Invoke<RetrieveEnvironmentInfoRequest,RetrieveEnvironmentInfoResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveEnvironmentInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveEnvironmentInfo operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetrieveEnvironmentInfo
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RetrieveEnvironmentInfo">REST API Reference for RetrieveEnvironmentInfo Operation</seealso>
        public virtual IAsyncResult BeginRetrieveEnvironmentInfo(RetrieveEnvironmentInfoRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RetrieveEnvironmentInfoRequestMarshaller.Instance;
            var unmarshaller = RetrieveEnvironmentInfoResponseUnmarshaller.Instance;

            return BeginInvoke<RetrieveEnvironmentInfoRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RetrieveEnvironmentInfo operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetrieveEnvironmentInfo.</param>
        /// 
        /// <returns>Returns a  RetrieveEnvironmentInfoResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RetrieveEnvironmentInfo">REST API Reference for RetrieveEnvironmentInfo Operation</seealso>
        public virtual RetrieveEnvironmentInfoResponse EndRetrieveEnvironmentInfo(IAsyncResult asyncResult)
        {
            return EndInvoke<RetrieveEnvironmentInfoResponse>(asyncResult);
        }

        #endregion
        
        #region  SwapEnvironmentCNAMEs

        /// <summary>
        /// Swaps the CNAMEs of two environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs service method.</param>
        /// 
        /// <returns>The response from the SwapEnvironmentCNAMEs service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/SwapEnvironmentCNAMEs">REST API Reference for SwapEnvironmentCNAMEs Operation</seealso>
        public virtual SwapEnvironmentCNAMEsResponse SwapEnvironmentCNAMEs(SwapEnvironmentCNAMEsRequest request)
        {
            var marshaller = SwapEnvironmentCNAMEsRequestMarshaller.Instance;
            var unmarshaller = SwapEnvironmentCNAMEsResponseUnmarshaller.Instance;

            return Invoke<SwapEnvironmentCNAMEsRequest,SwapEnvironmentCNAMEsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SwapEnvironmentCNAMEs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSwapEnvironmentCNAMEs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/SwapEnvironmentCNAMEs">REST API Reference for SwapEnvironmentCNAMEs Operation</seealso>
        public virtual IAsyncResult BeginSwapEnvironmentCNAMEs(SwapEnvironmentCNAMEsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = SwapEnvironmentCNAMEsRequestMarshaller.Instance;
            var unmarshaller = SwapEnvironmentCNAMEsResponseUnmarshaller.Instance;

            return BeginInvoke<SwapEnvironmentCNAMEsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SwapEnvironmentCNAMEs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSwapEnvironmentCNAMEs.</param>
        /// 
        /// <returns>Returns a  SwapEnvironmentCNAMEsResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/SwapEnvironmentCNAMEs">REST API Reference for SwapEnvironmentCNAMEs Operation</seealso>
        public virtual SwapEnvironmentCNAMEsResponse EndSwapEnvironmentCNAMEs(IAsyncResult asyncResult)
        {
            return EndInvoke<SwapEnvironmentCNAMEsResponse>(asyncResult);
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
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/TerminateEnvironment">REST API Reference for TerminateEnvironment Operation</seealso>
        public virtual TerminateEnvironmentResponse TerminateEnvironment(TerminateEnvironmentRequest request)
        {
            var marshaller = TerminateEnvironmentRequestMarshaller.Instance;
            var unmarshaller = TerminateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<TerminateEnvironmentRequest,TerminateEnvironmentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateEnvironment operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/TerminateEnvironment">REST API Reference for TerminateEnvironment Operation</seealso>
        public virtual IAsyncResult BeginTerminateEnvironment(TerminateEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = TerminateEnvironmentRequestMarshaller.Instance;
            var unmarshaller = TerminateEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke<TerminateEnvironmentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateEnvironment.</param>
        /// 
        /// <returns>Returns a  TerminateEnvironmentResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/TerminateEnvironment">REST API Reference for TerminateEnvironment Operation</seealso>
        public virtual TerminateEnvironmentResponse EndTerminateEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApplication

        /// <summary>
        /// Updates the specified application to have the specified properties.
        /// 
        ///  <note> 
        /// <para>
        /// If a property (for example, <code>description</code>) is not provided, the value remains
        /// unchanged. To clear these properties, specify an empty string.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var marshaller = UpdateApplicationRequestMarshaller.Instance;
            var unmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationRequest,UpdateApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual IAsyncResult BeginUpdateApplication(UpdateApplicationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateApplicationRequestMarshaller.Instance;
            var unmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateApplicationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplication.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApplicationResourceLifecycle

        /// <summary>
        /// Modifies lifecycle settings for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationResourceLifecycle service method.</param>
        /// 
        /// <returns>The response from the UpdateApplicationResourceLifecycle service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateApplicationResourceLifecycle">REST API Reference for UpdateApplicationResourceLifecycle Operation</seealso>
        public virtual UpdateApplicationResourceLifecycleResponse UpdateApplicationResourceLifecycle(UpdateApplicationResourceLifecycleRequest request)
        {
            var marshaller = UpdateApplicationResourceLifecycleRequestMarshaller.Instance;
            var unmarshaller = UpdateApplicationResourceLifecycleResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResourceLifecycleRequest,UpdateApplicationResourceLifecycleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationResourceLifecycle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationResourceLifecycle operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplicationResourceLifecycle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateApplicationResourceLifecycle">REST API Reference for UpdateApplicationResourceLifecycle Operation</seealso>
        public virtual IAsyncResult BeginUpdateApplicationResourceLifecycle(UpdateApplicationResourceLifecycleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateApplicationResourceLifecycleRequestMarshaller.Instance;
            var unmarshaller = UpdateApplicationResourceLifecycleResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateApplicationResourceLifecycleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplicationResourceLifecycle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplicationResourceLifecycle.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationResourceLifecycleResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateApplicationResourceLifecycle">REST API Reference for UpdateApplicationResourceLifecycle Operation</seealso>
        public virtual UpdateApplicationResourceLifecycleResponse EndUpdateApplicationResourceLifecycle(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApplicationResourceLifecycleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApplicationVersion

        /// <summary>
        /// Updates the specified application version to have the specified properties.
        /// 
        ///  <note> 
        /// <para>
        /// If a property (for example, <code>description</code>) is not provided, the value remains
        /// unchanged. To clear properties, specify an empty string.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateApplicationVersion">REST API Reference for UpdateApplicationVersion Operation</seealso>
        public virtual UpdateApplicationVersionResponse UpdateApplicationVersion(UpdateApplicationVersionRequest request)
        {
            var marshaller = UpdateApplicationVersionRequestMarshaller.Instance;
            var unmarshaller = UpdateApplicationVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationVersionRequest,UpdateApplicationVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationVersion operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplicationVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateApplicationVersion">REST API Reference for UpdateApplicationVersion Operation</seealso>
        public virtual IAsyncResult BeginUpdateApplicationVersion(UpdateApplicationVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateApplicationVersionRequestMarshaller.Instance;
            var unmarshaller = UpdateApplicationVersionResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateApplicationVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplicationVersion.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationVersionResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateApplicationVersion">REST API Reference for UpdateApplicationVersion Operation</seealso>
        public virtual UpdateApplicationVersionResponse EndUpdateApplicationVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApplicationVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConfigurationTemplate

        /// <summary>
        /// Updates the specified configuration template to have the specified properties or configuration
        /// option values.
        /// 
        ///  <note> 
        /// <para>
        /// If a property (for example, <code>ApplicationName</code>) is not provided, its value
        /// remains unchanged. To clear such properties, specify an empty string.
        /// </para>
        ///  </note> 
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeConfigurationOptions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateConfigurationTemplate">REST API Reference for UpdateConfigurationTemplate Operation</seealso>
        public virtual UpdateConfigurationTemplateResponse UpdateConfigurationTemplate(UpdateConfigurationTemplateRequest request)
        {
            var marshaller = UpdateConfigurationTemplateRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationTemplateRequest,UpdateConfigurationTemplateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationTemplate operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfigurationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateConfigurationTemplate">REST API Reference for UpdateConfigurationTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdateConfigurationTemplate(UpdateConfigurationTemplateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateConfigurationTemplateRequestMarshaller.Instance;
            var unmarshaller = UpdateConfigurationTemplateResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateConfigurationTemplateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateConfigurationTemplateResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateConfigurationTemplate">REST API Reference for UpdateConfigurationTemplate Operation</seealso>
        public virtual UpdateConfigurationTemplateResponse EndUpdateConfigurationTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConfigurationTemplateResponse>(asyncResult);
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
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
        {
            var marshaller = UpdateEnvironmentRequestMarshaller.Instance;
            var unmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentRequest,UpdateEnvironmentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual IAsyncResult BeginUpdateEnvironment(UpdateEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateEnvironmentRequestMarshaller.Instance;
            var unmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateEnvironmentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnvironment.</param>
        /// 
        /// <returns>Returns a  UpdateEnvironmentResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual UpdateEnvironmentResponse EndUpdateEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTagsForResource

        /// <summary>
        /// Update the list of tags applied to an AWS Elastic Beanstalk resource. Two lists can
        /// be passed: <code>TagsToAdd</code> for tags to add or update, and <code>TagsToRemove</code>.
        /// 
        ///  
        /// <para>
        /// Currently, Elastic Beanstalk only supports tagging of Elastic Beanstalk environments.
        /// For details about environment tagging, see <a href="http://docs.aws.amazon.com/elasticbeanstalk/latest/dg/using-features.tagging.html">Tagging
        /// Resources in Your Elastic Beanstalk Environment</a>.
        /// </para>
        ///  
        /// <para>
        /// If you create a custom IAM user policy to control permission to this operation, specify
        /// one of the following two virtual actions (or both) instead of the API operation name:
        /// </para>
        ///  <dl> <dt>elasticbeanstalk:AddTags</dt> <dd> 
        /// <para>
        /// Controls permission to call <code>UpdateTagsForResource</code> and pass a list of
        /// tags to add in the <code>TagsToAdd</code> parameter.
        /// </para>
        ///  </dd> <dt>elasticbeanstalk:RemoveTags</dt> <dd> 
        /// <para>
        /// Controls permission to call <code>UpdateTagsForResource</code> and pass a list of
        /// tag keys to remove in the <code>TagsToRemove</code> parameter.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// For details about creating a custom user policy, see <a href="http://docs.aws.amazon.com/elasticbeanstalk/latest/dg/AWSHowTo.iam.managed-policies.html#AWSHowTo.iam.policies">Creating
        /// a Custom User Policy</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagsForResource service method.</param>
        /// 
        /// <returns>The response from the UpdateTagsForResource service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN).
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ResourceTypeNotSupportedException">
        /// The type of the specified Amazon Resource Name (ARN) isn't supported for this operation.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyTagsException">
        /// The number of tags in the resource would exceed the number of tags that each resource
        /// can have.
        /// 
        ///  
        /// <para>
        /// To calculate this, the operation considers both the number of tags the resource already
        /// has and the tags this operation would add if it succeeded.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateTagsForResource">REST API Reference for UpdateTagsForResource Operation</seealso>
        public virtual UpdateTagsForResourceResponse UpdateTagsForResource(UpdateTagsForResourceRequest request)
        {
            var marshaller = UpdateTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = UpdateTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<UpdateTagsForResourceRequest,UpdateTagsForResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagsForResource operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateTagsForResource">REST API Reference for UpdateTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginUpdateTagsForResource(UpdateTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = UpdateTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateTagsForResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTagsForResource.</param>
        /// 
        /// <returns>Returns a  UpdateTagsForResourceResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateTagsForResource">REST API Reference for UpdateTagsForResource Operation</seealso>
        public virtual UpdateTagsForResourceResponse EndUpdateTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ValidateConfigurationSettings

        /// <summary>
        /// Takes a set of configuration settings and either a configuration template or environment,
        /// and determines whether those values are valid.
        /// 
        ///  
        /// <para>
        /// This action returns a list of messages indicating any errors or warnings associated
        /// with the selection of option values.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateConfigurationSettings service method.</param>
        /// 
        /// <returns>The response from the ValidateConfigurationSettings service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ValidateConfigurationSettings">REST API Reference for ValidateConfigurationSettings Operation</seealso>
        public virtual ValidateConfigurationSettingsResponse ValidateConfigurationSettings(ValidateConfigurationSettingsRequest request)
        {
            var marshaller = ValidateConfigurationSettingsRequestMarshaller.Instance;
            var unmarshaller = ValidateConfigurationSettingsResponseUnmarshaller.Instance;

            return Invoke<ValidateConfigurationSettingsRequest,ValidateConfigurationSettingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateConfigurationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateConfigurationSettings operation on AmazonElasticBeanstalkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidateConfigurationSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ValidateConfigurationSettings">REST API Reference for ValidateConfigurationSettings Operation</seealso>
        public virtual IAsyncResult BeginValidateConfigurationSettings(ValidateConfigurationSettingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ValidateConfigurationSettingsRequestMarshaller.Instance;
            var unmarshaller = ValidateConfigurationSettingsResponseUnmarshaller.Instance;

            return BeginInvoke<ValidateConfigurationSettingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ValidateConfigurationSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateConfigurationSettings.</param>
        /// 
        /// <returns>Returns a  ValidateConfigurationSettingsResult from ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ValidateConfigurationSettings">REST API Reference for ValidateConfigurationSettings Operation</seealso>
        public virtual ValidateConfigurationSettingsResponse EndValidateConfigurationSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<ValidateConfigurationSettingsResponse>(asyncResult);
        }

        #endregion
        
    }
}
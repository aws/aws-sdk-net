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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.DevOpsGuru.Model;
using Amazon.DevOpsGuru.Model.Internal.MarshallTransformations;
using Amazon.DevOpsGuru.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DevOpsGuru
{
    /// <summary>
    /// Implementation for accessing DevOpsGuru
    ///
    /// Amazon DevOps Guru is a fully managed service that helps you identify anomalous behavior
    /// in business critical operational applications. You specify the AWS resources that
    /// you want DevOps Guru to cover, then the Amazon CloudWatch metrics and AWS CloudTrail
    /// events related to those resources are analyzed. When anomalous behavior is detected,
    /// DevOps Guru creates an <i>insight</i> that includes recommendations, related events,
    /// and related metrics that can help you improve your operational applications. For more
    /// information, see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/welcome.html">What
    /// is Amazon DevOps Guru</a>. 
    /// 
    ///  
    /// <para>
    ///  You can specify 1 or 2 Amazon Simple Notification Service topics so you are notified
    /// every time a new insight is created. You can also enable DevOps Guru to generate an
    /// OpsItem in AWS Systems Manager for each insight to help you manage and track your
    /// work addressing insights. 
    /// </para>
    ///  
    /// <para>
    ///  To learn about the DevOps Guru workflow, see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/welcome.html#how-it-works">How
    /// DevOps Guru works</a>. To learn about DevOps Guru concepts, see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/concepts.html">Concepts
    /// in DevOps Guru</a>. 
    /// </para>
    /// </summary>
    public partial class AmazonDevOpsGuruClient : AmazonServiceClient, IAmazonDevOpsGuru
    {
        private static IServiceMetadata serviceMetadata = new AmazonDevOpsGuruMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonDevOpsGuruClient with the credentials loaded from the application's
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
        public AmazonDevOpsGuruClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDevOpsGuruConfig()) { }

        /// <summary>
        /// Constructs AmazonDevOpsGuruClient with the credentials loaded from the application's
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
        public AmazonDevOpsGuruClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDevOpsGuruConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDevOpsGuruClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDevOpsGuruClient Configuration Object</param>
        public AmazonDevOpsGuruClient(AmazonDevOpsGuruConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonDevOpsGuruClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDevOpsGuruClient(AWSCredentials credentials)
            : this(credentials, new AmazonDevOpsGuruConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDevOpsGuruClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDevOpsGuruClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDevOpsGuruConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDevOpsGuruClient with AWS Credentials and an
        /// AmazonDevOpsGuruClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDevOpsGuruClient Configuration Object</param>
        public AmazonDevOpsGuruClient(AWSCredentials credentials, AmazonDevOpsGuruConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDevOpsGuruClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDevOpsGuruClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDevOpsGuruConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDevOpsGuruClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDevOpsGuruClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDevOpsGuruConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDevOpsGuruClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDevOpsGuruClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDevOpsGuruClient Configuration Object</param>
        public AmazonDevOpsGuruClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDevOpsGuruConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDevOpsGuruClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDevOpsGuruClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDevOpsGuruConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDevOpsGuruClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDevOpsGuruClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDevOpsGuruConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDevOpsGuruClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDevOpsGuruClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDevOpsGuruClient Configuration Object</param>
        public AmazonDevOpsGuruClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDevOpsGuruConfig clientConfig)
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

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
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


        #region  AddNotificationChannel

        /// <summary>
        /// Adds a notification channel to DevOps Guru. A notification channel is used to notify
        /// you about important DevOps Guru events, such as when an insight is generated. 
        /// 
        ///  
        /// <para>
        /// If you use an Amazon SNS topic in another account, you must attach a policy to it
        /// that grants DevOps Guru permission to it notifications. DevOps Guru adds the required
        /// policy on your behalf to send notifications using Amazon SNS in your account. For
        /// more information, see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/sns-required-permissions.html">Permissions
        /// for cross account Amazon SNS topics</a>.
        /// </para>
        ///  
        /// <para>
        /// If you use an Amazon SNS topic that is encrypted by an AWS Key Management Service
        /// customer-managed key (CMK), then you must add permissions to the CMK. For more information,
        /// see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/sns-kms-permissions.html">Permissions
        /// for AWS KMS–encrypted Amazon SNS topics</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddNotificationChannel service method.</param>
        /// 
        /// <returns>The response from the AddNotificationChannel service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ConflictException">
        /// An exception that is thrown when a conflict occurs.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// An internal failure in an Amazon service occurred.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ResourceNotFoundException">
        /// A requested resource could not be found
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ServiceQuotaExceededException">
        /// The request contains a value that exceeds a maximum quota.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// The request was denied due to a request throttling.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// Contains information about data passed in to a field during a request that is not
        /// valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/AddNotificationChannel">REST API Reference for AddNotificationChannel Operation</seealso>
        public virtual AddNotificationChannelResponse AddNotificationChannel(AddNotificationChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddNotificationChannelResponseUnmarshaller.Instance;

            return Invoke<AddNotificationChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddNotificationChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddNotificationChannel operation on AmazonDevOpsGuruClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddNotificationChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/AddNotificationChannel">REST API Reference for AddNotificationChannel Operation</seealso>
        public virtual IAsyncResult BeginAddNotificationChannel(AddNotificationChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddNotificationChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddNotificationChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddNotificationChannel.</param>
        /// 
        /// <returns>Returns a  AddNotificationChannelResult from DevOpsGuru.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/AddNotificationChannel">REST API Reference for AddNotificationChannel Operation</seealso>
        public virtual AddNotificationChannelResponse EndAddNotificationChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<AddNotificationChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccountHealth

        /// <summary>
        /// Returns the number of open reactive insights, the number of open proactive insights,
        /// and the number of metrics analyzed in your AWS account. Use these numbers to gauge
        /// the health of operations in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountHealth service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountHealth service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// An internal failure in an Amazon service occurred.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// The request was denied due to a request throttling.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// Contains information about data passed in to a field during a request that is not
        /// valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeAccountHealth">REST API Reference for DescribeAccountHealth Operation</seealso>
        public virtual DescribeAccountHealthResponse DescribeAccountHealth(DescribeAccountHealthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountHealthResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountHealthResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountHealth operation on AmazonDevOpsGuruClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountHealth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeAccountHealth">REST API Reference for DescribeAccountHealth Operation</seealso>
        public virtual IAsyncResult BeginDescribeAccountHealth(DescribeAccountHealthRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountHealthResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountHealth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountHealth.</param>
        /// 
        /// <returns>Returns a  DescribeAccountHealthResult from DevOpsGuru.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeAccountHealth">REST API Reference for DescribeAccountHealth Operation</seealso>
        public virtual DescribeAccountHealthResponse EndDescribeAccountHealth(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccountHealthResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccountOverview

        /// <summary>
        /// For the time range passed in, returns the number of open reactive insight that were
        /// created, the number of open proactive insights that were created, and the Mean Time
        /// to Recover (MTTR) for all closed reactive insights.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountOverview service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountOverview service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// An internal failure in an Amazon service occurred.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// The request was denied due to a request throttling.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// Contains information about data passed in to a field during a request that is not
        /// valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeAccountOverview">REST API Reference for DescribeAccountOverview Operation</seealso>
        public virtual DescribeAccountOverviewResponse DescribeAccountOverview(DescribeAccountOverviewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountOverviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountOverviewResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountOverviewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountOverview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountOverview operation on AmazonDevOpsGuruClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountOverview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeAccountOverview">REST API Reference for DescribeAccountOverview Operation</seealso>
        public virtual IAsyncResult BeginDescribeAccountOverview(DescribeAccountOverviewRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountOverviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountOverviewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountOverview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountOverview.</param>
        /// 
        /// <returns>Returns a  DescribeAccountOverviewResult from DevOpsGuru.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeAccountOverview">REST API Reference for DescribeAccountOverview Operation</seealso>
        public virtual DescribeAccountOverviewResponse EndDescribeAccountOverview(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccountOverviewResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAnomaly

        /// <summary>
        /// Returns details about an anomaly that you specify using its ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnomaly service method.</param>
        /// 
        /// <returns>The response from the DescribeAnomaly service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// An internal failure in an Amazon service occurred.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ResourceNotFoundException">
        /// A requested resource could not be found
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// The request was denied due to a request throttling.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// Contains information about data passed in to a field during a request that is not
        /// valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeAnomaly">REST API Reference for DescribeAnomaly Operation</seealso>
        public virtual DescribeAnomalyResponse DescribeAnomaly(DescribeAnomalyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAnomalyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnomalyResponseUnmarshaller.Instance;

            return Invoke<DescribeAnomalyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAnomaly operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnomaly operation on AmazonDevOpsGuruClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAnomaly
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeAnomaly">REST API Reference for DescribeAnomaly Operation</seealso>
        public virtual IAsyncResult BeginDescribeAnomaly(DescribeAnomalyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAnomalyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnomalyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAnomaly operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAnomaly.</param>
        /// 
        /// <returns>Returns a  DescribeAnomalyResult from DevOpsGuru.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeAnomaly">REST API Reference for DescribeAnomaly Operation</seealso>
        public virtual DescribeAnomalyResponse EndDescribeAnomaly(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAnomalyResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInsight

        /// <summary>
        /// Returns details about an insight that you specify using its ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInsight service method.</param>
        /// 
        /// <returns>The response from the DescribeInsight service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// An internal failure in an Amazon service occurred.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ResourceNotFoundException">
        /// A requested resource could not be found
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// The request was denied due to a request throttling.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// Contains information about data passed in to a field during a request that is not
        /// valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeInsight">REST API Reference for DescribeInsight Operation</seealso>
        public virtual DescribeInsightResponse DescribeInsight(DescribeInsightRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInsightResponseUnmarshaller.Instance;

            return Invoke<DescribeInsightResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInsight operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInsight operation on AmazonDevOpsGuruClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInsight
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeInsight">REST API Reference for DescribeInsight Operation</seealso>
        public virtual IAsyncResult BeginDescribeInsight(DescribeInsightRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInsightResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInsight operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInsight.</param>
        /// 
        /// <returns>Returns a  DescribeInsightResult from DevOpsGuru.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeInsight">REST API Reference for DescribeInsight Operation</seealso>
        public virtual DescribeInsightResponse EndDescribeInsight(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInsightResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeResourceCollectionHealth

        /// <summary>
        /// Returns the number of open proactive insights, open reactive insights, and the Mean
        /// Time to Recover (MTTR) for all closed insights in resource collections in your account.
        /// You specify the type of AWS resources collection. The one type of AWS resource collection
        /// supported is AWS CloudFormation stacks. DevOps Guru can be configured to analyze only
        /// the AWS resources that are defined in the stacks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceCollectionHealth service method.</param>
        /// 
        /// <returns>The response from the DescribeResourceCollectionHealth service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// An internal failure in an Amazon service occurred.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// The request was denied due to a request throttling.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// Contains information about data passed in to a field during a request that is not
        /// valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeResourceCollectionHealth">REST API Reference for DescribeResourceCollectionHealth Operation</seealso>
        public virtual DescribeResourceCollectionHealthResponse DescribeResourceCollectionHealth(DescribeResourceCollectionHealthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourceCollectionHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceCollectionHealthResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceCollectionHealthResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourceCollectionHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceCollectionHealth operation on AmazonDevOpsGuruClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResourceCollectionHealth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeResourceCollectionHealth">REST API Reference for DescribeResourceCollectionHealth Operation</seealso>
        public virtual IAsyncResult BeginDescribeResourceCollectionHealth(DescribeResourceCollectionHealthRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourceCollectionHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceCollectionHealthResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResourceCollectionHealth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResourceCollectionHealth.</param>
        /// 
        /// <returns>Returns a  DescribeResourceCollectionHealthResult from DevOpsGuru.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeResourceCollectionHealth">REST API Reference for DescribeResourceCollectionHealth Operation</seealso>
        public virtual DescribeResourceCollectionHealthResponse EndDescribeResourceCollectionHealth(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeResourceCollectionHealthResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeServiceIntegration

        /// <summary>
        /// Returns the integration status of services that are integrated with DevOps Guru.
        /// The one service that can be integrated with DevOps Guru is AWS Systems Manager, which
        /// can be used to create an OpsItem for each generated insight.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceIntegration service method.</param>
        /// 
        /// <returns>The response from the DescribeServiceIntegration service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// An internal failure in an Amazon service occurred.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// The request was denied due to a request throttling.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// Contains information about data passed in to a field during a request that is not
        /// valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeServiceIntegration">REST API Reference for DescribeServiceIntegration Operation</seealso>
        public virtual DescribeServiceIntegrationResponse DescribeServiceIntegration(DescribeServiceIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServiceIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceIntegrationResponseUnmarshaller.Instance;

            return Invoke<DescribeServiceIntegrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceIntegration operation on AmazonDevOpsGuruClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeServiceIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeServiceIntegration">REST API Reference for DescribeServiceIntegration Operation</seealso>
        public virtual IAsyncResult BeginDescribeServiceIntegration(DescribeServiceIntegrationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServiceIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeServiceIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServiceIntegration.</param>
        /// 
        /// <returns>Returns a  DescribeServiceIntegrationResult from DevOpsGuru.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeServiceIntegration">REST API Reference for DescribeServiceIntegration Operation</seealso>
        public virtual DescribeServiceIntegrationResponse EndDescribeServiceIntegration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeServiceIntegrationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourceCollection

        /// <summary>
        /// Returns lists AWS resources that are of the specified resource collection type. The
        /// one type of AWS resource collection supported is AWS CloudFormation stacks. DevOps
        /// Guru can be configured to analyze only the AWS resources that are defined in the stacks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceCollection service method.</param>
        /// 
        /// <returns>The response from the GetResourceCollection service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// An internal failure in an Amazon service occurred.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ResourceNotFoundException">
        /// A requested resource could not be found
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// The request was denied due to a request throttling.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// Contains information about data passed in to a field during a request that is not
        /// valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/GetResourceCollection">REST API Reference for GetResourceCollection Operation</seealso>
        public virtual GetResourceCollectionResponse GetResourceCollection(GetResourceCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceCollectionResponseUnmarshaller.Instance;

            return Invoke<GetResourceCollectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceCollection operation on AmazonDevOpsGuruClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/GetResourceCollection">REST API Reference for GetResourceCollection Operation</seealso>
        public virtual IAsyncResult BeginGetResourceCollection(GetResourceCollectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceCollectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceCollection.</param>
        /// 
        /// <returns>Returns a  GetResourceCollectionResult from DevOpsGuru.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/GetResourceCollection">REST API Reference for GetResourceCollection Operation</seealso>
        public virtual GetResourceCollectionResponse EndGetResourceCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourceCollectionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAnomaliesForInsight

        /// <summary>
        /// Returns a list of the anomalies that belong to an insight that you specify using
        /// its ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnomaliesForInsight service method.</param>
        /// 
        /// <returns>The response from the ListAnomaliesForInsight service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// An internal failure in an Amazon service occurred.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ResourceNotFoundException">
        /// A requested resource could not be found
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// The request was denied due to a request throttling.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// Contains information about data passed in to a field during a request that is not
        /// valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListAnomaliesForInsight">REST API Reference for ListAnomaliesForInsight Operation</seealso>
        public virtual ListAnomaliesForInsightResponse ListAnomaliesForInsight(ListAnomaliesForInsightRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAnomaliesForInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomaliesForInsightResponseUnmarshaller.Instance;

            return Invoke<ListAnomaliesForInsightResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAnomaliesForInsight operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAnomaliesForInsight operation on AmazonDevOpsGuruClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAnomaliesForInsight
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListAnomaliesForInsight">REST API Reference for ListAnomaliesForInsight Operation</seealso>
        public virtual IAsyncResult BeginListAnomaliesForInsight(ListAnomaliesForInsightRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAnomaliesForInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomaliesForInsightResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAnomaliesForInsight operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAnomaliesForInsight.</param>
        /// 
        /// <returns>Returns a  ListAnomaliesForInsightResult from DevOpsGuru.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListAnomaliesForInsight">REST API Reference for ListAnomaliesForInsight Operation</seealso>
        public virtual ListAnomaliesForInsightResponse EndListAnomaliesForInsight(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAnomaliesForInsightResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEvents

        /// <summary>
        /// Returns a list of the events emitted by the resources that are evaluated by DevOps
        /// Guru. You can use filters to specify which events are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEvents service method.</param>
        /// 
        /// <returns>The response from the ListEvents service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// An internal failure in an Amazon service occurred.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ResourceNotFoundException">
        /// A requested resource could not be found
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// The request was denied due to a request throttling.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// Contains information about data passed in to a field during a request that is not
        /// valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListEvents">REST API Reference for ListEvents Operation</seealso>
        public virtual ListEventsResponse ListEvents(ListEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventsResponseUnmarshaller.Instance;

            return Invoke<ListEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEvents operation on AmazonDevOpsGuruClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListEvents">REST API Reference for ListEvents Operation</seealso>
        public virtual IAsyncResult BeginListEvents(ListEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEvents.</param>
        /// 
        /// <returns>Returns a  ListEventsResult from DevOpsGuru.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListEvents">REST API Reference for ListEvents Operation</seealso>
        public virtual ListEventsResponse EndListEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInsights

        /// <summary>
        /// Returns a list of insights in your AWS account. You can specify which insights are
        /// returned by their start time and status (<code>ONGOING</code>, <code>CLOSED</code>,
        /// or <code>ANY</code>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInsights service method.</param>
        /// 
        /// <returns>The response from the ListInsights service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// An internal failure in an Amazon service occurred.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// The request was denied due to a request throttling.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// Contains information about data passed in to a field during a request that is not
        /// valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListInsights">REST API Reference for ListInsights Operation</seealso>
        public virtual ListInsightsResponse ListInsights(ListInsightsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInsightsResponseUnmarshaller.Instance;

            return Invoke<ListInsightsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInsights operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInsights operation on AmazonDevOpsGuruClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInsights
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListInsights">REST API Reference for ListInsights Operation</seealso>
        public virtual IAsyncResult BeginListInsights(ListInsightsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInsightsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInsights operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInsights.</param>
        /// 
        /// <returns>Returns a  ListInsightsResult from DevOpsGuru.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListInsights">REST API Reference for ListInsights Operation</seealso>
        public virtual ListInsightsResponse EndListInsights(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInsightsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNotificationChannels

        /// <summary>
        /// Returns a list of notification channels configured for DevOps Guru. Each notification
        /// channel is used to notify you when DevOps Guru generates an insight that contains
        /// information about how to improve your operations. The one supported notification channel
        /// is Amazon Simple Notification Service (Amazon SNS).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationChannels service method.</param>
        /// 
        /// <returns>The response from the ListNotificationChannels service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// An internal failure in an Amazon service occurred.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// The request was denied due to a request throttling.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// Contains information about data passed in to a field during a request that is not
        /// valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListNotificationChannels">REST API Reference for ListNotificationChannels Operation</seealso>
        public virtual ListNotificationChannelsResponse ListNotificationChannels(ListNotificationChannelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotificationChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationChannelsResponseUnmarshaller.Instance;

            return Invoke<ListNotificationChannelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNotificationChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationChannels operation on AmazonDevOpsGuruClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotificationChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListNotificationChannels">REST API Reference for ListNotificationChannels Operation</seealso>
        public virtual IAsyncResult BeginListNotificationChannels(ListNotificationChannelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotificationChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationChannelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotificationChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotificationChannels.</param>
        /// 
        /// <returns>Returns a  ListNotificationChannelsResult from DevOpsGuru.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListNotificationChannels">REST API Reference for ListNotificationChannels Operation</seealso>
        public virtual ListNotificationChannelsResponse EndListNotificationChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNotificationChannelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRecommendations

        /// <summary>
        /// Returns a list of a specified insight's recommendations. Each recommendation includes
        /// a list of related metrics and a list of related events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListRecommendations service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// An internal failure in an Amazon service occurred.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ResourceNotFoundException">
        /// A requested resource could not be found
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// The request was denied due to a request throttling.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// Contains information about data passed in to a field during a request that is not
        /// valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        public virtual ListRecommendationsResponse ListRecommendations(ListRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ListRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations operation on AmazonDevOpsGuruClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        public virtual IAsyncResult BeginListRecommendations(ListRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecommendations.</param>
        /// 
        /// <returns>Returns a  ListRecommendationsResult from DevOpsGuru.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        public virtual ListRecommendationsResponse EndListRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutFeedback

        /// <summary>
        /// Collects customer feedback about the specified insight.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback service method.</param>
        /// 
        /// <returns>The response from the PutFeedback service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ConflictException">
        /// An exception that is thrown when a conflict occurs.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// An internal failure in an Amazon service occurred.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ResourceNotFoundException">
        /// A requested resource could not be found
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// The request was denied due to a request throttling.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// Contains information about data passed in to a field during a request that is not
        /// valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        public virtual PutFeedbackResponse PutFeedback(PutFeedbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFeedbackResponseUnmarshaller.Instance;

            return Invoke<PutFeedbackResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback operation on AmazonDevOpsGuruClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        public virtual IAsyncResult BeginPutFeedback(PutFeedbackRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFeedbackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutFeedback.</param>
        /// 
        /// <returns>Returns a  PutFeedbackResult from DevOpsGuru.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        public virtual PutFeedbackResponse EndPutFeedback(IAsyncResult asyncResult)
        {
            return EndInvoke<PutFeedbackResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveNotificationChannel

        /// <summary>
        /// Removes a notification channel from DevOps Guru. A notification channel is used to
        /// notify you when DevOps Guru generates an insight that contains information about how
        /// to improve your operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveNotificationChannel service method.</param>
        /// 
        /// <returns>The response from the RemoveNotificationChannel service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ConflictException">
        /// An exception that is thrown when a conflict occurs.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// An internal failure in an Amazon service occurred.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ResourceNotFoundException">
        /// A requested resource could not be found
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// The request was denied due to a request throttling.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// Contains information about data passed in to a field during a request that is not
        /// valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/RemoveNotificationChannel">REST API Reference for RemoveNotificationChannel Operation</seealso>
        public virtual RemoveNotificationChannelResponse RemoveNotificationChannel(RemoveNotificationChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveNotificationChannelResponseUnmarshaller.Instance;

            return Invoke<RemoveNotificationChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveNotificationChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveNotificationChannel operation on AmazonDevOpsGuruClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveNotificationChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/RemoveNotificationChannel">REST API Reference for RemoveNotificationChannel Operation</seealso>
        public virtual IAsyncResult BeginRemoveNotificationChannel(RemoveNotificationChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveNotificationChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveNotificationChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveNotificationChannel.</param>
        /// 
        /// <returns>Returns a  RemoveNotificationChannelResult from DevOpsGuru.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/RemoveNotificationChannel">REST API Reference for RemoveNotificationChannel Operation</seealso>
        public virtual RemoveNotificationChannelResponse EndRemoveNotificationChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveNotificationChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchInsights

        /// <summary>
        /// Returns a list of insights in your AWS account. You can specify which insights are
        /// returned by their start time, one or more statuses (<code>ONGOING</code>, <code>CLOSED</code>,
        /// and <code>CLOSED</code>), one or more severities (<code>LOW</code>, <code>MEDIUM</code>,
        /// and <code>HIGH</code>), and type (<code>REACTIVE</code> or <code>PROACTIVE</code>).
        /// 
        /// 
        ///  
        /// <para>
        ///  Use the <code>Filters</code> parameter to specify status and severity search parameters.
        /// Use the <code>Type</code> parameter to specify <code>REACTIVE</code> or <code>PROACTIVE</code>
        /// in your search. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchInsights service method.</param>
        /// 
        /// <returns>The response from the SearchInsights service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// An internal failure in an Amazon service occurred.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// The request was denied due to a request throttling.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// Contains information about data passed in to a field during a request that is not
        /// valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/SearchInsights">REST API Reference for SearchInsights Operation</seealso>
        public virtual SearchInsightsResponse SearchInsights(SearchInsightsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchInsightsResponseUnmarshaller.Instance;

            return Invoke<SearchInsightsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchInsights operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchInsights operation on AmazonDevOpsGuruClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchInsights
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/SearchInsights">REST API Reference for SearchInsights Operation</seealso>
        public virtual IAsyncResult BeginSearchInsights(SearchInsightsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchInsightsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchInsights operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchInsights.</param>
        /// 
        /// <returns>Returns a  SearchInsightsResult from DevOpsGuru.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/SearchInsights">REST API Reference for SearchInsights Operation</seealso>
        public virtual SearchInsightsResponse EndSearchInsights(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchInsightsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateResourceCollection

        /// <summary>
        /// Updates the collection of resources that DevOps Guru analyzes. The one type of AWS
        /// resource collection supported is AWS CloudFormation stacks. DevOps Guru can be configured
        /// to analyze only the AWS resources that are defined in the stacks. This method also
        /// creates the IAM role required for you to use DevOps Guru.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceCollection service method.</param>
        /// 
        /// <returns>The response from the UpdateResourceCollection service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ConflictException">
        /// An exception that is thrown when a conflict occurs.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// An internal failure in an Amazon service occurred.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// The request was denied due to a request throttling.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// Contains information about data passed in to a field during a request that is not
        /// valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/UpdateResourceCollection">REST API Reference for UpdateResourceCollection Operation</seealso>
        public virtual UpdateResourceCollectionResponse UpdateResourceCollection(UpdateResourceCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceCollectionResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceCollectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourceCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceCollection operation on AmazonDevOpsGuruClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResourceCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/UpdateResourceCollection">REST API Reference for UpdateResourceCollection Operation</seealso>
        public virtual IAsyncResult BeginUpdateResourceCollection(UpdateResourceCollectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceCollectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResourceCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResourceCollection.</param>
        /// 
        /// <returns>Returns a  UpdateResourceCollectionResult from DevOpsGuru.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/UpdateResourceCollection">REST API Reference for UpdateResourceCollection Operation</seealso>
        public virtual UpdateResourceCollectionResponse EndUpdateResourceCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateResourceCollectionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateServiceIntegration

        /// <summary>
        /// Enables or disables integration with a service that can be integrated with DevOps
        /// Guru. The one service that can be integrated with DevOps Guru is AWS Systems Manager,
        /// which can be used to create an OpsItem for each generated insight.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceIntegration service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceIntegration service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ConflictException">
        /// An exception that is thrown when a conflict occurs.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// An internal failure in an Amazon service occurred.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// The request was denied due to a request throttling.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// Contains information about data passed in to a field during a request that is not
        /// valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/UpdateServiceIntegration">REST API Reference for UpdateServiceIntegration Operation</seealso>
        public virtual UpdateServiceIntegrationResponse UpdateServiceIntegration(UpdateServiceIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceIntegrationResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceIntegrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceIntegration operation on AmazonDevOpsGuruClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServiceIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/UpdateServiceIntegration">REST API Reference for UpdateServiceIntegration Operation</seealso>
        public virtual IAsyncResult BeginUpdateServiceIntegration(UpdateServiceIntegrationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServiceIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceIntegration.</param>
        /// 
        /// <returns>Returns a  UpdateServiceIntegrationResult from DevOpsGuru.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/UpdateServiceIntegration">REST API Reference for UpdateServiceIntegration Operation</seealso>
        public virtual UpdateServiceIntegrationResponse EndUpdateServiceIntegration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateServiceIntegrationResponse>(asyncResult);
        }

        #endregion
        
    }
}
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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.DevOpsGuru.Model;
using Amazon.DevOpsGuru.Model.Internal.MarshallTransformations;
using Amazon.DevOpsGuru.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.DevOpsGuru
{
    /// <summary>
    /// <para>Implementation for accessing DevOpsGuru</para>
    ///
    /// Amazon DevOps Guru is a fully managed service that helps you identify anomalous behavior
    /// in business critical operational applications. You specify the Amazon Web Services
    /// resources that you want DevOps Guru to cover, then the Amazon CloudWatch metrics and
    /// Amazon Web Services CloudTrail events related to those resources are analyzed. When
    /// anomalous behavior is detected, DevOps Guru creates an <i>insight</i> that includes
    /// recommendations, related events, and related metrics that can help you improve your
    /// operational applications. For more information, see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/welcome.html">What
    /// is Amazon DevOps Guru</a>. 
    /// 
    ///  
    /// <para>
    ///  You can specify 1 or 2 Amazon Simple Notification Service topics so you are notified
    /// every time a new insight is created. You can also enable DevOps Guru to generate an
    /// OpsItem in Amazon Web Services Systems Manager for each insight to help you manage
    /// and track your work addressing insights. 
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
        private IDevOpsGuruPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDevOpsGuruPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DevOpsGuruPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
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
            : base(new AmazonDevOpsGuruConfig()) { }

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
            : base(new AmazonDevOpsGuruConfig{RegionEndpoint = region}) { }

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
            : base(config) { }

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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDevOpsGuruEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDevOpsGuruAuthSchemeHandler());
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
        /// that grants DevOps Guru permission to send it notifications. DevOps Guru adds the
        /// required policy on your behalf to send notifications using Amazon SNS in your account.
        /// DevOps Guru only supports standard SNS topics. For more information, see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/sns-required-permissions.html">Permissions
        /// for Amazon SNS topics</a>.
        /// </para>
        ///  
        /// <para>
        /// If you use an Amazon SNS topic that is encrypted by an Amazon Web Services Key Management
        /// Service customer-managed key (CMK), then you must add permissions to the CMK. For
        /// more information, see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/sns-kms-permissions.html">Permissions
        /// for Amazon Web Services KMS–encrypted Amazon SNS topics</a>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddNotificationChannelResponseUnmarshaller.Instance;

            return Invoke<AddNotificationChannelResponse>(request, options);
        }


        /// <summary>
        /// Adds a notification channel to DevOps Guru. A notification channel is used to notify
        /// you about important DevOps Guru events, such as when an insight is generated. 
        /// 
        ///  
        /// <para>
        /// If you use an Amazon SNS topic in another account, you must attach a policy to it
        /// that grants DevOps Guru permission to send it notifications. DevOps Guru adds the
        /// required policy on your behalf to send notifications using Amazon SNS in your account.
        /// DevOps Guru only supports standard SNS topics. For more information, see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/sns-required-permissions.html">Permissions
        /// for Amazon SNS topics</a>.
        /// </para>
        ///  
        /// <para>
        /// If you use an Amazon SNS topic that is encrypted by an Amazon Web Services Key Management
        /// Service customer-managed key (CMK), then you must add permissions to the CMK. For
        /// more information, see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/sns-kms-permissions.html">Permissions
        /// for Amazon Web Services KMS–encrypted Amazon SNS topics</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddNotificationChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AddNotificationChannelResponse> AddNotificationChannelAsync(AddNotificationChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddNotificationChannelResponseUnmarshaller.Instance;
            
            return InvokeAsync<AddNotificationChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInsight


        /// <summary>
        /// Deletes the insight along with the associated anomalies, events and recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInsight service method.</param>
        /// 
        /// <returns>The response from the DeleteInsight service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DeleteInsight">REST API Reference for DeleteInsight Operation</seealso>
        public virtual DeleteInsightResponse DeleteInsight(DeleteInsightRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInsightResponseUnmarshaller.Instance;

            return Invoke<DeleteInsightResponse>(request, options);
        }


        /// <summary>
        /// Deletes the insight along with the associated anomalies, events and recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInsight service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInsight service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DeleteInsight">REST API Reference for DeleteInsight Operation</seealso>
        public virtual Task<DeleteInsightResponse> DeleteInsightAsync(DeleteInsightRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInsightResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteInsightResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountHealth


        /// <summary>
        /// Returns the number of open reactive insights, the number of open proactive insights,
        /// and the number of metrics analyzed in your Amazon Web Services account. Use these
        /// numbers to gauge the health of operations in your Amazon Web Services account.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccountHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountHealthResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountHealthResponse>(request, options);
        }


        /// <summary>
        /// Returns the number of open reactive insights, the number of open proactive insights,
        /// and the number of metrics analyzed in your Amazon Web Services account. Use these
        /// numbers to gauge the health of operations in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountHealth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeAccountHealthResponse> DescribeAccountHealthAsync(DescribeAccountHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccountHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountHealthResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAccountHealthResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccountOverviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountOverviewResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountOverviewResponse>(request, options);
        }


        /// <summary>
        /// For the time range passed in, returns the number of open reactive insight that were
        /// created, the number of open proactive insights that were created, and the Mean Time
        /// to Recover (MTTR) for all closed reactive insights.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountOverview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeAccountOverviewResponse> DescribeAccountOverviewAsync(DescribeAccountOverviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccountOverviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountOverviewResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAccountOverviewResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAnomalyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnomalyResponseUnmarshaller.Instance;

            return Invoke<DescribeAnomalyResponse>(request, options);
        }


        /// <summary>
        /// Returns details about an anomaly that you specify using its ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnomaly service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeAnomalyResponse> DescribeAnomalyAsync(DescribeAnomalyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAnomalyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnomalyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAnomalyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventSourcesConfig


        /// <summary>
        /// Returns the integration status of services that are integrated with DevOps Guru as
        /// Consumer via EventBridge. The one service that can be integrated with DevOps Guru
        /// is Amazon CodeGuru Profiler, which can produce proactive recommendations which can
        /// be stored and viewed in DevOps Guru.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSourcesConfig service method.</param>
        /// 
        /// <returns>The response from the DescribeEventSourcesConfig service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeEventSourcesConfig">REST API Reference for DescribeEventSourcesConfig Operation</seealso>
        public virtual DescribeEventSourcesConfigResponse DescribeEventSourcesConfig(DescribeEventSourcesConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventSourcesConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSourcesConfigResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSourcesConfigResponse>(request, options);
        }


        /// <summary>
        /// Returns the integration status of services that are integrated with DevOps Guru as
        /// Consumer via EventBridge. The one service that can be integrated with DevOps Guru
        /// is Amazon CodeGuru Profiler, which can produce proactive recommendations which can
        /// be stored and viewed in DevOps Guru.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSourcesConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventSourcesConfig service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeEventSourcesConfig">REST API Reference for DescribeEventSourcesConfig Operation</seealso>
        public virtual Task<DescribeEventSourcesConfigResponse> DescribeEventSourcesConfigAsync(DescribeEventSourcesConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventSourcesConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSourcesConfigResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEventSourcesConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFeedback


        /// <summary>
        /// Returns the most recent feedback submitted in the current Amazon Web Services account
        /// and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFeedback service method.</param>
        /// 
        /// <returns>The response from the DescribeFeedback service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeFeedback">REST API Reference for DescribeFeedback Operation</seealso>
        public virtual DescribeFeedbackResponse DescribeFeedback(DescribeFeedbackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFeedbackResponseUnmarshaller.Instance;

            return Invoke<DescribeFeedbackResponse>(request, options);
        }


        /// <summary>
        /// Returns the most recent feedback submitted in the current Amazon Web Services account
        /// and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFeedback service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeFeedback">REST API Reference for DescribeFeedback Operation</seealso>
        public virtual Task<DescribeFeedbackResponse> DescribeFeedbackAsync(DescribeFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFeedbackResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFeedbackResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInsightResponseUnmarshaller.Instance;

            return Invoke<DescribeInsightResponse>(request, options);
        }


        /// <summary>
        /// Returns details about an insight that you specify using its ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInsight service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeInsightResponse> DescribeInsightAsync(DescribeInsightRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInsightResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeInsightResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrganizationHealth


        /// <summary>
        /// Returns active insights, predictive insights, and resource hours analyzed in last
        /// hour.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationHealth service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganizationHealth service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeOrganizationHealth">REST API Reference for DescribeOrganizationHealth Operation</seealso>
        public virtual DescribeOrganizationHealthResponse DescribeOrganizationHealth(DescribeOrganizationHealthRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationHealthResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationHealthResponse>(request, options);
        }


        /// <summary>
        /// Returns active insights, predictive insights, and resource hours analyzed in last
        /// hour.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationHealth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrganizationHealth service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeOrganizationHealth">REST API Reference for DescribeOrganizationHealth Operation</seealso>
        public virtual Task<DescribeOrganizationHealthResponse> DescribeOrganizationHealthAsync(DescribeOrganizationHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationHealthResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeOrganizationHealthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrganizationOverview


        /// <summary>
        /// Returns an overview of your organization's history based on the specified time range.
        /// The overview includes the total reactive and proactive insights.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationOverview service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganizationOverview service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeOrganizationOverview">REST API Reference for DescribeOrganizationOverview Operation</seealso>
        public virtual DescribeOrganizationOverviewResponse DescribeOrganizationOverview(DescribeOrganizationOverviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationOverviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationOverviewResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationOverviewResponse>(request, options);
        }


        /// <summary>
        /// Returns an overview of your organization's history based on the specified time range.
        /// The overview includes the total reactive and proactive insights.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationOverview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrganizationOverview service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeOrganizationOverview">REST API Reference for DescribeOrganizationOverview Operation</seealso>
        public virtual Task<DescribeOrganizationOverviewResponse> DescribeOrganizationOverviewAsync(DescribeOrganizationOverviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationOverviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationOverviewResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeOrganizationOverviewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrganizationResourceCollectionHealth


        /// <summary>
        /// Provides an overview of your system's health. If additional member accounts are part
        /// of your organization, you can filter those accounts using the <c>AccountIds</c> field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationResourceCollectionHealth service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganizationResourceCollectionHealth service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeOrganizationResourceCollectionHealth">REST API Reference for DescribeOrganizationResourceCollectionHealth Operation</seealso>
        public virtual DescribeOrganizationResourceCollectionHealthResponse DescribeOrganizationResourceCollectionHealth(DescribeOrganizationResourceCollectionHealthRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationResourceCollectionHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationResourceCollectionHealthResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationResourceCollectionHealthResponse>(request, options);
        }


        /// <summary>
        /// Provides an overview of your system's health. If additional member accounts are part
        /// of your organization, you can filter those accounts using the <c>AccountIds</c> field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationResourceCollectionHealth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrganizationResourceCollectionHealth service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeOrganizationResourceCollectionHealth">REST API Reference for DescribeOrganizationResourceCollectionHealth Operation</seealso>
        public virtual Task<DescribeOrganizationResourceCollectionHealthResponse> DescribeOrganizationResourceCollectionHealthAsync(DescribeOrganizationResourceCollectionHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationResourceCollectionHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationResourceCollectionHealthResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeOrganizationResourceCollectionHealthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeResourceCollectionHealth


        /// <summary>
        /// Returns the number of open proactive insights, open reactive insights, and the Mean
        /// Time to Recover (MTTR) for all closed insights in resource collections in your account.
        /// You specify the type of Amazon Web Services resources collection. The two types of
        /// Amazon Web Services resource collections supported are Amazon Web Services CloudFormation
        /// stacks and Amazon Web Services resources that contain the same Amazon Web Services
        /// tag. DevOps Guru can be configured to analyze the Amazon Web Services resources that
        /// are defined in the stacks or that are tagged using the same tag <i>key</i>. You can
        /// specify up to 500 Amazon Web Services CloudFormation stacks.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeResourceCollectionHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceCollectionHealthResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceCollectionHealthResponse>(request, options);
        }


        /// <summary>
        /// Returns the number of open proactive insights, open reactive insights, and the Mean
        /// Time to Recover (MTTR) for all closed insights in resource collections in your account.
        /// You specify the type of Amazon Web Services resources collection. The two types of
        /// Amazon Web Services resource collections supported are Amazon Web Services CloudFormation
        /// stacks and Amazon Web Services resources that contain the same Amazon Web Services
        /// tag. DevOps Guru can be configured to analyze the Amazon Web Services resources that
        /// are defined in the stacks or that are tagged using the same tag <i>key</i>. You can
        /// specify up to 500 Amazon Web Services CloudFormation stacks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceCollectionHealth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeResourceCollectionHealthResponse> DescribeResourceCollectionHealthAsync(DescribeResourceCollectionHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeResourceCollectionHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceCollectionHealthResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeResourceCollectionHealthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeServiceIntegration


        /// <summary>
        /// Returns the integration status of services that are integrated with DevOps Guru.
        /// The one service that can be integrated with DevOps Guru is Amazon Web Services Systems
        /// Manager, which can be used to create an OpsItem for each generated insight.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeServiceIntegration">REST API Reference for DescribeServiceIntegration Operation</seealso>
        public virtual DescribeServiceIntegrationResponse DescribeServiceIntegration(DescribeServiceIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeServiceIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceIntegrationResponseUnmarshaller.Instance;

            return Invoke<DescribeServiceIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Returns the integration status of services that are integrated with DevOps Guru.
        /// The one service that can be integrated with DevOps Guru is Amazon Web Services Systems
        /// Manager, which can be used to create an OpsItem for each generated insight.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeServiceIntegration">REST API Reference for DescribeServiceIntegration Operation</seealso>
        public virtual Task<DescribeServiceIntegrationResponse> DescribeServiceIntegrationAsync(DescribeServiceIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeServiceIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeServiceIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCostEstimation


        /// <summary>
        /// Returns an estimate of the monthly cost for DevOps Guru to analyze your Amazon Web
        /// Services resources. For more information, see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/cost-estimate.html">Estimate
        /// your Amazon DevOps Guru costs</a> and <a href="http://aws.amazon.com/devops-guru/pricing/">Amazon
        /// DevOps Guru pricing</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCostEstimation service method.</param>
        /// 
        /// <returns>The response from the GetCostEstimation service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/GetCostEstimation">REST API Reference for GetCostEstimation Operation</seealso>
        public virtual GetCostEstimationResponse GetCostEstimation(GetCostEstimationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCostEstimationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCostEstimationResponseUnmarshaller.Instance;

            return Invoke<GetCostEstimationResponse>(request, options);
        }


        /// <summary>
        /// Returns an estimate of the monthly cost for DevOps Guru to analyze your Amazon Web
        /// Services resources. For more information, see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/cost-estimate.html">Estimate
        /// your Amazon DevOps Guru costs</a> and <a href="http://aws.amazon.com/devops-guru/pricing/">Amazon
        /// DevOps Guru pricing</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCostEstimation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCostEstimation service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/GetCostEstimation">REST API Reference for GetCostEstimation Operation</seealso>
        public virtual Task<GetCostEstimationResponse> GetCostEstimationAsync(GetCostEstimationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCostEstimationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCostEstimationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCostEstimationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourceCollection


        /// <summary>
        /// Returns lists Amazon Web Services resources that are of the specified resource collection
        /// type. The two types of Amazon Web Services resource collections supported are Amazon
        /// Web Services CloudFormation stacks and Amazon Web Services resources that contain
        /// the same Amazon Web Services tag. DevOps Guru can be configured to analyze the Amazon
        /// Web Services resources that are defined in the stacks or that are tagged using the
        /// same tag <i>key</i>. You can specify up to 500 Amazon Web Services CloudFormation
        /// stacks.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceCollectionResponseUnmarshaller.Instance;

            return Invoke<GetResourceCollectionResponse>(request, options);
        }


        /// <summary>
        /// Returns lists Amazon Web Services resources that are of the specified resource collection
        /// type. The two types of Amazon Web Services resource collections supported are Amazon
        /// Web Services CloudFormation stacks and Amazon Web Services resources that contain
        /// the same Amazon Web Services tag. DevOps Guru can be configured to analyze the Amazon
        /// Web Services resources that are defined in the stacks or that are tagged using the
        /// same tag <i>key</i>. You can specify up to 500 Amazon Web Services CloudFormation
        /// stacks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetResourceCollectionResponse> GetResourceCollectionAsync(GetResourceCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceCollectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetResourceCollectionResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnomaliesForInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomaliesForInsightResponseUnmarshaller.Instance;

            return Invoke<ListAnomaliesForInsightResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the anomalies that belong to an insight that you specify using
        /// its ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnomaliesForInsight service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListAnomaliesForInsightResponse> ListAnomaliesForInsightAsync(ListAnomaliesForInsightRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnomaliesForInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomaliesForInsightResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAnomaliesForInsightResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAnomalousLogGroups


        /// <summary>
        /// Returns the list of log groups that contain log anomalies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalousLogGroups service method.</param>
        /// 
        /// <returns>The response from the ListAnomalousLogGroups service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListAnomalousLogGroups">REST API Reference for ListAnomalousLogGroups Operation</seealso>
        public virtual ListAnomalousLogGroupsResponse ListAnomalousLogGroups(ListAnomalousLogGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnomalousLogGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomalousLogGroupsResponseUnmarshaller.Instance;

            return Invoke<ListAnomalousLogGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns the list of log groups that contain log anomalies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalousLogGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnomalousLogGroups service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListAnomalousLogGroups">REST API Reference for ListAnomalousLogGroups Operation</seealso>
        public virtual Task<ListAnomalousLogGroupsResponse> ListAnomalousLogGroupsAsync(ListAnomalousLogGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnomalousLogGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomalousLogGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAnomalousLogGroupsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventsResponseUnmarshaller.Instance;

            return Invoke<ListEventsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the events emitted by the resources that are evaluated by DevOps
        /// Guru. You can use filters to specify which events are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListEventsResponse> ListEventsAsync(ListEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInsights


        /// <summary>
        /// Returns a list of insights in your Amazon Web Services account. You can specify which
        /// insights are returned by their start time and status (<c>ONGOING</c>, <c>CLOSED</c>,
        /// or <c>ANY</c>).
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInsightsResponseUnmarshaller.Instance;

            return Invoke<ListInsightsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of insights in your Amazon Web Services account. You can specify which
        /// insights are returned by their start time and status (<c>ONGOING</c>, <c>CLOSED</c>,
        /// or <c>ANY</c>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInsights service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListInsightsResponse> ListInsightsAsync(ListInsightsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInsightsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListInsightsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMonitoredResources


        /// <summary>
        /// Returns the list of all log groups that are being monitored and tagged by DevOps
        /// Guru.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitoredResources service method.</param>
        /// 
        /// <returns>The response from the ListMonitoredResources service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListMonitoredResources">REST API Reference for ListMonitoredResources Operation</seealso>
        public virtual ListMonitoredResourcesResponse ListMonitoredResources(ListMonitoredResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMonitoredResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitoredResourcesResponseUnmarshaller.Instance;

            return Invoke<ListMonitoredResourcesResponse>(request, options);
        }


        /// <summary>
        /// Returns the list of all log groups that are being monitored and tagged by DevOps
        /// Guru.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitoredResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMonitoredResources service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListMonitoredResources">REST API Reference for ListMonitoredResources Operation</seealso>
        public virtual Task<ListMonitoredResourcesResponse> ListMonitoredResourcesAsync(ListMonitoredResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMonitoredResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitoredResourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMonitoredResourcesResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotificationChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationChannelsResponseUnmarshaller.Instance;

            return Invoke<ListNotificationChannelsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of notification channels configured for DevOps Guru. Each notification
        /// channel is used to notify you when DevOps Guru generates an insight that contains
        /// information about how to improve your operations. The one supported notification channel
        /// is Amazon Simple Notification Service (Amazon SNS).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListNotificationChannelsResponse> ListNotificationChannelsAsync(ListNotificationChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotificationChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationChannelsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListNotificationChannelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOrganizationInsights


        /// <summary>
        /// Returns a list of insights associated with the account or OU Id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationInsights service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationInsights service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListOrganizationInsights">REST API Reference for ListOrganizationInsights Operation</seealso>
        public virtual ListOrganizationInsightsResponse ListOrganizationInsights(ListOrganizationInsightsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOrganizationInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationInsightsResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationInsightsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of insights associated with the account or OU Id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationInsights service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrganizationInsights service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListOrganizationInsights">REST API Reference for ListOrganizationInsights Operation</seealso>
        public virtual Task<ListOrganizationInsightsResponse> ListOrganizationInsightsAsync(ListOrganizationInsightsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOrganizationInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationInsightsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOrganizationInsightsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ListRecommendationsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of a specified insight's recommendations. Each recommendation includes
        /// a list of related metrics and a list of related events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListRecommendationsResponse> ListRecommendationsAsync(ListRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRecommendationsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFeedbackResponseUnmarshaller.Instance;

            return Invoke<PutFeedbackResponse>(request, options);
        }


        /// <summary>
        /// Collects customer feedback about the specified insight.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<PutFeedbackResponse> PutFeedbackAsync(PutFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFeedbackResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutFeedbackResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveNotificationChannelResponseUnmarshaller.Instance;

            return Invoke<RemoveNotificationChannelResponse>(request, options);
        }


        /// <summary>
        /// Removes a notification channel from DevOps Guru. A notification channel is used to
        /// notify you when DevOps Guru generates an insight that contains information about how
        /// to improve your operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveNotificationChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RemoveNotificationChannelResponse> RemoveNotificationChannelAsync(RemoveNotificationChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveNotificationChannelResponseUnmarshaller.Instance;
            
            return InvokeAsync<RemoveNotificationChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchInsights


        /// <summary>
        /// Returns a list of insights in your Amazon Web Services account. You can specify which
        /// insights are returned by their start time, one or more statuses (<c>ONGOING</c> or
        /// <c>CLOSED</c>), one or more severities (<c>LOW</c>, <c>MEDIUM</c>, and <c>HIGH</c>),
        /// and type (<c>REACTIVE</c> or <c>PROACTIVE</c>). 
        /// 
        ///  
        /// <para>
        ///  Use the <c>Filters</c> parameter to specify status and severity search parameters.
        /// Use the <c>Type</c> parameter to specify <c>REACTIVE</c> or <c>PROACTIVE</c> in your
        /// search. 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchInsightsResponseUnmarshaller.Instance;

            return Invoke<SearchInsightsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of insights in your Amazon Web Services account. You can specify which
        /// insights are returned by their start time, one or more statuses (<c>ONGOING</c> or
        /// <c>CLOSED</c>), one or more severities (<c>LOW</c>, <c>MEDIUM</c>, and <c>HIGH</c>),
        /// and type (<c>REACTIVE</c> or <c>PROACTIVE</c>). 
        /// 
        ///  
        /// <para>
        ///  Use the <c>Filters</c> parameter to specify status and severity search parameters.
        /// Use the <c>Type</c> parameter to specify <c>REACTIVE</c> or <c>PROACTIVE</c> in your
        /// search. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchInsights service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<SearchInsightsResponse> SearchInsightsAsync(SearchInsightsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchInsightsResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchInsightsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchOrganizationInsights


        /// <summary>
        /// Returns a list of insights in your organization. You can specify which insights are
        /// returned by their start time, one or more statuses (<c>ONGOING</c>, <c>CLOSED</c>,
        /// and <c>CLOSED</c>), one or more severities (<c>LOW</c>, <c>MEDIUM</c>, and <c>HIGH</c>),
        /// and type (<c>REACTIVE</c> or <c>PROACTIVE</c>). 
        /// 
        ///  
        /// <para>
        ///  Use the <c>Filters</c> parameter to specify status and severity search parameters.
        /// Use the <c>Type</c> parameter to specify <c>REACTIVE</c> or <c>PROACTIVE</c> in your
        /// search. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchOrganizationInsights service method.</param>
        /// 
        /// <returns>The response from the SearchOrganizationInsights service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/SearchOrganizationInsights">REST API Reference for SearchOrganizationInsights Operation</seealso>
        public virtual SearchOrganizationInsightsResponse SearchOrganizationInsights(SearchOrganizationInsightsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchOrganizationInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchOrganizationInsightsResponseUnmarshaller.Instance;

            return Invoke<SearchOrganizationInsightsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of insights in your organization. You can specify which insights are
        /// returned by their start time, one or more statuses (<c>ONGOING</c>, <c>CLOSED</c>,
        /// and <c>CLOSED</c>), one or more severities (<c>LOW</c>, <c>MEDIUM</c>, and <c>HIGH</c>),
        /// and type (<c>REACTIVE</c> or <c>PROACTIVE</c>). 
        /// 
        ///  
        /// <para>
        ///  Use the <c>Filters</c> parameter to specify status and severity search parameters.
        /// Use the <c>Type</c> parameter to specify <c>REACTIVE</c> or <c>PROACTIVE</c> in your
        /// search. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchOrganizationInsights service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchOrganizationInsights service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/SearchOrganizationInsights">REST API Reference for SearchOrganizationInsights Operation</seealso>
        public virtual Task<SearchOrganizationInsightsResponse> SearchOrganizationInsightsAsync(SearchOrganizationInsightsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchOrganizationInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchOrganizationInsightsResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchOrganizationInsightsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartCostEstimation


        /// <summary>
        /// Starts the creation of an estimate of the monthly cost to analyze your Amazon Web
        /// Services resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCostEstimation service method.</param>
        /// 
        /// <returns>The response from the StartCostEstimation service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/StartCostEstimation">REST API Reference for StartCostEstimation Operation</seealso>
        public virtual StartCostEstimationResponse StartCostEstimation(StartCostEstimationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCostEstimationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCostEstimationResponseUnmarshaller.Instance;

            return Invoke<StartCostEstimationResponse>(request, options);
        }


        /// <summary>
        /// Starts the creation of an estimate of the monthly cost to analyze your Amazon Web
        /// Services resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCostEstimation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCostEstimation service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/StartCostEstimation">REST API Reference for StartCostEstimation Operation</seealso>
        public virtual Task<StartCostEstimationResponse> StartCostEstimationAsync(StartCostEstimationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCostEstimationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCostEstimationResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartCostEstimationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEventSourcesConfig


        /// <summary>
        /// Enables or disables integration with a service that can be integrated with DevOps
        /// Guru. The one service that can be integrated with DevOps Guru is Amazon CodeGuru Profiler,
        /// which can produce proactive recommendations which can be stored and viewed in DevOps
        /// Guru.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventSourcesConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateEventSourcesConfig service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/UpdateEventSourcesConfig">REST API Reference for UpdateEventSourcesConfig Operation</seealso>
        public virtual UpdateEventSourcesConfigResponse UpdateEventSourcesConfig(UpdateEventSourcesConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEventSourcesConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventSourcesConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateEventSourcesConfigResponse>(request, options);
        }


        /// <summary>
        /// Enables or disables integration with a service that can be integrated with DevOps
        /// Guru. The one service that can be integrated with DevOps Guru is Amazon CodeGuru Profiler,
        /// which can produce proactive recommendations which can be stored and viewed in DevOps
        /// Guru.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventSourcesConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEventSourcesConfig service method, as returned by DevOpsGuru.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/UpdateEventSourcesConfig">REST API Reference for UpdateEventSourcesConfig Operation</seealso>
        public virtual Task<UpdateEventSourcesConfigResponse> UpdateEventSourcesConfigAsync(UpdateEventSourcesConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEventSourcesConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventSourcesConfigResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateEventSourcesConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateResourceCollection


        /// <summary>
        /// Updates the collection of resources that DevOps Guru analyzes. The two types of Amazon
        /// Web Services resource collections supported are Amazon Web Services CloudFormation
        /// stacks and Amazon Web Services resources that contain the same Amazon Web Services
        /// tag. DevOps Guru can be configured to analyze the Amazon Web Services resources that
        /// are defined in the stacks or that are tagged using the same tag <i>key</i>. You can
        /// specify up to 500 Amazon Web Services CloudFormation stacks. This method also creates
        /// the IAM role required for you to use DevOps Guru.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResourceCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceCollectionResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceCollectionResponse>(request, options);
        }


        /// <summary>
        /// Updates the collection of resources that DevOps Guru analyzes. The two types of Amazon
        /// Web Services resource collections supported are Amazon Web Services CloudFormation
        /// stacks and Amazon Web Services resources that contain the same Amazon Web Services
        /// tag. DevOps Guru can be configured to analyze the Amazon Web Services resources that
        /// are defined in the stacks or that are tagged using the same tag <i>key</i>. You can
        /// specify up to 500 Amazon Web Services CloudFormation stacks. This method also creates
        /// the IAM role required for you to use DevOps Guru.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateResourceCollectionResponse> UpdateResourceCollectionAsync(UpdateResourceCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResourceCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceCollectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateResourceCollectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateServiceIntegration


        /// <summary>
        /// Enables or disables integration with a service that can be integrated with DevOps
        /// Guru. The one service that can be integrated with DevOps Guru is Amazon Web Services
        /// Systems Manager, which can be used to create an OpsItem for each generated insight.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateServiceIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceIntegrationResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Enables or disables integration with a service that can be integrated with DevOps
        /// Guru. The one service that can be integrated with DevOps Guru is Amazon Web Services
        /// Systems Manager, which can be used to create an OpsItem for each generated insight.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateServiceIntegrationResponse> UpdateServiceIntegrationAsync(UpdateServiceIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateServiceIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateServiceIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}
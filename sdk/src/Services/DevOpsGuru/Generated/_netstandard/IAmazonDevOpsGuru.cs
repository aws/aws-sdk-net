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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DevOpsGuru.Model;

namespace Amazon.DevOpsGuru
{
    /// <summary>
    /// Interface for accessing DevOpsGuru
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
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonDevOpsGuru : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IDevOpsGuruPaginatorFactory Paginators { get; }
#endif
                
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
        Task<AddNotificationChannelResponse> AddNotificationChannelAsync(AddNotificationChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccountHealth



        /// <summary>
        /// Returns the number of open reactive insights, the number of open proactive insights,
        /// and the number of metrics analyzed in your AWS account. Use these numbers to gauge
        /// the health of operations in your AWS account.
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
        Task<DescribeAccountHealthResponse> DescribeAccountHealthAsync(DescribeAccountHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccountOverview



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
        Task<DescribeAccountOverviewResponse> DescribeAccountOverviewAsync(DescribeAccountOverviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAnomaly



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
        Task<DescribeAnomalyResponse> DescribeAnomalyAsync(DescribeAnomalyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInsight



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
        Task<DescribeInsightResponse> DescribeInsightAsync(DescribeInsightRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DescribeResourceCollectionHealthResponse> DescribeResourceCollectionHealthAsync(DescribeResourceCollectionHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeServiceIntegration



        /// <summary>
        /// Returns the integration status of services that are integrated with DevOps Guru.
        /// The one service that can be integrated with DevOps Guru is AWS Systems Manager, which
        /// can be used to create an OpsItem for each generated insight.
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
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// The request was denied due to a request throttling.
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// Contains information about data passed in to a field during a request that is not
        /// valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeServiceIntegration">REST API Reference for DescribeServiceIntegration Operation</seealso>
        Task<DescribeServiceIntegrationResponse> DescribeServiceIntegrationAsync(DescribeServiceIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetResourceCollection



        /// <summary>
        /// Returns lists AWS resources that are of the specified resource collection type. The
        /// one type of AWS resource collection supported is AWS CloudFormation stacks. DevOps
        /// Guru can be configured to analyze only the AWS resources that are defined in the stacks.
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
        Task<GetResourceCollectionResponse> GetResourceCollectionAsync(GetResourceCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAnomaliesForInsight



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
        Task<ListAnomaliesForInsightResponse> ListAnomaliesForInsightAsync(ListAnomaliesForInsightRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEvents



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
        Task<ListEventsResponse> ListEventsAsync(ListEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInsights



        /// <summary>
        /// Returns a list of insights in your AWS account. You can specify which insights are
        /// returned by their start time and status (<code>ONGOING</code>, <code>CLOSED</code>,
        /// or <code>ANY</code>).
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
        Task<ListInsightsResponse> ListInsightsAsync(ListInsightsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNotificationChannels



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
        Task<ListNotificationChannelsResponse> ListNotificationChannelsAsync(ListNotificationChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRecommendations



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
        Task<ListRecommendationsResponse> ListRecommendationsAsync(ListRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutFeedback



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
        Task<PutFeedbackResponse> PutFeedbackAsync(PutFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveNotificationChannel



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
        Task<RemoveNotificationChannelResponse> RemoveNotificationChannelAsync(RemoveNotificationChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<SearchInsightsResponse> SearchInsightsAsync(SearchInsightsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateResourceCollection



        /// <summary>
        /// Updates the collection of resources that DevOps Guru analyzes. The one type of AWS
        /// resource collection supported is AWS CloudFormation stacks. DevOps Guru can be configured
        /// to analyze only the AWS resources that are defined in the stacks. This method also
        /// creates the IAM role required for you to use DevOps Guru.
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
        Task<UpdateResourceCollectionResponse> UpdateResourceCollectionAsync(UpdateResourceCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateServiceIntegration



        /// <summary>
        /// Enables or disables integration with a service that can be integrated with DevOps
        /// Guru. The one service that can be integrated with DevOps Guru is AWS Systems Manager,
        /// which can be used to create an OpsItem for each generated insight.
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
        Task<UpdateServiceIntegrationResponse> UpdateServiceIntegrationAsync(UpdateServiceIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
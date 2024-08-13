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

#pragma warning disable CS1570
namespace Amazon.DevOpsGuru
{
    /// <summary>
    /// <para>Interface for accessing DevOpsGuru</para>
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
    public partial interface IAmazonDevOpsGuru : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IDevOpsGuruPaginatorFactory Paginators { get; }

        
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
        AddNotificationChannelResponse AddNotificationChannel(AddNotificationChannelRequest request);



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
        Task<AddNotificationChannelResponse> AddNotificationChannelAsync(AddNotificationChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteInsightResponse DeleteInsight(DeleteInsightRequest request);



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
        Task<DeleteInsightResponse> DeleteInsightAsync(DeleteInsightRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeAccountHealthResponse DescribeAccountHealth(DescribeAccountHealthRequest request);



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
        Task<DescribeAccountHealthResponse> DescribeAccountHealthAsync(DescribeAccountHealthRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeAccountOverviewResponse DescribeAccountOverview(DescribeAccountOverviewRequest request);



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
        Task<DescribeAccountOverviewResponse> DescribeAccountOverviewAsync(DescribeAccountOverviewRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeAnomalyResponse DescribeAnomaly(DescribeAnomalyRequest request);



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
        Task<DescribeAnomalyResponse> DescribeAnomalyAsync(DescribeAnomalyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeEventSourcesConfigResponse DescribeEventSourcesConfig(DescribeEventSourcesConfigRequest request);



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
        Task<DescribeEventSourcesConfigResponse> DescribeEventSourcesConfigAsync(DescribeEventSourcesConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeFeedbackResponse DescribeFeedback(DescribeFeedbackRequest request);



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
        Task<DescribeFeedbackResponse> DescribeFeedbackAsync(DescribeFeedbackRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeInsightResponse DescribeInsight(DescribeInsightRequest request);



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
        Task<DescribeInsightResponse> DescribeInsightAsync(DescribeInsightRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeOrganizationHealthResponse DescribeOrganizationHealth(DescribeOrganizationHealthRequest request);



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
        Task<DescribeOrganizationHealthResponse> DescribeOrganizationHealthAsync(DescribeOrganizationHealthRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeOrganizationOverviewResponse DescribeOrganizationOverview(DescribeOrganizationOverviewRequest request);



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
        Task<DescribeOrganizationOverviewResponse> DescribeOrganizationOverviewAsync(DescribeOrganizationOverviewRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeOrganizationResourceCollectionHealthResponse DescribeOrganizationResourceCollectionHealth(DescribeOrganizationResourceCollectionHealthRequest request);



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
        Task<DescribeOrganizationResourceCollectionHealthResponse> DescribeOrganizationResourceCollectionHealthAsync(DescribeOrganizationResourceCollectionHealthRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeResourceCollectionHealthResponse DescribeResourceCollectionHealth(DescribeResourceCollectionHealthRequest request);



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
        Task<DescribeResourceCollectionHealthResponse> DescribeResourceCollectionHealthAsync(DescribeResourceCollectionHealthRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeServiceIntegrationResponse DescribeServiceIntegration(DescribeServiceIntegrationRequest request);



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
        Task<DescribeServiceIntegrationResponse> DescribeServiceIntegrationAsync(DescribeServiceIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetCostEstimationResponse GetCostEstimation(GetCostEstimationRequest request);



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
        Task<GetCostEstimationResponse> GetCostEstimationAsync(GetCostEstimationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetResourceCollectionResponse GetResourceCollection(GetResourceCollectionRequest request);



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
        Task<GetResourceCollectionResponse> GetResourceCollectionAsync(GetResourceCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListAnomaliesForInsightResponse ListAnomaliesForInsight(ListAnomaliesForInsightRequest request);



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
        Task<ListAnomaliesForInsightResponse> ListAnomaliesForInsightAsync(ListAnomaliesForInsightRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListAnomalousLogGroupsResponse ListAnomalousLogGroups(ListAnomalousLogGroupsRequest request);



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
        Task<ListAnomalousLogGroupsResponse> ListAnomalousLogGroupsAsync(ListAnomalousLogGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListEventsResponse ListEvents(ListEventsRequest request);



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
        Task<ListEventsResponse> ListEventsAsync(ListEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListInsightsResponse ListInsights(ListInsightsRequest request);



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
        Task<ListInsightsResponse> ListInsightsAsync(ListInsightsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListMonitoredResourcesResponse ListMonitoredResources(ListMonitoredResourcesRequest request);



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
        Task<ListMonitoredResourcesResponse> ListMonitoredResourcesAsync(ListMonitoredResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListNotificationChannelsResponse ListNotificationChannels(ListNotificationChannelsRequest request);



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
        Task<ListNotificationChannelsResponse> ListNotificationChannelsAsync(ListNotificationChannelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListOrganizationInsightsResponse ListOrganizationInsights(ListOrganizationInsightsRequest request);



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
        Task<ListOrganizationInsightsResponse> ListOrganizationInsightsAsync(ListOrganizationInsightsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListRecommendationsResponse ListRecommendations(ListRecommendationsRequest request);



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
        Task<ListRecommendationsResponse> ListRecommendationsAsync(ListRecommendationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        PutFeedbackResponse PutFeedback(PutFeedbackRequest request);



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
        Task<PutFeedbackResponse> PutFeedbackAsync(PutFeedbackRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        RemoveNotificationChannelResponse RemoveNotificationChannel(RemoveNotificationChannelRequest request);



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
        Task<RemoveNotificationChannelResponse> RemoveNotificationChannelAsync(RemoveNotificationChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        SearchInsightsResponse SearchInsights(SearchInsightsRequest request);



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
        Task<SearchInsightsResponse> SearchInsightsAsync(SearchInsightsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        SearchOrganizationInsightsResponse SearchOrganizationInsights(SearchOrganizationInsightsRequest request);



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
        Task<SearchOrganizationInsightsResponse> SearchOrganizationInsightsAsync(SearchOrganizationInsightsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StartCostEstimationResponse StartCostEstimation(StartCostEstimationRequest request);



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
        Task<StartCostEstimationResponse> StartCostEstimationAsync(StartCostEstimationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateEventSourcesConfigResponse UpdateEventSourcesConfig(UpdateEventSourcesConfigRequest request);



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
        Task<UpdateEventSourcesConfigResponse> UpdateEventSourcesConfigAsync(UpdateEventSourcesConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateResourceCollectionResponse UpdateResourceCollection(UpdateResourceCollectionRequest request);



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
        Task<UpdateResourceCollectionResponse> UpdateResourceCollectionAsync(UpdateResourceCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateServiceIntegrationResponse UpdateServiceIntegration(UpdateServiceIntegrationRequest request);



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
        Task<UpdateServiceIntegrationResponse> UpdateServiceIntegrationAsync(UpdateServiceIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}
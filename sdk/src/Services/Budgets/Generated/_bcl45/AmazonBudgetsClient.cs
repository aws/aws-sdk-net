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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Budgets.Model;
using Amazon.Budgets.Model.Internal.MarshallTransformations;
using Amazon.Budgets.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Budgets
{
    /// <summary>
    /// Implementation for accessing Budgets
    ///
    /// The AWS Budgets API enables you to use AWS Budgets to plan your service usage, service
    /// costs, and instance reservations. The API reference provides descriptions, syntax,
    /// and usage examples for each of the actions and data types for AWS Budgets. 
    /// 
    ///  
    /// <para>
    /// Budgets provide you with a way to see the following information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// How close your plan is to your budgeted amount or to the free tier limits
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Your usage-to-date, including how much you've used of your Reserved Instances (RIs)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Your current estimated charges from AWS, and how much your predicted usage will accrue
    /// in charges by the end of the month
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// How much of your budget has been used
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// AWS updates your budget status several times a day. Budgets track your unblended costs,
    /// subscriptions, refunds, and RIs. You can create the following types of budgets:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Cost budgets</b> - Plan how much you want to spend on a service.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Usage budgets</b> - Plan how much you want to use one or more services.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>RI utilization budgets</b> - Define a utilization threshold, and receive alerts
    /// when your RI usage falls below that threshold. This lets you see if your RIs are unused
    /// or under-utilized.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>RI coverage budgets</b> - Define a coverage threshold, and receive alerts when
    /// the number of your instance hours that are covered by RIs fall below that threshold.
    /// This lets you see how much of your instance usage is covered by a reservation.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Service Endpoint
    /// </para>
    ///  
    /// <para>
    /// The AWS Budgets API provides the following endpoint:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// https://budgets.amazonaws.com
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For information about costs that are associated with the AWS Budgets API, see <a href="https://aws.amazon.com/aws-cost-management/pricing/">AWS
    /// Cost Management Pricing</a>.
    /// </para>
    /// </summary>
    public partial class AmazonBudgetsClient : AmazonServiceClient, IAmazonBudgets
    {
        private static IServiceMetadata serviceMetadata = new AmazonBudgetsMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonBudgetsClient with the credentials loaded from the application's
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
        public AmazonBudgetsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBudgetsConfig()) { }

        /// <summary>
        /// Constructs AmazonBudgetsClient with the credentials loaded from the application's
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
        public AmazonBudgetsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBudgetsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBudgetsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBudgetsClient Configuration Object</param>
        public AmazonBudgetsClient(AmazonBudgetsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonBudgetsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBudgetsClient(AWSCredentials credentials)
            : this(credentials, new AmazonBudgetsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBudgetsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBudgetsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBudgetsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBudgetsClient with AWS Credentials and an
        /// AmazonBudgetsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBudgetsClient Configuration Object</param>
        public AmazonBudgetsClient(AWSCredentials credentials, AmazonBudgetsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBudgetsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBudgetsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBudgetsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBudgetsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBudgetsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBudgetsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBudgetsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBudgetsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBudgetsClient Configuration Object</param>
        public AmazonBudgetsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBudgetsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBudgetsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBudgetsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBudgetsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBudgetsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBudgetsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBudgetsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBudgetsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBudgetsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBudgetsClient Configuration Object</param>
        public AmazonBudgetsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBudgetsConfig clientConfig)
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


        #region  CreateBudget


        /// <summary>
        /// Creates a budget and, if included, notifications and subscribers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBudget service method.</param>
        /// 
        /// <returns>The response from the CreateBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.CreationLimitExceededException">
        /// You've exceeded the notification or subscriber limit.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.DuplicateRecordException">
        /// The budget name already exists. Budget names must be unique within an account.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        public virtual CreateBudgetResponse CreateBudget(CreateBudgetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBudgetResponseUnmarshaller.Instance;

            return Invoke<CreateBudgetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBudget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateBudgetResponse> CreateBudgetAsync(CreateBudgetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBudgetResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateBudgetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNotification


        /// <summary>
        /// Creates a notification. You must create the budget before you create the associated
        /// notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotification service method.</param>
        /// 
        /// <returns>The response from the CreateNotification service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.CreationLimitExceededException">
        /// You've exceeded the notification or subscriber limit.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.DuplicateRecordException">
        /// The budget name already exists. Budget names must be unique within an account.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        public virtual CreateNotificationResponse CreateNotification(CreateNotificationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotificationResponseUnmarshaller.Instance;

            return Invoke<CreateNotificationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateNotificationResponse> CreateNotificationAsync(CreateNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotificationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateNotificationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSubscriber


        /// <summary>
        /// Creates a subscriber. You must create the associated budget and notification before
        /// you create the subscriber.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriber service method.</param>
        /// 
        /// <returns>The response from the CreateSubscriber service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.CreationLimitExceededException">
        /// You've exceeded the notification or subscriber limit.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.DuplicateRecordException">
        /// The budget name already exists. Budget names must be unique within an account.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        public virtual CreateSubscriberResponse CreateSubscriber(CreateSubscriberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriberResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriber operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateSubscriberResponse> CreateSubscriberAsync(CreateSubscriberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriberResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSubscriberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBudget


        /// <summary>
        /// Deletes a budget. You can delete your budget at any time.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a budget also deletes the notifications and subscribers that are associated
        /// with that budget.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBudget service method.</param>
        /// 
        /// <returns>The response from the DeleteBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        public virtual DeleteBudgetResponse DeleteBudget(DeleteBudgetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBudgetResponseUnmarshaller.Instance;

            return Invoke<DeleteBudgetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBudget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBudgetResponse> DeleteBudgetAsync(DeleteBudgetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBudgetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBudgetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNotification


        /// <summary>
        /// Deletes a notification.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a notification also deletes the subscribers that are associated with the
        /// notification.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotification service method.</param>
        /// 
        /// <returns>The response from the DeleteNotification service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        public virtual DeleteNotificationResponse DeleteNotification(DeleteNotificationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationResponseUnmarshaller.Instance;

            return Invoke<DeleteNotificationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteNotificationResponse> DeleteNotificationAsync(DeleteNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteNotificationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSubscriber


        /// <summary>
        /// Deletes a subscriber.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting the last subscriber to a notification also deletes the notification.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriber service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscriber service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        public virtual DeleteSubscriberResponse DeleteSubscriber(DeleteSubscriberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriberResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubscriber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriber operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteSubscriberResponse> DeleteSubscriberAsync(DeleteSubscriberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriberResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSubscriberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBudget


        /// <summary>
        /// Describes a budget.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudget service method.</param>
        /// 
        /// <returns>The response from the DescribeBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        public virtual DescribeBudgetResponse DescribeBudget(DescribeBudgetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBudgetResponseUnmarshaller.Instance;

            return Invoke<DescribeBudgetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DescribeBudgetResponse> DescribeBudgetAsync(DescribeBudgetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBudgetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeBudgetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBudgetPerformanceHistory


        /// <summary>
        /// Describes the history for <code>DAILY</code>, <code>MONTHLY</code>, and <code>QUARTERLY</code>
        /// budgets. Budget history isn't available for <code>ANNUAL</code> budgets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetPerformanceHistory service method.</param>
        /// 
        /// <returns>The response from the DescribeBudgetPerformanceHistory service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.ExpiredNextTokenException">
        /// The pagination token expired.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidNextTokenException">
        /// The pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        public virtual DescribeBudgetPerformanceHistoryResponse DescribeBudgetPerformanceHistory(DescribeBudgetPerformanceHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBudgetPerformanceHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBudgetPerformanceHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeBudgetPerformanceHistoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBudgetPerformanceHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetPerformanceHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DescribeBudgetPerformanceHistoryResponse> DescribeBudgetPerformanceHistoryAsync(DescribeBudgetPerformanceHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBudgetPerformanceHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBudgetPerformanceHistoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeBudgetPerformanceHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBudgets


        /// <summary>
        /// Lists the budgets that are associated with an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgets service method.</param>
        /// 
        /// <returns>The response from the DescribeBudgets service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.ExpiredNextTokenException">
        /// The pagination token expired.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidNextTokenException">
        /// The pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        public virtual DescribeBudgetsResponse DescribeBudgets(DescribeBudgetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBudgetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBudgetsResponseUnmarshaller.Instance;

            return Invoke<DescribeBudgetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBudgets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DescribeBudgetsResponse> DescribeBudgetsAsync(DescribeBudgetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBudgetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBudgetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeBudgetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNotificationsForBudget


        /// <summary>
        /// Lists the notifications that are associated with a budget.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationsForBudget service method.</param>
        /// 
        /// <returns>The response from the DescribeNotificationsForBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.ExpiredNextTokenException">
        /// The pagination token expired.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidNextTokenException">
        /// The pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        public virtual DescribeNotificationsForBudgetResponse DescribeNotificationsForBudget(DescribeNotificationsForBudgetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotificationsForBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotificationsForBudgetResponseUnmarshaller.Instance;

            return Invoke<DescribeNotificationsForBudgetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotificationsForBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationsForBudget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DescribeNotificationsForBudgetResponse> DescribeNotificationsForBudgetAsync(DescribeNotificationsForBudgetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotificationsForBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotificationsForBudgetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeNotificationsForBudgetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSubscribersForNotification


        /// <summary>
        /// Lists the subscribers that are associated with a notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscribersForNotification service method.</param>
        /// 
        /// <returns>The response from the DescribeSubscribersForNotification service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.ExpiredNextTokenException">
        /// The pagination token expired.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidNextTokenException">
        /// The pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        public virtual DescribeSubscribersForNotificationResponse DescribeSubscribersForNotification(DescribeSubscribersForNotificationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubscribersForNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubscribersForNotificationResponseUnmarshaller.Instance;

            return Invoke<DescribeSubscribersForNotificationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubscribersForNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscribersForNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DescribeSubscribersForNotificationResponse> DescribeSubscribersForNotificationAsync(DescribeSubscribersForNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubscribersForNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubscribersForNotificationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeSubscribersForNotificationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBudget


        /// <summary>
        /// Updates a budget. You can change every part of a budget except for the <code>budgetName</code>
        /// and the <code>calculatedSpend</code>. When you modify a budget, the <code>calculatedSpend</code>
        /// drops to zero until AWS has new usage data to use for forecasting.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudget service method.</param>
        /// 
        /// <returns>The response from the UpdateBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        public virtual UpdateBudgetResponse UpdateBudget(UpdateBudgetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBudgetResponseUnmarshaller.Instance;

            return Invoke<UpdateBudgetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateBudgetResponse> UpdateBudgetAsync(UpdateBudgetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBudgetResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateBudgetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNotification


        /// <summary>
        /// Updates a notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotification service method.</param>
        /// 
        /// <returns>The response from the UpdateNotification service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.DuplicateRecordException">
        /// The budget name already exists. Budget names must be unique within an account.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        public virtual UpdateNotificationResponse UpdateNotification(UpdateNotificationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationResponseUnmarshaller.Instance;

            return Invoke<UpdateNotificationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateNotificationResponse> UpdateNotificationAsync(UpdateNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateNotificationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSubscriber


        /// <summary>
        /// Updates a subscriber.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriber service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscriber service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.DuplicateRecordException">
        /// The budget name already exists. Budget names must be unique within an account.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        public virtual UpdateSubscriberResponse UpdateSubscriber(UpdateSubscriberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriberResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriber operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateSubscriberResponse> UpdateSubscriberAsync(UpdateSubscriberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriberResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSubscriberResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}
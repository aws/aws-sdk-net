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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Budgets.Model;
using Amazon.Budgets.Model.Internal.MarshallTransformations;
using Amazon.Budgets.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.Budgets
{
    /// <summary>
    /// <para>Implementation for accessing Budgets</para>
    ///
    /// Use the Amazon Web Services Budgets API to plan your service usage, service costs,
    /// and instance reservations. This API reference provides descriptions, syntax, and usage
    /// examples for each of the actions and data types for the Amazon Web Services Budgets
    /// feature. 
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
    /// Your current estimated charges from Amazon Web Services, and how much your predicted
    /// usage will accrue in charges by the end of the month
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// How much of your budget has been used
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Amazon Web Services updates your budget status several times a day. Budgets track
    /// your unblended costs, subscriptions, refunds, and RIs. You can create the following
    /// types of budgets:
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
    /// The Amazon Web Services Budgets API provides the following endpoint:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// https://budgets.amazonaws.com
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For information about costs that are associated with the Amazon Web Services Budgets
    /// API, see <a href="https://aws.amazon.com/aws-cost-management/pricing/">Amazon Web
    /// Services Cost Management Pricing</a>.
    /// </para>
    /// </summary>
    public partial class AmazonBudgetsClient : AmazonServiceClient, IAmazonBudgets
    {
        private static IServiceMetadata serviceMetadata = new AmazonBudgetsMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IBudgetsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBudgetsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BudgetsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBudgetsEndpointResolver());
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
        /// 
        ///  <important> 
        /// <para>
        /// Only one of <c>BudgetLimit</c> or <c>PlannedBudgetLimits</c> can be present in the
        /// syntax at one time. Use the syntax that matches your use case. The Request Syntax
        /// section shows the <c>BudgetLimit</c> syntax. For <c>PlannedBudgetLimits</c>, see the
        /// <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_budgets_CreateBudget.html#API_CreateBudget_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// Similarly, only one set of filter and metric selections can be present in the syntax
        /// at one time. Either <c>FilterExpression</c> and <c>Metrics</c> or <c>CostFilters</c>
        /// and <c>CostTypes</c>, not both or a different combination. We recommend using <c>FilterExpression</c>
        /// and <c>Metrics</c> as they provide more flexible and powerful filtering capabilities.
        /// The Request Syntax section shows the <c>FilterExpression</c>/<c>Metrics</c> syntax.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBudget service method.</param>
        /// 
        /// <returns>The response from the CreateBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.BillingViewHealthStatusException">
        /// The billing view status must be HEALTHY to perform this action. Try again when the
        /// status is HEALTHY.
        /// </exception>
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
        /// <exception cref="Amazon.Budgets.Model.ServiceQuotaExceededException">
        /// You've reached the limit on the number of tags you can associate with a resource.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateBudget">REST API Reference for CreateBudget Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateBudget operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBudget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateBudget">REST API Reference for CreateBudget Operation</seealso>
        public virtual IAsyncResult BeginCreateBudget(CreateBudgetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBudgetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBudget.</param>
        /// 
        /// <returns>Returns a  CreateBudgetResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateBudget">REST API Reference for CreateBudget Operation</seealso>
        public virtual CreateBudgetResponse EndCreateBudget(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBudgetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBudgetAction

        /// <summary>
        /// Creates a budget action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBudgetAction service method.</param>
        /// 
        /// <returns>The response from the CreateBudgetAction service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
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
        /// <exception cref="Amazon.Budgets.Model.ServiceQuotaExceededException">
        /// You've reached the limit on the number of tags you can associate with a resource.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateBudgetAction">REST API Reference for CreateBudgetAction Operation</seealso>
        public virtual CreateBudgetActionResponse CreateBudgetAction(CreateBudgetActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBudgetActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBudgetActionResponseUnmarshaller.Instance;

            return Invoke<CreateBudgetActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBudgetAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBudgetAction operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBudgetAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateBudgetAction">REST API Reference for CreateBudgetAction Operation</seealso>
        public virtual IAsyncResult BeginCreateBudgetAction(CreateBudgetActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBudgetActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBudgetActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBudgetAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBudgetAction.</param>
        /// 
        /// <returns>Returns a  CreateBudgetActionResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateBudgetAction">REST API Reference for CreateBudgetAction Operation</seealso>
        public virtual CreateBudgetActionResponse EndCreateBudgetAction(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBudgetActionResponse>(asyncResult);
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
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
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
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateNotification">REST API Reference for CreateNotification Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateNotification operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNotification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateNotification">REST API Reference for CreateNotification Operation</seealso>
        public virtual IAsyncResult BeginCreateNotification(CreateNotificationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotificationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNotification.</param>
        /// 
        /// <returns>Returns a  CreateNotificationResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateNotification">REST API Reference for CreateNotification Operation</seealso>
        public virtual CreateNotificationResponse EndCreateNotification(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNotificationResponse>(asyncResult);
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
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
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
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateSubscriber">REST API Reference for CreateSubscriber Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriber operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubscriber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateSubscriber">REST API Reference for CreateSubscriber Operation</seealso>
        public virtual IAsyncResult BeginCreateSubscriber(CreateSubscriberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubscriber.</param>
        /// 
        /// <returns>Returns a  CreateSubscriberResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateSubscriber">REST API Reference for CreateSubscriber Operation</seealso>
        public virtual CreateSubscriberResponse EndCreateSubscriber(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSubscriberResponse>(asyncResult);
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
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
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
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteBudget">REST API Reference for DeleteBudget Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteBudget operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBudget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteBudget">REST API Reference for DeleteBudget Operation</seealso>
        public virtual IAsyncResult BeginDeleteBudget(DeleteBudgetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBudgetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBudget.</param>
        /// 
        /// <returns>Returns a  DeleteBudgetResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteBudget">REST API Reference for DeleteBudget Operation</seealso>
        public virtual DeleteBudgetResponse EndDeleteBudget(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBudgetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBudgetAction

        /// <summary>
        /// Deletes a budget action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBudgetAction service method.</param>
        /// 
        /// <returns>The response from the DeleteBudgetAction service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
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
        /// <exception cref="Amazon.Budgets.Model.ResourceLockedException">
        /// The request was received and recognized by the server, but the server rejected that
        /// particular method for the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteBudgetAction">REST API Reference for DeleteBudgetAction Operation</seealso>
        public virtual DeleteBudgetActionResponse DeleteBudgetAction(DeleteBudgetActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBudgetActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBudgetActionResponseUnmarshaller.Instance;

            return Invoke<DeleteBudgetActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBudgetAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBudgetAction operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBudgetAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteBudgetAction">REST API Reference for DeleteBudgetAction Operation</seealso>
        public virtual IAsyncResult BeginDeleteBudgetAction(DeleteBudgetActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBudgetActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBudgetActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBudgetAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBudgetAction.</param>
        /// 
        /// <returns>Returns a  DeleteBudgetActionResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteBudgetAction">REST API Reference for DeleteBudgetAction Operation</seealso>
        public virtual DeleteBudgetActionResponse EndDeleteBudgetAction(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBudgetActionResponse>(asyncResult);
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
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
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
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteNotification">REST API Reference for DeleteNotification Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotification operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNotification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteNotification">REST API Reference for DeleteNotification Operation</seealso>
        public virtual IAsyncResult BeginDeleteNotification(DeleteNotificationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotification.</param>
        /// 
        /// <returns>Returns a  DeleteNotificationResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteNotification">REST API Reference for DeleteNotification Operation</seealso>
        public virtual DeleteNotificationResponse EndDeleteNotification(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNotificationResponse>(asyncResult);
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
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
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
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteSubscriber">REST API Reference for DeleteSubscriber Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriber operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSubscriber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteSubscriber">REST API Reference for DeleteSubscriber Operation</seealso>
        public virtual IAsyncResult BeginDeleteSubscriber(DeleteSubscriberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubscriber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubscriber.</param>
        /// 
        /// <returns>Returns a  DeleteSubscriberResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteSubscriber">REST API Reference for DeleteSubscriber Operation</seealso>
        public virtual DeleteSubscriberResponse EndDeleteSubscriber(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSubscriberResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBudget

        /// <summary>
        /// Describes a budget.
        /// 
        ///  <important> 
        /// <para>
        /// The Request Syntax section shows the <c>BudgetLimit</c> syntax. For <c>PlannedBudgetLimits</c>,
        /// see the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_budgets_DescribeBudget.html#API_DescribeBudget_Examples">Examples</a>
        /// section.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudget service method.</param>
        /// 
        /// <returns>The response from the DescribeBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
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
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudget">REST API Reference for DescribeBudget Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudget operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBudget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudget">REST API Reference for DescribeBudget Operation</seealso>
        public virtual IAsyncResult BeginDescribeBudget(DescribeBudgetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBudgetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBudget.</param>
        /// 
        /// <returns>Returns a  DescribeBudgetResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudget">REST API Reference for DescribeBudget Operation</seealso>
        public virtual DescribeBudgetResponse EndDescribeBudget(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBudgetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBudgetAction

        /// <summary>
        /// Describes a budget action detail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetAction service method.</param>
        /// 
        /// <returns>The response from the DescribeBudgetAction service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
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
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetAction">REST API Reference for DescribeBudgetAction Operation</seealso>
        public virtual DescribeBudgetActionResponse DescribeBudgetAction(DescribeBudgetActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBudgetActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBudgetActionResponseUnmarshaller.Instance;

            return Invoke<DescribeBudgetActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBudgetAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetAction operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBudgetAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetAction">REST API Reference for DescribeBudgetAction Operation</seealso>
        public virtual IAsyncResult BeginDescribeBudgetAction(DescribeBudgetActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBudgetActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBudgetActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBudgetAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBudgetAction.</param>
        /// 
        /// <returns>Returns a  DescribeBudgetActionResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetAction">REST API Reference for DescribeBudgetAction Operation</seealso>
        public virtual DescribeBudgetActionResponse EndDescribeBudgetAction(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBudgetActionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBudgetActionHistories

        /// <summary>
        /// Describes a budget action history detail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetActionHistories service method.</param>
        /// 
        /// <returns>The response from the DescribeBudgetActionHistories service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
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
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetActionHistories">REST API Reference for DescribeBudgetActionHistories Operation</seealso>
        public virtual DescribeBudgetActionHistoriesResponse DescribeBudgetActionHistories(DescribeBudgetActionHistoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBudgetActionHistoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBudgetActionHistoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeBudgetActionHistoriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBudgetActionHistories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetActionHistories operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBudgetActionHistories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetActionHistories">REST API Reference for DescribeBudgetActionHistories Operation</seealso>
        public virtual IAsyncResult BeginDescribeBudgetActionHistories(DescribeBudgetActionHistoriesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBudgetActionHistoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBudgetActionHistoriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBudgetActionHistories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBudgetActionHistories.</param>
        /// 
        /// <returns>Returns a  DescribeBudgetActionHistoriesResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetActionHistories">REST API Reference for DescribeBudgetActionHistories Operation</seealso>
        public virtual DescribeBudgetActionHistoriesResponse EndDescribeBudgetActionHistories(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBudgetActionHistoriesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBudgetActionsForAccount

        /// <summary>
        /// Describes all of the budget actions for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetActionsForAccount service method.</param>
        /// 
        /// <returns>The response from the DescribeBudgetActionsForAccount service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
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
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetActionsForAccount">REST API Reference for DescribeBudgetActionsForAccount Operation</seealso>
        public virtual DescribeBudgetActionsForAccountResponse DescribeBudgetActionsForAccount(DescribeBudgetActionsForAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBudgetActionsForAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBudgetActionsForAccountResponseUnmarshaller.Instance;

            return Invoke<DescribeBudgetActionsForAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBudgetActionsForAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetActionsForAccount operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBudgetActionsForAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetActionsForAccount">REST API Reference for DescribeBudgetActionsForAccount Operation</seealso>
        public virtual IAsyncResult BeginDescribeBudgetActionsForAccount(DescribeBudgetActionsForAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBudgetActionsForAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBudgetActionsForAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBudgetActionsForAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBudgetActionsForAccount.</param>
        /// 
        /// <returns>Returns a  DescribeBudgetActionsForAccountResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetActionsForAccount">REST API Reference for DescribeBudgetActionsForAccount Operation</seealso>
        public virtual DescribeBudgetActionsForAccountResponse EndDescribeBudgetActionsForAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBudgetActionsForAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBudgetActionsForBudget

        /// <summary>
        /// Describes all of the budget actions for a budget.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetActionsForBudget service method.</param>
        /// 
        /// <returns>The response from the DescribeBudgetActionsForBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
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
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetActionsForBudget">REST API Reference for DescribeBudgetActionsForBudget Operation</seealso>
        public virtual DescribeBudgetActionsForBudgetResponse DescribeBudgetActionsForBudget(DescribeBudgetActionsForBudgetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBudgetActionsForBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBudgetActionsForBudgetResponseUnmarshaller.Instance;

            return Invoke<DescribeBudgetActionsForBudgetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBudgetActionsForBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetActionsForBudget operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBudgetActionsForBudget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetActionsForBudget">REST API Reference for DescribeBudgetActionsForBudget Operation</seealso>
        public virtual IAsyncResult BeginDescribeBudgetActionsForBudget(DescribeBudgetActionsForBudgetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBudgetActionsForBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBudgetActionsForBudgetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBudgetActionsForBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBudgetActionsForBudget.</param>
        /// 
        /// <returns>Returns a  DescribeBudgetActionsForBudgetResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetActionsForBudget">REST API Reference for DescribeBudgetActionsForBudget Operation</seealso>
        public virtual DescribeBudgetActionsForBudgetResponse EndDescribeBudgetActionsForBudget(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBudgetActionsForBudgetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBudgetNotificationsForAccount

        /// <summary>
        /// Lists the budget names and notifications that are associated with an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetNotificationsForAccount service method.</param>
        /// 
        /// <returns>The response from the DescribeBudgetNotificationsForAccount service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
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
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetNotificationsForAccount">REST API Reference for DescribeBudgetNotificationsForAccount Operation</seealso>
        public virtual DescribeBudgetNotificationsForAccountResponse DescribeBudgetNotificationsForAccount(DescribeBudgetNotificationsForAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBudgetNotificationsForAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBudgetNotificationsForAccountResponseUnmarshaller.Instance;

            return Invoke<DescribeBudgetNotificationsForAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBudgetNotificationsForAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetNotificationsForAccount operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBudgetNotificationsForAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetNotificationsForAccount">REST API Reference for DescribeBudgetNotificationsForAccount Operation</seealso>
        public virtual IAsyncResult BeginDescribeBudgetNotificationsForAccount(DescribeBudgetNotificationsForAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBudgetNotificationsForAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBudgetNotificationsForAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBudgetNotificationsForAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBudgetNotificationsForAccount.</param>
        /// 
        /// <returns>Returns a  DescribeBudgetNotificationsForAccountResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetNotificationsForAccount">REST API Reference for DescribeBudgetNotificationsForAccount Operation</seealso>
        public virtual DescribeBudgetNotificationsForAccountResponse EndDescribeBudgetNotificationsForAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBudgetNotificationsForAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBudgetPerformanceHistory

        /// <summary>
        /// Describes the history for <c>DAILY</c>, <c>MONTHLY</c>, and <c>QUARTERLY</c> budgets.
        /// Budget history isn't available for <c>ANNUAL</c> budgets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetPerformanceHistory service method.</param>
        /// 
        /// <returns>The response from the DescribeBudgetPerformanceHistory service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
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
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetPerformanceHistory">REST API Reference for DescribeBudgetPerformanceHistory Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetPerformanceHistory operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBudgetPerformanceHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetPerformanceHistory">REST API Reference for DescribeBudgetPerformanceHistory Operation</seealso>
        public virtual IAsyncResult BeginDescribeBudgetPerformanceHistory(DescribeBudgetPerformanceHistoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBudgetPerformanceHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBudgetPerformanceHistoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBudgetPerformanceHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBudgetPerformanceHistory.</param>
        /// 
        /// <returns>Returns a  DescribeBudgetPerformanceHistoryResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetPerformanceHistory">REST API Reference for DescribeBudgetPerformanceHistory Operation</seealso>
        public virtual DescribeBudgetPerformanceHistoryResponse EndDescribeBudgetPerformanceHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBudgetPerformanceHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBudgets

        /// <summary>
        /// Lists the budgets that are associated with an account.
        /// 
        ///  <important> 
        /// <para>
        /// The Request Syntax section shows the <c>BudgetLimit</c> syntax. For <c>PlannedBudgetLimits</c>,
        /// see the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_budgets_DescribeBudgets.html#API_DescribeBudgets_Examples">Examples</a>
        /// section.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgets service method.</param>
        /// 
        /// <returns>The response from the DescribeBudgets service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
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
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgets">REST API Reference for DescribeBudgets Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgets operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBudgets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgets">REST API Reference for DescribeBudgets Operation</seealso>
        public virtual IAsyncResult BeginDescribeBudgets(DescribeBudgetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBudgetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBudgetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBudgets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBudgets.</param>
        /// 
        /// <returns>Returns a  DescribeBudgetsResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgets">REST API Reference for DescribeBudgets Operation</seealso>
        public virtual DescribeBudgetsResponse EndDescribeBudgets(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBudgetsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeNotificationsForBudget

        /// <summary>
        /// Lists the notifications that are associated with a budget.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationsForBudget service method.</param>
        /// 
        /// <returns>The response from the DescribeNotificationsForBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
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
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeNotificationsForBudget">REST API Reference for DescribeNotificationsForBudget Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationsForBudget operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNotificationsForBudget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeNotificationsForBudget">REST API Reference for DescribeNotificationsForBudget Operation</seealso>
        public virtual IAsyncResult BeginDescribeNotificationsForBudget(DescribeNotificationsForBudgetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotificationsForBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotificationsForBudgetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNotificationsForBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNotificationsForBudget.</param>
        /// 
        /// <returns>Returns a  DescribeNotificationsForBudgetResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeNotificationsForBudget">REST API Reference for DescribeNotificationsForBudget Operation</seealso>
        public virtual DescribeNotificationsForBudgetResponse EndDescribeNotificationsForBudget(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeNotificationsForBudgetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSubscribersForNotification

        /// <summary>
        /// Lists the subscribers that are associated with a notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscribersForNotification service method.</param>
        /// 
        /// <returns>The response from the DescribeSubscribersForNotification service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
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
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeSubscribersForNotification">REST API Reference for DescribeSubscribersForNotification Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscribersForNotification operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSubscribersForNotification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeSubscribersForNotification">REST API Reference for DescribeSubscribersForNotification Operation</seealso>
        public virtual IAsyncResult BeginDescribeSubscribersForNotification(DescribeSubscribersForNotificationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubscribersForNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubscribersForNotificationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSubscribersForNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSubscribersForNotification.</param>
        /// 
        /// <returns>Returns a  DescribeSubscribersForNotificationResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeSubscribersForNotification">REST API Reference for DescribeSubscribersForNotification Operation</seealso>
        public virtual DescribeSubscribersForNotificationResponse EndDescribeSubscribersForNotification(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSubscribersForNotificationResponse>(asyncResult);
        }

        #endregion
        
        #region  ExecuteBudgetAction

        /// <summary>
        /// Executes a budget action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteBudgetAction service method.</param>
        /// 
        /// <returns>The response from the ExecuteBudgetAction service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
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
        /// <exception cref="Amazon.Budgets.Model.ResourceLockedException">
        /// The request was received and recognized by the server, but the server rejected that
        /// particular method for the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/ExecuteBudgetAction">REST API Reference for ExecuteBudgetAction Operation</seealso>
        public virtual ExecuteBudgetActionResponse ExecuteBudgetAction(ExecuteBudgetActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteBudgetActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteBudgetActionResponseUnmarshaller.Instance;

            return Invoke<ExecuteBudgetActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteBudgetAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteBudgetAction operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteBudgetAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/ExecuteBudgetAction">REST API Reference for ExecuteBudgetAction Operation</seealso>
        public virtual IAsyncResult BeginExecuteBudgetAction(ExecuteBudgetActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteBudgetActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteBudgetActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteBudgetAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteBudgetAction.</param>
        /// 
        /// <returns>Returns a  ExecuteBudgetActionResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/ExecuteBudgetAction">REST API Reference for ExecuteBudgetAction Operation</seealso>
        public virtual ExecuteBudgetActionResponse EndExecuteBudgetAction(IAsyncResult asyncResult)
        {
            return EndInvoke<ExecuteBudgetActionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists tags associated with a budget or budget action resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
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
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Creates tags for a budget or budget action resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
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
        /// <exception cref="Amazon.Budgets.Model.ServiceQuotaExceededException">
        /// You've reached the limit on the number of tags you can associate with a resource.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Deletes tags associated with a budget or budget action resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
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
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBudget

        /// <summary>
        /// Updates a budget. You can change every part of a budget except for the <c>budgetName</c>
        /// and the <c>calculatedSpend</c>. When you modify a budget, the <c>calculatedSpend</c>
        /// drops to zero until Amazon Web Services has new usage data to use for forecasting.
        /// 
        ///  <important> 
        /// <para>
        /// Only one of <c>BudgetLimit</c> or <c>PlannedBudgetLimits</c> can be present in the
        /// syntax at one time. Use the syntax that matches your case. The Request Syntax section
        /// shows the <c>BudgetLimit</c> syntax. For <c>PlannedBudgetLimits</c>, see the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_budgets_UpdateBudget.html#API_UpdateBudget_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// Similarly, only one set of filter and metric selections can be present in the syntax
        /// at one time. Either <c>FilterExpression</c> and <c>Metrics</c> or <c>CostFilters</c>
        /// and <c>CostTypes</c>, not both or a different combination. We recommend using <c>FilterExpression</c>
        /// and <c>Metrics</c> as they provide more flexible and powerful filtering capabilities.
        /// The Request Syntax section shows the <c>FilterExpression</c>/<c>Metrics</c> syntax.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudget service method.</param>
        /// 
        /// <returns>The response from the UpdateBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.BillingViewHealthStatusException">
        /// The billing view status must be HEALTHY to perform this action. Try again when the
        /// status is HEALTHY.
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
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateBudget">REST API Reference for UpdateBudget Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudget operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBudget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateBudget">REST API Reference for UpdateBudget Operation</seealso>
        public virtual IAsyncResult BeginUpdateBudget(UpdateBudgetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBudgetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBudget.</param>
        /// 
        /// <returns>Returns a  UpdateBudgetResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateBudget">REST API Reference for UpdateBudget Operation</seealso>
        public virtual UpdateBudgetResponse EndUpdateBudget(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBudgetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBudgetAction

        /// <summary>
        /// Updates a budget action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudgetAction service method.</param>
        /// 
        /// <returns>The response from the UpdateBudgetAction service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
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
        /// <exception cref="Amazon.Budgets.Model.ResourceLockedException">
        /// The request was received and recognized by the server, but the server rejected that
        /// particular method for the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateBudgetAction">REST API Reference for UpdateBudgetAction Operation</seealso>
        public virtual UpdateBudgetActionResponse UpdateBudgetAction(UpdateBudgetActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBudgetActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBudgetActionResponseUnmarshaller.Instance;

            return Invoke<UpdateBudgetActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBudgetAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudgetAction operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBudgetAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateBudgetAction">REST API Reference for UpdateBudgetAction Operation</seealso>
        public virtual IAsyncResult BeginUpdateBudgetAction(UpdateBudgetActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBudgetActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBudgetActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBudgetAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBudgetAction.</param>
        /// 
        /// <returns>Returns a  UpdateBudgetActionResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateBudgetAction">REST API Reference for UpdateBudgetAction Operation</seealso>
        public virtual UpdateBudgetActionResponse EndUpdateBudgetAction(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBudgetActionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateNotification

        /// <summary>
        /// Updates a notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotification service method.</param>
        /// 
        /// <returns>The response from the UpdateNotification service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
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
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateNotification">REST API Reference for UpdateNotification Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotification operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNotification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateNotification">REST API Reference for UpdateNotification Operation</seealso>
        public virtual IAsyncResult BeginUpdateNotification(UpdateNotificationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNotification.</param>
        /// 
        /// <returns>Returns a  UpdateNotificationResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateNotification">REST API Reference for UpdateNotification Operation</seealso>
        public virtual UpdateNotificationResponse EndUpdateNotification(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNotificationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSubscriber

        /// <summary>
        /// Updates a subscriber.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriber service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscriber service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
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
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateSubscriber">REST API Reference for UpdateSubscriber Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriber operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSubscriber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateSubscriber">REST API Reference for UpdateSubscriber Operation</seealso>
        public virtual IAsyncResult BeginUpdateSubscriber(UpdateSubscriberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubscriber.</param>
        /// 
        /// <returns>Returns a  UpdateSubscriberResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateSubscriber">REST API Reference for UpdateSubscriber Operation</seealso>
        public virtual UpdateSubscriberResponse EndUpdateSubscriber(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSubscriberResponse>(asyncResult);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonBudgetsEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}
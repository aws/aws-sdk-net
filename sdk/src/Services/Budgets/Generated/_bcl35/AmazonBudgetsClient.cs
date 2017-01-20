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
using System.Collections.Generic;

using Amazon.Budgets.Model;
using Amazon.Budgets.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Budgets
{
    /// <summary>
    /// Implementation for accessing Budgets
    ///
    /// All public APIs for AWS Budgets
    /// </summary>
    public partial class AmazonBudgetsClient : AmazonServiceClient, IAmazonBudgets
    {
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
        /// Create a new budget
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBudget service method.</param>
        /// 
        /// <returns>The response from the CreateBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.CreationLimitExceededException">
        /// The exception is thrown when customer tries to create a record (e.g. budget), but
        /// the number this record already exceeds the limitation.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.DuplicateRecordException">
        /// The exception is thrown when customer tries to create a record (e.g. budget) that
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        public CreateBudgetResponse CreateBudget(CreateBudgetRequest request)
        {
            var marshaller = new CreateBudgetRequestMarshaller();
            var unmarshaller = CreateBudgetResponseUnmarshaller.Instance;

            return Invoke<CreateBudgetRequest,CreateBudgetResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginCreateBudget(CreateBudgetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateBudgetRequestMarshaller();
            var unmarshaller = CreateBudgetResponseUnmarshaller.Instance;

            return BeginInvoke<CreateBudgetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBudget.</param>
        /// 
        /// <returns>Returns a  CreateBudgetResult from Budgets.</returns>
        public  CreateBudgetResponse EndCreateBudget(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBudgetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateNotification

        /// <summary>
        /// Create a new Notification with subscribers for a budget
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotification service method.</param>
        /// 
        /// <returns>The response from the CreateNotification service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.CreationLimitExceededException">
        /// The exception is thrown when customer tries to create a record (e.g. budget), but
        /// the number this record already exceeds the limitation.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.DuplicateRecordException">
        /// The exception is thrown when customer tries to create a record (e.g. budget) that
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        public CreateNotificationResponse CreateNotification(CreateNotificationRequest request)
        {
            var marshaller = new CreateNotificationRequestMarshaller();
            var unmarshaller = CreateNotificationResponseUnmarshaller.Instance;

            return Invoke<CreateNotificationRequest,CreateNotificationResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginCreateNotification(CreateNotificationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateNotificationRequestMarshaller();
            var unmarshaller = CreateNotificationResponseUnmarshaller.Instance;

            return BeginInvoke<CreateNotificationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNotification.</param>
        /// 
        /// <returns>Returns a  CreateNotificationResult from Budgets.</returns>
        public  CreateNotificationResponse EndCreateNotification(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNotificationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSubscriber

        /// <summary>
        /// Create a new Subscriber for a notification
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriber service method.</param>
        /// 
        /// <returns>The response from the CreateSubscriber service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.CreationLimitExceededException">
        /// The exception is thrown when customer tries to create a record (e.g. budget), but
        /// the number this record already exceeds the limitation.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.DuplicateRecordException">
        /// The exception is thrown when customer tries to create a record (e.g. budget) that
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        public CreateSubscriberResponse CreateSubscriber(CreateSubscriberRequest request)
        {
            var marshaller = new CreateSubscriberRequestMarshaller();
            var unmarshaller = CreateSubscriberResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriberRequest,CreateSubscriberResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginCreateSubscriber(CreateSubscriberRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateSubscriberRequestMarshaller();
            var unmarshaller = CreateSubscriberResponseUnmarshaller.Instance;

            return BeginInvoke<CreateSubscriberRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubscriber.</param>
        /// 
        /// <returns>Returns a  CreateSubscriberResult from Budgets.</returns>
        public  CreateSubscriberResponse EndCreateSubscriber(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSubscriberResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBudget

        /// <summary>
        /// Delete a budget and related notifications
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBudget service method.</param>
        /// 
        /// <returns>The response from the DeleteBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        public DeleteBudgetResponse DeleteBudget(DeleteBudgetRequest request)
        {
            var marshaller = new DeleteBudgetRequestMarshaller();
            var unmarshaller = DeleteBudgetResponseUnmarshaller.Instance;

            return Invoke<DeleteBudgetRequest,DeleteBudgetResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDeleteBudget(DeleteBudgetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteBudgetRequestMarshaller();
            var unmarshaller = DeleteBudgetResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteBudgetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBudget.</param>
        /// 
        /// <returns>Returns a  DeleteBudgetResult from Budgets.</returns>
        public  DeleteBudgetResponse EndDeleteBudget(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBudgetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNotification

        /// <summary>
        /// Delete a notification and related subscribers
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotification service method.</param>
        /// 
        /// <returns>The response from the DeleteNotification service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        public DeleteNotificationResponse DeleteNotification(DeleteNotificationRequest request)
        {
            var marshaller = new DeleteNotificationRequestMarshaller();
            var unmarshaller = DeleteNotificationResponseUnmarshaller.Instance;

            return Invoke<DeleteNotificationRequest,DeleteNotificationResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDeleteNotification(DeleteNotificationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteNotificationRequestMarshaller();
            var unmarshaller = DeleteNotificationResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteNotificationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotification.</param>
        /// 
        /// <returns>Returns a  DeleteNotificationResult from Budgets.</returns>
        public  DeleteNotificationResponse EndDeleteNotification(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNotificationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSubscriber

        /// <summary>
        /// Delete a Subscriber for a notification
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriber service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscriber service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        public DeleteSubscriberResponse DeleteSubscriber(DeleteSubscriberRequest request)
        {
            var marshaller = new DeleteSubscriberRequestMarshaller();
            var unmarshaller = DeleteSubscriberResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriberRequest,DeleteSubscriberResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDeleteSubscriber(DeleteSubscriberRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteSubscriberRequestMarshaller();
            var unmarshaller = DeleteSubscriberResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteSubscriberRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubscriber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubscriber.</param>
        /// 
        /// <returns>Returns a  DeleteSubscriberResult from Budgets.</returns>
        public  DeleteSubscriberResponse EndDeleteSubscriber(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSubscriberResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBudget

        /// <summary>
        /// Get a single budget
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudget service method.</param>
        /// 
        /// <returns>The response from the DescribeBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        public DescribeBudgetResponse DescribeBudget(DescribeBudgetRequest request)
        {
            var marshaller = new DescribeBudgetRequestMarshaller();
            var unmarshaller = DescribeBudgetResponseUnmarshaller.Instance;

            return Invoke<DescribeBudgetRequest,DescribeBudgetResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeBudget(DescribeBudgetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeBudgetRequestMarshaller();
            var unmarshaller = DescribeBudgetResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeBudgetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBudget.</param>
        /// 
        /// <returns>Returns a  DescribeBudgetResult from Budgets.</returns>
        public  DescribeBudgetResponse EndDescribeBudget(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBudgetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBudgets

        /// <summary>
        /// Get all budgets for an account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgets service method.</param>
        /// 
        /// <returns>The response from the DescribeBudgets service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.ExpiredNextTokenException">
        /// This exception is thrown if the paging token is expired - past its TTL
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidNextTokenException">
        /// This exception is thrown if paging token signature didn't match the token, or the
        /// paging token isn't for this request
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        public DescribeBudgetsResponse DescribeBudgets(DescribeBudgetsRequest request)
        {
            var marshaller = new DescribeBudgetsRequestMarshaller();
            var unmarshaller = DescribeBudgetsResponseUnmarshaller.Instance;

            return Invoke<DescribeBudgetsRequest,DescribeBudgetsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeBudgets(DescribeBudgetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeBudgetsRequestMarshaller();
            var unmarshaller = DescribeBudgetsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeBudgetsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBudgets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBudgets.</param>
        /// 
        /// <returns>Returns a  DescribeBudgetsResult from Budgets.</returns>
        public  DescribeBudgetsResponse EndDescribeBudgets(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBudgetsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeNotificationsForBudget

        /// <summary>
        /// Get notifications of a budget
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationsForBudget service method.</param>
        /// 
        /// <returns>The response from the DescribeNotificationsForBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.ExpiredNextTokenException">
        /// This exception is thrown if the paging token is expired - past its TTL
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidNextTokenException">
        /// This exception is thrown if paging token signature didn't match the token, or the
        /// paging token isn't for this request
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        public DescribeNotificationsForBudgetResponse DescribeNotificationsForBudget(DescribeNotificationsForBudgetRequest request)
        {
            var marshaller = new DescribeNotificationsForBudgetRequestMarshaller();
            var unmarshaller = DescribeNotificationsForBudgetResponseUnmarshaller.Instance;

            return Invoke<DescribeNotificationsForBudgetRequest,DescribeNotificationsForBudgetResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeNotificationsForBudget(DescribeNotificationsForBudgetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeNotificationsForBudgetRequestMarshaller();
            var unmarshaller = DescribeNotificationsForBudgetResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeNotificationsForBudgetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNotificationsForBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNotificationsForBudget.</param>
        /// 
        /// <returns>Returns a  DescribeNotificationsForBudgetResult from Budgets.</returns>
        public  DescribeNotificationsForBudgetResponse EndDescribeNotificationsForBudget(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeNotificationsForBudgetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSubscribersForNotification

        /// <summary>
        /// Get subscribers of a notification
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscribersForNotification service method.</param>
        /// 
        /// <returns>The response from the DescribeSubscribersForNotification service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.ExpiredNextTokenException">
        /// This exception is thrown if the paging token is expired - past its TTL
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidNextTokenException">
        /// This exception is thrown if paging token signature didn't match the token, or the
        /// paging token isn't for this request
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        public DescribeSubscribersForNotificationResponse DescribeSubscribersForNotification(DescribeSubscribersForNotificationRequest request)
        {
            var marshaller = new DescribeSubscribersForNotificationRequestMarshaller();
            var unmarshaller = DescribeSubscribersForNotificationResponseUnmarshaller.Instance;

            return Invoke<DescribeSubscribersForNotificationRequest,DescribeSubscribersForNotificationResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeSubscribersForNotification(DescribeSubscribersForNotificationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeSubscribersForNotificationRequestMarshaller();
            var unmarshaller = DescribeSubscribersForNotificationResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeSubscribersForNotificationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSubscribersForNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSubscribersForNotification.</param>
        /// 
        /// <returns>Returns a  DescribeSubscribersForNotificationResult from Budgets.</returns>
        public  DescribeSubscribersForNotificationResponse EndDescribeSubscribersForNotification(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSubscribersForNotificationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBudget

        /// <summary>
        /// Update the information of a budget already created
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudget service method.</param>
        /// 
        /// <returns>The response from the UpdateBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        public UpdateBudgetResponse UpdateBudget(UpdateBudgetRequest request)
        {
            var marshaller = new UpdateBudgetRequestMarshaller();
            var unmarshaller = UpdateBudgetResponseUnmarshaller.Instance;

            return Invoke<UpdateBudgetRequest,UpdateBudgetResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginUpdateBudget(UpdateBudgetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateBudgetRequestMarshaller();
            var unmarshaller = UpdateBudgetResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateBudgetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBudget.</param>
        /// 
        /// <returns>Returns a  UpdateBudgetResult from Budgets.</returns>
        public  UpdateBudgetResponse EndUpdateBudget(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBudgetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateNotification

        /// <summary>
        /// Update the information about a notification already created
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotification service method.</param>
        /// 
        /// <returns>The response from the UpdateNotification service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        public UpdateNotificationResponse UpdateNotification(UpdateNotificationRequest request)
        {
            var marshaller = new UpdateNotificationRequestMarshaller();
            var unmarshaller = UpdateNotificationResponseUnmarshaller.Instance;

            return Invoke<UpdateNotificationRequest,UpdateNotificationResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginUpdateNotification(UpdateNotificationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateNotificationRequestMarshaller();
            var unmarshaller = UpdateNotificationResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateNotificationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNotification.</param>
        /// 
        /// <returns>Returns a  UpdateNotificationResult from Budgets.</returns>
        public  UpdateNotificationResponse EndUpdateNotification(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNotificationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSubscriber

        /// <summary>
        /// Update a subscriber
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriber service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscriber service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        public UpdateSubscriberResponse UpdateSubscriber(UpdateSubscriberRequest request)
        {
            var marshaller = new UpdateSubscriberRequestMarshaller();
            var unmarshaller = UpdateSubscriberResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriberRequest,UpdateSubscriberResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginUpdateSubscriber(UpdateSubscriberRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateSubscriberRequestMarshaller();
            var unmarshaller = UpdateSubscriberResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateSubscriberRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubscriber.</param>
        /// 
        /// <returns>Returns a  UpdateSubscriberResult from Budgets.</returns>
        public  UpdateSubscriberResponse EndUpdateSubscriber(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSubscriberResponse>(asyncResult);
        }

        #endregion
        
    }
}
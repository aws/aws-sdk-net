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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.QuickSight.Model;

#pragma warning disable CS1570
namespace Amazon.QuickSight
{
    /// <summary>
    /// <para>Interface for accessing QuickSight</para>
    ///
    /// Amazon Quick Suite API Reference 
    /// <para>
    /// Amazon Quick Sight is a fully managed, serverless business intelligence service for
    /// the Amazon Web Services Cloud that makes it easy to extend data and insights to every
    /// user in your organization. This API reference contains documentation for a programming
    /// interface that you can use to manage Amazon Quick Sight. 
    /// </para>
    /// </summary>
    public partial interface IAmazonQuickSight : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IQuickSightPaginatorFactory Paginators { get; }
#endif


        
        #region  BatchCreateTopicReviewedAnswer


        /// <summary>
        /// Creates new reviewed answers for a Q Topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateTopicReviewedAnswer service method.</param>
        /// 
        /// <returns>The response from the BatchCreateTopicReviewedAnswer service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/BatchCreateTopicReviewedAnswer">REST API Reference for BatchCreateTopicReviewedAnswer Operation</seealso>
        BatchCreateTopicReviewedAnswerResponse BatchCreateTopicReviewedAnswer(BatchCreateTopicReviewedAnswerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateTopicReviewedAnswer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateTopicReviewedAnswer operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateTopicReviewedAnswer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/BatchCreateTopicReviewedAnswer">REST API Reference for BatchCreateTopicReviewedAnswer Operation</seealso>
        IAsyncResult BeginBatchCreateTopicReviewedAnswer(BatchCreateTopicReviewedAnswerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateTopicReviewedAnswer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateTopicReviewedAnswer.</param>
        /// 
        /// <returns>Returns a  BatchCreateTopicReviewedAnswerResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/BatchCreateTopicReviewedAnswer">REST API Reference for BatchCreateTopicReviewedAnswer Operation</seealso>
        BatchCreateTopicReviewedAnswerResponse EndBatchCreateTopicReviewedAnswer(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDeleteTopicReviewedAnswer


        /// <summary>
        /// Deletes reviewed answers for Q Topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTopicReviewedAnswer service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteTopicReviewedAnswer service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/BatchDeleteTopicReviewedAnswer">REST API Reference for BatchDeleteTopicReviewedAnswer Operation</seealso>
        BatchDeleteTopicReviewedAnswerResponse BatchDeleteTopicReviewedAnswer(BatchDeleteTopicReviewedAnswerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteTopicReviewedAnswer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTopicReviewedAnswer operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteTopicReviewedAnswer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/BatchDeleteTopicReviewedAnswer">REST API Reference for BatchDeleteTopicReviewedAnswer Operation</seealso>
        IAsyncResult BeginBatchDeleteTopicReviewedAnswer(BatchDeleteTopicReviewedAnswerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteTopicReviewedAnswer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteTopicReviewedAnswer.</param>
        /// 
        /// <returns>Returns a  BatchDeleteTopicReviewedAnswerResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/BatchDeleteTopicReviewedAnswer">REST API Reference for BatchDeleteTopicReviewedAnswer Operation</seealso>
        BatchDeleteTopicReviewedAnswerResponse EndBatchDeleteTopicReviewedAnswer(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelIngestion


        /// <summary>
        /// Cancels an ongoing ingestion of data into SPICE.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelIngestion service method.</param>
        /// 
        /// <returns>The response from the CancelIngestion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CancelIngestion">REST API Reference for CancelIngestion Operation</seealso>
        CancelIngestionResponse CancelIngestion(CancelIngestionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelIngestion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelIngestion operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelIngestion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CancelIngestion">REST API Reference for CancelIngestion Operation</seealso>
        IAsyncResult BeginCancelIngestion(CancelIngestionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelIngestion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelIngestion.</param>
        /// 
        /// <returns>Returns a  CancelIngestionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CancelIngestion">REST API Reference for CancelIngestion Operation</seealso>
        CancelIngestionResponse EndCancelIngestion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAccountCustomization


        /// <summary>
        /// Creates Amazon Quick Sight customizations. Currently, you can add a custom default
        /// theme by using the <c>CreateAccountCustomization</c> or <c>UpdateAccountCustomization</c>
        /// API operation. To further customize Amazon Quick Sight by removing Amazon Quick Sight
        /// sample assets and videos for all new users, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/customizing-quicksight.html">Customizing
        /// Quick Sight</a> in the <i>Amazon Quick Sight User Guide.</i> 
        /// 
        ///  
        /// <para>
        /// You can create customizations for your Amazon Web Services account or, if you specify
        /// a namespace, for a Quick Sight namespace instead. Customizations that apply to a namespace
        /// always override customizations that apply to an Amazon Web Services account. To find
        /// out which customizations apply, use the <c>DescribeAccountCustomization</c> API operation.
        /// </para>
        ///  
        /// <para>
        /// Before you use the <c>CreateAccountCustomization</c> API operation to add a theme
        /// as the namespace default, make sure that you first share the theme with the namespace.
        /// If you don't share it with the namespace, the theme isn't visible to your users even
        /// if you make it the default theme. To check if the theme is shared, view the current
        /// permissions by using the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DescribeThemePermissions.html">DescribeThemePermissions</a>
        /// </c> API operation. To share the theme, grant permissions by using the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_UpdateThemePermissions.html">UpdateThemePermissions</a>
        /// </c> API operation. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountCustomization service method.</param>
        /// 
        /// <returns>The response from the CreateAccountCustomization service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateAccountCustomization">REST API Reference for CreateAccountCustomization Operation</seealso>
        CreateAccountCustomizationResponse CreateAccountCustomization(CreateAccountCustomizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccountCustomization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountCustomization operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccountCustomization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateAccountCustomization">REST API Reference for CreateAccountCustomization Operation</seealso>
        IAsyncResult BeginCreateAccountCustomization(CreateAccountCustomizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccountCustomization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccountCustomization.</param>
        /// 
        /// <returns>Returns a  CreateAccountCustomizationResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateAccountCustomization">REST API Reference for CreateAccountCustomization Operation</seealso>
        CreateAccountCustomizationResponse EndCreateAccountCustomization(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAccountSubscription


        /// <summary>
        /// Creates an Amazon Quick Sight account, or subscribes to Amazon Quick Sight Q.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Region for the account is derived from what is configured
        /// in the CLI or SDK.
        /// </para>
        ///  
        /// <para>
        /// Before you use this operation, make sure that you can connect to an existing Amazon
        /// Web Services account. If you don't have an Amazon Web Services account, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/setting-up-aws-sign-up.html">Sign
        /// up for Amazon Web Services</a> in the <i>Amazon Quick Sight User Guide</i>. The person
        /// who signs up for Amazon Quick Sight needs to have the correct Identity and Access
        /// Management (IAM) permissions. For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/iam-policy-examples.html">IAM
        /// Policy Examples for Amazon Quick Sight</a> in the <i>Amazon Quick Sight User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If your IAM policy includes both the <c>Subscribe</c> and <c>CreateAccountSubscription</c>
        /// actions, make sure that both actions are set to <c>Allow</c>. If either action is
        /// set to <c>Deny</c>, the <c>Deny</c> action prevails and your API call fails.
        /// </para>
        ///  
        /// <para>
        /// You can't pass an existing IAM role to access other Amazon Web Services services using
        /// this API operation. To pass your existing IAM role to Amazon Quick Sight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/security_iam_service-with-iam.html#security-create-iam-role">Passing
        /// IAM roles to Amazon Quick Sight</a> in the <i>Amazon Quick Sight User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can't set default resource access on the new account from the Amazon Quick Sight
        /// API. Instead, add default resource access from the Amazon Quick Sight console. For
        /// more information about setting default resource access to Amazon Web Services services,
        /// see <a href="https://docs.aws.amazon.com/quicksight/latest/user/scoping-policies-defaults.html">Setting
        /// default resource access to Amazon Web Services services</a> in the <i>Amazon Quick
        /// Sight User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateAccountSubscription service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateAccountSubscription">REST API Reference for CreateAccountSubscription Operation</seealso>
        CreateAccountSubscriptionResponse CreateAccountSubscription(CreateAccountSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccountSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountSubscription operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccountSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateAccountSubscription">REST API Reference for CreateAccountSubscription Operation</seealso>
        IAsyncResult BeginCreateAccountSubscription(CreateAccountSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccountSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccountSubscription.</param>
        /// 
        /// <returns>Returns a  CreateAccountSubscriptionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateAccountSubscription">REST API Reference for CreateAccountSubscription Operation</seealso>
        CreateAccountSubscriptionResponse EndCreateAccountSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateActionConnector


        /// <summary>
        /// Creates an action connector that enables Amazon Quick Sight to connect to external
        /// services and perform actions. Action connectors support various authentication methods
        /// and can be configured with specific actions from supported connector types like Amazon
        /// S3, Salesforce, JIRA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateActionConnector service method.</param>
        /// 
        /// <returns>The response from the CreateActionConnector service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateActionConnector">REST API Reference for CreateActionConnector Operation</seealso>
        CreateActionConnectorResponse CreateActionConnector(CreateActionConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateActionConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateActionConnector operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateActionConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateActionConnector">REST API Reference for CreateActionConnector Operation</seealso>
        IAsyncResult BeginCreateActionConnector(CreateActionConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateActionConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateActionConnector.</param>
        /// 
        /// <returns>Returns a  CreateActionConnectorResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateActionConnector">REST API Reference for CreateActionConnector Operation</seealso>
        CreateActionConnectorResponse EndCreateActionConnector(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAnalysis


        /// <summary>
        /// Creates an analysis in Amazon Quick Sight. Analyses can be created either from a template
        /// or from an <c>AnalysisDefinition</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnalysis service method.</param>
        /// 
        /// <returns>The response from the CreateAnalysis service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateAnalysis">REST API Reference for CreateAnalysis Operation</seealso>
        CreateAnalysisResponse CreateAnalysis(CreateAnalysisRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAnalysis operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateAnalysis">REST API Reference for CreateAnalysis Operation</seealso>
        IAsyncResult BeginCreateAnalysis(CreateAnalysisRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAnalysis.</param>
        /// 
        /// <returns>Returns a  CreateAnalysisResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateAnalysis">REST API Reference for CreateAnalysis Operation</seealso>
        CreateAnalysisResponse EndCreateAnalysis(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBrand


        /// <summary>
        /// Creates an Quick Sight brand.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBrand service method.</param>
        /// 
        /// <returns>The response from the CreateBrand service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateBrand">REST API Reference for CreateBrand Operation</seealso>
        CreateBrandResponse CreateBrand(CreateBrandRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBrand operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBrand operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBrand
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateBrand">REST API Reference for CreateBrand Operation</seealso>
        IAsyncResult BeginCreateBrand(CreateBrandRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBrand operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBrand.</param>
        /// 
        /// <returns>Returns a  CreateBrandResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateBrand">REST API Reference for CreateBrand Operation</seealso>
        CreateBrandResponse EndCreateBrand(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCustomPermissions


        /// <summary>
        /// Creates a custom permissions profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomPermissions service method.</param>
        /// 
        /// <returns>The response from the CreateCustomPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateCustomPermissions">REST API Reference for CreateCustomPermissions Operation</seealso>
        CreateCustomPermissionsResponse CreateCustomPermissions(CreateCustomPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateCustomPermissions">REST API Reference for CreateCustomPermissions Operation</seealso>
        IAsyncResult BeginCreateCustomPermissions(CreateCustomPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomPermissions.</param>
        /// 
        /// <returns>Returns a  CreateCustomPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateCustomPermissions">REST API Reference for CreateCustomPermissions Operation</seealso>
        CreateCustomPermissionsResponse EndCreateCustomPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDashboard


        /// <summary>
        /// Creates a dashboard from either a template or directly with a <c>DashboardDefinition</c>.
        /// To first create a template, see the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_CreateTemplate.html">CreateTemplate</a>
        /// </c> API operation.
        /// 
        ///  
        /// <para>
        /// A dashboard is an entity in Amazon Quick Sight that identifies Amazon Quick Sight
        /// reports, created from analyses. You can share Amazon Quick Sight dashboards. With
        /// the right permissions, you can create scheduled email reports from them. If you have
        /// the correct permissions, you can create a dashboard from a template that exists in
        /// a different Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard service method.</param>
        /// 
        /// <returns>The response from the CreateDashboard service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        CreateDashboardResponse CreateDashboard(CreateDashboardRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        IAsyncResult BeginCreateDashboard(CreateDashboardRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDashboard.</param>
        /// 
        /// <returns>Returns a  CreateDashboardResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        CreateDashboardResponse EndCreateDashboard(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataSet


        /// <summary>
        /// Creates a dataset. This operation doesn't support datasets that include uploaded files
        /// as a source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSet service method.</param>
        /// 
        /// <returns>The response from the CreateDataSet service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidDataSetParameterValueException">
        /// An exception thrown when an invalid parameter value is provided for dataset operations.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSet">REST API Reference for CreateDataSet Operation</seealso>
        CreateDataSetResponse CreateDataSet(CreateDataSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSet operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSet">REST API Reference for CreateDataSet Operation</seealso>
        IAsyncResult BeginCreateDataSet(CreateDataSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataSet.</param>
        /// 
        /// <returns>Returns a  CreateDataSetResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSet">REST API Reference for CreateDataSet Operation</seealso>
        CreateDataSetResponse EndCreateDataSet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataSource


        /// <summary>
        /// Creates a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.CustomerManagedKeyUnavailableException">
        /// The customer managed key that is registered to your Amazon Quick Sight account is
        /// unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        IAsyncResult BeginCreateDataSource(CreateDataSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataSource.</param>
        /// 
        /// <returns>Returns a  CreateDataSourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        CreateDataSourceResponse EndCreateDataSource(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFolder


        /// <summary>
        /// Creates an empty shared folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFolder service method.</param>
        /// 
        /// <returns>The response from the CreateFolder service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateFolder">REST API Reference for CreateFolder Operation</seealso>
        CreateFolderResponse CreateFolder(CreateFolderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFolder operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFolder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateFolder">REST API Reference for CreateFolder Operation</seealso>
        IAsyncResult BeginCreateFolder(CreateFolderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFolder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFolder.</param>
        /// 
        /// <returns>Returns a  CreateFolderResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateFolder">REST API Reference for CreateFolder Operation</seealso>
        CreateFolderResponse EndCreateFolder(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFolderMembership


        /// <summary>
        /// Adds an asset, such as a dashboard, analysis, or dataset into a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFolderMembership service method.</param>
        /// 
        /// <returns>The response from the CreateFolderMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateFolderMembership">REST API Reference for CreateFolderMembership Operation</seealso>
        CreateFolderMembershipResponse CreateFolderMembership(CreateFolderMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFolderMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFolderMembership operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFolderMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateFolderMembership">REST API Reference for CreateFolderMembership Operation</seealso>
        IAsyncResult BeginCreateFolderMembership(CreateFolderMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFolderMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFolderMembership.</param>
        /// 
        /// <returns>Returns a  CreateFolderMembershipResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateFolderMembership">REST API Reference for CreateFolderMembership Operation</seealso>
        CreateFolderMembershipResponse EndCreateFolderMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGroup


        /// <summary>
        /// Use the <c>CreateGroup</c> operation to create a group in Quick Sight. You can create
        /// up to 10,000 groups in a namespace. If you want to create more than 10,000 groups
        /// in a namespace, contact Amazon Web Services Support.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <c>arn:aws:quicksight:&lt;your-region&gt;:<i>&lt;relevant-aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </c>.
        /// </para>
        ///  
        /// <para>
        /// The response is a group object.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse CreateGroup(CreateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        IAsyncResult BeginCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a  CreateGroupResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGroupMembership


        /// <summary>
        /// Adds an Amazon Quick Sight user to an Amazon Quick Sight group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupMembership service method.</param>
        /// 
        /// <returns>The response from the CreateGroupMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        CreateGroupMembershipResponse CreateGroupMembership(CreateGroupMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupMembership operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroupMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        IAsyncResult BeginCreateGroupMembership(CreateGroupMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroupMembership.</param>
        /// 
        /// <returns>Returns a  CreateGroupMembershipResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        CreateGroupMembershipResponse EndCreateGroupMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateIAMPolicyAssignment


        /// <summary>
        /// Creates an assignment with one specified IAM policy, identified by its Amazon Resource
        /// Name (ARN). This policy assignment is attached to the specified groups or users of
        /// Amazon Quick Sight. Assignment names are unique per Amazon Web Services account. To
        /// avoid overwriting rules in other namespaces, use assignment names that are unique.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIAMPolicyAssignment service method.</param>
        /// 
        /// <returns>The response from the CreateIAMPolicyAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConcurrentUpdatingException">
        /// A resource is already in a state that indicates an operation is happening that must
        /// complete before a new update can be applied.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIAMPolicyAssignment">REST API Reference for CreateIAMPolicyAssignment Operation</seealso>
        CreateIAMPolicyAssignmentResponse CreateIAMPolicyAssignment(CreateIAMPolicyAssignmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIAMPolicyAssignment operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIAMPolicyAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIAMPolicyAssignment">REST API Reference for CreateIAMPolicyAssignment Operation</seealso>
        IAsyncResult BeginCreateIAMPolicyAssignment(CreateIAMPolicyAssignmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIAMPolicyAssignment.</param>
        /// 
        /// <returns>Returns a  CreateIAMPolicyAssignmentResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIAMPolicyAssignment">REST API Reference for CreateIAMPolicyAssignment Operation</seealso>
        CreateIAMPolicyAssignmentResponse EndCreateIAMPolicyAssignment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateIngestion


        /// <summary>
        /// Creates and starts a new SPICE ingestion for a dataset. You can manually refresh datasets
        /// in an Enterprise edition account 32 times in a 24-hour period. You can manually refresh
        /// datasets in a Standard edition account 8 times in a 24-hour period. Each 24-hour period
        /// is measured starting 24 hours before the current date and time.
        /// 
        ///  
        /// <para>
        /// Any ingestions operating on tagged datasets inherit the same tags automatically for
        /// use in access control. For an example, see <a href="http://aws.amazon.com/premiumsupport/knowledge-center/iam-ec2-resource-tags/">How
        /// do I create an IAM policy to control access to Amazon EC2 resources using tags?</a>
        /// in the Amazon Web Services Knowledge Center. Tags are visible on the tagged dataset,
        /// but not on the ingestion resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIngestion service method.</param>
        /// 
        /// <returns>The response from the CreateIngestion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIngestion">REST API Reference for CreateIngestion Operation</seealso>
        CreateIngestionResponse CreateIngestion(CreateIngestionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIngestion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIngestion operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIngestion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIngestion">REST API Reference for CreateIngestion Operation</seealso>
        IAsyncResult BeginCreateIngestion(CreateIngestionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIngestion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIngestion.</param>
        /// 
        /// <returns>Returns a  CreateIngestionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIngestion">REST API Reference for CreateIngestion Operation</seealso>
        CreateIngestionResponse EndCreateIngestion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNamespace


        /// <summary>
        /// (Enterprise edition only) Creates a new namespace for you to use with Amazon Quick
        /// Sight.
        /// 
        ///  
        /// <para>
        /// A namespace allows you to isolate the Quick Sight users and groups that are registered
        /// for that namespace. Users that access the namespace can share assets only with other
        /// users or groups in the same namespace. They can't see users and groups in other namespaces.
        /// You can create a namespace after your Amazon Web Services account is subscribed to
        /// Quick Sight. The namespace must be unique within the Amazon Web Services account.
        /// By default, there is a limit of 100 namespaces per Amazon Web Services account. To
        /// increase your limit, create a ticket with Amazon Web Services Support. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNamespace service method.</param>
        /// 
        /// <returns>The response from the CreateNamespace service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateNamespace">REST API Reference for CreateNamespace Operation</seealso>
        CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNamespace operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateNamespace">REST API Reference for CreateNamespace Operation</seealso>
        IAsyncResult BeginCreateNamespace(CreateNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNamespace.</param>
        /// 
        /// <returns>Returns a  CreateNamespaceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateNamespace">REST API Reference for CreateNamespace Operation</seealso>
        CreateNamespaceResponse EndCreateNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRefreshSchedule


        /// <summary>
        /// Creates a refresh schedule for a dataset. You can create up to 5 different schedules
        /// for a single dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRefreshSchedule service method.</param>
        /// 
        /// <returns>The response from the CreateRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateRefreshSchedule">REST API Reference for CreateRefreshSchedule Operation</seealso>
        CreateRefreshScheduleResponse CreateRefreshSchedule(CreateRefreshScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRefreshSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRefreshSchedule operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRefreshSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateRefreshSchedule">REST API Reference for CreateRefreshSchedule Operation</seealso>
        IAsyncResult BeginCreateRefreshSchedule(CreateRefreshScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRefreshSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRefreshSchedule.</param>
        /// 
        /// <returns>Returns a  CreateRefreshScheduleResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateRefreshSchedule">REST API Reference for CreateRefreshSchedule Operation</seealso>
        CreateRefreshScheduleResponse EndCreateRefreshSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRoleMembership


        /// <summary>
        /// Use <c>CreateRoleMembership</c> to add an existing Quick Sight group to an existing
        /// role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoleMembership service method.</param>
        /// 
        /// <returns>The response from the CreateRoleMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateRoleMembership">REST API Reference for CreateRoleMembership Operation</seealso>
        CreateRoleMembershipResponse CreateRoleMembership(CreateRoleMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoleMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoleMembership operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRoleMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateRoleMembership">REST API Reference for CreateRoleMembership Operation</seealso>
        IAsyncResult BeginCreateRoleMembership(CreateRoleMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoleMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoleMembership.</param>
        /// 
        /// <returns>Returns a  CreateRoleMembershipResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateRoleMembership">REST API Reference for CreateRoleMembership Operation</seealso>
        CreateRoleMembershipResponse EndCreateRoleMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTemplate


        /// <summary>
        /// Creates a template either from a <c>TemplateDefinition</c> or from an existing Quick
        /// Sight analysis or template. You can use the resulting template to create additional
        /// dashboards, templates, or analyses.
        /// 
        ///  
        /// <para>
        /// A <i>template</i> is an entity in Quick Sight that encapsulates the metadata required
        /// to create an analysis and that you can use to create s dashboard. A template adds
        /// a layer of abstraction by using placeholders to replace the dataset associated with
        /// the analysis. You can use templates to create dashboards by replacing dataset placeholders
        /// with datasets that follow the same schema that was used to create the source analysis
        /// and template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        CreateTemplateResponse CreateTemplate(CreateTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        IAsyncResult BeginCreateTemplate(CreateTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTemplate.</param>
        /// 
        /// <returns>Returns a  CreateTemplateResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        CreateTemplateResponse EndCreateTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTemplateAlias


        /// <summary>
        /// Creates a template alias for a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateAlias service method.</param>
        /// 
        /// <returns>The response from the CreateTemplateAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplateAlias">REST API Reference for CreateTemplateAlias Operation</seealso>
        CreateTemplateAliasResponse CreateTemplateAlias(CreateTemplateAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateAlias operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTemplateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplateAlias">REST API Reference for CreateTemplateAlias Operation</seealso>
        IAsyncResult BeginCreateTemplateAlias(CreateTemplateAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTemplateAlias.</param>
        /// 
        /// <returns>Returns a  CreateTemplateAliasResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplateAlias">REST API Reference for CreateTemplateAlias Operation</seealso>
        CreateTemplateAliasResponse EndCreateTemplateAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTheme


        /// <summary>
        /// Creates a theme.
        /// 
        ///  
        /// <para>
        /// A <i>theme</i> is set of configuration options for color and layout. Themes apply
        /// to analyses and dashboards. For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/themes-in-quicksight.html">Using
        /// Themes in Amazon Quick Sight</a> in the <i>Amazon Quick Sight User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTheme service method.</param>
        /// 
        /// <returns>The response from the CreateTheme service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTheme">REST API Reference for CreateTheme Operation</seealso>
        CreateThemeResponse CreateTheme(CreateThemeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTheme operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTheme operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTheme
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTheme">REST API Reference for CreateTheme Operation</seealso>
        IAsyncResult BeginCreateTheme(CreateThemeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTheme operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTheme.</param>
        /// 
        /// <returns>Returns a  CreateThemeResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTheme">REST API Reference for CreateTheme Operation</seealso>
        CreateThemeResponse EndCreateTheme(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateThemeAlias


        /// <summary>
        /// Creates a theme alias for a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThemeAlias service method.</param>
        /// 
        /// <returns>The response from the CreateThemeAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateThemeAlias">REST API Reference for CreateThemeAlias Operation</seealso>
        CreateThemeAliasResponse CreateThemeAlias(CreateThemeAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateThemeAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateThemeAlias operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateThemeAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateThemeAlias">REST API Reference for CreateThemeAlias Operation</seealso>
        IAsyncResult BeginCreateThemeAlias(CreateThemeAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateThemeAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateThemeAlias.</param>
        /// 
        /// <returns>Returns a  CreateThemeAliasResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateThemeAlias">REST API Reference for CreateThemeAlias Operation</seealso>
        CreateThemeAliasResponse EndCreateThemeAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTopic


        /// <summary>
        /// Creates a new Q topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTopic service method.</param>
        /// 
        /// <returns>The response from the CreateTopic service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTopic">REST API Reference for CreateTopic Operation</seealso>
        CreateTopicResponse CreateTopic(CreateTopicRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTopic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTopic operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTopic
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTopic">REST API Reference for CreateTopic Operation</seealso>
        IAsyncResult BeginCreateTopic(CreateTopicRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTopic operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTopic.</param>
        /// 
        /// <returns>Returns a  CreateTopicResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTopic">REST API Reference for CreateTopic Operation</seealso>
        CreateTopicResponse EndCreateTopic(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTopicRefreshSchedule


        /// <summary>
        /// Creates a topic refresh schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTopicRefreshSchedule service method.</param>
        /// 
        /// <returns>The response from the CreateTopicRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTopicRefreshSchedule">REST API Reference for CreateTopicRefreshSchedule Operation</seealso>
        CreateTopicRefreshScheduleResponse CreateTopicRefreshSchedule(CreateTopicRefreshScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTopicRefreshSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTopicRefreshSchedule operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTopicRefreshSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTopicRefreshSchedule">REST API Reference for CreateTopicRefreshSchedule Operation</seealso>
        IAsyncResult BeginCreateTopicRefreshSchedule(CreateTopicRefreshScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTopicRefreshSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTopicRefreshSchedule.</param>
        /// 
        /// <returns>Returns a  CreateTopicRefreshScheduleResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTopicRefreshSchedule">REST API Reference for CreateTopicRefreshSchedule Operation</seealso>
        CreateTopicRefreshScheduleResponse EndCreateTopicRefreshSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVPCConnection


        /// <summary>
        /// Creates a new VPC connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVPCConnection service method.</param>
        /// 
        /// <returns>The response from the CreateVPCConnection service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateVPCConnection">REST API Reference for CreateVPCConnection Operation</seealso>
        CreateVPCConnectionResponse CreateVPCConnection(CreateVPCConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVPCConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVPCConnection operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVPCConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateVPCConnection">REST API Reference for CreateVPCConnection Operation</seealso>
        IAsyncResult BeginCreateVPCConnection(CreateVPCConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVPCConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVPCConnection.</param>
        /// 
        /// <returns>Returns a  CreateVPCConnectionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateVPCConnection">REST API Reference for CreateVPCConnection Operation</seealso>
        CreateVPCConnectionResponse EndCreateVPCConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccountCustomization


        /// <summary>
        /// <important> 
        /// <para>
        /// This API permanently deletes all Quick Sight customizations for the specified Amazon
        /// Web Services account and namespace. When you delete account customizations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// All customizations are removed including themes, branding, and visual settings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This action cannot be undone through the API
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Users will see default Quick Sight styling after customizations are deleted
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Before proceeding:</b> Ensure you have backups of any custom themes or branding
        /// elements you may want to recreate.
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes all Amazon Quick Sight customizations for the specified Amazon Web Services
        /// account and Quick Sight namespace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountCustomization service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountCustomization service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteAccountCustomization">REST API Reference for DeleteAccountCustomization Operation</seealso>
        DeleteAccountCustomizationResponse DeleteAccountCustomization(DeleteAccountCustomizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountCustomization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountCustomization operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccountCustomization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteAccountCustomization">REST API Reference for DeleteAccountCustomization Operation</seealso>
        IAsyncResult BeginDeleteAccountCustomization(DeleteAccountCustomizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccountCustomization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountCustomization.</param>
        /// 
        /// <returns>Returns a  DeleteAccountCustomizationResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteAccountCustomization">REST API Reference for DeleteAccountCustomization Operation</seealso>
        DeleteAccountCustomizationResponse EndDeleteAccountCustomization(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccountCustomPermission


        /// <summary>
        /// Unapplies a custom permissions profile from an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountCustomPermission service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountCustomPermission service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteAccountCustomPermission">REST API Reference for DeleteAccountCustomPermission Operation</seealso>
        DeleteAccountCustomPermissionResponse DeleteAccountCustomPermission(DeleteAccountCustomPermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountCustomPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountCustomPermission operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccountCustomPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteAccountCustomPermission">REST API Reference for DeleteAccountCustomPermission Operation</seealso>
        IAsyncResult BeginDeleteAccountCustomPermission(DeleteAccountCustomPermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccountCustomPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountCustomPermission.</param>
        /// 
        /// <returns>Returns a  DeleteAccountCustomPermissionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteAccountCustomPermission">REST API Reference for DeleteAccountCustomPermission Operation</seealso>
        DeleteAccountCustomPermissionResponse EndDeleteAccountCustomPermission(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccountSubscription


        /// <summary>
        /// <important> 
        /// <para>
        /// Deleting your Quick Sight account subscription has permanent, irreversible consequences
        /// across all Amazon Web Services regions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Global deletion – Running this operation from any single region will delete your Quick
        /// Sight account and all data in every Amazon Web Services region where you have Quick
        /// Sight resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Complete data loss – All dashboards, analyses, datasets, data sources, and custom
        /// visuals will be permanently deleted across all regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Embedded content failure – All embedded dashboards and visuals in your applications
        /// will immediately stop working and display errors to end users.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Shared resources removed – All shared dashboards, folders, and resources will become
        /// inaccessible to other users and external recipients.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User access terminated – All Quick Sight users in your account will lose access immediately,
        /// including authors, readers, and administrators.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>No recovery possible</b> – Once deleted, your Quick Sight account and all associated
        /// data cannot be restored.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Consider exporting critical dashboards and data before proceeding with account deletion.
        /// </para>
        ///  </important> 
        /// <para>
        /// Use the <c>DeleteAccountSubscription</c> operation to delete an Quick Sight account.
        /// This operation will result in an error message if you have configured your account
        /// termination protection settings to <c>True</c>. To change this setting and delete
        /// your account, call the <c>UpdateAccountSettings</c> API and set the value of the <c>TerminationProtectionEnabled</c>
        /// parameter to <c>False</c>, then make another call to the <c>DeleteAccountSubscription</c>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountSubscription service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteAccountSubscription">REST API Reference for DeleteAccountSubscription Operation</seealso>
        DeleteAccountSubscriptionResponse DeleteAccountSubscription(DeleteAccountSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountSubscription operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccountSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteAccountSubscription">REST API Reference for DeleteAccountSubscription Operation</seealso>
        IAsyncResult BeginDeleteAccountSubscription(DeleteAccountSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccountSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteAccountSubscriptionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteAccountSubscription">REST API Reference for DeleteAccountSubscription Operation</seealso>
        DeleteAccountSubscriptionResponse EndDeleteAccountSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteActionConnector


        /// <summary>
        /// Hard deletes an action connector, making it unrecoverable. This operation removes
        /// the connector and all its associated configurations. Any resources currently using
        /// this action connector will no longer be able to perform actions through it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteActionConnector service method.</param>
        /// 
        /// <returns>The response from the DeleteActionConnector service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteActionConnector">REST API Reference for DeleteActionConnector Operation</seealso>
        DeleteActionConnectorResponse DeleteActionConnector(DeleteActionConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteActionConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteActionConnector operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteActionConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteActionConnector">REST API Reference for DeleteActionConnector Operation</seealso>
        IAsyncResult BeginDeleteActionConnector(DeleteActionConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteActionConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteActionConnector.</param>
        /// 
        /// <returns>Returns a  DeleteActionConnectorResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteActionConnector">REST API Reference for DeleteActionConnector Operation</seealso>
        DeleteActionConnectorResponse EndDeleteActionConnector(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAnalysis


        /// <summary>
        /// Deletes an analysis from Amazon Quick Sight. You can optionally include a recovery
        /// window during which you can restore the analysis. If you don't specify a recovery
        /// window value, the operation defaults to 30 days. Amazon Quick Sight attaches a <c>DeletionTime</c>
        /// stamp to the response that specifies the end of the recovery window. At the end of
        /// the recovery window, Amazon Quick Sight deletes the analysis permanently.
        /// 
        ///  
        /// <para>
        /// At any time before recovery window ends, you can use the <c>RestoreAnalysis</c> API
        /// operation to remove the <c>DeletionTime</c> stamp and cancel the deletion of the analysis.
        /// The analysis remains visible in the API until it's deleted, so you can describe it
        /// but you can't make a template from it.
        /// </para>
        ///  
        /// <para>
        /// An analysis that's scheduled for deletion isn't accessible in the Amazon Quick Sight
        /// console. To access it in the console, restore it. Deleting an analysis doesn't delete
        /// the dashboards that you publish from it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnalysis service method.</param>
        /// 
        /// <returns>The response from the DeleteAnalysis service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteAnalysis">REST API Reference for DeleteAnalysis Operation</seealso>
        DeleteAnalysisResponse DeleteAnalysis(DeleteAnalysisRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnalysis operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteAnalysis">REST API Reference for DeleteAnalysis Operation</seealso>
        IAsyncResult BeginDeleteAnalysis(DeleteAnalysisRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAnalysis.</param>
        /// 
        /// <returns>Returns a  DeleteAnalysisResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteAnalysis">REST API Reference for DeleteAnalysis Operation</seealso>
        DeleteAnalysisResponse EndDeleteAnalysis(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBrand


        /// <summary>
        /// <important> 
        /// <para>
        /// This API permanently deletes the specified Quick Sight brand. When you delete a brand:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The brand and all its associated branding elements are permanently removed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any applications or dashboards using this brand will revert to default styling
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This action cannot be undone through the API
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Before proceeding:</b> Verify that the brand is no longer needed and consider
        /// the impact on any applications currently using this brand.
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes an Quick Sight brand.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrand service method.</param>
        /// 
        /// <returns>The response from the DeleteBrand service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteBrand">REST API Reference for DeleteBrand Operation</seealso>
        DeleteBrandResponse DeleteBrand(DeleteBrandRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBrand operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrand operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBrand
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteBrand">REST API Reference for DeleteBrand Operation</seealso>
        IAsyncResult BeginDeleteBrand(DeleteBrandRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBrand operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBrand.</param>
        /// 
        /// <returns>Returns a  DeleteBrandResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteBrand">REST API Reference for DeleteBrand Operation</seealso>
        DeleteBrandResponse EndDeleteBrand(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBrandAssignment


        /// <summary>
        /// Deletes a brand assignment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrandAssignment service method.</param>
        /// 
        /// <returns>The response from the DeleteBrandAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteBrandAssignment">REST API Reference for DeleteBrandAssignment Operation</seealso>
        DeleteBrandAssignmentResponse DeleteBrandAssignment(DeleteBrandAssignmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBrandAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrandAssignment operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBrandAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteBrandAssignment">REST API Reference for DeleteBrandAssignment Operation</seealso>
        IAsyncResult BeginDeleteBrandAssignment(DeleteBrandAssignmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBrandAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBrandAssignment.</param>
        /// 
        /// <returns>Returns a  DeleteBrandAssignmentResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteBrandAssignment">REST API Reference for DeleteBrandAssignment Operation</seealso>
        DeleteBrandAssignmentResponse EndDeleteBrandAssignment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCustomPermissions


        /// <summary>
        /// Deletes a custom permissions profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomPermissions service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteCustomPermissions">REST API Reference for DeleteCustomPermissions Operation</seealso>
        DeleteCustomPermissionsResponse DeleteCustomPermissions(DeleteCustomPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteCustomPermissions">REST API Reference for DeleteCustomPermissions Operation</seealso>
        IAsyncResult BeginDeleteCustomPermissions(DeleteCustomPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomPermissions.</param>
        /// 
        /// <returns>Returns a  DeleteCustomPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteCustomPermissions">REST API Reference for DeleteCustomPermissions Operation</seealso>
        DeleteCustomPermissionsResponse EndDeleteCustomPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDashboard


        /// <summary>
        /// Deletes a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard service method.</param>
        /// 
        /// <returns>The response from the DeleteDashboard service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        DeleteDashboardResponse DeleteDashboard(DeleteDashboardRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        IAsyncResult BeginDeleteDashboard(DeleteDashboardRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDashboard.</param>
        /// 
        /// <returns>Returns a  DeleteDashboardResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        DeleteDashboardResponse EndDeleteDashboard(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataSet


        /// <summary>
        /// Deletes a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSet service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSet service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSet">REST API Reference for DeleteDataSet Operation</seealso>
        DeleteDataSetResponse DeleteDataSet(DeleteDataSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSet operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSet">REST API Reference for DeleteDataSet Operation</seealso>
        IAsyncResult BeginDeleteDataSet(DeleteDataSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataSet.</param>
        /// 
        /// <returns>Returns a  DeleteDataSetResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSet">REST API Reference for DeleteDataSet Operation</seealso>
        DeleteDataSetResponse EndDeleteDataSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataSetRefreshProperties


        /// <summary>
        /// Deletes the dataset refresh properties of the dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSetRefreshProperties service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSetRefreshProperties service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSetRefreshProperties">REST API Reference for DeleteDataSetRefreshProperties Operation</seealso>
        DeleteDataSetRefreshPropertiesResponse DeleteDataSetRefreshProperties(DeleteDataSetRefreshPropertiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataSetRefreshProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSetRefreshProperties operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataSetRefreshProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSetRefreshProperties">REST API Reference for DeleteDataSetRefreshProperties Operation</seealso>
        IAsyncResult BeginDeleteDataSetRefreshProperties(DeleteDataSetRefreshPropertiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataSetRefreshProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataSetRefreshProperties.</param>
        /// 
        /// <returns>Returns a  DeleteDataSetRefreshPropertiesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSetRefreshProperties">REST API Reference for DeleteDataSetRefreshProperties Operation</seealso>
        DeleteDataSetRefreshPropertiesResponse EndDeleteDataSetRefreshProperties(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataSource


        /// <summary>
        /// Deletes the data source permanently. This operation breaks all the datasets that reference
        /// the deleted data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        IAsyncResult BeginDeleteDataSource(DeleteDataSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataSource.</param>
        /// 
        /// <returns>Returns a  DeleteDataSourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        DeleteDataSourceResponse EndDeleteDataSource(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDefaultQBusinessApplication


        /// <summary>
        /// Deletes a linked Amazon Q Business application from an Quick Sight account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDefaultQBusinessApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteDefaultQBusinessApplication service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDefaultQBusinessApplication">REST API Reference for DeleteDefaultQBusinessApplication Operation</seealso>
        DeleteDefaultQBusinessApplicationResponse DeleteDefaultQBusinessApplication(DeleteDefaultQBusinessApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDefaultQBusinessApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDefaultQBusinessApplication operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDefaultQBusinessApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDefaultQBusinessApplication">REST API Reference for DeleteDefaultQBusinessApplication Operation</seealso>
        IAsyncResult BeginDeleteDefaultQBusinessApplication(DeleteDefaultQBusinessApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDefaultQBusinessApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDefaultQBusinessApplication.</param>
        /// 
        /// <returns>Returns a  DeleteDefaultQBusinessApplicationResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDefaultQBusinessApplication">REST API Reference for DeleteDefaultQBusinessApplication Operation</seealso>
        DeleteDefaultQBusinessApplicationResponse EndDeleteDefaultQBusinessApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFolder


        /// <summary>
        /// Deletes an empty folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFolder service method.</param>
        /// 
        /// <returns>The response from the DeleteFolder service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteFolder">REST API Reference for DeleteFolder Operation</seealso>
        DeleteFolderResponse DeleteFolder(DeleteFolderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFolder operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFolder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteFolder">REST API Reference for DeleteFolder Operation</seealso>
        IAsyncResult BeginDeleteFolder(DeleteFolderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFolder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFolder.</param>
        /// 
        /// <returns>Returns a  DeleteFolderResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteFolder">REST API Reference for DeleteFolder Operation</seealso>
        DeleteFolderResponse EndDeleteFolder(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFolderMembership


        /// <summary>
        /// Removes an asset, such as a dashboard, analysis, or dataset, from a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFolderMembership service method.</param>
        /// 
        /// <returns>The response from the DeleteFolderMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteFolderMembership">REST API Reference for DeleteFolderMembership Operation</seealso>
        DeleteFolderMembershipResponse DeleteFolderMembership(DeleteFolderMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFolderMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFolderMembership operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFolderMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteFolderMembership">REST API Reference for DeleteFolderMembership Operation</seealso>
        IAsyncResult BeginDeleteFolderMembership(DeleteFolderMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFolderMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFolderMembership.</param>
        /// 
        /// <returns>Returns a  DeleteFolderMembershipResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteFolderMembership">REST API Reference for DeleteFolderMembership Operation</seealso>
        DeleteFolderMembershipResponse EndDeleteFolderMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Removes a user group from Amazon Quick Sight.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse DeleteGroup(DeleteGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGroupMembership


        /// <summary>
        /// Removes a user from a group so that the user is no longer a member of the group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupMembership service method.</param>
        /// 
        /// <returns>The response from the DeleteGroupMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        DeleteGroupMembershipResponse DeleteGroupMembership(DeleteGroupMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupMembership operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroupMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        IAsyncResult BeginDeleteGroupMembership(DeleteGroupMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroupMembership.</param>
        /// 
        /// <returns>Returns a  DeleteGroupMembershipResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        DeleteGroupMembershipResponse EndDeleteGroupMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIAMPolicyAssignment


        /// <summary>
        /// Deletes an existing IAM policy assignment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIAMPolicyAssignment service method.</param>
        /// 
        /// <returns>The response from the DeleteIAMPolicyAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConcurrentUpdatingException">
        /// A resource is already in a state that indicates an operation is happening that must
        /// complete before a new update can be applied.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteIAMPolicyAssignment">REST API Reference for DeleteIAMPolicyAssignment Operation</seealso>
        DeleteIAMPolicyAssignmentResponse DeleteIAMPolicyAssignment(DeleteIAMPolicyAssignmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIAMPolicyAssignment operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIAMPolicyAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteIAMPolicyAssignment">REST API Reference for DeleteIAMPolicyAssignment Operation</seealso>
        IAsyncResult BeginDeleteIAMPolicyAssignment(DeleteIAMPolicyAssignmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIAMPolicyAssignment.</param>
        /// 
        /// <returns>Returns a  DeleteIAMPolicyAssignmentResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteIAMPolicyAssignment">REST API Reference for DeleteIAMPolicyAssignment Operation</seealso>
        DeleteIAMPolicyAssignmentResponse EndDeleteIAMPolicyAssignment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIdentityPropagationConfig


        /// <summary>
        /// Deletes all access scopes and authorized targets that are associated with a service
        /// from the Quick Sight IAM Identity Center application.
        /// 
        ///  
        /// <para>
        /// This operation is only supported for Quick Sight accounts that use IAM Identity Center.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityPropagationConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteIdentityPropagationConfig service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteIdentityPropagationConfig">REST API Reference for DeleteIdentityPropagationConfig Operation</seealso>
        DeleteIdentityPropagationConfigResponse DeleteIdentityPropagationConfig(DeleteIdentityPropagationConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentityPropagationConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityPropagationConfig operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIdentityPropagationConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteIdentityPropagationConfig">REST API Reference for DeleteIdentityPropagationConfig Operation</seealso>
        IAsyncResult BeginDeleteIdentityPropagationConfig(DeleteIdentityPropagationConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdentityPropagationConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdentityPropagationConfig.</param>
        /// 
        /// <returns>Returns a  DeleteIdentityPropagationConfigResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteIdentityPropagationConfig">REST API Reference for DeleteIdentityPropagationConfig Operation</seealso>
        DeleteIdentityPropagationConfigResponse EndDeleteIdentityPropagationConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNamespace


        /// <summary>
        /// Deletes a namespace and the users and groups that are associated with the namespace.
        /// This is an asynchronous process. Assets including dashboards, analyses, datasets and
        /// data sources are not deleted. To delete these assets, you use the API operations for
        /// the relevant asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace service method.</param>
        /// 
        /// <returns>The response from the DeleteNamespace service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        IAsyncResult BeginDeleteNamespace(DeleteNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNamespace.</param>
        /// 
        /// <returns>Returns a  DeleteNamespaceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        DeleteNamespaceResponse EndDeleteNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRefreshSchedule


        /// <summary>
        /// Deletes a refresh schedule from a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRefreshSchedule service method.</param>
        /// 
        /// <returns>The response from the DeleteRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteRefreshSchedule">REST API Reference for DeleteRefreshSchedule Operation</seealso>
        DeleteRefreshScheduleResponse DeleteRefreshSchedule(DeleteRefreshScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRefreshSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRefreshSchedule operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRefreshSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteRefreshSchedule">REST API Reference for DeleteRefreshSchedule Operation</seealso>
        IAsyncResult BeginDeleteRefreshSchedule(DeleteRefreshScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRefreshSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRefreshSchedule.</param>
        /// 
        /// <returns>Returns a  DeleteRefreshScheduleResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteRefreshSchedule">REST API Reference for DeleteRefreshSchedule Operation</seealso>
        DeleteRefreshScheduleResponse EndDeleteRefreshSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRoleCustomPermission


        /// <summary>
        /// Removes custom permissions from the role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoleCustomPermission service method.</param>
        /// 
        /// <returns>The response from the DeleteRoleCustomPermission service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteRoleCustomPermission">REST API Reference for DeleteRoleCustomPermission Operation</seealso>
        DeleteRoleCustomPermissionResponse DeleteRoleCustomPermission(DeleteRoleCustomPermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoleCustomPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoleCustomPermission operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRoleCustomPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteRoleCustomPermission">REST API Reference for DeleteRoleCustomPermission Operation</seealso>
        IAsyncResult BeginDeleteRoleCustomPermission(DeleteRoleCustomPermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoleCustomPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoleCustomPermission.</param>
        /// 
        /// <returns>Returns a  DeleteRoleCustomPermissionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteRoleCustomPermission">REST API Reference for DeleteRoleCustomPermission Operation</seealso>
        DeleteRoleCustomPermissionResponse EndDeleteRoleCustomPermission(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRoleMembership


        /// <summary>
        /// Removes a group from a role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoleMembership service method.</param>
        /// 
        /// <returns>The response from the DeleteRoleMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteRoleMembership">REST API Reference for DeleteRoleMembership Operation</seealso>
        DeleteRoleMembershipResponse DeleteRoleMembership(DeleteRoleMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoleMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoleMembership operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRoleMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteRoleMembership">REST API Reference for DeleteRoleMembership Operation</seealso>
        IAsyncResult BeginDeleteRoleMembership(DeleteRoleMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoleMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoleMembership.</param>
        /// 
        /// <returns>Returns a  DeleteRoleMembershipResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteRoleMembership">REST API Reference for DeleteRoleMembership Operation</seealso>
        DeleteRoleMembershipResponse EndDeleteRoleMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTemplate


        /// <summary>
        /// Deletes a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteTemplate service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        IAsyncResult BeginDeleteTemplate(DeleteTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteTemplateResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        DeleteTemplateResponse EndDeleteTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTemplateAlias


        /// <summary>
        /// Deletes the item that the specified template alias points to. If you provide a specific
        /// alias, you delete the version of the template that the alias points to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplateAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteTemplateAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplateAlias">REST API Reference for DeleteTemplateAlias Operation</seealso>
        DeleteTemplateAliasResponse DeleteTemplateAlias(DeleteTemplateAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplateAlias operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTemplateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplateAlias">REST API Reference for DeleteTemplateAlias Operation</seealso>
        IAsyncResult BeginDeleteTemplateAlias(DeleteTemplateAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTemplateAlias.</param>
        /// 
        /// <returns>Returns a  DeleteTemplateAliasResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplateAlias">REST API Reference for DeleteTemplateAlias Operation</seealso>
        DeleteTemplateAliasResponse EndDeleteTemplateAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTheme


        /// <summary>
        /// Deletes a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTheme service method.</param>
        /// 
        /// <returns>The response from the DeleteTheme service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTheme">REST API Reference for DeleteTheme Operation</seealso>
        DeleteThemeResponse DeleteTheme(DeleteThemeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTheme operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTheme operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTheme
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTheme">REST API Reference for DeleteTheme Operation</seealso>
        IAsyncResult BeginDeleteTheme(DeleteThemeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTheme operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTheme.</param>
        /// 
        /// <returns>Returns a  DeleteThemeResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTheme">REST API Reference for DeleteTheme Operation</seealso>
        DeleteThemeResponse EndDeleteTheme(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteThemeAlias


        /// <summary>
        /// Deletes the version of the theme that the specified theme alias points to. If you
        /// provide a specific alias, you delete the version of the theme that the alias points
        /// to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThemeAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteThemeAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteThemeAlias">REST API Reference for DeleteThemeAlias Operation</seealso>
        DeleteThemeAliasResponse DeleteThemeAlias(DeleteThemeAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteThemeAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteThemeAlias operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteThemeAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteThemeAlias">REST API Reference for DeleteThemeAlias Operation</seealso>
        IAsyncResult BeginDeleteThemeAlias(DeleteThemeAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteThemeAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteThemeAlias.</param>
        /// 
        /// <returns>Returns a  DeleteThemeAliasResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteThemeAlias">REST API Reference for DeleteThemeAlias Operation</seealso>
        DeleteThemeAliasResponse EndDeleteThemeAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTopic


        /// <summary>
        /// Deletes a topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopic service method.</param>
        /// 
        /// <returns>The response from the DeleteTopic service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTopic">REST API Reference for DeleteTopic Operation</seealso>
        DeleteTopicResponse DeleteTopic(DeleteTopicRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTopic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopic operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTopic
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTopic">REST API Reference for DeleteTopic Operation</seealso>
        IAsyncResult BeginDeleteTopic(DeleteTopicRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTopic operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTopic.</param>
        /// 
        /// <returns>Returns a  DeleteTopicResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTopic">REST API Reference for DeleteTopic Operation</seealso>
        DeleteTopicResponse EndDeleteTopic(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTopicRefreshSchedule


        /// <summary>
        /// Deletes a topic refresh schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopicRefreshSchedule service method.</param>
        /// 
        /// <returns>The response from the DeleteTopicRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTopicRefreshSchedule">REST API Reference for DeleteTopicRefreshSchedule Operation</seealso>
        DeleteTopicRefreshScheduleResponse DeleteTopicRefreshSchedule(DeleteTopicRefreshScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTopicRefreshSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopicRefreshSchedule operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTopicRefreshSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTopicRefreshSchedule">REST API Reference for DeleteTopicRefreshSchedule Operation</seealso>
        IAsyncResult BeginDeleteTopicRefreshSchedule(DeleteTopicRefreshScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTopicRefreshSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTopicRefreshSchedule.</param>
        /// 
        /// <returns>Returns a  DeleteTopicRefreshScheduleResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTopicRefreshSchedule">REST API Reference for DeleteTopicRefreshSchedule Operation</seealso>
        DeleteTopicRefreshScheduleResponse EndDeleteTopicRefreshSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Deletes the Amazon Quick Sight user that is associated with the identity of the IAM
        /// user or role that's making the call. The IAM user isn't deleted as a result of this
        /// call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse DeleteUser(DeleteUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUserByPrincipalId


        /// <summary>
        /// Deletes a user identified by its principal ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserByPrincipalId service method.</param>
        /// 
        /// <returns>The response from the DeleteUserByPrincipalId service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUserByPrincipalId">REST API Reference for DeleteUserByPrincipalId Operation</seealso>
        DeleteUserByPrincipalIdResponse DeleteUserByPrincipalId(DeleteUserByPrincipalIdRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserByPrincipalId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserByPrincipalId operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserByPrincipalId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUserByPrincipalId">REST API Reference for DeleteUserByPrincipalId Operation</seealso>
        IAsyncResult BeginDeleteUserByPrincipalId(DeleteUserByPrincipalIdRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserByPrincipalId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserByPrincipalId.</param>
        /// 
        /// <returns>Returns a  DeleteUserByPrincipalIdResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUserByPrincipalId">REST API Reference for DeleteUserByPrincipalId Operation</seealso>
        DeleteUserByPrincipalIdResponse EndDeleteUserByPrincipalId(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUserCustomPermission


        /// <summary>
        /// Deletes a custom permissions profile from a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserCustomPermission service method.</param>
        /// 
        /// <returns>The response from the DeleteUserCustomPermission service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUserCustomPermission">REST API Reference for DeleteUserCustomPermission Operation</seealso>
        DeleteUserCustomPermissionResponse DeleteUserCustomPermission(DeleteUserCustomPermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserCustomPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserCustomPermission operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserCustomPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUserCustomPermission">REST API Reference for DeleteUserCustomPermission Operation</seealso>
        IAsyncResult BeginDeleteUserCustomPermission(DeleteUserCustomPermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserCustomPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserCustomPermission.</param>
        /// 
        /// <returns>Returns a  DeleteUserCustomPermissionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUserCustomPermission">REST API Reference for DeleteUserCustomPermission Operation</seealso>
        DeleteUserCustomPermissionResponse EndDeleteUserCustomPermission(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVPCConnection


        /// <summary>
        /// Deletes a VPC connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVPCConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteVPCConnection service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteVPCConnection">REST API Reference for DeleteVPCConnection Operation</seealso>
        DeleteVPCConnectionResponse DeleteVPCConnection(DeleteVPCConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVPCConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVPCConnection operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVPCConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteVPCConnection">REST API Reference for DeleteVPCConnection Operation</seealso>
        IAsyncResult BeginDeleteVPCConnection(DeleteVPCConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVPCConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVPCConnection.</param>
        /// 
        /// <returns>Returns a  DeleteVPCConnectionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteVPCConnection">REST API Reference for DeleteVPCConnection Operation</seealso>
        DeleteVPCConnectionResponse EndDeleteVPCConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAccountCustomization


        /// <summary>
        /// Describes the customizations associated with the provided Amazon Web Services account
        /// and Amazon Quick Sight namespace. The Quick Sight console evaluates which customizations
        /// to apply by running this API operation with the <c>Resolved</c> flag included. 
        /// 
        ///  
        /// <para>
        /// To determine what customizations display when you run this command, it can help to
        /// visualize the relationship of the entities involved. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Amazon Web Services account</c> - The Amazon Web Services account exists at the
        /// top of the hierarchy. It has the potential to use all of the Amazon Web Services Regions
        /// and Amazon Web Services Services. When you subscribe to Quick Sight, you choose one
        /// Amazon Web Services Region to use as your home Region. That's where your free SPICE
        /// capacity is located. You can use Quick Sight in any supported Amazon Web Services
        /// Region. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Amazon Web Services Region</c> - You can sign in to Quick Sight in any Amazon
        /// Web Services Region. If you have a user directory, it resides in us-east-1, which
        /// is US East (N. Virginia). Generally speaking, these users have access to Quick Sight
        /// in any Amazon Web Services Region, unless they are constrained to a namespace. 
        /// </para>
        ///  
        /// <para>
        /// To run the command in a different Amazon Web Services Region, you change your Region
        /// settings. If you're using the CLI, you can use one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-configure-options.html">command
        /// line options</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-configure-profiles.html">named
        /// profiles</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Run <c>aws configure</c> to change your default Amazon Web Services Region. Use Enter
        /// to key the same settings for your keys. For more information, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-chap-configure.html">Configuring
        /// the CLI</a>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>Namespace</c> - A Quick Sight namespace is a partition that contains users and
        /// assets (data sources, datasets, dashboards, and so on). To access assets that are
        /// in a specific namespace, users and groups must also be part of the same namespace.
        /// People who share a namespace are completely isolated from users and assets in other
        /// namespaces, even if they are in the same Amazon Web Services account and Amazon Web
        /// Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Applied customizations</c> - Quick Sight customizations can apply to an Amazon
        /// Web Services account or to a namespace. Settings that you apply to a namespace override
        /// settings that you apply to an Amazon Web Services account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountCustomization service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountCustomization service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAccountCustomization">REST API Reference for DescribeAccountCustomization Operation</seealso>
        DescribeAccountCustomizationResponse DescribeAccountCustomization(DescribeAccountCustomizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountCustomization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountCustomization operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountCustomization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAccountCustomization">REST API Reference for DescribeAccountCustomization Operation</seealso>
        IAsyncResult BeginDescribeAccountCustomization(DescribeAccountCustomizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountCustomization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountCustomization.</param>
        /// 
        /// <returns>Returns a  DescribeAccountCustomizationResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAccountCustomization">REST API Reference for DescribeAccountCustomization Operation</seealso>
        DescribeAccountCustomizationResponse EndDescribeAccountCustomization(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAccountCustomPermission


        /// <summary>
        /// Describes the custom permissions profile that is applied to an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountCustomPermission service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountCustomPermission service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAccountCustomPermission">REST API Reference for DescribeAccountCustomPermission Operation</seealso>
        DescribeAccountCustomPermissionResponse DescribeAccountCustomPermission(DescribeAccountCustomPermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountCustomPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountCustomPermission operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountCustomPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAccountCustomPermission">REST API Reference for DescribeAccountCustomPermission Operation</seealso>
        IAsyncResult BeginDescribeAccountCustomPermission(DescribeAccountCustomPermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountCustomPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountCustomPermission.</param>
        /// 
        /// <returns>Returns a  DescribeAccountCustomPermissionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAccountCustomPermission">REST API Reference for DescribeAccountCustomPermission Operation</seealso>
        DescribeAccountCustomPermissionResponse EndDescribeAccountCustomPermission(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAccountSettings


        /// <summary>
        /// Describes the settings that were used when your Quick Sight subscription was first
        /// created in this Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountSettings service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAccountSettings">REST API Reference for DescribeAccountSettings Operation</seealso>
        DescribeAccountSettingsResponse DescribeAccountSettings(DescribeAccountSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountSettings operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAccountSettings">REST API Reference for DescribeAccountSettings Operation</seealso>
        IAsyncResult BeginDescribeAccountSettings(DescribeAccountSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountSettings.</param>
        /// 
        /// <returns>Returns a  DescribeAccountSettingsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAccountSettings">REST API Reference for DescribeAccountSettings Operation</seealso>
        DescribeAccountSettingsResponse EndDescribeAccountSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAccountSubscription


        /// <summary>
        /// Use the DescribeAccountSubscription operation to receive a description of an Quick
        /// Sight account's subscription. A successful API call returns an <c>AccountInfo</c>
        /// object that includes an account's name, subscription status, authentication type,
        /// edition, and notification email address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountSubscription service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountSubscription service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAccountSubscription">REST API Reference for DescribeAccountSubscription Operation</seealso>
        DescribeAccountSubscriptionResponse DescribeAccountSubscription(DescribeAccountSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountSubscription operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAccountSubscription">REST API Reference for DescribeAccountSubscription Operation</seealso>
        IAsyncResult BeginDescribeAccountSubscription(DescribeAccountSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountSubscription.</param>
        /// 
        /// <returns>Returns a  DescribeAccountSubscriptionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAccountSubscription">REST API Reference for DescribeAccountSubscription Operation</seealso>
        DescribeAccountSubscriptionResponse EndDescribeAccountSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeActionConnector


        /// <summary>
        /// Retrieves detailed information about an action connector, including its configuration,
        /// authentication settings, enabled actions, and current status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActionConnector service method.</param>
        /// 
        /// <returns>The response from the DescribeActionConnector service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeActionConnector">REST API Reference for DescribeActionConnector Operation</seealso>
        DescribeActionConnectorResponse DescribeActionConnector(DescribeActionConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeActionConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeActionConnector operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeActionConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeActionConnector">REST API Reference for DescribeActionConnector Operation</seealso>
        IAsyncResult BeginDescribeActionConnector(DescribeActionConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeActionConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeActionConnector.</param>
        /// 
        /// <returns>Returns a  DescribeActionConnectorResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeActionConnector">REST API Reference for DescribeActionConnector Operation</seealso>
        DescribeActionConnectorResponse EndDescribeActionConnector(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeActionConnectorPermissions


        /// <summary>
        /// Retrieves the permissions configuration for an action connector, showing which users,
        /// groups, and namespaces have access and what operations they can perform.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActionConnectorPermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeActionConnectorPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeActionConnectorPermissions">REST API Reference for DescribeActionConnectorPermissions Operation</seealso>
        DescribeActionConnectorPermissionsResponse DescribeActionConnectorPermissions(DescribeActionConnectorPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeActionConnectorPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeActionConnectorPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeActionConnectorPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeActionConnectorPermissions">REST API Reference for DescribeActionConnectorPermissions Operation</seealso>
        IAsyncResult BeginDescribeActionConnectorPermissions(DescribeActionConnectorPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeActionConnectorPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeActionConnectorPermissions.</param>
        /// 
        /// <returns>Returns a  DescribeActionConnectorPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeActionConnectorPermissions">REST API Reference for DescribeActionConnectorPermissions Operation</seealso>
        DescribeActionConnectorPermissionsResponse EndDescribeActionConnectorPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAnalysis


        /// <summary>
        /// Provides a summary of the metadata for an analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnalysis service method.</param>
        /// 
        /// <returns>The response from the DescribeAnalysis service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAnalysis">REST API Reference for DescribeAnalysis Operation</seealso>
        DescribeAnalysisResponse DescribeAnalysis(DescribeAnalysisRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnalysis operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAnalysis">REST API Reference for DescribeAnalysis Operation</seealso>
        IAsyncResult BeginDescribeAnalysis(DescribeAnalysisRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAnalysis.</param>
        /// 
        /// <returns>Returns a  DescribeAnalysisResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAnalysis">REST API Reference for DescribeAnalysis Operation</seealso>
        DescribeAnalysisResponse EndDescribeAnalysis(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAnalysisDefinition


        /// <summary>
        /// Provides a detailed description of the definition of an analysis.
        /// 
        ///  <note> 
        /// <para>
        /// If you do not need to know details about the content of an Analysis, for instance
        /// if you are trying to check the status of a recently created or updated Analysis, use
        /// the <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DescribeAnalysis.html">
        /// <c>DescribeAnalysis</c> </a> instead. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnalysisDefinition service method.</param>
        /// 
        /// <returns>The response from the DescribeAnalysisDefinition service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAnalysisDefinition">REST API Reference for DescribeAnalysisDefinition Operation</seealso>
        DescribeAnalysisDefinitionResponse DescribeAnalysisDefinition(DescribeAnalysisDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAnalysisDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnalysisDefinition operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAnalysisDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAnalysisDefinition">REST API Reference for DescribeAnalysisDefinition Operation</seealso>
        IAsyncResult BeginDescribeAnalysisDefinition(DescribeAnalysisDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAnalysisDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAnalysisDefinition.</param>
        /// 
        /// <returns>Returns a  DescribeAnalysisDefinitionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAnalysisDefinition">REST API Reference for DescribeAnalysisDefinition Operation</seealso>
        DescribeAnalysisDefinitionResponse EndDescribeAnalysisDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAnalysisPermissions


        /// <summary>
        /// Provides the read and write permissions for an analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnalysisPermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeAnalysisPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAnalysisPermissions">REST API Reference for DescribeAnalysisPermissions Operation</seealso>
        DescribeAnalysisPermissionsResponse DescribeAnalysisPermissions(DescribeAnalysisPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAnalysisPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnalysisPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAnalysisPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAnalysisPermissions">REST API Reference for DescribeAnalysisPermissions Operation</seealso>
        IAsyncResult BeginDescribeAnalysisPermissions(DescribeAnalysisPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAnalysisPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAnalysisPermissions.</param>
        /// 
        /// <returns>Returns a  DescribeAnalysisPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAnalysisPermissions">REST API Reference for DescribeAnalysisPermissions Operation</seealso>
        DescribeAnalysisPermissionsResponse EndDescribeAnalysisPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAssetBundleExportJob


        /// <summary>
        /// Describes an existing export job.
        /// 
        ///  
        /// <para>
        /// Poll job descriptions after a job starts to know the status of the job. When a job
        /// succeeds, a URL is provided to download the exported assets' data from. Download URLs
        /// are valid for five minutes after they are generated. You can call the <c>DescribeAssetBundleExportJob</c>
        /// API for a new download URL as needed.
        /// </para>
        ///  
        /// <para>
        /// Job descriptions are available for 14 days after the job starts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetBundleExportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeAssetBundleExportJob service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAssetBundleExportJob">REST API Reference for DescribeAssetBundleExportJob Operation</seealso>
        DescribeAssetBundleExportJobResponse DescribeAssetBundleExportJob(DescribeAssetBundleExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssetBundleExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetBundleExportJob operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAssetBundleExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAssetBundleExportJob">REST API Reference for DescribeAssetBundleExportJob Operation</seealso>
        IAsyncResult BeginDescribeAssetBundleExportJob(DescribeAssetBundleExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAssetBundleExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAssetBundleExportJob.</param>
        /// 
        /// <returns>Returns a  DescribeAssetBundleExportJobResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAssetBundleExportJob">REST API Reference for DescribeAssetBundleExportJob Operation</seealso>
        DescribeAssetBundleExportJobResponse EndDescribeAssetBundleExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAssetBundleImportJob


        /// <summary>
        /// Describes an existing import job.
        /// 
        ///  
        /// <para>
        /// Poll job descriptions after starting a job to know when it has succeeded or failed.
        /// Job descriptions are available for 14 days after job starts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetBundleImportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeAssetBundleImportJob service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAssetBundleImportJob">REST API Reference for DescribeAssetBundleImportJob Operation</seealso>
        DescribeAssetBundleImportJobResponse DescribeAssetBundleImportJob(DescribeAssetBundleImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssetBundleImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetBundleImportJob operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAssetBundleImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAssetBundleImportJob">REST API Reference for DescribeAssetBundleImportJob Operation</seealso>
        IAsyncResult BeginDescribeAssetBundleImportJob(DescribeAssetBundleImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAssetBundleImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAssetBundleImportJob.</param>
        /// 
        /// <returns>Returns a  DescribeAssetBundleImportJobResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAssetBundleImportJob">REST API Reference for DescribeAssetBundleImportJob Operation</seealso>
        DescribeAssetBundleImportJobResponse EndDescribeAssetBundleImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBrand


        /// <summary>
        /// Describes a brand.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBrand service method.</param>
        /// 
        /// <returns>The response from the DescribeBrand service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeBrand">REST API Reference for DescribeBrand Operation</seealso>
        DescribeBrandResponse DescribeBrand(DescribeBrandRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBrand operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBrand operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBrand
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeBrand">REST API Reference for DescribeBrand Operation</seealso>
        IAsyncResult BeginDescribeBrand(DescribeBrandRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBrand operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBrand.</param>
        /// 
        /// <returns>Returns a  DescribeBrandResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeBrand">REST API Reference for DescribeBrand Operation</seealso>
        DescribeBrandResponse EndDescribeBrand(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBrandAssignment


        /// <summary>
        /// Describes a brand assignment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBrandAssignment service method.</param>
        /// 
        /// <returns>The response from the DescribeBrandAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeBrandAssignment">REST API Reference for DescribeBrandAssignment Operation</seealso>
        DescribeBrandAssignmentResponse DescribeBrandAssignment(DescribeBrandAssignmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBrandAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBrandAssignment operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBrandAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeBrandAssignment">REST API Reference for DescribeBrandAssignment Operation</seealso>
        IAsyncResult BeginDescribeBrandAssignment(DescribeBrandAssignmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBrandAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBrandAssignment.</param>
        /// 
        /// <returns>Returns a  DescribeBrandAssignmentResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeBrandAssignment">REST API Reference for DescribeBrandAssignment Operation</seealso>
        DescribeBrandAssignmentResponse EndDescribeBrandAssignment(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBrandPublishedVersion


        /// <summary>
        /// Describes the published version of the brand.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBrandPublishedVersion service method.</param>
        /// 
        /// <returns>The response from the DescribeBrandPublishedVersion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeBrandPublishedVersion">REST API Reference for DescribeBrandPublishedVersion Operation</seealso>
        DescribeBrandPublishedVersionResponse DescribeBrandPublishedVersion(DescribeBrandPublishedVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBrandPublishedVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBrandPublishedVersion operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBrandPublishedVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeBrandPublishedVersion">REST API Reference for DescribeBrandPublishedVersion Operation</seealso>
        IAsyncResult BeginDescribeBrandPublishedVersion(DescribeBrandPublishedVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBrandPublishedVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBrandPublishedVersion.</param>
        /// 
        /// <returns>Returns a  DescribeBrandPublishedVersionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeBrandPublishedVersion">REST API Reference for DescribeBrandPublishedVersion Operation</seealso>
        DescribeBrandPublishedVersionResponse EndDescribeBrandPublishedVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCustomPermissions


        /// <summary>
        /// Describes a custom permissions profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomPermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeCustomPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeCustomPermissions">REST API Reference for DescribeCustomPermissions Operation</seealso>
        DescribeCustomPermissionsResponse DescribeCustomPermissions(DescribeCustomPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCustomPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeCustomPermissions">REST API Reference for DescribeCustomPermissions Operation</seealso>
        IAsyncResult BeginDescribeCustomPermissions(DescribeCustomPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCustomPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCustomPermissions.</param>
        /// 
        /// <returns>Returns a  DescribeCustomPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeCustomPermissions">REST API Reference for DescribeCustomPermissions Operation</seealso>
        DescribeCustomPermissionsResponse EndDescribeCustomPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDashboard


        /// <summary>
        /// Provides a summary for a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboard service method.</param>
        /// 
        /// <returns>The response from the DescribeDashboard service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboard">REST API Reference for DescribeDashboard Operation</seealso>
        DescribeDashboardResponse DescribeDashboard(DescribeDashboardRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboard operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboard">REST API Reference for DescribeDashboard Operation</seealso>
        IAsyncResult BeginDescribeDashboard(DescribeDashboardRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDashboard.</param>
        /// 
        /// <returns>Returns a  DescribeDashboardResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboard">REST API Reference for DescribeDashboard Operation</seealso>
        DescribeDashboardResponse EndDescribeDashboard(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDashboardDefinition


        /// <summary>
        /// Provides a detailed description of the definition of a dashboard.
        /// 
        ///  <note> 
        /// <para>
        /// If you do not need to know details about the content of a dashboard, for instance
        /// if you are trying to check the status of a recently created or updated dashboard,
        /// use the <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DescribeDashboard.html">
        /// <c>DescribeDashboard</c> </a> instead. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardDefinition service method.</param>
        /// 
        /// <returns>The response from the DescribeDashboardDefinition service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardDefinition">REST API Reference for DescribeDashboardDefinition Operation</seealso>
        DescribeDashboardDefinitionResponse DescribeDashboardDefinition(DescribeDashboardDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDashboardDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardDefinition operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDashboardDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardDefinition">REST API Reference for DescribeDashboardDefinition Operation</seealso>
        IAsyncResult BeginDescribeDashboardDefinition(DescribeDashboardDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDashboardDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDashboardDefinition.</param>
        /// 
        /// <returns>Returns a  DescribeDashboardDefinitionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardDefinition">REST API Reference for DescribeDashboardDefinition Operation</seealso>
        DescribeDashboardDefinitionResponse EndDescribeDashboardDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDashboardPermissions


        /// <summary>
        /// Describes read and write permissions for a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardPermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeDashboardPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardPermissions">REST API Reference for DescribeDashboardPermissions Operation</seealso>
        DescribeDashboardPermissionsResponse DescribeDashboardPermissions(DescribeDashboardPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDashboardPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDashboardPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardPermissions">REST API Reference for DescribeDashboardPermissions Operation</seealso>
        IAsyncResult BeginDescribeDashboardPermissions(DescribeDashboardPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDashboardPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDashboardPermissions.</param>
        /// 
        /// <returns>Returns a  DescribeDashboardPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardPermissions">REST API Reference for DescribeDashboardPermissions Operation</seealso>
        DescribeDashboardPermissionsResponse EndDescribeDashboardPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDashboardSnapshotJob


        /// <summary>
        /// Describes an existing snapshot job.
        /// 
        ///  
        /// <para>
        /// Poll job descriptions after a job starts to know the status of the job. For information
        /// on available status codes, see <c>JobStatus</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Registered user support</b> 
        /// </para>
        ///  
        /// <para>
        /// This API can be called as before to get status of a job started by the same Quick
        /// Sight user.
        /// </para>
        ///  
        /// <para>
        ///  <b>Possible error scenarios</b> 
        /// </para>
        ///  
        /// <para>
        /// Request will fail with an Access Denied error in the following scenarios:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The credentials have expired.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Job has been started by a different user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Impersonated Quick Sight user doesn't have access to the specified dashboard in the
        /// job.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardSnapshotJob service method.</param>
        /// 
        /// <returns>The response from the DescribeDashboardSnapshotJob service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardSnapshotJob">REST API Reference for DescribeDashboardSnapshotJob Operation</seealso>
        DescribeDashboardSnapshotJobResponse DescribeDashboardSnapshotJob(DescribeDashboardSnapshotJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDashboardSnapshotJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardSnapshotJob operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDashboardSnapshotJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardSnapshotJob">REST API Reference for DescribeDashboardSnapshotJob Operation</seealso>
        IAsyncResult BeginDescribeDashboardSnapshotJob(DescribeDashboardSnapshotJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDashboardSnapshotJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDashboardSnapshotJob.</param>
        /// 
        /// <returns>Returns a  DescribeDashboardSnapshotJobResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardSnapshotJob">REST API Reference for DescribeDashboardSnapshotJob Operation</seealso>
        DescribeDashboardSnapshotJobResponse EndDescribeDashboardSnapshotJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDashboardSnapshotJobResult


        /// <summary>
        /// Describes the result of an existing snapshot job that has finished running.
        /// 
        ///  
        /// <para>
        /// A finished snapshot job will return a <c>COMPLETED</c> or <c>FAILED</c> status when
        /// you poll the job with a <c>DescribeDashboardSnapshotJob</c> API call.
        /// </para>
        ///  
        /// <para>
        /// If the job has not finished running, this operation returns a message that says <c>Dashboard
        /// Snapshot Job with id &lt;SnapshotjobId&gt; has not reached a terminal state.</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Registered user support</b> 
        /// </para>
        ///  
        /// <para>
        /// This API can be called as before to get the result of a job started by the same Quick
        /// Sight user. The result for the user will be returned in <c>RegisteredUsers</c> response
        /// attribute. The attribute will contain a list with at most one object in it.
        /// </para>
        ///  
        /// <para>
        ///  <b>Possible error scenarios</b> 
        /// </para>
        ///  
        /// <para>
        /// The request fails with an Access Denied error in the following scenarios:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The credentials have expired.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The job was started by a different user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The registered user doesn't have access to the specified dashboard.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The request succeeds but the job fails in the following scenarios:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DASHBOARD_ACCESS_DENIED</c> - The registered user lost access to the dashboard.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CAPABILITY_RESTRICTED</c> - The registered user is restricted from exporting data
        /// in <b>all</b> selected formats.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The request succeeds but the response contains an error code in the following scenarios:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CAPABILITY_RESTRICTED</c> - The registered user is restricted from exporting data
        /// in <b>some</b> selected formats.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RLS_CHANGED</c> - Row-level security settings have changed. Re-run the job with
        /// current settings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CLS_CHANGED</c> - Column-level security settings have changed. Re-run the job
        /// with current settings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DATASET_DELETED</c> - The dataset has been deleted. Verify the dataset exists
        /// before re-running the job.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardSnapshotJobResult service method.</param>
        /// 
        /// <returns>The response from the DescribeDashboardSnapshotJobResult service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardSnapshotJobResult">REST API Reference for DescribeDashboardSnapshotJobResult Operation</seealso>
        DescribeDashboardSnapshotJobResultResponse DescribeDashboardSnapshotJobResult(DescribeDashboardSnapshotJobResultRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDashboardSnapshotJobResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardSnapshotJobResult operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDashboardSnapshotJobResult
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardSnapshotJobResult">REST API Reference for DescribeDashboardSnapshotJobResult Operation</seealso>
        IAsyncResult BeginDescribeDashboardSnapshotJobResult(DescribeDashboardSnapshotJobResultRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDashboardSnapshotJobResult operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDashboardSnapshotJobResult.</param>
        /// 
        /// <returns>Returns a  DescribeDashboardSnapshotJobResultResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardSnapshotJobResult">REST API Reference for DescribeDashboardSnapshotJobResult Operation</seealso>
        DescribeDashboardSnapshotJobResultResponse EndDescribeDashboardSnapshotJobResult(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDashboardsQAConfiguration


        /// <summary>
        /// Describes an existing dashboard QA configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardsQAConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeDashboardsQAConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardsQAConfiguration">REST API Reference for DescribeDashboardsQAConfiguration Operation</seealso>
        DescribeDashboardsQAConfigurationResponse DescribeDashboardsQAConfiguration(DescribeDashboardsQAConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDashboardsQAConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardsQAConfiguration operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDashboardsQAConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardsQAConfiguration">REST API Reference for DescribeDashboardsQAConfiguration Operation</seealso>
        IAsyncResult BeginDescribeDashboardsQAConfiguration(DescribeDashboardsQAConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDashboardsQAConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDashboardsQAConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeDashboardsQAConfigurationResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardsQAConfiguration">REST API Reference for DescribeDashboardsQAConfiguration Operation</seealso>
        DescribeDashboardsQAConfigurationResponse EndDescribeDashboardsQAConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataSet


        /// <summary>
        /// Describes a dataset. This operation doesn't support datasets that include uploaded
        /// files as a source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSet service method.</param>
        /// 
        /// <returns>The response from the DescribeDataSet service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSet">REST API Reference for DescribeDataSet Operation</seealso>
        DescribeDataSetResponse DescribeDataSet(DescribeDataSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSet operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSet">REST API Reference for DescribeDataSet Operation</seealso>
        IAsyncResult BeginDescribeDataSet(DescribeDataSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataSet.</param>
        /// 
        /// <returns>Returns a  DescribeDataSetResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSet">REST API Reference for DescribeDataSet Operation</seealso>
        DescribeDataSetResponse EndDescribeDataSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataSetPermissions


        /// <summary>
        /// Describes the permissions on a dataset.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <c>arn:aws:quicksight:region:aws-account-id:dataset/data-set-id</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSetPermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeDataSetPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSetPermissions">REST API Reference for DescribeDataSetPermissions Operation</seealso>
        DescribeDataSetPermissionsResponse DescribeDataSetPermissions(DescribeDataSetPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataSetPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSetPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataSetPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSetPermissions">REST API Reference for DescribeDataSetPermissions Operation</seealso>
        IAsyncResult BeginDescribeDataSetPermissions(DescribeDataSetPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataSetPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataSetPermissions.</param>
        /// 
        /// <returns>Returns a  DescribeDataSetPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSetPermissions">REST API Reference for DescribeDataSetPermissions Operation</seealso>
        DescribeDataSetPermissionsResponse EndDescribeDataSetPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataSetRefreshProperties


        /// <summary>
        /// Describes the refresh properties of a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSetRefreshProperties service method.</param>
        /// 
        /// <returns>The response from the DescribeDataSetRefreshProperties service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSetRefreshProperties">REST API Reference for DescribeDataSetRefreshProperties Operation</seealso>
        DescribeDataSetRefreshPropertiesResponse DescribeDataSetRefreshProperties(DescribeDataSetRefreshPropertiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataSetRefreshProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSetRefreshProperties operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataSetRefreshProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSetRefreshProperties">REST API Reference for DescribeDataSetRefreshProperties Operation</seealso>
        IAsyncResult BeginDescribeDataSetRefreshProperties(DescribeDataSetRefreshPropertiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataSetRefreshProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataSetRefreshProperties.</param>
        /// 
        /// <returns>Returns a  DescribeDataSetRefreshPropertiesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSetRefreshProperties">REST API Reference for DescribeDataSetRefreshProperties Operation</seealso>
        DescribeDataSetRefreshPropertiesResponse EndDescribeDataSetRefreshProperties(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataSource


        /// <summary>
        /// Describes a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSource service method.</param>
        /// 
        /// <returns>The response from the DescribeDataSource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSource">REST API Reference for DescribeDataSource Operation</seealso>
        DescribeDataSourceResponse DescribeDataSource(DescribeDataSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSource">REST API Reference for DescribeDataSource Operation</seealso>
        IAsyncResult BeginDescribeDataSource(DescribeDataSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataSource.</param>
        /// 
        /// <returns>Returns a  DescribeDataSourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSource">REST API Reference for DescribeDataSource Operation</seealso>
        DescribeDataSourceResponse EndDescribeDataSource(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataSourcePermissions


        /// <summary>
        /// Describes the resource permissions for a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSourcePermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeDataSourcePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSourcePermissions">REST API Reference for DescribeDataSourcePermissions Operation</seealso>
        DescribeDataSourcePermissionsResponse DescribeDataSourcePermissions(DescribeDataSourcePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataSourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSourcePermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataSourcePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSourcePermissions">REST API Reference for DescribeDataSourcePermissions Operation</seealso>
        IAsyncResult BeginDescribeDataSourcePermissions(DescribeDataSourcePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataSourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataSourcePermissions.</param>
        /// 
        /// <returns>Returns a  DescribeDataSourcePermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSourcePermissions">REST API Reference for DescribeDataSourcePermissions Operation</seealso>
        DescribeDataSourcePermissionsResponse EndDescribeDataSourcePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDefaultQBusinessApplication


        /// <summary>
        /// Describes a Amazon Q Business application that is linked to an Quick Sight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultQBusinessApplication service method.</param>
        /// 
        /// <returns>The response from the DescribeDefaultQBusinessApplication service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDefaultQBusinessApplication">REST API Reference for DescribeDefaultQBusinessApplication Operation</seealso>
        DescribeDefaultQBusinessApplicationResponse DescribeDefaultQBusinessApplication(DescribeDefaultQBusinessApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultQBusinessApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultQBusinessApplication operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDefaultQBusinessApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDefaultQBusinessApplication">REST API Reference for DescribeDefaultQBusinessApplication Operation</seealso>
        IAsyncResult BeginDescribeDefaultQBusinessApplication(DescribeDefaultQBusinessApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDefaultQBusinessApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDefaultQBusinessApplication.</param>
        /// 
        /// <returns>Returns a  DescribeDefaultQBusinessApplicationResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDefaultQBusinessApplication">REST API Reference for DescribeDefaultQBusinessApplication Operation</seealso>
        DescribeDefaultQBusinessApplicationResponse EndDescribeDefaultQBusinessApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFolder


        /// <summary>
        /// Describes a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFolder service method.</param>
        /// 
        /// <returns>The response from the DescribeFolder service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeFolder">REST API Reference for DescribeFolder Operation</seealso>
        DescribeFolderResponse DescribeFolder(DescribeFolderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFolder operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFolder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeFolder">REST API Reference for DescribeFolder Operation</seealso>
        IAsyncResult BeginDescribeFolder(DescribeFolderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFolder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFolder.</param>
        /// 
        /// <returns>Returns a  DescribeFolderResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeFolder">REST API Reference for DescribeFolder Operation</seealso>
        DescribeFolderResponse EndDescribeFolder(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFolderPermissions


        /// <summary>
        /// Describes permissions for a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFolderPermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeFolderPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeFolderPermissions">REST API Reference for DescribeFolderPermissions Operation</seealso>
        DescribeFolderPermissionsResponse DescribeFolderPermissions(DescribeFolderPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFolderPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFolderPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFolderPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeFolderPermissions">REST API Reference for DescribeFolderPermissions Operation</seealso>
        IAsyncResult BeginDescribeFolderPermissions(DescribeFolderPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFolderPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFolderPermissions.</param>
        /// 
        /// <returns>Returns a  DescribeFolderPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeFolderPermissions">REST API Reference for DescribeFolderPermissions Operation</seealso>
        DescribeFolderPermissionsResponse EndDescribeFolderPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFolderResolvedPermissions


        /// <summary>
        /// Describes the folder resolved permissions. Permissions consists of both folder direct
        /// permissions and the inherited permissions from the ancestor folders.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFolderResolvedPermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeFolderResolvedPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeFolderResolvedPermissions">REST API Reference for DescribeFolderResolvedPermissions Operation</seealso>
        DescribeFolderResolvedPermissionsResponse DescribeFolderResolvedPermissions(DescribeFolderResolvedPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFolderResolvedPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFolderResolvedPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFolderResolvedPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeFolderResolvedPermissions">REST API Reference for DescribeFolderResolvedPermissions Operation</seealso>
        IAsyncResult BeginDescribeFolderResolvedPermissions(DescribeFolderResolvedPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFolderResolvedPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFolderResolvedPermissions.</param>
        /// 
        /// <returns>Returns a  DescribeFolderResolvedPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeFolderResolvedPermissions">REST API Reference for DescribeFolderResolvedPermissions Operation</seealso>
        DescribeFolderResolvedPermissionsResponse EndDescribeFolderResolvedPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeGroup


        /// <summary>
        /// Returns an Amazon Quick Sight group's description and Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        DescribeGroupResponse DescribeGroup(DescribeGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        IAsyncResult BeginDescribeGroup(DescribeGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGroup.</param>
        /// 
        /// <returns>Returns a  DescribeGroupResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        DescribeGroupResponse EndDescribeGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeGroupMembership


        /// <summary>
        /// Use the <c>DescribeGroupMembership</c> operation to determine if a user is a member
        /// of the specified group. If the user exists and is a member of the specified group,
        /// an associated <c>GroupMember</c> object is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroupMembership service method.</param>
        /// 
        /// <returns>The response from the DescribeGroupMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroupMembership">REST API Reference for DescribeGroupMembership Operation</seealso>
        DescribeGroupMembershipResponse DescribeGroupMembership(DescribeGroupMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroupMembership operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGroupMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroupMembership">REST API Reference for DescribeGroupMembership Operation</seealso>
        IAsyncResult BeginDescribeGroupMembership(DescribeGroupMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGroupMembership.</param>
        /// 
        /// <returns>Returns a  DescribeGroupMembershipResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroupMembership">REST API Reference for DescribeGroupMembership Operation</seealso>
        DescribeGroupMembershipResponse EndDescribeGroupMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeIAMPolicyAssignment


        /// <summary>
        /// Describes an existing IAM policy assignment, as specified by the assignment name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIAMPolicyAssignment service method.</param>
        /// 
        /// <returns>The response from the DescribeIAMPolicyAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIAMPolicyAssignment">REST API Reference for DescribeIAMPolicyAssignment Operation</seealso>
        DescribeIAMPolicyAssignmentResponse DescribeIAMPolicyAssignment(DescribeIAMPolicyAssignmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIAMPolicyAssignment operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIAMPolicyAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIAMPolicyAssignment">REST API Reference for DescribeIAMPolicyAssignment Operation</seealso>
        IAsyncResult BeginDescribeIAMPolicyAssignment(DescribeIAMPolicyAssignmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIAMPolicyAssignment.</param>
        /// 
        /// <returns>Returns a  DescribeIAMPolicyAssignmentResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIAMPolicyAssignment">REST API Reference for DescribeIAMPolicyAssignment Operation</seealso>
        DescribeIAMPolicyAssignmentResponse EndDescribeIAMPolicyAssignment(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeIngestion


        /// <summary>
        /// Describes a SPICE ingestion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIngestion service method.</param>
        /// 
        /// <returns>The response from the DescribeIngestion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIngestion">REST API Reference for DescribeIngestion Operation</seealso>
        DescribeIngestionResponse DescribeIngestion(DescribeIngestionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIngestion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIngestion operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIngestion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIngestion">REST API Reference for DescribeIngestion Operation</seealso>
        IAsyncResult BeginDescribeIngestion(DescribeIngestionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIngestion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIngestion.</param>
        /// 
        /// <returns>Returns a  DescribeIngestionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIngestion">REST API Reference for DescribeIngestion Operation</seealso>
        DescribeIngestionResponse EndDescribeIngestion(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeIpRestriction


        /// <summary>
        /// Provides a summary and status of IP rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIpRestriction service method.</param>
        /// 
        /// <returns>The response from the DescribeIpRestriction service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIpRestriction">REST API Reference for DescribeIpRestriction Operation</seealso>
        DescribeIpRestrictionResponse DescribeIpRestriction(DescribeIpRestrictionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIpRestriction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIpRestriction operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIpRestriction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIpRestriction">REST API Reference for DescribeIpRestriction Operation</seealso>
        IAsyncResult BeginDescribeIpRestriction(DescribeIpRestrictionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIpRestriction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIpRestriction.</param>
        /// 
        /// <returns>Returns a  DescribeIpRestrictionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIpRestriction">REST API Reference for DescribeIpRestriction Operation</seealso>
        DescribeIpRestrictionResponse EndDescribeIpRestriction(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeKeyRegistration


        /// <summary>
        /// Describes all customer managed key registrations in a Quick Sight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyRegistration service method.</param>
        /// 
        /// <returns>The response from the DescribeKeyRegistration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeKeyRegistration">REST API Reference for DescribeKeyRegistration Operation</seealso>
        DescribeKeyRegistrationResponse DescribeKeyRegistration(DescribeKeyRegistrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKeyRegistration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyRegistration operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeKeyRegistration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeKeyRegistration">REST API Reference for DescribeKeyRegistration Operation</seealso>
        IAsyncResult BeginDescribeKeyRegistration(DescribeKeyRegistrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeKeyRegistration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeKeyRegistration.</param>
        /// 
        /// <returns>Returns a  DescribeKeyRegistrationResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeKeyRegistration">REST API Reference for DescribeKeyRegistration Operation</seealso>
        DescribeKeyRegistrationResponse EndDescribeKeyRegistration(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeNamespace


        /// <summary>
        /// Describes the current namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNamespace service method.</param>
        /// 
        /// <returns>The response from the DescribeNamespace service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeNamespace">REST API Reference for DescribeNamespace Operation</seealso>
        DescribeNamespaceResponse DescribeNamespace(DescribeNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNamespace operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeNamespace">REST API Reference for DescribeNamespace Operation</seealso>
        IAsyncResult BeginDescribeNamespace(DescribeNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNamespace.</param>
        /// 
        /// <returns>Returns a  DescribeNamespaceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeNamespace">REST API Reference for DescribeNamespace Operation</seealso>
        DescribeNamespaceResponse EndDescribeNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeQPersonalizationConfiguration


        /// <summary>
        /// Describes a personalization configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQPersonalizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeQPersonalizationConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeQPersonalizationConfiguration">REST API Reference for DescribeQPersonalizationConfiguration Operation</seealso>
        DescribeQPersonalizationConfigurationResponse DescribeQPersonalizationConfiguration(DescribeQPersonalizationConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeQPersonalizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeQPersonalizationConfiguration operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeQPersonalizationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeQPersonalizationConfiguration">REST API Reference for DescribeQPersonalizationConfiguration Operation</seealso>
        IAsyncResult BeginDescribeQPersonalizationConfiguration(DescribeQPersonalizationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeQPersonalizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeQPersonalizationConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeQPersonalizationConfigurationResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeQPersonalizationConfiguration">REST API Reference for DescribeQPersonalizationConfiguration Operation</seealso>
        DescribeQPersonalizationConfigurationResponse EndDescribeQPersonalizationConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeQuickSightQSearchConfiguration


        /// <summary>
        /// Describes the state of a Quick Sight Q Search configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQuickSightQSearchConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeQuickSightQSearchConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeQuickSightQSearchConfiguration">REST API Reference for DescribeQuickSightQSearchConfiguration Operation</seealso>
        DescribeQuickSightQSearchConfigurationResponse DescribeQuickSightQSearchConfiguration(DescribeQuickSightQSearchConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeQuickSightQSearchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeQuickSightQSearchConfiguration operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeQuickSightQSearchConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeQuickSightQSearchConfiguration">REST API Reference for DescribeQuickSightQSearchConfiguration Operation</seealso>
        IAsyncResult BeginDescribeQuickSightQSearchConfiguration(DescribeQuickSightQSearchConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeQuickSightQSearchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeQuickSightQSearchConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeQuickSightQSearchConfigurationResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeQuickSightQSearchConfiguration">REST API Reference for DescribeQuickSightQSearchConfiguration Operation</seealso>
        DescribeQuickSightQSearchConfigurationResponse EndDescribeQuickSightQSearchConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRefreshSchedule


        /// <summary>
        /// Provides a summary of a refresh schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRefreshSchedule service method.</param>
        /// 
        /// <returns>The response from the DescribeRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeRefreshSchedule">REST API Reference for DescribeRefreshSchedule Operation</seealso>
        DescribeRefreshScheduleResponse DescribeRefreshSchedule(DescribeRefreshScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRefreshSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRefreshSchedule operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRefreshSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeRefreshSchedule">REST API Reference for DescribeRefreshSchedule Operation</seealso>
        IAsyncResult BeginDescribeRefreshSchedule(DescribeRefreshScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRefreshSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRefreshSchedule.</param>
        /// 
        /// <returns>Returns a  DescribeRefreshScheduleResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeRefreshSchedule">REST API Reference for DescribeRefreshSchedule Operation</seealso>
        DescribeRefreshScheduleResponse EndDescribeRefreshSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRoleCustomPermission


        /// <summary>
        /// Describes all custom permissions that are mapped to a role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoleCustomPermission service method.</param>
        /// 
        /// <returns>The response from the DescribeRoleCustomPermission service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeRoleCustomPermission">REST API Reference for DescribeRoleCustomPermission Operation</seealso>
        DescribeRoleCustomPermissionResponse DescribeRoleCustomPermission(DescribeRoleCustomPermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRoleCustomPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoleCustomPermission operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRoleCustomPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeRoleCustomPermission">REST API Reference for DescribeRoleCustomPermission Operation</seealso>
        IAsyncResult BeginDescribeRoleCustomPermission(DescribeRoleCustomPermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRoleCustomPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRoleCustomPermission.</param>
        /// 
        /// <returns>Returns a  DescribeRoleCustomPermissionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeRoleCustomPermission">REST API Reference for DescribeRoleCustomPermission Operation</seealso>
        DescribeRoleCustomPermissionResponse EndDescribeRoleCustomPermission(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSelfUpgradeConfiguration


        /// <summary>
        /// Describes the self-upgrade configuration for a Quick Suite account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSelfUpgradeConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeSelfUpgradeConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterException">
        /// One or more parameter has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeSelfUpgradeConfiguration">REST API Reference for DescribeSelfUpgradeConfiguration Operation</seealso>
        DescribeSelfUpgradeConfigurationResponse DescribeSelfUpgradeConfiguration(DescribeSelfUpgradeConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSelfUpgradeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSelfUpgradeConfiguration operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSelfUpgradeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeSelfUpgradeConfiguration">REST API Reference for DescribeSelfUpgradeConfiguration Operation</seealso>
        IAsyncResult BeginDescribeSelfUpgradeConfiguration(DescribeSelfUpgradeConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSelfUpgradeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSelfUpgradeConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeSelfUpgradeConfigurationResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeSelfUpgradeConfiguration">REST API Reference for DescribeSelfUpgradeConfiguration Operation</seealso>
        DescribeSelfUpgradeConfigurationResponse EndDescribeSelfUpgradeConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTemplate


        /// <summary>
        /// Describes a template's metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplate service method.</param>
        /// 
        /// <returns>The response from the DescribeTemplate service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplate">REST API Reference for DescribeTemplate Operation</seealso>
        DescribeTemplateResponse DescribeTemplate(DescribeTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplate operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplate">REST API Reference for DescribeTemplate Operation</seealso>
        IAsyncResult BeginDescribeTemplate(DescribeTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTemplate.</param>
        /// 
        /// <returns>Returns a  DescribeTemplateResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplate">REST API Reference for DescribeTemplate Operation</seealso>
        DescribeTemplateResponse EndDescribeTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTemplateAlias


        /// <summary>
        /// Describes the template alias for a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplateAlias service method.</param>
        /// 
        /// <returns>The response from the DescribeTemplateAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplateAlias">REST API Reference for DescribeTemplateAlias Operation</seealso>
        DescribeTemplateAliasResponse DescribeTemplateAlias(DescribeTemplateAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplateAlias operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTemplateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplateAlias">REST API Reference for DescribeTemplateAlias Operation</seealso>
        IAsyncResult BeginDescribeTemplateAlias(DescribeTemplateAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTemplateAlias.</param>
        /// 
        /// <returns>Returns a  DescribeTemplateAliasResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplateAlias">REST API Reference for DescribeTemplateAlias Operation</seealso>
        DescribeTemplateAliasResponse EndDescribeTemplateAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTemplateDefinition


        /// <summary>
        /// Provides a detailed description of the definition of a template.
        /// 
        ///  <note> 
        /// <para>
        /// If you do not need to know details about the content of a template, for instance if
        /// you are trying to check the status of a recently created or updated template, use
        /// the <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DescribeTemplate.html">
        /// <c>DescribeTemplate</c> </a> instead. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplateDefinition service method.</param>
        /// 
        /// <returns>The response from the DescribeTemplateDefinition service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplateDefinition">REST API Reference for DescribeTemplateDefinition Operation</seealso>
        DescribeTemplateDefinitionResponse DescribeTemplateDefinition(DescribeTemplateDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTemplateDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplateDefinition operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTemplateDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplateDefinition">REST API Reference for DescribeTemplateDefinition Operation</seealso>
        IAsyncResult BeginDescribeTemplateDefinition(DescribeTemplateDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTemplateDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTemplateDefinition.</param>
        /// 
        /// <returns>Returns a  DescribeTemplateDefinitionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplateDefinition">REST API Reference for DescribeTemplateDefinition Operation</seealso>
        DescribeTemplateDefinitionResponse EndDescribeTemplateDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTemplatePermissions


        /// <summary>
        /// Describes read and write permissions on a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplatePermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeTemplatePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplatePermissions">REST API Reference for DescribeTemplatePermissions Operation</seealso>
        DescribeTemplatePermissionsResponse DescribeTemplatePermissions(DescribeTemplatePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTemplatePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplatePermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTemplatePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplatePermissions">REST API Reference for DescribeTemplatePermissions Operation</seealso>
        IAsyncResult BeginDescribeTemplatePermissions(DescribeTemplatePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTemplatePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTemplatePermissions.</param>
        /// 
        /// <returns>Returns a  DescribeTemplatePermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplatePermissions">REST API Reference for DescribeTemplatePermissions Operation</seealso>
        DescribeTemplatePermissionsResponse EndDescribeTemplatePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTheme


        /// <summary>
        /// Describes a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTheme service method.</param>
        /// 
        /// <returns>The response from the DescribeTheme service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTheme">REST API Reference for DescribeTheme Operation</seealso>
        DescribeThemeResponse DescribeTheme(DescribeThemeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTheme operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTheme operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTheme
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTheme">REST API Reference for DescribeTheme Operation</seealso>
        IAsyncResult BeginDescribeTheme(DescribeThemeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTheme operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTheme.</param>
        /// 
        /// <returns>Returns a  DescribeThemeResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTheme">REST API Reference for DescribeTheme Operation</seealso>
        DescribeThemeResponse EndDescribeTheme(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeThemeAlias


        /// <summary>
        /// Describes the alias for a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThemeAlias service method.</param>
        /// 
        /// <returns>The response from the DescribeThemeAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeThemeAlias">REST API Reference for DescribeThemeAlias Operation</seealso>
        DescribeThemeAliasResponse DescribeThemeAlias(DescribeThemeAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeThemeAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeThemeAlias operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeThemeAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeThemeAlias">REST API Reference for DescribeThemeAlias Operation</seealso>
        IAsyncResult BeginDescribeThemeAlias(DescribeThemeAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeThemeAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeThemeAlias.</param>
        /// 
        /// <returns>Returns a  DescribeThemeAliasResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeThemeAlias">REST API Reference for DescribeThemeAlias Operation</seealso>
        DescribeThemeAliasResponse EndDescribeThemeAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeThemePermissions


        /// <summary>
        /// Describes the read and write permissions for a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThemePermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeThemePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeThemePermissions">REST API Reference for DescribeThemePermissions Operation</seealso>
        DescribeThemePermissionsResponse DescribeThemePermissions(DescribeThemePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeThemePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeThemePermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeThemePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeThemePermissions">REST API Reference for DescribeThemePermissions Operation</seealso>
        IAsyncResult BeginDescribeThemePermissions(DescribeThemePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeThemePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeThemePermissions.</param>
        /// 
        /// <returns>Returns a  DescribeThemePermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeThemePermissions">REST API Reference for DescribeThemePermissions Operation</seealso>
        DescribeThemePermissionsResponse EndDescribeThemePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTopic


        /// <summary>
        /// Describes a topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopic service method.</param>
        /// 
        /// <returns>The response from the DescribeTopic service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTopic">REST API Reference for DescribeTopic Operation</seealso>
        DescribeTopicResponse DescribeTopic(DescribeTopicRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTopic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopic operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTopic
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTopic">REST API Reference for DescribeTopic Operation</seealso>
        IAsyncResult BeginDescribeTopic(DescribeTopicRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTopic operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTopic.</param>
        /// 
        /// <returns>Returns a  DescribeTopicResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTopic">REST API Reference for DescribeTopic Operation</seealso>
        DescribeTopicResponse EndDescribeTopic(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTopicPermissions


        /// <summary>
        /// Describes the permissions of a topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopicPermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeTopicPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTopicPermissions">REST API Reference for DescribeTopicPermissions Operation</seealso>
        DescribeTopicPermissionsResponse DescribeTopicPermissions(DescribeTopicPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTopicPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopicPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTopicPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTopicPermissions">REST API Reference for DescribeTopicPermissions Operation</seealso>
        IAsyncResult BeginDescribeTopicPermissions(DescribeTopicPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTopicPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTopicPermissions.</param>
        /// 
        /// <returns>Returns a  DescribeTopicPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTopicPermissions">REST API Reference for DescribeTopicPermissions Operation</seealso>
        DescribeTopicPermissionsResponse EndDescribeTopicPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTopicRefresh


        /// <summary>
        /// Describes the status of a topic refresh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopicRefresh service method.</param>
        /// 
        /// <returns>The response from the DescribeTopicRefresh service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTopicRefresh">REST API Reference for DescribeTopicRefresh Operation</seealso>
        DescribeTopicRefreshResponse DescribeTopicRefresh(DescribeTopicRefreshRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTopicRefresh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopicRefresh operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTopicRefresh
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTopicRefresh">REST API Reference for DescribeTopicRefresh Operation</seealso>
        IAsyncResult BeginDescribeTopicRefresh(DescribeTopicRefreshRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTopicRefresh operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTopicRefresh.</param>
        /// 
        /// <returns>Returns a  DescribeTopicRefreshResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTopicRefresh">REST API Reference for DescribeTopicRefresh Operation</seealso>
        DescribeTopicRefreshResponse EndDescribeTopicRefresh(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTopicRefreshSchedule


        /// <summary>
        /// Deletes a topic refresh schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopicRefreshSchedule service method.</param>
        /// 
        /// <returns>The response from the DescribeTopicRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTopicRefreshSchedule">REST API Reference for DescribeTopicRefreshSchedule Operation</seealso>
        DescribeTopicRefreshScheduleResponse DescribeTopicRefreshSchedule(DescribeTopicRefreshScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTopicRefreshSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopicRefreshSchedule operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTopicRefreshSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTopicRefreshSchedule">REST API Reference for DescribeTopicRefreshSchedule Operation</seealso>
        IAsyncResult BeginDescribeTopicRefreshSchedule(DescribeTopicRefreshScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTopicRefreshSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTopicRefreshSchedule.</param>
        /// 
        /// <returns>Returns a  DescribeTopicRefreshScheduleResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTopicRefreshSchedule">REST API Reference for DescribeTopicRefreshSchedule Operation</seealso>
        DescribeTopicRefreshScheduleResponse EndDescribeTopicRefreshSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeUser


        /// <summary>
        /// Returns information about a user, given the user name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        DescribeUserResponse DescribeUser(DescribeUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        IAsyncResult BeginDescribeUser(DescribeUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUser.</param>
        /// 
        /// <returns>Returns a  DescribeUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        DescribeUserResponse EndDescribeUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVPCConnection


        /// <summary>
        /// Describes a VPC connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVPCConnection service method.</param>
        /// 
        /// <returns>The response from the DescribeVPCConnection service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeVPCConnection">REST API Reference for DescribeVPCConnection Operation</seealso>
        DescribeVPCConnectionResponse DescribeVPCConnection(DescribeVPCConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVPCConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVPCConnection operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVPCConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeVPCConnection">REST API Reference for DescribeVPCConnection Operation</seealso>
        IAsyncResult BeginDescribeVPCConnection(DescribeVPCConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVPCConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVPCConnection.</param>
        /// 
        /// <returns>Returns a  DescribeVPCConnectionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeVPCConnection">REST API Reference for DescribeVPCConnection Operation</seealso>
        DescribeVPCConnectionResponse EndDescribeVPCConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  GenerateEmbedUrlForAnonymousUser


        /// <summary>
        /// Generates an embed URL that you can use to embed an Amazon Quick Suite dashboard or
        /// visual in your website, without having to register any reader users. Before you use
        /// this action, make sure that you have configured the dashboards and permissions.
        /// 
        ///  
        /// <para>
        /// The following rules apply to the generated URL:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It contains a temporary bearer token. It is valid for 5 minutes after it is generated.
        /// Once redeemed within this period, it cannot be re-used again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The URL validity period should not be confused with the actual session lifetime that
        /// can be customized using the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GenerateEmbedUrlForAnonymousUser.html#QS-GenerateEmbedUrlForAnonymousUser-request-SessionLifetimeInMinutes">SessionLifetimeInMinutes</a>
        /// </c> parameter. The resulting user session is valid for 15 minutes (minimum) to 10
        /// hours (maximum). The default session duration is 10 hours.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You are charged only when the URL is used or there is interaction with Amazon Quick
        /// Suite.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/embedded-analytics.html">Embedded
        /// Analytics</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the high-level steps for embedding and for an interactive
        /// demo of the ways you can customize embedding, visit the <a href="https://docs.aws.amazon.com/quicksight/latest/user/quicksight-dev-portal.html">Amazon
        /// Quick Suite Developer Portal</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateEmbedUrlForAnonymousUser service method.</param>
        /// 
        /// <returns>The response from the GenerateEmbedUrlForAnonymousUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.SessionLifetimeInMinutesInvalidException">
        /// The number of minutes specified for the lifetime of a session isn't valid. The session
        /// lifetime must be 15-600 minutes.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedPricingPlanException">
        /// This error indicates that you are calling an embedding operation in Amazon Quick Sight
        /// without the required pricing plan on your Amazon Web Services account. Before you
        /// can use embedding for anonymous users, a Quick Suite administrator needs to add capacity
        /// pricing to Quick Sight. You can do this on the <b>Manage Quick Suite</b> page. 
        /// 
        ///  
        /// <para>
        /// After capacity pricing is added, you can use the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GetDashboardEmbedUrl.html">GetDashboardEmbedUrl</a>
        /// </c> API operation with the <c>--identity-type ANONYMOUS</c> option.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GenerateEmbedUrlForAnonymousUser">REST API Reference for GenerateEmbedUrlForAnonymousUser Operation</seealso>
        GenerateEmbedUrlForAnonymousUserResponse GenerateEmbedUrlForAnonymousUser(GenerateEmbedUrlForAnonymousUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateEmbedUrlForAnonymousUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateEmbedUrlForAnonymousUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateEmbedUrlForAnonymousUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GenerateEmbedUrlForAnonymousUser">REST API Reference for GenerateEmbedUrlForAnonymousUser Operation</seealso>
        IAsyncResult BeginGenerateEmbedUrlForAnonymousUser(GenerateEmbedUrlForAnonymousUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateEmbedUrlForAnonymousUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateEmbedUrlForAnonymousUser.</param>
        /// 
        /// <returns>Returns a  GenerateEmbedUrlForAnonymousUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GenerateEmbedUrlForAnonymousUser">REST API Reference for GenerateEmbedUrlForAnonymousUser Operation</seealso>
        GenerateEmbedUrlForAnonymousUserResponse EndGenerateEmbedUrlForAnonymousUser(IAsyncResult asyncResult);

        #endregion
        
        #region  GenerateEmbedUrlForRegisteredUser


        /// <summary>
        /// Generates an embed URL that you can use to embed an Amazon Quick Suite experience
        /// in your website. This action can be used for any type of user registered in an Amazon
        /// Quick Suite account. Before you use this action, make sure that you have configured
        /// the relevant Amazon Quick Suite resource and permissions.
        /// 
        ///  
        /// <para>
        /// The following rules apply to the generated URL:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It contains a temporary bearer token. It is valid for 5 minutes after it is generated.
        /// Once redeemed within this period, it cannot be re-used again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The URL validity period should not be confused with the actual session lifetime that
        /// can be customized using the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GenerateEmbedUrlForRegisteredUser.html#QS-GenerateEmbedUrlForRegisteredUser-request-SessionLifetimeInMinutes">SessionLifetimeInMinutes</a>
        /// </c> parameter.
        /// </para>
        ///  
        /// <para>
        /// The resulting user session is valid for 15 minutes (minimum) to 10 hours (maximum).
        /// The default session duration is 10 hours.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You are charged only when the URL is used or there is interaction with Amazon Quick
        /// Suite.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/embedded-analytics.html">Embedded
        /// Analytics</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the high-level steps for embedding and for an interactive
        /// demo of the ways you can customize embedding, visit the <a href="https://docs.aws.amazon.com/quicksight/latest/user/quicksight-dev-portal.html">Amazon
        /// Quick Suite Developer Portal</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateEmbedUrlForRegisteredUser service method.</param>
        /// 
        /// <returns>The response from the GenerateEmbedUrlForRegisteredUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.QuickSightUserNotFoundException">
        /// The user with the provided name isn't found. This error can happen in any operation
        /// that requires finding a user based on a provided user name, such as <c>DeleteUser</c>,
        /// <c>DescribeUser</c>, and so on.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.SessionLifetimeInMinutesInvalidException">
        /// The number of minutes specified for the lifetime of a session isn't valid. The session
        /// lifetime must be 15-600 minutes.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedPricingPlanException">
        /// This error indicates that you are calling an embedding operation in Amazon Quick Sight
        /// without the required pricing plan on your Amazon Web Services account. Before you
        /// can use embedding for anonymous users, a Quick Suite administrator needs to add capacity
        /// pricing to Quick Sight. You can do this on the <b>Manage Quick Suite</b> page. 
        /// 
        ///  
        /// <para>
        /// After capacity pricing is added, you can use the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GetDashboardEmbedUrl.html">GetDashboardEmbedUrl</a>
        /// </c> API operation with the <c>--identity-type ANONYMOUS</c> option.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GenerateEmbedUrlForRegisteredUser">REST API Reference for GenerateEmbedUrlForRegisteredUser Operation</seealso>
        GenerateEmbedUrlForRegisteredUserResponse GenerateEmbedUrlForRegisteredUser(GenerateEmbedUrlForRegisteredUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateEmbedUrlForRegisteredUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateEmbedUrlForRegisteredUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateEmbedUrlForRegisteredUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GenerateEmbedUrlForRegisteredUser">REST API Reference for GenerateEmbedUrlForRegisteredUser Operation</seealso>
        IAsyncResult BeginGenerateEmbedUrlForRegisteredUser(GenerateEmbedUrlForRegisteredUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateEmbedUrlForRegisteredUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateEmbedUrlForRegisteredUser.</param>
        /// 
        /// <returns>Returns a  GenerateEmbedUrlForRegisteredUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GenerateEmbedUrlForRegisteredUser">REST API Reference for GenerateEmbedUrlForRegisteredUser Operation</seealso>
        GenerateEmbedUrlForRegisteredUserResponse EndGenerateEmbedUrlForRegisteredUser(IAsyncResult asyncResult);

        #endregion
        
        #region  GenerateEmbedUrlForRegisteredUserWithIdentity


        /// <summary>
        /// Generates an embed URL that you can use to embed an Amazon Quick Sight experience
        /// in your website. This action can be used for any type of user that is registered in
        /// an Amazon Quick Sight account that uses IAM Identity Center for authentication. This
        /// API requires <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-overview.html#types-identity-enhanced-iam-role-sessions">identity-enhanced
        /// IAM Role sessions</a> for the authenticated user that the API call is being made for.
        /// 
        ///  
        /// <para>
        /// This API uses <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation.html">trusted
        /// identity propagation</a> to ensure that an end user is authenticated and receives
        /// the embed URL that is specific to that user. The IAM Identity Center application that
        /// the user has logged into needs to have <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-using-customermanagedapps-specify-trusted-apps.html">trusted
        /// Identity Propagation enabled for Amazon Quick Sight</a> with the scope value set to
        /// <c>quicksight:read</c>. Before you use this action, make sure that you have configured
        /// the relevant Amazon Quick Sight resource and permissions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateEmbedUrlForRegisteredUserWithIdentity service method.</param>
        /// 
        /// <returns>The response from the GenerateEmbedUrlForRegisteredUserWithIdentity service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.QuickSightUserNotFoundException">
        /// The user with the provided name isn't found. This error can happen in any operation
        /// that requires finding a user based on a provided user name, such as <c>DeleteUser</c>,
        /// <c>DescribeUser</c>, and so on.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.SessionLifetimeInMinutesInvalidException">
        /// The number of minutes specified for the lifetime of a session isn't valid. The session
        /// lifetime must be 15-600 minutes.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedPricingPlanException">
        /// This error indicates that you are calling an embedding operation in Amazon Quick Sight
        /// without the required pricing plan on your Amazon Web Services account. Before you
        /// can use embedding for anonymous users, a Quick Suite administrator needs to add capacity
        /// pricing to Quick Sight. You can do this on the <b>Manage Quick Suite</b> page. 
        /// 
        ///  
        /// <para>
        /// After capacity pricing is added, you can use the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GetDashboardEmbedUrl.html">GetDashboardEmbedUrl</a>
        /// </c> API operation with the <c>--identity-type ANONYMOUS</c> option.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GenerateEmbedUrlForRegisteredUserWithIdentity">REST API Reference for GenerateEmbedUrlForRegisteredUserWithIdentity Operation</seealso>
        GenerateEmbedUrlForRegisteredUserWithIdentityResponse GenerateEmbedUrlForRegisteredUserWithIdentity(GenerateEmbedUrlForRegisteredUserWithIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateEmbedUrlForRegisteredUserWithIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateEmbedUrlForRegisteredUserWithIdentity operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateEmbedUrlForRegisteredUserWithIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GenerateEmbedUrlForRegisteredUserWithIdentity">REST API Reference for GenerateEmbedUrlForRegisteredUserWithIdentity Operation</seealso>
        IAsyncResult BeginGenerateEmbedUrlForRegisteredUserWithIdentity(GenerateEmbedUrlForRegisteredUserWithIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateEmbedUrlForRegisteredUserWithIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateEmbedUrlForRegisteredUserWithIdentity.</param>
        /// 
        /// <returns>Returns a  GenerateEmbedUrlForRegisteredUserWithIdentityResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GenerateEmbedUrlForRegisteredUserWithIdentity">REST API Reference for GenerateEmbedUrlForRegisteredUserWithIdentity Operation</seealso>
        GenerateEmbedUrlForRegisteredUserWithIdentityResponse EndGenerateEmbedUrlForRegisteredUserWithIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDashboardEmbedUrl


        /// <summary>
        /// Generates a temporary session URL and authorization code(bearer token) that you can
        /// use to embed an Amazon Quick Sight read-only dashboard in your website or application.
        /// Before you use this command, make sure that you have configured the dashboards and
        /// permissions. 
        /// 
        ///  
        /// <para>
        /// Currently, you can use <c>GetDashboardEmbedURL</c> only from the server, not from
        /// the user's browser. The following rules apply to the generated URL:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// They must be used together.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// They can be used one time only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// They are valid for 5 minutes after you run this command.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You are charged only when the URL is used or there is interaction with Quick Suite.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The resulting user session is valid for 15 minutes (default) up to 10 hours (maximum).
        /// You can use the optional <c>SessionLifetimeInMinutes</c> parameter to customize session
        /// duration.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/embedded-analytics-deprecated.html">Embedding
        /// Analytics Using GetDashboardEmbedUrl</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the high-level steps for embedding and for an interactive
        /// demo of the ways you can customize embedding, visit the <a href="https://docs.aws.amazon.com/quicksight/latest/user/quicksight-dev-portal.html">Amazon
        /// Quick Suite Developer Portal</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDashboardEmbedUrl service method.</param>
        /// 
        /// <returns>The response from the GetDashboardEmbedUrl service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.DomainNotWhitelistedException">
        /// The domain specified isn't on the allow list. All domains for embedded dashboards
        /// must be added to the approved list by an Amazon Quick Suite admin.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.IdentityTypeNotSupportedException">
        /// The identity type specified isn't supported. Supported identity types include <c>IAM</c>
        /// and <c>QUICKSIGHT</c>.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.QuickSightUserNotFoundException">
        /// The user with the provided name isn't found. This error can happen in any operation
        /// that requires finding a user based on a provided user name, such as <c>DeleteUser</c>,
        /// <c>DescribeUser</c>, and so on.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.SessionLifetimeInMinutesInvalidException">
        /// The number of minutes specified for the lifetime of a session isn't valid. The session
        /// lifetime must be 15-600 minutes.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedPricingPlanException">
        /// This error indicates that you are calling an embedding operation in Amazon Quick Sight
        /// without the required pricing plan on your Amazon Web Services account. Before you
        /// can use embedding for anonymous users, a Quick Suite administrator needs to add capacity
        /// pricing to Quick Sight. You can do this on the <b>Manage Quick Suite</b> page. 
        /// 
        ///  
        /// <para>
        /// After capacity pricing is added, you can use the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GetDashboardEmbedUrl.html">GetDashboardEmbedUrl</a>
        /// </c> API operation with the <c>--identity-type ANONYMOUS</c> option.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetDashboardEmbedUrl">REST API Reference for GetDashboardEmbedUrl Operation</seealso>
        GetDashboardEmbedUrlResponse GetDashboardEmbedUrl(GetDashboardEmbedUrlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDashboardEmbedUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDashboardEmbedUrl operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDashboardEmbedUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetDashboardEmbedUrl">REST API Reference for GetDashboardEmbedUrl Operation</seealso>
        IAsyncResult BeginGetDashboardEmbedUrl(GetDashboardEmbedUrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDashboardEmbedUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDashboardEmbedUrl.</param>
        /// 
        /// <returns>Returns a  GetDashboardEmbedUrlResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetDashboardEmbedUrl">REST API Reference for GetDashboardEmbedUrl Operation</seealso>
        GetDashboardEmbedUrlResponse EndGetDashboardEmbedUrl(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFlowMetadata


        /// <summary>
        /// Retrieves the metadata of a flow, not including its definition specifying the steps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFlowMetadata service method.</param>
        /// 
        /// <returns>The response from the GetFlowMetadata service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetFlowMetadata">REST API Reference for GetFlowMetadata Operation</seealso>
        GetFlowMetadataResponse GetFlowMetadata(GetFlowMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFlowMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFlowMetadata operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFlowMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetFlowMetadata">REST API Reference for GetFlowMetadata Operation</seealso>
        IAsyncResult BeginGetFlowMetadata(GetFlowMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFlowMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFlowMetadata.</param>
        /// 
        /// <returns>Returns a  GetFlowMetadataResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetFlowMetadata">REST API Reference for GetFlowMetadata Operation</seealso>
        GetFlowMetadataResponse EndGetFlowMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFlowPermissions


        /// <summary>
        /// Get permissions for a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFlowPermissions service method.</param>
        /// 
        /// <returns>The response from the GetFlowPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetFlowPermissions">REST API Reference for GetFlowPermissions Operation</seealso>
        GetFlowPermissionsResponse GetFlowPermissions(GetFlowPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFlowPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFlowPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFlowPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetFlowPermissions">REST API Reference for GetFlowPermissions Operation</seealso>
        IAsyncResult BeginGetFlowPermissions(GetFlowPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFlowPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFlowPermissions.</param>
        /// 
        /// <returns>Returns a  GetFlowPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetFlowPermissions">REST API Reference for GetFlowPermissions Operation</seealso>
        GetFlowPermissionsResponse EndGetFlowPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIdentityContext


        /// <summary>
        /// Retrieves the identity context for a Quick Sight user in a specified namespace, allowing
        /// you to obtain identity tokens that can be used with identity-enhanced IAM role sessions
        /// to call identity-aware APIs.
        /// 
        ///  
        /// <para>
        /// Currently, you can call the following APIs with identity-enhanced Credentials
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_StartDashboardSnapshotJob.html">StartDashboardSnapshotJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DescribeDashboardSnapshotJob.html">DescribeDashboardSnapshotJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DescribeDashboardSnapshotJobResult.html">DescribeDashboardSnapshotJobResult</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Supported Authentication Methods</b> 
        /// </para>
        ///  
        /// <para>
        /// This API supports Quick Sight native users, IAM federated users, and Active Directory
        /// users. For Quick Sight users authenticated by Amazon Web Services Identity Center,
        /// see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-identity-enhanced-iam-role-sessions.html">Identity
        /// Center documentation on identity-enhanced IAM role sessions</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Getting Identity-Enhanced Credentials</b> 
        /// </para>
        ///  
        /// <para>
        /// To obtain identity-enhanced credentials, follow these steps:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Call the GetIdentityContext API to retrieve an identity token for the specified user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the identity token with the <a href="https://docs.aws.amazon.com/STS/latest/APIReference/API_AssumeRole.html">STS
        /// AssumeRole API</a> to obtain identity-enhanced IAM role session credentials.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Usage with STS AssumeRole</b> 
        /// </para>
        ///  
        /// <para>
        /// The identity token returned by this API should be used with the STS AssumeRole API
        /// to obtain credentials for an identity-enhanced IAM role session. When calling AssumeRole,
        /// include the identity token in the <c>ProvidedContexts</c> parameter with <c>ProviderArn</c>
        /// set to <c>arn:aws:iam::aws:contextProvider/QuickSight</c> and <c>ContextAssertion</c>
        /// set to the identity token received from this API.
        /// </para>
        ///  
        /// <para>
        /// The assumed role must allow the <c>sts:SetContext</c> action in addition to <c>sts:AssumeRole</c>
        /// in its trust relationship policy. The trust policy should include both actions for
        /// the principal that will be assuming the role.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityContext service method.</param>
        /// 
        /// <returns>The response from the GetIdentityContext service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetIdentityContext">REST API Reference for GetIdentityContext Operation</seealso>
        GetIdentityContextResponse GetIdentityContext(GetIdentityContextRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityContext operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityContext operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdentityContext
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetIdentityContext">REST API Reference for GetIdentityContext Operation</seealso>
        IAsyncResult BeginGetIdentityContext(GetIdentityContextRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdentityContext operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityContext.</param>
        /// 
        /// <returns>Returns a  GetIdentityContextResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetIdentityContext">REST API Reference for GetIdentityContext Operation</seealso>
        GetIdentityContextResponse EndGetIdentityContext(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSessionEmbedUrl


        /// <summary>
        /// Generates a session URL and authorization code that you can use to embed the Amazon
        /// Amazon Quick Sight console in your web server code. Use <c>GetSessionEmbedUrl</c>
        /// where you want to provide an authoring portal that allows users to create data sources,
        /// datasets, analyses, and dashboards. The users who access an embedded Amazon Quick
        /// Sight console need belong to the author or admin security cohort. If you want to restrict
        /// permissions to some of these features, add a custom permissions profile to the user
        /// with the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_UpdateUser.html">UpdateUser</a>
        /// </c> API operation. Use <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_RegisterUser.html">RegisterUser</a>
        /// </c> API operation to add a new user with a custom permission profile attached. For
        /// more information, see the following sections in the <i>Amazon Quick Suite User Guide</i>:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/quicksight/latest/user/embedded-analytics.html">Embedding
        /// Analytics</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/quicksight/latest/user/customizing-permissions-to-the-quicksight-console.html">Customizing
        /// Access to the Amazon Quick Suite Console</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionEmbedUrl service method.</param>
        /// 
        /// <returns>The response from the GetSessionEmbedUrl service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.QuickSightUserNotFoundException">
        /// The user with the provided name isn't found. This error can happen in any operation
        /// that requires finding a user based on a provided user name, such as <c>DeleteUser</c>,
        /// <c>DescribeUser</c>, and so on.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.SessionLifetimeInMinutesInvalidException">
        /// The number of minutes specified for the lifetime of a session isn't valid. The session
        /// lifetime must be 15-600 minutes.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetSessionEmbedUrl">REST API Reference for GetSessionEmbedUrl Operation</seealso>
        GetSessionEmbedUrlResponse GetSessionEmbedUrl(GetSessionEmbedUrlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSessionEmbedUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSessionEmbedUrl operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSessionEmbedUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetSessionEmbedUrl">REST API Reference for GetSessionEmbedUrl Operation</seealso>
        IAsyncResult BeginGetSessionEmbedUrl(GetSessionEmbedUrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSessionEmbedUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSessionEmbedUrl.</param>
        /// 
        /// <returns>Returns a  GetSessionEmbedUrlResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetSessionEmbedUrl">REST API Reference for GetSessionEmbedUrl Operation</seealso>
        GetSessionEmbedUrlResponse EndGetSessionEmbedUrl(IAsyncResult asyncResult);

        #endregion
        
        #region  ListActionConnectors


        /// <summary>
        /// Lists all action connectors in the specified Amazon Web Services account. Returns
        /// summary information for each connector including its name, type, creation time, and
        /// status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActionConnectors service method.</param>
        /// 
        /// <returns>The response from the ListActionConnectors service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListActionConnectors">REST API Reference for ListActionConnectors Operation</seealso>
        ListActionConnectorsResponse ListActionConnectors(ListActionConnectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListActionConnectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActionConnectors operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListActionConnectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListActionConnectors">REST API Reference for ListActionConnectors Operation</seealso>
        IAsyncResult BeginListActionConnectors(ListActionConnectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListActionConnectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListActionConnectors.</param>
        /// 
        /// <returns>Returns a  ListActionConnectorsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListActionConnectors">REST API Reference for ListActionConnectors Operation</seealso>
        ListActionConnectorsResponse EndListActionConnectors(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAnalyses


        /// <summary>
        /// Lists Amazon Quick Sight analyses that exist in the specified Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnalyses service method.</param>
        /// 
        /// <returns>The response from the ListAnalyses service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListAnalyses">REST API Reference for ListAnalyses Operation</seealso>
        ListAnalysesResponse ListAnalyses(ListAnalysesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAnalyses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAnalyses operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAnalyses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListAnalyses">REST API Reference for ListAnalyses Operation</seealso>
        IAsyncResult BeginListAnalyses(ListAnalysesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAnalyses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAnalyses.</param>
        /// 
        /// <returns>Returns a  ListAnalysesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListAnalyses">REST API Reference for ListAnalyses Operation</seealso>
        ListAnalysesResponse EndListAnalyses(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssetBundleExportJobs


        /// <summary>
        /// Lists all asset bundle export jobs that have been taken place in the last 14 days.
        /// Jobs created more than 14 days ago are deleted forever and are not returned. If you
        /// are using the same job ID for multiple jobs, <c>ListAssetBundleExportJobs</c> only
        /// returns the most recent job that uses the repeated job ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetBundleExportJobs service method.</param>
        /// 
        /// <returns>The response from the ListAssetBundleExportJobs service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListAssetBundleExportJobs">REST API Reference for ListAssetBundleExportJobs Operation</seealso>
        ListAssetBundleExportJobsResponse ListAssetBundleExportJobs(ListAssetBundleExportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssetBundleExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssetBundleExportJobs operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssetBundleExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListAssetBundleExportJobs">REST API Reference for ListAssetBundleExportJobs Operation</seealso>
        IAsyncResult BeginListAssetBundleExportJobs(ListAssetBundleExportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssetBundleExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssetBundleExportJobs.</param>
        /// 
        /// <returns>Returns a  ListAssetBundleExportJobsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListAssetBundleExportJobs">REST API Reference for ListAssetBundleExportJobs Operation</seealso>
        ListAssetBundleExportJobsResponse EndListAssetBundleExportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssetBundleImportJobs


        /// <summary>
        /// Lists all asset bundle import jobs that have taken place in the last 14 days. Jobs
        /// created more than 14 days ago are deleted forever and are not returned. If you are
        /// using the same job ID for multiple jobs, <c>ListAssetBundleImportJobs</c> only returns
        /// the most recent job that uses the repeated job ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetBundleImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListAssetBundleImportJobs service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListAssetBundleImportJobs">REST API Reference for ListAssetBundleImportJobs Operation</seealso>
        ListAssetBundleImportJobsResponse ListAssetBundleImportJobs(ListAssetBundleImportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssetBundleImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssetBundleImportJobs operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssetBundleImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListAssetBundleImportJobs">REST API Reference for ListAssetBundleImportJobs Operation</seealso>
        IAsyncResult BeginListAssetBundleImportJobs(ListAssetBundleImportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssetBundleImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssetBundleImportJobs.</param>
        /// 
        /// <returns>Returns a  ListAssetBundleImportJobsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListAssetBundleImportJobs">REST API Reference for ListAssetBundleImportJobs Operation</seealso>
        ListAssetBundleImportJobsResponse EndListAssetBundleImportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBrands


        /// <summary>
        /// Lists all brands in an Quick Sight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrands service method.</param>
        /// 
        /// <returns>The response from the ListBrands service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListBrands">REST API Reference for ListBrands Operation</seealso>
        ListBrandsResponse ListBrands(ListBrandsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBrands operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBrands operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBrands
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListBrands">REST API Reference for ListBrands Operation</seealso>
        IAsyncResult BeginListBrands(ListBrandsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBrands operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBrands.</param>
        /// 
        /// <returns>Returns a  ListBrandsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListBrands">REST API Reference for ListBrands Operation</seealso>
        ListBrandsResponse EndListBrands(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCustomPermissions


        /// <summary>
        /// Returns a list of all the custom permissions profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomPermissions service method.</param>
        /// 
        /// <returns>The response from the ListCustomPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListCustomPermissions">REST API Reference for ListCustomPermissions Operation</seealso>
        ListCustomPermissionsResponse ListCustomPermissions(ListCustomPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListCustomPermissions">REST API Reference for ListCustomPermissions Operation</seealso>
        IAsyncResult BeginListCustomPermissions(ListCustomPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomPermissions.</param>
        /// 
        /// <returns>Returns a  ListCustomPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListCustomPermissions">REST API Reference for ListCustomPermissions Operation</seealso>
        ListCustomPermissionsResponse EndListCustomPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDashboards


        /// <summary>
        /// Lists dashboards in an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards service method.</param>
        /// 
        /// <returns>The response from the ListDashboards service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        ListDashboardsResponse ListDashboards(ListDashboardsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDashboards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDashboards
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        IAsyncResult BeginListDashboards(ListDashboardsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDashboards operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDashboards.</param>
        /// 
        /// <returns>Returns a  ListDashboardsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        ListDashboardsResponse EndListDashboards(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDashboardVersions


        /// <summary>
        /// Lists all the versions of the dashboards in the Amazon Quick Sight subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboardVersions service method.</param>
        /// 
        /// <returns>The response from the ListDashboardVersions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboardVersions">REST API Reference for ListDashboardVersions Operation</seealso>
        ListDashboardVersionsResponse ListDashboardVersions(ListDashboardVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDashboardVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDashboardVersions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDashboardVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboardVersions">REST API Reference for ListDashboardVersions Operation</seealso>
        IAsyncResult BeginListDashboardVersions(ListDashboardVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDashboardVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDashboardVersions.</param>
        /// 
        /// <returns>Returns a  ListDashboardVersionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboardVersions">REST API Reference for ListDashboardVersions Operation</seealso>
        ListDashboardVersionsResponse EndListDashboardVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataSets


        /// <summary>
        /// Lists all of the datasets belonging to the current Amazon Web Services account in
        /// an Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <c>arn:aws:quicksight:region:aws-account-id:dataset/*</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSets service method.</param>
        /// 
        /// <returns>The response from the ListDataSets service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        ListDataSetsResponse ListDataSets(ListDataSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSets operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        IAsyncResult BeginListDataSets(ListDataSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSets.</param>
        /// 
        /// <returns>Returns a  ListDataSetsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        ListDataSetsResponse EndListDataSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataSources


        /// <summary>
        /// Lists data sources in current Amazon Web Services Region that belong to this Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        IAsyncResult BeginListDataSources(ListDataSourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSources.</param>
        /// 
        /// <returns>Returns a  ListDataSourcesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        ListDataSourcesResponse EndListDataSources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFlows


        /// <summary>
        /// Lists flows in an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlows service method.</param>
        /// 
        /// <returns>The response from the ListFlows service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListFlows">REST API Reference for ListFlows Operation</seealso>
        ListFlowsResponse ListFlows(ListFlowsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFlows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFlows operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFlows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListFlows">REST API Reference for ListFlows Operation</seealso>
        IAsyncResult BeginListFlows(ListFlowsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFlows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFlows.</param>
        /// 
        /// <returns>Returns a  ListFlowsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListFlows">REST API Reference for ListFlows Operation</seealso>
        ListFlowsResponse EndListFlows(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFolderMembers


        /// <summary>
        /// List all assets (<c>DASHBOARD</c>, <c>ANALYSIS</c>, and <c>DATASET</c>) in a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFolderMembers service method.</param>
        /// 
        /// <returns>The response from the ListFolderMembers service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListFolderMembers">REST API Reference for ListFolderMembers Operation</seealso>
        ListFolderMembersResponse ListFolderMembers(ListFolderMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFolderMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFolderMembers operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFolderMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListFolderMembers">REST API Reference for ListFolderMembers Operation</seealso>
        IAsyncResult BeginListFolderMembers(ListFolderMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFolderMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFolderMembers.</param>
        /// 
        /// <returns>Returns a  ListFolderMembersResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListFolderMembers">REST API Reference for ListFolderMembers Operation</seealso>
        ListFolderMembersResponse EndListFolderMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFolders


        /// <summary>
        /// Lists all folders in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFolders service method.</param>
        /// 
        /// <returns>The response from the ListFolders service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListFolders">REST API Reference for ListFolders Operation</seealso>
        ListFoldersResponse ListFolders(ListFoldersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFolders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFolders operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFolders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListFolders">REST API Reference for ListFolders Operation</seealso>
        IAsyncResult BeginListFolders(ListFoldersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFolders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFolders.</param>
        /// 
        /// <returns>Returns a  ListFoldersResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListFolders">REST API Reference for ListFolders Operation</seealso>
        ListFoldersResponse EndListFolders(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFoldersForResource


        /// <summary>
        /// List all folders that a resource is a member of.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFoldersForResource service method.</param>
        /// 
        /// <returns>The response from the ListFoldersForResource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListFoldersForResource">REST API Reference for ListFoldersForResource Operation</seealso>
        ListFoldersForResourceResponse ListFoldersForResource(ListFoldersForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFoldersForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFoldersForResource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFoldersForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListFoldersForResource">REST API Reference for ListFoldersForResource Operation</seealso>
        IAsyncResult BeginListFoldersForResource(ListFoldersForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFoldersForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFoldersForResource.</param>
        /// 
        /// <returns>Returns a  ListFoldersForResourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListFoldersForResource">REST API Reference for ListFoldersForResource Operation</seealso>
        ListFoldersForResourceResponse EndListFoldersForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroupMemberships


        /// <summary>
        /// Lists member users in a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMemberships service method.</param>
        /// 
        /// <returns>The response from the ListGroupMemberships service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        ListGroupMembershipsResponse ListGroupMemberships(ListGroupMembershipsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupMemberships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMemberships operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupMemberships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        IAsyncResult BeginListGroupMemberships(ListGroupMembershipsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupMemberships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupMemberships.</param>
        /// 
        /// <returns>Returns a  ListGroupMembershipsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        ListGroupMembershipsResponse EndListGroupMemberships(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroups


        /// <summary>
        /// Lists all user groups in Amazon Quick Sight.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        IAsyncResult BeginListGroups(ListGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a  ListGroupsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse EndListGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIAMPolicyAssignments


        /// <summary>
        /// Lists the IAM policy assignments in the current Amazon Quick Sight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIAMPolicyAssignments service method.</param>
        /// 
        /// <returns>The response from the ListIAMPolicyAssignments service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignments">REST API Reference for ListIAMPolicyAssignments Operation</seealso>
        ListIAMPolicyAssignmentsResponse ListIAMPolicyAssignments(ListIAMPolicyAssignmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIAMPolicyAssignments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIAMPolicyAssignments operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIAMPolicyAssignments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignments">REST API Reference for ListIAMPolicyAssignments Operation</seealso>
        IAsyncResult BeginListIAMPolicyAssignments(ListIAMPolicyAssignmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIAMPolicyAssignments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIAMPolicyAssignments.</param>
        /// 
        /// <returns>Returns a  ListIAMPolicyAssignmentsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignments">REST API Reference for ListIAMPolicyAssignments Operation</seealso>
        ListIAMPolicyAssignmentsResponse EndListIAMPolicyAssignments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIAMPolicyAssignmentsForUser


        /// <summary>
        /// Lists all of the IAM policy assignments, including the Amazon Resource Names (ARNs),
        /// for the IAM policies assigned to the specified user and group, or groups that the
        /// user belongs to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIAMPolicyAssignmentsForUser service method.</param>
        /// 
        /// <returns>The response from the ListIAMPolicyAssignmentsForUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConcurrentUpdatingException">
        /// A resource is already in a state that indicates an operation is happening that must
        /// complete before a new update can be applied.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignmentsForUser">REST API Reference for ListIAMPolicyAssignmentsForUser Operation</seealso>
        ListIAMPolicyAssignmentsForUserResponse ListIAMPolicyAssignmentsForUser(ListIAMPolicyAssignmentsForUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIAMPolicyAssignmentsForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIAMPolicyAssignmentsForUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIAMPolicyAssignmentsForUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignmentsForUser">REST API Reference for ListIAMPolicyAssignmentsForUser Operation</seealso>
        IAsyncResult BeginListIAMPolicyAssignmentsForUser(ListIAMPolicyAssignmentsForUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIAMPolicyAssignmentsForUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIAMPolicyAssignmentsForUser.</param>
        /// 
        /// <returns>Returns a  ListIAMPolicyAssignmentsForUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignmentsForUser">REST API Reference for ListIAMPolicyAssignmentsForUser Operation</seealso>
        ListIAMPolicyAssignmentsForUserResponse EndListIAMPolicyAssignmentsForUser(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIdentityPropagationConfigs


        /// <summary>
        /// Lists all services and authorized targets that the Quick Sight IAM Identity Center
        /// application can access.
        /// 
        ///  
        /// <para>
        /// This operation is only supported for Quick Sight accounts that use IAM Identity Center.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPropagationConfigs service method.</param>
        /// 
        /// <returns>The response from the ListIdentityPropagationConfigs service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIdentityPropagationConfigs">REST API Reference for ListIdentityPropagationConfigs Operation</seealso>
        ListIdentityPropagationConfigsResponse ListIdentityPropagationConfigs(ListIdentityPropagationConfigsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityPropagationConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPropagationConfigs operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdentityPropagationConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIdentityPropagationConfigs">REST API Reference for ListIdentityPropagationConfigs Operation</seealso>
        IAsyncResult BeginListIdentityPropagationConfigs(ListIdentityPropagationConfigsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdentityPropagationConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdentityPropagationConfigs.</param>
        /// 
        /// <returns>Returns a  ListIdentityPropagationConfigsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIdentityPropagationConfigs">REST API Reference for ListIdentityPropagationConfigs Operation</seealso>
        ListIdentityPropagationConfigsResponse EndListIdentityPropagationConfigs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIngestions


        /// <summary>
        /// Lists the history of SPICE ingestions for a dataset. Limited to 5 TPS per user and
        /// 25 TPS per account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngestions service method.</param>
        /// 
        /// <returns>The response from the ListIngestions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIngestions">REST API Reference for ListIngestions Operation</seealso>
        ListIngestionsResponse ListIngestions(ListIngestionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIngestions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIngestions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIngestions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIngestions">REST API Reference for ListIngestions Operation</seealso>
        IAsyncResult BeginListIngestions(ListIngestionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIngestions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIngestions.</param>
        /// 
        /// <returns>Returns a  ListIngestionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIngestions">REST API Reference for ListIngestions Operation</seealso>
        ListIngestionsResponse EndListIngestions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNamespaces


        /// <summary>
        /// Lists the namespaces for the specified Amazon Web Services account. This operation
        /// doesn't list deleted namespaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces service method.</param>
        /// 
        /// <returns>The response from the ListNamespaces service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        ListNamespacesResponse ListNamespaces(ListNamespacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNamespaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNamespaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        IAsyncResult BeginListNamespaces(ListNamespacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNamespaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNamespaces.</param>
        /// 
        /// <returns>Returns a  ListNamespacesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        ListNamespacesResponse EndListNamespaces(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRefreshSchedules


        /// <summary>
        /// Lists the refresh schedules of a dataset. Each dataset can have up to 5 schedules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRefreshSchedules service method.</param>
        /// 
        /// <returns>The response from the ListRefreshSchedules service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListRefreshSchedules">REST API Reference for ListRefreshSchedules Operation</seealso>
        ListRefreshSchedulesResponse ListRefreshSchedules(ListRefreshSchedulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRefreshSchedules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRefreshSchedules operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRefreshSchedules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListRefreshSchedules">REST API Reference for ListRefreshSchedules Operation</seealso>
        IAsyncResult BeginListRefreshSchedules(ListRefreshSchedulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRefreshSchedules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRefreshSchedules.</param>
        /// 
        /// <returns>Returns a  ListRefreshSchedulesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListRefreshSchedules">REST API Reference for ListRefreshSchedules Operation</seealso>
        ListRefreshSchedulesResponse EndListRefreshSchedules(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRoleMemberships


        /// <summary>
        /// Lists all groups that are associated with a role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoleMemberships service method.</param>
        /// 
        /// <returns>The response from the ListRoleMemberships service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListRoleMemberships">REST API Reference for ListRoleMemberships Operation</seealso>
        ListRoleMembershipsResponse ListRoleMemberships(ListRoleMembershipsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoleMemberships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoleMemberships operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRoleMemberships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListRoleMemberships">REST API Reference for ListRoleMemberships Operation</seealso>
        IAsyncResult BeginListRoleMemberships(ListRoleMembershipsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRoleMemberships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoleMemberships.</param>
        /// 
        /// <returns>Returns a  ListRoleMembershipsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListRoleMemberships">REST API Reference for ListRoleMemberships Operation</seealso>
        ListRoleMembershipsResponse EndListRoleMemberships(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSelfUpgrades


        /// <summary>
        /// Lists all self-upgrade requests for a Quick Suite account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSelfUpgrades service method.</param>
        /// 
        /// <returns>The response from the ListSelfUpgrades service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListSelfUpgrades">REST API Reference for ListSelfUpgrades Operation</seealso>
        ListSelfUpgradesResponse ListSelfUpgrades(ListSelfUpgradesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSelfUpgrades operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSelfUpgrades operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSelfUpgrades
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListSelfUpgrades">REST API Reference for ListSelfUpgrades Operation</seealso>
        IAsyncResult BeginListSelfUpgrades(ListSelfUpgradesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSelfUpgrades operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSelfUpgrades.</param>
        /// 
        /// <returns>Returns a  ListSelfUpgradesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListSelfUpgrades">REST API Reference for ListSelfUpgrades Operation</seealso>
        ListSelfUpgradesResponse EndListSelfUpgrades(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags assigned to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTemplateAliases


        /// <summary>
        /// Lists all the aliases of a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateAliases service method.</param>
        /// 
        /// <returns>The response from the ListTemplateAliases service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateAliases">REST API Reference for ListTemplateAliases Operation</seealso>
        ListTemplateAliasesResponse ListTemplateAliases(ListTemplateAliasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplateAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateAliases operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplateAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateAliases">REST API Reference for ListTemplateAliases Operation</seealso>
        IAsyncResult BeginListTemplateAliases(ListTemplateAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplateAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplateAliases.</param>
        /// 
        /// <returns>Returns a  ListTemplateAliasesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateAliases">REST API Reference for ListTemplateAliases Operation</seealso>
        ListTemplateAliasesResponse EndListTemplateAliases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTemplates


        /// <summary>
        /// Lists all the templates in the current Amazon Quick Sight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        ListTemplatesResponse ListTemplates(ListTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        IAsyncResult BeginListTemplates(ListTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplates.</param>
        /// 
        /// <returns>Returns a  ListTemplatesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        ListTemplatesResponse EndListTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTemplateVersions


        /// <summary>
        /// Lists all the versions of the templates in the current Amazon Quick Sight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateVersions service method.</param>
        /// 
        /// <returns>The response from the ListTemplateVersions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateVersions">REST API Reference for ListTemplateVersions Operation</seealso>
        ListTemplateVersionsResponse ListTemplateVersions(ListTemplateVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateVersions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplateVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateVersions">REST API Reference for ListTemplateVersions Operation</seealso>
        IAsyncResult BeginListTemplateVersions(ListTemplateVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplateVersions.</param>
        /// 
        /// <returns>Returns a  ListTemplateVersionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateVersions">REST API Reference for ListTemplateVersions Operation</seealso>
        ListTemplateVersionsResponse EndListTemplateVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListThemeAliases


        /// <summary>
        /// Lists all the aliases of a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThemeAliases service method.</param>
        /// 
        /// <returns>The response from the ListThemeAliases service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListThemeAliases">REST API Reference for ListThemeAliases Operation</seealso>
        ListThemeAliasesResponse ListThemeAliases(ListThemeAliasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListThemeAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThemeAliases operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListThemeAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListThemeAliases">REST API Reference for ListThemeAliases Operation</seealso>
        IAsyncResult BeginListThemeAliases(ListThemeAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListThemeAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListThemeAliases.</param>
        /// 
        /// <returns>Returns a  ListThemeAliasesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListThemeAliases">REST API Reference for ListThemeAliases Operation</seealso>
        ListThemeAliasesResponse EndListThemeAliases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListThemes


        /// <summary>
        /// Lists all the themes in the current Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThemes service method.</param>
        /// 
        /// <returns>The response from the ListThemes service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListThemes">REST API Reference for ListThemes Operation</seealso>
        ListThemesResponse ListThemes(ListThemesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListThemes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThemes operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListThemes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListThemes">REST API Reference for ListThemes Operation</seealso>
        IAsyncResult BeginListThemes(ListThemesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListThemes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListThemes.</param>
        /// 
        /// <returns>Returns a  ListThemesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListThemes">REST API Reference for ListThemes Operation</seealso>
        ListThemesResponse EndListThemes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListThemeVersions


        /// <summary>
        /// Lists all the versions of the themes in the current Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThemeVersions service method.</param>
        /// 
        /// <returns>The response from the ListThemeVersions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListThemeVersions">REST API Reference for ListThemeVersions Operation</seealso>
        ListThemeVersionsResponse ListThemeVersions(ListThemeVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListThemeVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThemeVersions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListThemeVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListThemeVersions">REST API Reference for ListThemeVersions Operation</seealso>
        IAsyncResult BeginListThemeVersions(ListThemeVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListThemeVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListThemeVersions.</param>
        /// 
        /// <returns>Returns a  ListThemeVersionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListThemeVersions">REST API Reference for ListThemeVersions Operation</seealso>
        ListThemeVersionsResponse EndListThemeVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTopicRefreshSchedules


        /// <summary>
        /// Lists all of the refresh schedules for a topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopicRefreshSchedules service method.</param>
        /// 
        /// <returns>The response from the ListTopicRefreshSchedules service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTopicRefreshSchedules">REST API Reference for ListTopicRefreshSchedules Operation</seealso>
        ListTopicRefreshSchedulesResponse ListTopicRefreshSchedules(ListTopicRefreshSchedulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTopicRefreshSchedules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTopicRefreshSchedules operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTopicRefreshSchedules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTopicRefreshSchedules">REST API Reference for ListTopicRefreshSchedules Operation</seealso>
        IAsyncResult BeginListTopicRefreshSchedules(ListTopicRefreshSchedulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTopicRefreshSchedules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTopicRefreshSchedules.</param>
        /// 
        /// <returns>Returns a  ListTopicRefreshSchedulesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTopicRefreshSchedules">REST API Reference for ListTopicRefreshSchedules Operation</seealso>
        ListTopicRefreshSchedulesResponse EndListTopicRefreshSchedules(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTopicReviewedAnswers


        /// <summary>
        /// Lists all reviewed answers for a Q Topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopicReviewedAnswers service method.</param>
        /// 
        /// <returns>The response from the ListTopicReviewedAnswers service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTopicReviewedAnswers">REST API Reference for ListTopicReviewedAnswers Operation</seealso>
        ListTopicReviewedAnswersResponse ListTopicReviewedAnswers(ListTopicReviewedAnswersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTopicReviewedAnswers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTopicReviewedAnswers operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTopicReviewedAnswers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTopicReviewedAnswers">REST API Reference for ListTopicReviewedAnswers Operation</seealso>
        IAsyncResult BeginListTopicReviewedAnswers(ListTopicReviewedAnswersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTopicReviewedAnswers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTopicReviewedAnswers.</param>
        /// 
        /// <returns>Returns a  ListTopicReviewedAnswersResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTopicReviewedAnswers">REST API Reference for ListTopicReviewedAnswers Operation</seealso>
        ListTopicReviewedAnswersResponse EndListTopicReviewedAnswers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTopics


        /// <summary>
        /// Lists all of the topics within an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopics service method.</param>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTopics">REST API Reference for ListTopics Operation</seealso>
        ListTopicsResponse ListTopics(ListTopicsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTopics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTopics operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTopics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTopics">REST API Reference for ListTopics Operation</seealso>
        IAsyncResult BeginListTopics(ListTopicsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTopics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTopics.</param>
        /// 
        /// <returns>Returns a  ListTopicsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTopics">REST API Reference for ListTopics Operation</seealso>
        ListTopicsResponse EndListTopics(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUserGroups


        /// <summary>
        /// Lists the Amazon Quick Sight groups that an Amazon Quick Sight user is a member of.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserGroups service method.</param>
        /// 
        /// <returns>The response from the ListUserGroups service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUserGroups">REST API Reference for ListUserGroups Operation</seealso>
        ListUserGroupsResponse ListUserGroups(ListUserGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserGroups operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUserGroups">REST API Reference for ListUserGroups Operation</seealso>
        IAsyncResult BeginListUserGroups(ListUserGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserGroups.</param>
        /// 
        /// <returns>Returns a  ListUserGroupsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUserGroups">REST API Reference for ListUserGroups Operation</seealso>
        ListUserGroupsResponse EndListUserGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUsers


        /// <summary>
        /// Returns a list of all of the Amazon Quick Sight users belonging to this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse ListUsers(ListUsersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        IAsyncResult BeginListUsers(ListUsersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsers.</param>
        /// 
        /// <returns>Returns a  ListUsersResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse EndListUsers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVPCConnections


        /// <summary>
        /// Lists all of the VPC connections in the current set Amazon Web Services Region of
        /// an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVPCConnections service method.</param>
        /// 
        /// <returns>The response from the ListVPCConnections service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListVPCConnections">REST API Reference for ListVPCConnections Operation</seealso>
        ListVPCConnectionsResponse ListVPCConnections(ListVPCConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVPCConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVPCConnections operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVPCConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListVPCConnections">REST API Reference for ListVPCConnections Operation</seealso>
        IAsyncResult BeginListVPCConnections(ListVPCConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVPCConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVPCConnections.</param>
        /// 
        /// <returns>Returns a  ListVPCConnectionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListVPCConnections">REST API Reference for ListVPCConnections Operation</seealso>
        ListVPCConnectionsResponse EndListVPCConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  PredictQAResults


        /// <summary>
        /// Predicts existing visuals or generates new visuals to answer a given query.
        /// 
        ///  
        /// <para>
        /// This API uses <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation.html">trusted
        /// identity propagation</a> to ensure that an end user is authenticated and receives
        /// the embed URL that is specific to that user. The IAM Identity Center application that
        /// the user has logged into needs to have <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-using-customermanagedapps-specify-trusted-apps.html">trusted
        /// Identity Propagation enabled for Quick Suite</a> with the scope value set to <c>quicksight:read</c>.
        /// Before you use this action, make sure that you have configured the relevant Quick
        /// Suite resource and permissions.
        /// </para>
        ///  
        /// <para>
        /// We recommend enabling the <c>QSearchStatus</c> API to unlock the full potential of
        /// <c>PredictQnA</c>. When <c>QSearchStatus</c> is enabled, it first checks the specified
        /// dashboard for any existing visuals that match the question. If no matching visuals
        /// are found, <c>PredictQnA</c> uses generative Q&amp;A to provide an answer. To update
        /// the <c>QSearchStatus</c>, see <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_UpdateQuickSightQSearchConfiguration.html">UpdateQuickSightQSearchConfiguration</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PredictQAResults service method.</param>
        /// 
        /// <returns>The response from the PredictQAResults service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/PredictQAResults">REST API Reference for PredictQAResults Operation</seealso>
        PredictQAResultsResponse PredictQAResults(PredictQAResultsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PredictQAResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PredictQAResults operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPredictQAResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/PredictQAResults">REST API Reference for PredictQAResults Operation</seealso>
        IAsyncResult BeginPredictQAResults(PredictQAResultsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PredictQAResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPredictQAResults.</param>
        /// 
        /// <returns>Returns a  PredictQAResultsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/PredictQAResults">REST API Reference for PredictQAResults Operation</seealso>
        PredictQAResultsResponse EndPredictQAResults(IAsyncResult asyncResult);

        #endregion
        
        #region  PutDataSetRefreshProperties


        /// <summary>
        /// Creates or updates the dataset refresh properties for the dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDataSetRefreshProperties service method.</param>
        /// 
        /// <returns>The response from the PutDataSetRefreshProperties service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/PutDataSetRefreshProperties">REST API Reference for PutDataSetRefreshProperties Operation</seealso>
        PutDataSetRefreshPropertiesResponse PutDataSetRefreshProperties(PutDataSetRefreshPropertiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutDataSetRefreshProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDataSetRefreshProperties operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDataSetRefreshProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/PutDataSetRefreshProperties">REST API Reference for PutDataSetRefreshProperties Operation</seealso>
        IAsyncResult BeginPutDataSetRefreshProperties(PutDataSetRefreshPropertiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutDataSetRefreshProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDataSetRefreshProperties.</param>
        /// 
        /// <returns>Returns a  PutDataSetRefreshPropertiesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/PutDataSetRefreshProperties">REST API Reference for PutDataSetRefreshProperties Operation</seealso>
        PutDataSetRefreshPropertiesResponse EndPutDataSetRefreshProperties(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterUser


        /// <summary>
        /// Creates an Amazon Quick Sight user whose identity is associated with the Identity
        /// and Access Management (IAM) identity or role specified in the request. When you register
        /// a new user from the Quick Sight API, Quick Sight generates a registration URL. The
        /// user accesses this registration URL to create their account. Quick Sight doesn't send
        /// a registration email to users who are registered from the Quick Sight API. If you
        /// want new users to receive a registration email, then add those users in the Quick
        /// Sight console. For more information on registering a new user in the Quick Sight console,
        /// see <a href="https://docs.aws.amazon.com/quicksight/latest/user/managing-users.html#inviting-users">
        /// Inviting users to access Quick Sight</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterUser service method.</param>
        /// 
        /// <returns>The response from the RegisterUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RegisterUser">REST API Reference for RegisterUser Operation</seealso>
        RegisterUserResponse RegisterUser(RegisterUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RegisterUser">REST API Reference for RegisterUser Operation</seealso>
        IAsyncResult BeginRegisterUser(RegisterUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterUser.</param>
        /// 
        /// <returns>Returns a  RegisterUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RegisterUser">REST API Reference for RegisterUser Operation</seealso>
        RegisterUserResponse EndRegisterUser(IAsyncResult asyncResult);

        #endregion
        
        #region  RestoreAnalysis


        /// <summary>
        /// Restores an analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreAnalysis service method.</param>
        /// 
        /// <returns>The response from the RestoreAnalysis service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RestoreAnalysis">REST API Reference for RestoreAnalysis Operation</seealso>
        RestoreAnalysisResponse RestoreAnalysis(RestoreAnalysisRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreAnalysis operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RestoreAnalysis">REST API Reference for RestoreAnalysis Operation</seealso>
        IAsyncResult BeginRestoreAnalysis(RestoreAnalysisRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreAnalysis.</param>
        /// 
        /// <returns>Returns a  RestoreAnalysisResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RestoreAnalysis">REST API Reference for RestoreAnalysis Operation</seealso>
        RestoreAnalysisResponse EndRestoreAnalysis(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchActionConnectors


        /// <summary>
        /// Searches for action connectors in the specified Amazon Web Services account using
        /// filters. You can search by connector name, type, or user permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchActionConnectors service method.</param>
        /// 
        /// <returns>The response from the SearchActionConnectors service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchActionConnectors">REST API Reference for SearchActionConnectors Operation</seealso>
        SearchActionConnectorsResponse SearchActionConnectors(SearchActionConnectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchActionConnectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchActionConnectors operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchActionConnectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchActionConnectors">REST API Reference for SearchActionConnectors Operation</seealso>
        IAsyncResult BeginSearchActionConnectors(SearchActionConnectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchActionConnectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchActionConnectors.</param>
        /// 
        /// <returns>Returns a  SearchActionConnectorsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchActionConnectors">REST API Reference for SearchActionConnectors Operation</seealso>
        SearchActionConnectorsResponse EndSearchActionConnectors(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchAnalyses


        /// <summary>
        /// Searches for analyses that belong to the user specified in the filter.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchAnalyses service method.</param>
        /// 
        /// <returns>The response from the SearchAnalyses service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchAnalyses">REST API Reference for SearchAnalyses Operation</seealso>
        SearchAnalysesResponse SearchAnalyses(SearchAnalysesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchAnalyses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchAnalyses operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchAnalyses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchAnalyses">REST API Reference for SearchAnalyses Operation</seealso>
        IAsyncResult BeginSearchAnalyses(SearchAnalysesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchAnalyses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchAnalyses.</param>
        /// 
        /// <returns>Returns a  SearchAnalysesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchAnalyses">REST API Reference for SearchAnalyses Operation</seealso>
        SearchAnalysesResponse EndSearchAnalyses(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchDashboards


        /// <summary>
        /// Searches for dashboards that belong to a user. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDashboards service method.</param>
        /// 
        /// <returns>The response from the SearchDashboards service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchDashboards">REST API Reference for SearchDashboards Operation</seealso>
        SearchDashboardsResponse SearchDashboards(SearchDashboardsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchDashboards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchDashboards operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchDashboards
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchDashboards">REST API Reference for SearchDashboards Operation</seealso>
        IAsyncResult BeginSearchDashboards(SearchDashboardsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchDashboards operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchDashboards.</param>
        /// 
        /// <returns>Returns a  SearchDashboardsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchDashboards">REST API Reference for SearchDashboards Operation</seealso>
        SearchDashboardsResponse EndSearchDashboards(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchDataSets


        /// <summary>
        /// Use the <c>SearchDataSets</c> operation to search for datasets that belong to an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDataSets service method.</param>
        /// 
        /// <returns>The response from the SearchDataSets service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchDataSets">REST API Reference for SearchDataSets Operation</seealso>
        SearchDataSetsResponse SearchDataSets(SearchDataSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchDataSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchDataSets operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchDataSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchDataSets">REST API Reference for SearchDataSets Operation</seealso>
        IAsyncResult BeginSearchDataSets(SearchDataSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchDataSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchDataSets.</param>
        /// 
        /// <returns>Returns a  SearchDataSetsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchDataSets">REST API Reference for SearchDataSets Operation</seealso>
        SearchDataSetsResponse EndSearchDataSets(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchDataSources


        /// <summary>
        /// Use the <c>SearchDataSources</c> operation to search for data sources that belong
        /// to an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDataSources service method.</param>
        /// 
        /// <returns>The response from the SearchDataSources service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchDataSources">REST API Reference for SearchDataSources Operation</seealso>
        SearchDataSourcesResponse SearchDataSources(SearchDataSourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchDataSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchDataSources operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchDataSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchDataSources">REST API Reference for SearchDataSources Operation</seealso>
        IAsyncResult BeginSearchDataSources(SearchDataSourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchDataSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchDataSources.</param>
        /// 
        /// <returns>Returns a  SearchDataSourcesResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchDataSources">REST API Reference for SearchDataSources Operation</seealso>
        SearchDataSourcesResponse EndSearchDataSources(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchFlows


        /// <summary>
        /// Search for the flows in an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFlows service method.</param>
        /// 
        /// <returns>The response from the SearchFlows service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchFlows">REST API Reference for SearchFlows Operation</seealso>
        SearchFlowsResponse SearchFlows(SearchFlowsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchFlows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchFlows operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchFlows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchFlows">REST API Reference for SearchFlows Operation</seealso>
        IAsyncResult BeginSearchFlows(SearchFlowsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchFlows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchFlows.</param>
        /// 
        /// <returns>Returns a  SearchFlowsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchFlows">REST API Reference for SearchFlows Operation</seealso>
        SearchFlowsResponse EndSearchFlows(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchFolders


        /// <summary>
        /// Searches the subfolders in a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFolders service method.</param>
        /// 
        /// <returns>The response from the SearchFolders service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchFolders">REST API Reference for SearchFolders Operation</seealso>
        SearchFoldersResponse SearchFolders(SearchFoldersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchFolders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchFolders operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchFolders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchFolders">REST API Reference for SearchFolders Operation</seealso>
        IAsyncResult BeginSearchFolders(SearchFoldersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchFolders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchFolders.</param>
        /// 
        /// <returns>Returns a  SearchFoldersResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchFolders">REST API Reference for SearchFolders Operation</seealso>
        SearchFoldersResponse EndSearchFolders(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchGroups


        /// <summary>
        /// Use the <c>SearchGroups</c> operation to search groups in a specified Quick Sight
        /// namespace using the supplied filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchGroups service method.</param>
        /// 
        /// <returns>The response from the SearchGroups service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchGroups">REST API Reference for SearchGroups Operation</seealso>
        SearchGroupsResponse SearchGroups(SearchGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchGroups operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchGroups">REST API Reference for SearchGroups Operation</seealso>
        IAsyncResult BeginSearchGroups(SearchGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchGroups.</param>
        /// 
        /// <returns>Returns a  SearchGroupsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchGroups">REST API Reference for SearchGroups Operation</seealso>
        SearchGroupsResponse EndSearchGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchTopics


        /// <summary>
        /// Searches for any Q topic that exists in an Quick Suite account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTopics service method.</param>
        /// 
        /// <returns>The response from the SearchTopics service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchTopics">REST API Reference for SearchTopics Operation</seealso>
        SearchTopicsResponse SearchTopics(SearchTopicsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchTopics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchTopics operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchTopics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchTopics">REST API Reference for SearchTopics Operation</seealso>
        IAsyncResult BeginSearchTopics(SearchTopicsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchTopics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchTopics.</param>
        /// 
        /// <returns>Returns a  SearchTopicsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchTopics">REST API Reference for SearchTopics Operation</seealso>
        SearchTopicsResponse EndSearchTopics(IAsyncResult asyncResult);

        #endregion
        
        #region  StartAssetBundleExportJob


        /// <summary>
        /// Starts an Asset Bundle export job.
        /// 
        ///  
        /// <para>
        /// An Asset Bundle export job exports specified Amazon Quick Sight assets. You can also
        /// choose to export any asset dependencies in the same job. Export jobs run asynchronously
        /// and can be polled with a <c>DescribeAssetBundleExportJob</c> API call. When a job
        /// is successfully completed, a download URL that contains the exported assets is returned.
        /// The URL is valid for 5 minutes and can be refreshed with a <c>DescribeAssetBundleExportJob</c>
        /// API call. Each Amazon Quick Sight account can run up to 5 export jobs concurrently.
        /// </para>
        ///  
        /// <para>
        /// The API caller must have the necessary permissions in their IAM role to access each
        /// resource before the resources can be exported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssetBundleExportJob service method.</param>
        /// 
        /// <returns>The response from the StartAssetBundleExportJob service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/StartAssetBundleExportJob">REST API Reference for StartAssetBundleExportJob Operation</seealso>
        StartAssetBundleExportJobResponse StartAssetBundleExportJob(StartAssetBundleExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartAssetBundleExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAssetBundleExportJob operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAssetBundleExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/StartAssetBundleExportJob">REST API Reference for StartAssetBundleExportJob Operation</seealso>
        IAsyncResult BeginStartAssetBundleExportJob(StartAssetBundleExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartAssetBundleExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAssetBundleExportJob.</param>
        /// 
        /// <returns>Returns a  StartAssetBundleExportJobResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/StartAssetBundleExportJob">REST API Reference for StartAssetBundleExportJob Operation</seealso>
        StartAssetBundleExportJobResponse EndStartAssetBundleExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartAssetBundleImportJob


        /// <summary>
        /// Starts an Asset Bundle import job.
        /// 
        ///  
        /// <para>
        /// An Asset Bundle import job imports specified Amazon Quick Sight assets into an Amazon
        /// Quick Sight account. You can also choose to import a naming prefix and specified configuration
        /// overrides. The assets that are contained in the bundle file that you provide are used
        /// to create or update a new or existing asset in your Amazon Quick Sight account. Each
        /// Amazon Quick Sight account can run up to 5 import jobs concurrently.
        /// </para>
        ///  
        /// <para>
        /// The API caller must have the necessary <c>"create"</c>, <c>"describe"</c>, and <c>"update"</c>
        /// permissions in their IAM role to access each resource type that is contained in the
        /// bundle file before the resources can be imported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssetBundleImportJob service method.</param>
        /// 
        /// <returns>The response from the StartAssetBundleImportJob service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/StartAssetBundleImportJob">REST API Reference for StartAssetBundleImportJob Operation</seealso>
        StartAssetBundleImportJobResponse StartAssetBundleImportJob(StartAssetBundleImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartAssetBundleImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAssetBundleImportJob operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAssetBundleImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/StartAssetBundleImportJob">REST API Reference for StartAssetBundleImportJob Operation</seealso>
        IAsyncResult BeginStartAssetBundleImportJob(StartAssetBundleImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartAssetBundleImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAssetBundleImportJob.</param>
        /// 
        /// <returns>Returns a  StartAssetBundleImportJobResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/StartAssetBundleImportJob">REST API Reference for StartAssetBundleImportJob Operation</seealso>
        StartAssetBundleImportJobResponse EndStartAssetBundleImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartDashboardSnapshotJob


        /// <summary>
        /// Starts an asynchronous job that generates a snapshot of a dashboard's output. You
        /// can request one or several of the following format configurations in each API call.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// 1 Paginated PDF
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1 Excel workbook that includes up to 5 table or pivot table visuals
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 5 CSVs from table or pivot table visuals
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The status of a submitted job can be polled with the <c>DescribeDashboardSnapshotJob</c>
        /// API. When you call the <c>DescribeDashboardSnapshotJob</c> API, check the <c>JobStatus</c>
        /// field in the response. Once the job reaches a <c>COMPLETED</c> or <c>FAILED</c> status,
        /// use the <c>DescribeDashboardSnapshotJobResult</c> API to obtain the URLs for the generated
        /// files. If the job fails, the <c>DescribeDashboardSnapshotJobResult</c> API returns
        /// detailed information about the error that occurred.
        /// </para>
        ///  
        /// <para>
        ///  <b>StartDashboardSnapshotJob API throttling</b> 
        /// </para>
        ///  
        /// <para>
        /// Quick Sight utilizes API throttling to create a more consistent user experience within
        /// a time span for customers when they call the <c>StartDashboardSnapshotJob</c>. By
        /// default, 12 jobs can run simlutaneously in one Amazon Web Services account and users
        /// can submit up 10 API requests per second before an account is throttled. If an overwhelming
        /// number of API requests are made by the same user in a short period of time, Quick
        /// Sight throttles the API calls to maintin an optimal experience and reliability for
        /// all Quick Sight users.
        /// </para>
        ///  
        /// <para>
        ///  <b>Common throttling scenarios</b> 
        /// </para>
        ///  
        /// <para>
        /// The following list provides information about the most commin throttling scenarios
        /// that can occur.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>A large number of <c>SnapshotExport</c> API jobs are running simultaneously on
        /// an Amazon Web Services account.</b> When a new <c>StartDashboardSnapshotJob</c> is
        /// created and there are already 12 jobs with the <c>RUNNING</c> status, the new job
        /// request fails and returns a <c>LimitExceededException</c> error. Wait for a current
        /// job to comlpete before you resubmit the new job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>A large number of API requests are submitted on an Amazon Web Services account.</b>
        /// When a user makes more than 10 API calls to the Quick Sight API in one second, a <c>ThrottlingException</c>
        /// is returned.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If your use case requires a higher throttling limit, contact your account admin or
        /// <a href="http://aws.amazon.com/contact-us/">Amazon Web ServicesSupport</a> to explore
        /// options to tailor a more optimal expereince for your account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Best practices to handle throttling</b> 
        /// </para>
        ///  
        /// <para>
        /// If your use case projects high levels of API traffic, try to reduce the degree of
        /// frequency and parallelism of API calls as much as you can to avoid throttling. You
        /// can also perform a timing test to calculate an estimate for the total processing time
        /// of your projected load that stays within the throttling limits of the Quick Sight
        /// APIs. For example, if your projected traffic is 100 snapshot jobs before 12:00 PM
        /// per day, start 12 jobs in parallel and measure the amount of time it takes to proccess
        /// all 12 jobs. Once you obtain the result, multiply the duration by 9, for example <c>(12
        /// minutes * 9 = 108 minutes)</c>. Use the new result to determine the latest time at
        /// which the jobs need to be started to meet your target deadline.
        /// </para>
        ///  
        /// <para>
        /// The time that it takes to process a job can be impacted by the following factors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The dataset type (Direct Query or SPICE).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The size of the dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The complexity of the calculated fields that are used in the dashboard.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The number of visuals that are on a sheet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The types of visuals that are on the sheet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The number of formats and snapshots that are requested in the job configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The size of the generated snapshots.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Registered user support</b> 
        /// </para>
        ///  
        /// <para>
        /// You can generate snapshots for registered Quick Sight users by using the Snapshot
        /// Job APIs with <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-identity-enhanced-iam-role-sessions.html">identity-enhanced
        /// IAM role session credentials</a>. This approach allows you to create snapshots on
        /// behalf of specific Quick Sight users while respecting their row-level security (RLS),
        /// column-level security (CLS), dynamic default parameters and dashboard parameter/filter
        /// settings.
        /// </para>
        ///  
        /// <para>
        /// To generate snapshots for registered Quick Sight users, you need to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Obtain identity-enhanced IAM role session credentials from Amazon Web Services Security
        /// Token Service (STS).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use these credentials to call the Snapshot Job APIs.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Identity-enhanced credentials are credentials that contain information about the end
        /// user (e.g., registered Quick Sight user).
        /// </para>
        ///  
        /// <para>
        /// If your Quick Sight users are backed by <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/what-is.html">Amazon
        /// Web Services Identity Center</a>, then you need to set up a <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/setuptrustedtokenissuer.html">trusted
        /// token issuer</a>. Then, getting identity-enhanced IAM credentials for a Quick Sight
        /// user will look like the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Authenticate user with your OIDC compliant Identity Provider. You should get auth
        /// tokens back.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the OIDC API, <a href="https://docs.aws.amazon.com/singlesignon/latest/OIDCAPIReference/API_CreateTokenWithIAM.html">CreateTokenWithIAM</a>,
        /// to exchange auth tokens to IAM tokens. One of the resulted tokens will be identity
        /// token.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call STS AssumeRole API as you normally would, but provide an extra <c>ProvidedContexts</c>
        /// parameter in the API request. The list of contexts must have a single trusted context
        /// assertion. The <c>ProviderArn</c> should be <c>arn:aws:iam::aws:contextProvider/IdentityCenter</c>
        /// while <c>ContextAssertion</c> will be the identity token you received in response
        /// from CreateTokenWithIAM
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more details, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-identity-enhanced-iam-role-sessions.html">IdC
        /// documentation on Identity-enhanced IAM role sessions</a>.
        /// </para>
        ///  
        /// <para>
        /// To obtain Identity-enhanced credentials for Quick Sight native users, IAM federated
        /// users, or Active Directory users, follow the steps below:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Call Quick Sight <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GetIdentityContext.html">GetIdentityContext
        /// API</a> to get identity token.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call STS AssumeRole API as you normally would, but provide extra <c>ProvidedContexts</c>
        /// parameter in the API request. The list of contexts must have a single trusted context
        /// assertion. The <c>ProviderArn</c> should be <c>arn:aws:iam::aws:contextProvider/QuickSight</c>
        /// while <c>ContextAssertion</c> will be the identity token you received in response
        /// from GetIdentityContext
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After obtaining the identity-enhanced IAM role session credentials, you can use them
        /// to start a job, describe the job and describe job result. You can use the same credentials
        /// as long as they haven't expired. All API requests made with these credentials are
        /// considered to be made by the impersonated Quick Sight user.
        /// </para>
        ///  <important> 
        /// <para>
        /// When using identity-enhanced session credentials, set the UserConfiguration request
        /// attribute to null. Otherwise, the request will be invalid.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Possible error scenarios</b> 
        /// </para>
        ///  
        /// <para>
        /// The request fails with an Access Denied error in the following scenarios:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The credentials have expired.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The impersonated Quick Sight user doesn't have access to the specified dashboard.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The impersonated Quick Sight user is restricted from exporting data in the selected
        /// formats. For more information about export restrictions, see <a href="https://docs.aws.amazon.com/quicksuite/latest/userguide/create-custom-permisions-profile.html">Customizing
        /// access to Amazon Quick Sight capabilities</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDashboardSnapshotJob service method.</param>
        /// 
        /// <returns>The response from the StartDashboardSnapshotJob service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedPricingPlanException">
        /// This error indicates that you are calling an embedding operation in Amazon Quick Sight
        /// without the required pricing plan on your Amazon Web Services account. Before you
        /// can use embedding for anonymous users, a Quick Suite administrator needs to add capacity
        /// pricing to Quick Sight. You can do this on the <b>Manage Quick Suite</b> page. 
        /// 
        ///  
        /// <para>
        /// After capacity pricing is added, you can use the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GetDashboardEmbedUrl.html">GetDashboardEmbedUrl</a>
        /// </c> API operation with the <c>--identity-type ANONYMOUS</c> option.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/StartDashboardSnapshotJob">REST API Reference for StartDashboardSnapshotJob Operation</seealso>
        StartDashboardSnapshotJobResponse StartDashboardSnapshotJob(StartDashboardSnapshotJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartDashboardSnapshotJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDashboardSnapshotJob operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDashboardSnapshotJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/StartDashboardSnapshotJob">REST API Reference for StartDashboardSnapshotJob Operation</seealso>
        IAsyncResult BeginStartDashboardSnapshotJob(StartDashboardSnapshotJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartDashboardSnapshotJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDashboardSnapshotJob.</param>
        /// 
        /// <returns>Returns a  StartDashboardSnapshotJobResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/StartDashboardSnapshotJob">REST API Reference for StartDashboardSnapshotJob Operation</seealso>
        StartDashboardSnapshotJobResponse EndStartDashboardSnapshotJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartDashboardSnapshotJobSchedule


        /// <summary>
        /// Starts an asynchronous job that runs an existing dashboard schedule and sends the
        /// dashboard snapshot through email. 
        /// 
        ///  
        /// <para>
        /// Only one job can run simultaneously in a given schedule. Repeated requests are skipped
        /// with a <c>202</c> HTTP status code.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/sending-reports.html">Scheduling
        /// and sending Amazon Quick Sight reports by email</a> and <a href="https://docs.aws.amazon.com/quicksight/latest/user/email-reports-from-dashboard.html">Configuring
        /// email report settings for a Amazon Quick Sight dashboard</a> in the <i>Amazon Quick
        /// Sight User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDashboardSnapshotJobSchedule service method.</param>
        /// 
        /// <returns>The response from the StartDashboardSnapshotJobSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/StartDashboardSnapshotJobSchedule">REST API Reference for StartDashboardSnapshotJobSchedule Operation</seealso>
        StartDashboardSnapshotJobScheduleResponse StartDashboardSnapshotJobSchedule(StartDashboardSnapshotJobScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartDashboardSnapshotJobSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDashboardSnapshotJobSchedule operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDashboardSnapshotJobSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/StartDashboardSnapshotJobSchedule">REST API Reference for StartDashboardSnapshotJobSchedule Operation</seealso>
        IAsyncResult BeginStartDashboardSnapshotJobSchedule(StartDashboardSnapshotJobScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartDashboardSnapshotJobSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDashboardSnapshotJobSchedule.</param>
        /// 
        /// <returns>Returns a  StartDashboardSnapshotJobScheduleResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/StartDashboardSnapshotJobSchedule">REST API Reference for StartDashboardSnapshotJobSchedule Operation</seealso>
        StartDashboardSnapshotJobScheduleResponse EndStartDashboardSnapshotJobSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified Amazon Quick Sight resource.
        /// 
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions, by granting a user permission to access or change only resources
        /// with certain tag values. You can use the <c>TagResource</c> operation with a resource
        /// that already has tags. If you specify a new tag key for the resource, this tag is
        /// appended to the list of tags associated with the resource. If you specify a tag key
        /// that is already associated with the resource, the new tag value that you specify replaces
        /// the previous value for that tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource. Amazon Quick Sight supports
        /// tagging on data set, data source, dashboard, template, topic, and user. 
        /// </para>
        ///  
        /// <para>
        /// Tagging for Amazon Quick Sight works in a similar way to tagging for other Amazon
        /// Web Services services, except for the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Tags are used to track costs for users in Amazon Quick Sight. You can't tag other
        /// resources that Amazon Quick Sight costs are based on, such as storage capacoty (SPICE),
        /// session usage, alert consumption, or reporting units.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Quick Sight doesn't currently support the tag editor for Resource Groups.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag or tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAccountCustomization


        /// <summary>
        /// Updates Amazon Quick Sight customizations. Currently, the only customization that
        /// you can use is a theme.
        /// 
        ///  
        /// <para>
        /// You can use customizations for your Amazon Web Services account or, if you specify
        /// a namespace, for a Quick Sight namespace instead. Customizations that apply to a namespace
        /// override customizations that apply to an Amazon Web Services account. To find out
        /// which customizations apply, use the <c>DescribeAccountCustomization</c> API operation.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountCustomization service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountCustomization service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAccountCustomization">REST API Reference for UpdateAccountCustomization Operation</seealso>
        UpdateAccountCustomizationResponse UpdateAccountCustomization(UpdateAccountCustomizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountCustomization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountCustomization operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccountCustomization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAccountCustomization">REST API Reference for UpdateAccountCustomization Operation</seealso>
        IAsyncResult BeginUpdateAccountCustomization(UpdateAccountCustomizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccountCustomization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountCustomization.</param>
        /// 
        /// <returns>Returns a  UpdateAccountCustomizationResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAccountCustomization">REST API Reference for UpdateAccountCustomization Operation</seealso>
        UpdateAccountCustomizationResponse EndUpdateAccountCustomization(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAccountCustomPermission


        /// <summary>
        /// Applies a custom permissions profile to an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountCustomPermission service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountCustomPermission service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAccountCustomPermission">REST API Reference for UpdateAccountCustomPermission Operation</seealso>
        UpdateAccountCustomPermissionResponse UpdateAccountCustomPermission(UpdateAccountCustomPermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountCustomPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountCustomPermission operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccountCustomPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAccountCustomPermission">REST API Reference for UpdateAccountCustomPermission Operation</seealso>
        IAsyncResult BeginUpdateAccountCustomPermission(UpdateAccountCustomPermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccountCustomPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountCustomPermission.</param>
        /// 
        /// <returns>Returns a  UpdateAccountCustomPermissionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAccountCustomPermission">REST API Reference for UpdateAccountCustomPermission Operation</seealso>
        UpdateAccountCustomPermissionResponse EndUpdateAccountCustomPermission(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAccountSettings


        /// <summary>
        /// Updates the Amazon Quick Sight settings in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountSettings service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        UpdateAccountSettingsResponse UpdateAccountSettings(UpdateAccountSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccountSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        IAsyncResult BeginUpdateAccountSettings(UpdateAccountSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountSettings.</param>
        /// 
        /// <returns>Returns a  UpdateAccountSettingsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        UpdateAccountSettingsResponse EndUpdateAccountSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateActionConnector


        /// <summary>
        /// Updates an existing action connector with new configuration details, authentication
        /// settings, or enabled actions. You can modify the connector's name, description, authentication
        /// configuration, and which actions are enabled. For more information, <a href="https://docs.aws.amazon.com/quicksuite/latest/userguide/quick-action-auth.html">https://docs.aws.amazon.com/quicksuite/latest/userguide/quick-action-auth.html</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateActionConnector service method.</param>
        /// 
        /// <returns>The response from the UpdateActionConnector service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateActionConnector">REST API Reference for UpdateActionConnector Operation</seealso>
        UpdateActionConnectorResponse UpdateActionConnector(UpdateActionConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateActionConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateActionConnector operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateActionConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateActionConnector">REST API Reference for UpdateActionConnector Operation</seealso>
        IAsyncResult BeginUpdateActionConnector(UpdateActionConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateActionConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateActionConnector.</param>
        /// 
        /// <returns>Returns a  UpdateActionConnectorResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateActionConnector">REST API Reference for UpdateActionConnector Operation</seealso>
        UpdateActionConnectorResponse EndUpdateActionConnector(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateActionConnectorPermissions


        /// <summary>
        /// Updates the permissions for an action connector by granting or revoking access for
        /// specific users and groups. You can control who can view, use, or manage the action
        /// connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateActionConnectorPermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateActionConnectorPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateActionConnectorPermissions">REST API Reference for UpdateActionConnectorPermissions Operation</seealso>
        UpdateActionConnectorPermissionsResponse UpdateActionConnectorPermissions(UpdateActionConnectorPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateActionConnectorPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateActionConnectorPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateActionConnectorPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateActionConnectorPermissions">REST API Reference for UpdateActionConnectorPermissions Operation</seealso>
        IAsyncResult BeginUpdateActionConnectorPermissions(UpdateActionConnectorPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateActionConnectorPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateActionConnectorPermissions.</param>
        /// 
        /// <returns>Returns a  UpdateActionConnectorPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateActionConnectorPermissions">REST API Reference for UpdateActionConnectorPermissions Operation</seealso>
        UpdateActionConnectorPermissionsResponse EndUpdateActionConnectorPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAnalysis


        /// <summary>
        /// Updates an analysis in Amazon Quick Sight
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnalysis service method.</param>
        /// 
        /// <returns>The response from the UpdateAnalysis service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAnalysis">REST API Reference for UpdateAnalysis Operation</seealso>
        UpdateAnalysisResponse UpdateAnalysis(UpdateAnalysisRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnalysis operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAnalysis">REST API Reference for UpdateAnalysis Operation</seealso>
        IAsyncResult BeginUpdateAnalysis(UpdateAnalysisRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAnalysis.</param>
        /// 
        /// <returns>Returns a  UpdateAnalysisResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAnalysis">REST API Reference for UpdateAnalysis Operation</seealso>
        UpdateAnalysisResponse EndUpdateAnalysis(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAnalysisPermissions


        /// <summary>
        /// Updates the read and write permissions for an analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnalysisPermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateAnalysisPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAnalysisPermissions">REST API Reference for UpdateAnalysisPermissions Operation</seealso>
        UpdateAnalysisPermissionsResponse UpdateAnalysisPermissions(UpdateAnalysisPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAnalysisPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnalysisPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAnalysisPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAnalysisPermissions">REST API Reference for UpdateAnalysisPermissions Operation</seealso>
        IAsyncResult BeginUpdateAnalysisPermissions(UpdateAnalysisPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAnalysisPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAnalysisPermissions.</param>
        /// 
        /// <returns>Returns a  UpdateAnalysisPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAnalysisPermissions">REST API Reference for UpdateAnalysisPermissions Operation</seealso>
        UpdateAnalysisPermissionsResponse EndUpdateAnalysisPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApplicationWithTokenExchangeGrant


        /// <summary>
        /// Updates an Quick Suite application with a token exchange grant. This operation only
        /// supports Quick Suite applications that are registered with IAM Identity Center.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationWithTokenExchangeGrant service method.</param>
        /// 
        /// <returns>The response from the UpdateApplicationWithTokenExchangeGrant service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateApplicationWithTokenExchangeGrant">REST API Reference for UpdateApplicationWithTokenExchangeGrant Operation</seealso>
        UpdateApplicationWithTokenExchangeGrantResponse UpdateApplicationWithTokenExchangeGrant(UpdateApplicationWithTokenExchangeGrantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationWithTokenExchangeGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationWithTokenExchangeGrant operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplicationWithTokenExchangeGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateApplicationWithTokenExchangeGrant">REST API Reference for UpdateApplicationWithTokenExchangeGrant Operation</seealso>
        IAsyncResult BeginUpdateApplicationWithTokenExchangeGrant(UpdateApplicationWithTokenExchangeGrantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplicationWithTokenExchangeGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplicationWithTokenExchangeGrant.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationWithTokenExchangeGrantResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateApplicationWithTokenExchangeGrant">REST API Reference for UpdateApplicationWithTokenExchangeGrant Operation</seealso>
        UpdateApplicationWithTokenExchangeGrantResponse EndUpdateApplicationWithTokenExchangeGrant(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBrand


        /// <summary>
        /// Updates a brand.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrand service method.</param>
        /// 
        /// <returns>The response from the UpdateBrand service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateBrand">REST API Reference for UpdateBrand Operation</seealso>
        UpdateBrandResponse UpdateBrand(UpdateBrandRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBrand operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrand operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBrand
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateBrand">REST API Reference for UpdateBrand Operation</seealso>
        IAsyncResult BeginUpdateBrand(UpdateBrandRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBrand operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBrand.</param>
        /// 
        /// <returns>Returns a  UpdateBrandResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateBrand">REST API Reference for UpdateBrand Operation</seealso>
        UpdateBrandResponse EndUpdateBrand(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBrandAssignment


        /// <summary>
        /// Updates a brand assignment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrandAssignment service method.</param>
        /// 
        /// <returns>The response from the UpdateBrandAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateBrandAssignment">REST API Reference for UpdateBrandAssignment Operation</seealso>
        UpdateBrandAssignmentResponse UpdateBrandAssignment(UpdateBrandAssignmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBrandAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrandAssignment operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBrandAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateBrandAssignment">REST API Reference for UpdateBrandAssignment Operation</seealso>
        IAsyncResult BeginUpdateBrandAssignment(UpdateBrandAssignmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBrandAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBrandAssignment.</param>
        /// 
        /// <returns>Returns a  UpdateBrandAssignmentResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateBrandAssignment">REST API Reference for UpdateBrandAssignment Operation</seealso>
        UpdateBrandAssignmentResponse EndUpdateBrandAssignment(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBrandPublishedVersion


        /// <summary>
        /// Updates the published version of a brand.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrandPublishedVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateBrandPublishedVersion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateBrandPublishedVersion">REST API Reference for UpdateBrandPublishedVersion Operation</seealso>
        UpdateBrandPublishedVersionResponse UpdateBrandPublishedVersion(UpdateBrandPublishedVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBrandPublishedVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrandPublishedVersion operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBrandPublishedVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateBrandPublishedVersion">REST API Reference for UpdateBrandPublishedVersion Operation</seealso>
        IAsyncResult BeginUpdateBrandPublishedVersion(UpdateBrandPublishedVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBrandPublishedVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBrandPublishedVersion.</param>
        /// 
        /// <returns>Returns a  UpdateBrandPublishedVersionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateBrandPublishedVersion">REST API Reference for UpdateBrandPublishedVersion Operation</seealso>
        UpdateBrandPublishedVersionResponse EndUpdateBrandPublishedVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCustomPermissions


        /// <summary>
        /// Updates a custom permissions profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomPermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateCustomPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateCustomPermissions">REST API Reference for UpdateCustomPermissions Operation</seealso>
        UpdateCustomPermissionsResponse UpdateCustomPermissions(UpdateCustomPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCustomPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCustomPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateCustomPermissions">REST API Reference for UpdateCustomPermissions Operation</seealso>
        IAsyncResult BeginUpdateCustomPermissions(UpdateCustomPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCustomPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCustomPermissions.</param>
        /// 
        /// <returns>Returns a  UpdateCustomPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateCustomPermissions">REST API Reference for UpdateCustomPermissions Operation</seealso>
        UpdateCustomPermissionsResponse EndUpdateCustomPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDashboard


        /// <summary>
        /// Updates a dashboard in an Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// Updating a Dashboard creates a new dashboard version but does not immediately publish
        /// the new version. You can update the published version of a dashboard by using the
        /// <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_UpdateDashboardPublishedVersion.html">UpdateDashboardPublishedVersion</a>
        /// </c> API operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard service method.</param>
        /// 
        /// <returns>The response from the UpdateDashboard service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        UpdateDashboardResponse UpdateDashboard(UpdateDashboardRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        IAsyncResult BeginUpdateDashboard(UpdateDashboardRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDashboard.</param>
        /// 
        /// <returns>Returns a  UpdateDashboardResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        UpdateDashboardResponse EndUpdateDashboard(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDashboardLinks


        /// <summary>
        /// Updates the linked analyses on a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardLinks service method.</param>
        /// 
        /// <returns>The response from the UpdateDashboardLinks service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardLinks">REST API Reference for UpdateDashboardLinks Operation</seealso>
        UpdateDashboardLinksResponse UpdateDashboardLinks(UpdateDashboardLinksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDashboardLinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardLinks operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDashboardLinks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardLinks">REST API Reference for UpdateDashboardLinks Operation</seealso>
        IAsyncResult BeginUpdateDashboardLinks(UpdateDashboardLinksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDashboardLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDashboardLinks.</param>
        /// 
        /// <returns>Returns a  UpdateDashboardLinksResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardLinks">REST API Reference for UpdateDashboardLinks Operation</seealso>
        UpdateDashboardLinksResponse EndUpdateDashboardLinks(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDashboardPermissions


        /// <summary>
        /// Updates read and write permissions on a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardPermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateDashboardPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPermissions">REST API Reference for UpdateDashboardPermissions Operation</seealso>
        UpdateDashboardPermissionsResponse UpdateDashboardPermissions(UpdateDashboardPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDashboardPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDashboardPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPermissions">REST API Reference for UpdateDashboardPermissions Operation</seealso>
        IAsyncResult BeginUpdateDashboardPermissions(UpdateDashboardPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDashboardPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDashboardPermissions.</param>
        /// 
        /// <returns>Returns a  UpdateDashboardPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPermissions">REST API Reference for UpdateDashboardPermissions Operation</seealso>
        UpdateDashboardPermissionsResponse EndUpdateDashboardPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDashboardPublishedVersion


        /// <summary>
        /// Updates the published version of a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardPublishedVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateDashboardPublishedVersion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPublishedVersion">REST API Reference for UpdateDashboardPublishedVersion Operation</seealso>
        UpdateDashboardPublishedVersionResponse UpdateDashboardPublishedVersion(UpdateDashboardPublishedVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDashboardPublishedVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardPublishedVersion operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDashboardPublishedVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPublishedVersion">REST API Reference for UpdateDashboardPublishedVersion Operation</seealso>
        IAsyncResult BeginUpdateDashboardPublishedVersion(UpdateDashboardPublishedVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDashboardPublishedVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDashboardPublishedVersion.</param>
        /// 
        /// <returns>Returns a  UpdateDashboardPublishedVersionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPublishedVersion">REST API Reference for UpdateDashboardPublishedVersion Operation</seealso>
        UpdateDashboardPublishedVersionResponse EndUpdateDashboardPublishedVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDashboardsQAConfiguration


        /// <summary>
        /// Updates a Dashboard QA configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardsQAConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateDashboardsQAConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardsQAConfiguration">REST API Reference for UpdateDashboardsQAConfiguration Operation</seealso>
        UpdateDashboardsQAConfigurationResponse UpdateDashboardsQAConfiguration(UpdateDashboardsQAConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDashboardsQAConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardsQAConfiguration operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDashboardsQAConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardsQAConfiguration">REST API Reference for UpdateDashboardsQAConfiguration Operation</seealso>
        IAsyncResult BeginUpdateDashboardsQAConfiguration(UpdateDashboardsQAConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDashboardsQAConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDashboardsQAConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateDashboardsQAConfigurationResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardsQAConfiguration">REST API Reference for UpdateDashboardsQAConfiguration Operation</seealso>
        UpdateDashboardsQAConfigurationResponse EndUpdateDashboardsQAConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataSet


        /// <summary>
        /// Updates a dataset. This operation doesn't support datasets that include uploaded files
        /// as a source. Partial updates are not supported by this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSet service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSet service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidDataSetParameterValueException">
        /// An exception thrown when an invalid parameter value is provided for dataset operations.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSet">REST API Reference for UpdateDataSet Operation</seealso>
        UpdateDataSetResponse UpdateDataSet(UpdateDataSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSet operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSet">REST API Reference for UpdateDataSet Operation</seealso>
        IAsyncResult BeginUpdateDataSet(UpdateDataSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSet.</param>
        /// 
        /// <returns>Returns a  UpdateDataSetResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSet">REST API Reference for UpdateDataSet Operation</seealso>
        UpdateDataSetResponse EndUpdateDataSet(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataSetPermissions


        /// <summary>
        /// Updates the permissions on a dataset.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <c>arn:aws:quicksight:region:aws-account-id:dataset/data-set-id</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSetPermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSetPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSetPermissions">REST API Reference for UpdateDataSetPermissions Operation</seealso>
        UpdateDataSetPermissionsResponse UpdateDataSetPermissions(UpdateDataSetPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSetPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSetPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSetPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSetPermissions">REST API Reference for UpdateDataSetPermissions Operation</seealso>
        IAsyncResult BeginUpdateDataSetPermissions(UpdateDataSetPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSetPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSetPermissions.</param>
        /// 
        /// <returns>Returns a  UpdateDataSetPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSetPermissions">REST API Reference for UpdateDataSetPermissions Operation</seealso>
        UpdateDataSetPermissionsResponse EndUpdateDataSetPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataSource


        /// <summary>
        /// Updates a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.CustomerManagedKeyUnavailableException">
        /// The customer managed key that is registered to your Amazon Quick Sight account is
        /// unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        IAsyncResult BeginUpdateDataSource(UpdateDataSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSource.</param>
        /// 
        /// <returns>Returns a  UpdateDataSourceResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        UpdateDataSourceResponse EndUpdateDataSource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataSourcePermissions


        /// <summary>
        /// Updates the permissions to a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSourcePermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSourcePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSourcePermissions">REST API Reference for UpdateDataSourcePermissions Operation</seealso>
        UpdateDataSourcePermissionsResponse UpdateDataSourcePermissions(UpdateDataSourcePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSourcePermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSourcePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSourcePermissions">REST API Reference for UpdateDataSourcePermissions Operation</seealso>
        IAsyncResult BeginUpdateDataSourcePermissions(UpdateDataSourcePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSourcePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSourcePermissions.</param>
        /// 
        /// <returns>Returns a  UpdateDataSourcePermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSourcePermissions">REST API Reference for UpdateDataSourcePermissions Operation</seealso>
        UpdateDataSourcePermissionsResponse EndUpdateDataSourcePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDefaultQBusinessApplication


        /// <summary>
        /// Updates a Amazon Q Business application that is linked to a Quick Sight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultQBusinessApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateDefaultQBusinessApplication service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDefaultQBusinessApplication">REST API Reference for UpdateDefaultQBusinessApplication Operation</seealso>
        UpdateDefaultQBusinessApplicationResponse UpdateDefaultQBusinessApplication(UpdateDefaultQBusinessApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDefaultQBusinessApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultQBusinessApplication operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDefaultQBusinessApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDefaultQBusinessApplication">REST API Reference for UpdateDefaultQBusinessApplication Operation</seealso>
        IAsyncResult BeginUpdateDefaultQBusinessApplication(UpdateDefaultQBusinessApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDefaultQBusinessApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDefaultQBusinessApplication.</param>
        /// 
        /// <returns>Returns a  UpdateDefaultQBusinessApplicationResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDefaultQBusinessApplication">REST API Reference for UpdateDefaultQBusinessApplication Operation</seealso>
        UpdateDefaultQBusinessApplicationResponse EndUpdateDefaultQBusinessApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFlowPermissions


        /// <summary>
        /// Updates permissions against principals on a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowPermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateFlowPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateFlowPermissions">REST API Reference for UpdateFlowPermissions Operation</seealso>
        UpdateFlowPermissionsResponse UpdateFlowPermissions(UpdateFlowPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFlowPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFlowPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateFlowPermissions">REST API Reference for UpdateFlowPermissions Operation</seealso>
        IAsyncResult BeginUpdateFlowPermissions(UpdateFlowPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFlowPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFlowPermissions.</param>
        /// 
        /// <returns>Returns a  UpdateFlowPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateFlowPermissions">REST API Reference for UpdateFlowPermissions Operation</seealso>
        UpdateFlowPermissionsResponse EndUpdateFlowPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFolder


        /// <summary>
        /// Updates the name of a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFolder service method.</param>
        /// 
        /// <returns>The response from the UpdateFolder service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateFolder">REST API Reference for UpdateFolder Operation</seealso>
        UpdateFolderResponse UpdateFolder(UpdateFolderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFolder operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFolder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateFolder">REST API Reference for UpdateFolder Operation</seealso>
        IAsyncResult BeginUpdateFolder(UpdateFolderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFolder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFolder.</param>
        /// 
        /// <returns>Returns a  UpdateFolderResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateFolder">REST API Reference for UpdateFolder Operation</seealso>
        UpdateFolderResponse EndUpdateFolder(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFolderPermissions


        /// <summary>
        /// Updates permissions of a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFolderPermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateFolderPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateFolderPermissions">REST API Reference for UpdateFolderPermissions Operation</seealso>
        UpdateFolderPermissionsResponse UpdateFolderPermissions(UpdateFolderPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFolderPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFolderPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFolderPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateFolderPermissions">REST API Reference for UpdateFolderPermissions Operation</seealso>
        IAsyncResult BeginUpdateFolderPermissions(UpdateFolderPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFolderPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFolderPermissions.</param>
        /// 
        /// <returns>Returns a  UpdateFolderPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateFolderPermissions">REST API Reference for UpdateFolderPermissions Operation</seealso>
        UpdateFolderPermissionsResponse EndUpdateFolderPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGroup


        /// <summary>
        /// Changes a group description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        UpdateGroupResponse UpdateGroup(UpdateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        IAsyncResult BeginUpdateGroup(UpdateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGroupResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIAMPolicyAssignment


        /// <summary>
        /// Updates an existing IAM policy assignment. This operation updates only the optional
        /// parameter or parameters that are specified in the request. This overwrites all of
        /// the users included in <c>Identities</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIAMPolicyAssignment service method.</param>
        /// 
        /// <returns>The response from the UpdateIAMPolicyAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConcurrentUpdatingException">
        /// A resource is already in a state that indicates an operation is happening that must
        /// complete before a new update can be applied.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIAMPolicyAssignment">REST API Reference for UpdateIAMPolicyAssignment Operation</seealso>
        UpdateIAMPolicyAssignmentResponse UpdateIAMPolicyAssignment(UpdateIAMPolicyAssignmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIAMPolicyAssignment operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIAMPolicyAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIAMPolicyAssignment">REST API Reference for UpdateIAMPolicyAssignment Operation</seealso>
        IAsyncResult BeginUpdateIAMPolicyAssignment(UpdateIAMPolicyAssignmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIAMPolicyAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIAMPolicyAssignment.</param>
        /// 
        /// <returns>Returns a  UpdateIAMPolicyAssignmentResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIAMPolicyAssignment">REST API Reference for UpdateIAMPolicyAssignment Operation</seealso>
        UpdateIAMPolicyAssignmentResponse EndUpdateIAMPolicyAssignment(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIdentityPropagationConfig


        /// <summary>
        /// Adds or updates services and authorized targets to configure what the Quick Sight
        /// IAM Identity Center application can access.
        /// 
        ///  
        /// <para>
        /// This operation is only supported for Quick Sight accounts using IAM Identity Center
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityPropagationConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateIdentityPropagationConfig service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIdentityPropagationConfig">REST API Reference for UpdateIdentityPropagationConfig Operation</seealso>
        UpdateIdentityPropagationConfigResponse UpdateIdentityPropagationConfig(UpdateIdentityPropagationConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdentityPropagationConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityPropagationConfig operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIdentityPropagationConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIdentityPropagationConfig">REST API Reference for UpdateIdentityPropagationConfig Operation</seealso>
        IAsyncResult BeginUpdateIdentityPropagationConfig(UpdateIdentityPropagationConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIdentityPropagationConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIdentityPropagationConfig.</param>
        /// 
        /// <returns>Returns a  UpdateIdentityPropagationConfigResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIdentityPropagationConfig">REST API Reference for UpdateIdentityPropagationConfig Operation</seealso>
        UpdateIdentityPropagationConfigResponse EndUpdateIdentityPropagationConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIpRestriction


        /// <summary>
        /// Updates the content and status of IP rules. Traffic from a source is allowed when
        /// the source satisfies either the <c>IpRestrictionRule</c>, <c>VpcIdRestrictionRule</c>,
        /// or <c>VpcEndpointIdRestrictionRule</c>. To use this operation, you must provide the
        /// entire map of rules. You can use the <c>DescribeIpRestriction</c> operation to get
        /// the current rule map.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIpRestriction service method.</param>
        /// 
        /// <returns>The response from the UpdateIpRestriction service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIpRestriction">REST API Reference for UpdateIpRestriction Operation</seealso>
        UpdateIpRestrictionResponse UpdateIpRestriction(UpdateIpRestrictionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIpRestriction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIpRestriction operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIpRestriction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIpRestriction">REST API Reference for UpdateIpRestriction Operation</seealso>
        IAsyncResult BeginUpdateIpRestriction(UpdateIpRestrictionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIpRestriction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIpRestriction.</param>
        /// 
        /// <returns>Returns a  UpdateIpRestrictionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIpRestriction">REST API Reference for UpdateIpRestriction Operation</seealso>
        UpdateIpRestrictionResponse EndUpdateIpRestriction(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateKeyRegistration


        /// <summary>
        /// Updates a customer managed key in a Quick Sight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyRegistration service method.</param>
        /// 
        /// <returns>The response from the UpdateKeyRegistration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateKeyRegistration">REST API Reference for UpdateKeyRegistration Operation</seealso>
        UpdateKeyRegistrationResponse UpdateKeyRegistration(UpdateKeyRegistrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKeyRegistration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyRegistration operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKeyRegistration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateKeyRegistration">REST API Reference for UpdateKeyRegistration Operation</seealso>
        IAsyncResult BeginUpdateKeyRegistration(UpdateKeyRegistrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKeyRegistration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKeyRegistration.</param>
        /// 
        /// <returns>Returns a  UpdateKeyRegistrationResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateKeyRegistration">REST API Reference for UpdateKeyRegistration Operation</seealso>
        UpdateKeyRegistrationResponse EndUpdateKeyRegistration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePublicSharingSettings


        /// <summary>
        /// <important> 
        /// <para>
        /// This API controls public sharing settings for your entire Quick Sight account, affecting
        /// data security and access. When you enable public sharing:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Dashboards can be shared publicly
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This setting affects your entire Amazon Web Services account and all Quick Sight users
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Before proceeding:</b> Ensure you understand the security implications and have
        /// proper IAM permissions configured.
        /// </para>
        ///  </important> 
        /// <para>
        /// Use the <c>UpdatePublicSharingSettings</c> operation to turn on or turn off the public
        /// sharing settings of an Amazon Quick Sight dashboard.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, turn on session capacity pricing for your Amazon Quick Sight
        /// account.
        /// </para>
        ///  
        /// <para>
        /// Before you can turn on public sharing on your account, make sure to give public sharing
        /// permissions to an administrative user in the Identity and Access Management (IAM)
        /// console. For more information on using IAM with Amazon Quick Sight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/security_iam_service-with-iam.html">Using
        /// Quick Suite with IAM</a> in the <i>Amazon Quick Sight User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePublicSharingSettings service method.</param>
        /// 
        /// <returns>The response from the UpdatePublicSharingSettings service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedPricingPlanException">
        /// This error indicates that you are calling an embedding operation in Amazon Quick Sight
        /// without the required pricing plan on your Amazon Web Services account. Before you
        /// can use embedding for anonymous users, a Quick Suite administrator needs to add capacity
        /// pricing to Quick Sight. You can do this on the <b>Manage Quick Suite</b> page. 
        /// 
        ///  
        /// <para>
        /// After capacity pricing is added, you can use the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GetDashboardEmbedUrl.html">GetDashboardEmbedUrl</a>
        /// </c> API operation with the <c>--identity-type ANONYMOUS</c> option.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdatePublicSharingSettings">REST API Reference for UpdatePublicSharingSettings Operation</seealso>
        UpdatePublicSharingSettingsResponse UpdatePublicSharingSettings(UpdatePublicSharingSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePublicSharingSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePublicSharingSettings operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePublicSharingSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdatePublicSharingSettings">REST API Reference for UpdatePublicSharingSettings Operation</seealso>
        IAsyncResult BeginUpdatePublicSharingSettings(UpdatePublicSharingSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePublicSharingSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePublicSharingSettings.</param>
        /// 
        /// <returns>Returns a  UpdatePublicSharingSettingsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdatePublicSharingSettings">REST API Reference for UpdatePublicSharingSettings Operation</seealso>
        UpdatePublicSharingSettingsResponse EndUpdatePublicSharingSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateQPersonalizationConfiguration


        /// <summary>
        /// Updates a personalization configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQPersonalizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateQPersonalizationConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateQPersonalizationConfiguration">REST API Reference for UpdateQPersonalizationConfiguration Operation</seealso>
        UpdateQPersonalizationConfigurationResponse UpdateQPersonalizationConfiguration(UpdateQPersonalizationConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQPersonalizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQPersonalizationConfiguration operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQPersonalizationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateQPersonalizationConfiguration">REST API Reference for UpdateQPersonalizationConfiguration Operation</seealso>
        IAsyncResult BeginUpdateQPersonalizationConfiguration(UpdateQPersonalizationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQPersonalizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQPersonalizationConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateQPersonalizationConfigurationResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateQPersonalizationConfiguration">REST API Reference for UpdateQPersonalizationConfiguration Operation</seealso>
        UpdateQPersonalizationConfigurationResponse EndUpdateQPersonalizationConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateQuickSightQSearchConfiguration


        /// <summary>
        /// Updates the state of a Quick Sight Q Search configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuickSightQSearchConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateQuickSightQSearchConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateQuickSightQSearchConfiguration">REST API Reference for UpdateQuickSightQSearchConfiguration Operation</seealso>
        UpdateQuickSightQSearchConfigurationResponse UpdateQuickSightQSearchConfiguration(UpdateQuickSightQSearchConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQuickSightQSearchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuickSightQSearchConfiguration operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQuickSightQSearchConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateQuickSightQSearchConfiguration">REST API Reference for UpdateQuickSightQSearchConfiguration Operation</seealso>
        IAsyncResult BeginUpdateQuickSightQSearchConfiguration(UpdateQuickSightQSearchConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQuickSightQSearchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQuickSightQSearchConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateQuickSightQSearchConfigurationResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateQuickSightQSearchConfiguration">REST API Reference for UpdateQuickSightQSearchConfiguration Operation</seealso>
        UpdateQuickSightQSearchConfigurationResponse EndUpdateQuickSightQSearchConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRefreshSchedule


        /// <summary>
        /// Updates a refresh schedule for a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRefreshSchedule service method.</param>
        /// 
        /// <returns>The response from the UpdateRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateRefreshSchedule">REST API Reference for UpdateRefreshSchedule Operation</seealso>
        UpdateRefreshScheduleResponse UpdateRefreshSchedule(UpdateRefreshScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRefreshSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRefreshSchedule operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRefreshSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateRefreshSchedule">REST API Reference for UpdateRefreshSchedule Operation</seealso>
        IAsyncResult BeginUpdateRefreshSchedule(UpdateRefreshScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRefreshSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRefreshSchedule.</param>
        /// 
        /// <returns>Returns a  UpdateRefreshScheduleResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateRefreshSchedule">REST API Reference for UpdateRefreshSchedule Operation</seealso>
        UpdateRefreshScheduleResponse EndUpdateRefreshSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRoleCustomPermission


        /// <summary>
        /// Updates the custom permissions that are associated with a role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoleCustomPermission service method.</param>
        /// 
        /// <returns>The response from the UpdateRoleCustomPermission service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateRoleCustomPermission">REST API Reference for UpdateRoleCustomPermission Operation</seealso>
        UpdateRoleCustomPermissionResponse UpdateRoleCustomPermission(UpdateRoleCustomPermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoleCustomPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoleCustomPermission operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoleCustomPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateRoleCustomPermission">REST API Reference for UpdateRoleCustomPermission Operation</seealso>
        IAsyncResult BeginUpdateRoleCustomPermission(UpdateRoleCustomPermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoleCustomPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoleCustomPermission.</param>
        /// 
        /// <returns>Returns a  UpdateRoleCustomPermissionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateRoleCustomPermission">REST API Reference for UpdateRoleCustomPermission Operation</seealso>
        UpdateRoleCustomPermissionResponse EndUpdateRoleCustomPermission(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSelfUpgrade


        /// <summary>
        /// Updates a self-upgrade request for a Quick Suite user by approving, denying, or verifying
        /// the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSelfUpgrade service method.</param>
        /// 
        /// <returns>The response from the UpdateSelfUpgrade service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateSelfUpgrade">REST API Reference for UpdateSelfUpgrade Operation</seealso>
        UpdateSelfUpgradeResponse UpdateSelfUpgrade(UpdateSelfUpgradeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSelfUpgrade operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSelfUpgrade operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSelfUpgrade
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateSelfUpgrade">REST API Reference for UpdateSelfUpgrade Operation</seealso>
        IAsyncResult BeginUpdateSelfUpgrade(UpdateSelfUpgradeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSelfUpgrade operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSelfUpgrade.</param>
        /// 
        /// <returns>Returns a  UpdateSelfUpgradeResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateSelfUpgrade">REST API Reference for UpdateSelfUpgrade Operation</seealso>
        UpdateSelfUpgradeResponse EndUpdateSelfUpgrade(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSelfUpgradeConfiguration


        /// <summary>
        /// Updates the self-upgrade configuration for a Quick Suite account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSelfUpgradeConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateSelfUpgradeConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterException">
        /// One or more parameter has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateSelfUpgradeConfiguration">REST API Reference for UpdateSelfUpgradeConfiguration Operation</seealso>
        UpdateSelfUpgradeConfigurationResponse UpdateSelfUpgradeConfiguration(UpdateSelfUpgradeConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSelfUpgradeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSelfUpgradeConfiguration operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSelfUpgradeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateSelfUpgradeConfiguration">REST API Reference for UpdateSelfUpgradeConfiguration Operation</seealso>
        IAsyncResult BeginUpdateSelfUpgradeConfiguration(UpdateSelfUpgradeConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSelfUpgradeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSelfUpgradeConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateSelfUpgradeConfigurationResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateSelfUpgradeConfiguration">REST API Reference for UpdateSelfUpgradeConfiguration Operation</seealso>
        UpdateSelfUpgradeConfigurationResponse EndUpdateSelfUpgradeConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSPICECapacityConfiguration


        /// <summary>
        /// Updates the SPICE capacity configuration for a Quick Sight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSPICECapacityConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateSPICECapacityConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateSPICECapacityConfiguration">REST API Reference for UpdateSPICECapacityConfiguration Operation</seealso>
        UpdateSPICECapacityConfigurationResponse UpdateSPICECapacityConfiguration(UpdateSPICECapacityConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSPICECapacityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSPICECapacityConfiguration operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSPICECapacityConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateSPICECapacityConfiguration">REST API Reference for UpdateSPICECapacityConfiguration Operation</seealso>
        IAsyncResult BeginUpdateSPICECapacityConfiguration(UpdateSPICECapacityConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSPICECapacityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSPICECapacityConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateSPICECapacityConfigurationResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateSPICECapacityConfiguration">REST API Reference for UpdateSPICECapacityConfiguration Operation</seealso>
        UpdateSPICECapacityConfigurationResponse EndUpdateSPICECapacityConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTemplate


        /// <summary>
        /// Updates a template from an existing Amazon Quick Sight analysis or another template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        IAsyncResult BeginUpdateTemplate(UpdateTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateTemplateResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        UpdateTemplateResponse EndUpdateTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTemplateAlias


        /// <summary>
        /// Updates the template alias of a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplateAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplateAlias">REST API Reference for UpdateTemplateAlias Operation</seealso>
        UpdateTemplateAliasResponse UpdateTemplateAlias(UpdateTemplateAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateAlias operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTemplateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplateAlias">REST API Reference for UpdateTemplateAlias Operation</seealso>
        IAsyncResult BeginUpdateTemplateAlias(UpdateTemplateAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTemplateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTemplateAlias.</param>
        /// 
        /// <returns>Returns a  UpdateTemplateAliasResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplateAlias">REST API Reference for UpdateTemplateAlias Operation</seealso>
        UpdateTemplateAliasResponse EndUpdateTemplateAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTemplatePermissions


        /// <summary>
        /// Updates the resource permissions for a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplatePermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplatePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplatePermissions">REST API Reference for UpdateTemplatePermissions Operation</seealso>
        UpdateTemplatePermissionsResponse UpdateTemplatePermissions(UpdateTemplatePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTemplatePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplatePermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTemplatePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplatePermissions">REST API Reference for UpdateTemplatePermissions Operation</seealso>
        IAsyncResult BeginUpdateTemplatePermissions(UpdateTemplatePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTemplatePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTemplatePermissions.</param>
        /// 
        /// <returns>Returns a  UpdateTemplatePermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplatePermissions">REST API Reference for UpdateTemplatePermissions Operation</seealso>
        UpdateTemplatePermissionsResponse EndUpdateTemplatePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTheme


        /// <summary>
        /// Updates a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTheme service method.</param>
        /// 
        /// <returns>The response from the UpdateTheme service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTheme">REST API Reference for UpdateTheme Operation</seealso>
        UpdateThemeResponse UpdateTheme(UpdateThemeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTheme operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTheme operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTheme
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTheme">REST API Reference for UpdateTheme Operation</seealso>
        IAsyncResult BeginUpdateTheme(UpdateThemeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTheme operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTheme.</param>
        /// 
        /// <returns>Returns a  UpdateThemeResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTheme">REST API Reference for UpdateTheme Operation</seealso>
        UpdateThemeResponse EndUpdateTheme(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateThemeAlias


        /// <summary>
        /// Updates an alias of a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThemeAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateThemeAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateThemeAlias">REST API Reference for UpdateThemeAlias Operation</seealso>
        UpdateThemeAliasResponse UpdateThemeAlias(UpdateThemeAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateThemeAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateThemeAlias operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateThemeAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateThemeAlias">REST API Reference for UpdateThemeAlias Operation</seealso>
        IAsyncResult BeginUpdateThemeAlias(UpdateThemeAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateThemeAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateThemeAlias.</param>
        /// 
        /// <returns>Returns a  UpdateThemeAliasResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateThemeAlias">REST API Reference for UpdateThemeAlias Operation</seealso>
        UpdateThemeAliasResponse EndUpdateThemeAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateThemePermissions


        /// <summary>
        /// Updates the resource permissions for a theme. Permissions apply to the action to grant
        /// or revoke permissions on, for example <c>"quicksight:DescribeTheme"</c>.
        /// 
        ///  
        /// <para>
        /// Theme permissions apply in groupings. Valid groupings include the following for the
        /// three levels of permissions, which are user, owner, or no permissions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// User
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"quicksight:DescribeTheme"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:DescribeThemeAlias"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:ListThemeAliases"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:ListThemeVersions"</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Owner
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"quicksight:DescribeTheme"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:DescribeThemeAlias"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:ListThemeAliases"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:ListThemeVersions"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:DeleteTheme"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:UpdateTheme"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:CreateThemeAlias"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:DeleteThemeAlias"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:UpdateThemeAlias"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:UpdateThemePermissions"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:DescribeThemePermissions"</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// To specify no permissions, omit the permissions list.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThemePermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateThemePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateThemePermissions">REST API Reference for UpdateThemePermissions Operation</seealso>
        UpdateThemePermissionsResponse UpdateThemePermissions(UpdateThemePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateThemePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateThemePermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateThemePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateThemePermissions">REST API Reference for UpdateThemePermissions Operation</seealso>
        IAsyncResult BeginUpdateThemePermissions(UpdateThemePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateThemePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateThemePermissions.</param>
        /// 
        /// <returns>Returns a  UpdateThemePermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateThemePermissions">REST API Reference for UpdateThemePermissions Operation</seealso>
        UpdateThemePermissionsResponse EndUpdateThemePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTopic


        /// <summary>
        /// Updates a topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTopic service method.</param>
        /// 
        /// <returns>The response from the UpdateTopic service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTopic">REST API Reference for UpdateTopic Operation</seealso>
        UpdateTopicResponse UpdateTopic(UpdateTopicRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTopic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTopic operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTopic
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTopic">REST API Reference for UpdateTopic Operation</seealso>
        IAsyncResult BeginUpdateTopic(UpdateTopicRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTopic operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTopic.</param>
        /// 
        /// <returns>Returns a  UpdateTopicResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTopic">REST API Reference for UpdateTopic Operation</seealso>
        UpdateTopicResponse EndUpdateTopic(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTopicPermissions


        /// <summary>
        /// Updates the permissions of a topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTopicPermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateTopicPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTopicPermissions">REST API Reference for UpdateTopicPermissions Operation</seealso>
        UpdateTopicPermissionsResponse UpdateTopicPermissions(UpdateTopicPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTopicPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTopicPermissions operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTopicPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTopicPermissions">REST API Reference for UpdateTopicPermissions Operation</seealso>
        IAsyncResult BeginUpdateTopicPermissions(UpdateTopicPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTopicPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTopicPermissions.</param>
        /// 
        /// <returns>Returns a  UpdateTopicPermissionsResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTopicPermissions">REST API Reference for UpdateTopicPermissions Operation</seealso>
        UpdateTopicPermissionsResponse EndUpdateTopicPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTopicRefreshSchedule


        /// <summary>
        /// Updates a topic refresh schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTopicRefreshSchedule service method.</param>
        /// 
        /// <returns>The response from the UpdateTopicRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTopicRefreshSchedule">REST API Reference for UpdateTopicRefreshSchedule Operation</seealso>
        UpdateTopicRefreshScheduleResponse UpdateTopicRefreshSchedule(UpdateTopicRefreshScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTopicRefreshSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTopicRefreshSchedule operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTopicRefreshSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTopicRefreshSchedule">REST API Reference for UpdateTopicRefreshSchedule Operation</seealso>
        IAsyncResult BeginUpdateTopicRefreshSchedule(UpdateTopicRefreshScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTopicRefreshSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTopicRefreshSchedule.</param>
        /// 
        /// <returns>Returns a  UpdateTopicRefreshScheduleResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTopicRefreshSchedule">REST API Reference for UpdateTopicRefreshSchedule Operation</seealso>
        UpdateTopicRefreshScheduleResponse EndUpdateTopicRefreshSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUser


        /// <summary>
        /// Updates an Amazon Quick Sight user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse UpdateUser(UpdateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        IAsyncResult BeginUpdateUser(UpdateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUser.</param>
        /// 
        /// <returns>Returns a  UpdateUserResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUserCustomPermission


        /// <summary>
        /// Updates a custom permissions profile for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserCustomPermission service method.</param>
        /// 
        /// <returns>The response from the UpdateUserCustomPermission service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUserCustomPermission">REST API Reference for UpdateUserCustomPermission Operation</seealso>
        UpdateUserCustomPermissionResponse UpdateUserCustomPermission(UpdateUserCustomPermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserCustomPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserCustomPermission operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserCustomPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUserCustomPermission">REST API Reference for UpdateUserCustomPermission Operation</seealso>
        IAsyncResult BeginUpdateUserCustomPermission(UpdateUserCustomPermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserCustomPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserCustomPermission.</param>
        /// 
        /// <returns>Returns a  UpdateUserCustomPermissionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUserCustomPermission">REST API Reference for UpdateUserCustomPermission Operation</seealso>
        UpdateUserCustomPermissionResponse EndUpdateUserCustomPermission(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVPCConnection


        /// <summary>
        /// Updates a VPC connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVPCConnection service method.</param>
        /// 
        /// <returns>The response from the UpdateVPCConnection service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon Quick Sight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon Quick Suite subscription
        /// where the edition doesn't include support for that operation. Amazon Quick Suite currently
        /// has Standard Edition and Enterprise Edition. Not every operation and capability is
        /// available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateVPCConnection">REST API Reference for UpdateVPCConnection Operation</seealso>
        UpdateVPCConnectionResponse UpdateVPCConnection(UpdateVPCConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVPCConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVPCConnection operation on AmazonQuickSightClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVPCConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateVPCConnection">REST API Reference for UpdateVPCConnection Operation</seealso>
        IAsyncResult BeginUpdateVPCConnection(UpdateVPCConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVPCConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVPCConnection.</param>
        /// 
        /// <returns>Returns a  UpdateVPCConnectionResult from QuickSight.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateVPCConnection">REST API Reference for UpdateVPCConnection Operation</seealso>
        UpdateVPCConnectionResponse EndUpdateVPCConnection(IAsyncResult asyncResult);

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
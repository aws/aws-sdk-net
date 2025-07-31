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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SimpleEmailV2.Model;

#pragma warning disable CS1570
namespace Amazon.SimpleEmailV2
{
    /// <summary>
    /// <para>Interface for accessing SimpleEmailServiceV2</para>
    ///
    /// Amazon SES API v2 
    /// <para>
    ///  <a href="http://aws.amazon.com/ses">Amazon SES</a> is an Amazon Web Services service
    /// that you can use to send email messages to your customers.
    /// </para>
    ///  
    /// <para>
    /// If you're new to Amazon SES API v2, you might find it helpful to review the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/">Amazon
    /// Simple Email Service Developer Guide</a>. The <i>Amazon SES Developer Guide</i> provides
    /// information and code samples that demonstrate how to use Amazon SES API v2 features
    /// programmatically.
    /// </para>
    /// </summary>
    public partial interface IAmazonSimpleEmailServiceV2 : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISimpleEmailV2PaginatorFactory Paginators { get; }
#endif


        
        #region  BatchGetMetricData


        /// <summary>
        /// Retrieves batches of metric data collected based on your sending activity.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than 16 times per second, and with at most
        /// 160 queries from the batches per second (cumulative).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetMetricData service method.</param>
        /// 
        /// <returns>The response from the BatchGetMetricData service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.InternalServiceErrorException">
        /// The request couldn't be processed because an error occurred with the Amazon SES API
        /// v2.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/BatchGetMetricData">REST API Reference for BatchGetMetricData Operation</seealso>
        BatchGetMetricDataResponse BatchGetMetricData(BatchGetMetricDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetMetricData operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetMetricData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/BatchGetMetricData">REST API Reference for BatchGetMetricData Operation</seealso>
        IAsyncResult BeginBatchGetMetricData(BatchGetMetricDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetMetricData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetMetricData.</param>
        /// 
        /// <returns>Returns a  BatchGetMetricDataResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/BatchGetMetricData">REST API Reference for BatchGetMetricData Operation</seealso>
        BatchGetMetricDataResponse EndBatchGetMetricData(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelExportJob


        /// <summary>
        /// Cancels an export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelExportJob service method.</param>
        /// 
        /// <returns>The response from the CancelExportJob service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CancelExportJob">REST API Reference for CancelExportJob Operation</seealso>
        CancelExportJobResponse CancelExportJob(CancelExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelExportJob operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CancelExportJob">REST API Reference for CancelExportJob Operation</seealso>
        IAsyncResult BeginCancelExportJob(CancelExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelExportJob.</param>
        /// 
        /// <returns>Returns a  CancelExportJobResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CancelExportJob">REST API Reference for CancelExportJob Operation</seealso>
        CancelExportJobResponse EndCancelExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConfigurationSet


        /// <summary>
        /// Create a configuration set. <i>Configuration sets</i> are groups of rules that you
        /// can apply to the emails that you send. You apply a configuration set to an email by
        /// specifying the name of the configuration set when you call the Amazon SES API v2.
        /// When you apply a configuration set to an email, all of the rules in that configuration
        /// set are applied to the email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationSet service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        CreateConfigurationSetResponse CreateConfigurationSet(CreateConfigurationSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfigurationSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        IAsyncResult BeginCreateConfigurationSet(CreateConfigurationSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfigurationSet.</param>
        /// 
        /// <returns>Returns a  CreateConfigurationSetResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        CreateConfigurationSetResponse EndCreateConfigurationSet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConfigurationSetEventDestination


        /// <summary>
        /// Create an event destination. <i>Events</i> include message sends, deliveries, opens,
        /// clicks, bounces, and complaints. <i>Event destinations</i> are places that you can
        /// send information about these events to. For example, you can send event data to Amazon
        /// EventBridge and associate a rule to send the event to the specified target.
        /// 
        ///  
        /// <para>
        /// A single configuration set can include more than one event destination.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationSetEventDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateConfigurationSetEventDestination">REST API Reference for CreateConfigurationSetEventDestination Operation</seealso>
        CreateConfigurationSetEventDestinationResponse CreateConfigurationSetEventDestination(CreateConfigurationSetEventDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetEventDestination operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfigurationSetEventDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateConfigurationSetEventDestination">REST API Reference for CreateConfigurationSetEventDestination Operation</seealso>
        IAsyncResult BeginCreateConfigurationSetEventDestination(CreateConfigurationSetEventDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfigurationSetEventDestination.</param>
        /// 
        /// <returns>Returns a  CreateConfigurationSetEventDestinationResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateConfigurationSetEventDestination">REST API Reference for CreateConfigurationSetEventDestination Operation</seealso>
        CreateConfigurationSetEventDestinationResponse EndCreateConfigurationSetEventDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateContact


        /// <summary>
        /// Creates a contact, which is an end-user who is receiving the email, and adds them
        /// to a contact list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContact service method.</param>
        /// 
        /// <returns>The response from the CreateContact service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateContact">REST API Reference for CreateContact Operation</seealso>
        CreateContactResponse CreateContact(CreateContactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContact operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateContact">REST API Reference for CreateContact Operation</seealso>
        IAsyncResult BeginCreateContact(CreateContactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContact.</param>
        /// 
        /// <returns>Returns a  CreateContactResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateContact">REST API Reference for CreateContact Operation</seealso>
        CreateContactResponse EndCreateContact(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateContactList


        /// <summary>
        /// Creates a contact list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContactList service method.</param>
        /// 
        /// <returns>The response from the CreateContactList service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateContactList">REST API Reference for CreateContactList Operation</seealso>
        CreateContactListResponse CreateContactList(CreateContactListRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateContactList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContactList operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContactList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateContactList">REST API Reference for CreateContactList Operation</seealso>
        IAsyncResult BeginCreateContactList(CreateContactListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContactList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContactList.</param>
        /// 
        /// <returns>Returns a  CreateContactListResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateContactList">REST API Reference for CreateContactList Operation</seealso>
        CreateContactListResponse EndCreateContactList(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCustomVerificationEmailTemplate


        /// <summary>
        /// Creates a new custom verification email template.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// custom verification email templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomVerificationEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateCustomVerificationEmailTemplate service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateCustomVerificationEmailTemplate">REST API Reference for CreateCustomVerificationEmailTemplate Operation</seealso>
        CreateCustomVerificationEmailTemplateResponse CreateCustomVerificationEmailTemplate(CreateCustomVerificationEmailTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomVerificationEmailTemplate operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomVerificationEmailTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateCustomVerificationEmailTemplate">REST API Reference for CreateCustomVerificationEmailTemplate Operation</seealso>
        IAsyncResult BeginCreateCustomVerificationEmailTemplate(CreateCustomVerificationEmailTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomVerificationEmailTemplate.</param>
        /// 
        /// <returns>Returns a  CreateCustomVerificationEmailTemplateResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateCustomVerificationEmailTemplate">REST API Reference for CreateCustomVerificationEmailTemplate Operation</seealso>
        CreateCustomVerificationEmailTemplateResponse EndCreateCustomVerificationEmailTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDedicatedIpPool


        /// <summary>
        /// Create a new pool of dedicated IP addresses. A pool can include one or more dedicated
        /// IP addresses that are associated with your Amazon Web Services account. You can associate
        /// a pool with a configuration set. When you send an email that uses that configuration
        /// set, the message is sent from one of the addresses in the associated pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDedicatedIpPool service method.</param>
        /// 
        /// <returns>The response from the CreateDedicatedIpPool service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateDedicatedIpPool">REST API Reference for CreateDedicatedIpPool Operation</seealso>
        CreateDedicatedIpPoolResponse CreateDedicatedIpPool(CreateDedicatedIpPoolRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDedicatedIpPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDedicatedIpPool operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDedicatedIpPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateDedicatedIpPool">REST API Reference for CreateDedicatedIpPool Operation</seealso>
        IAsyncResult BeginCreateDedicatedIpPool(CreateDedicatedIpPoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDedicatedIpPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDedicatedIpPool.</param>
        /// 
        /// <returns>Returns a  CreateDedicatedIpPoolResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateDedicatedIpPool">REST API Reference for CreateDedicatedIpPool Operation</seealso>
        CreateDedicatedIpPoolResponse EndCreateDedicatedIpPool(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDeliverabilityTestReport


        /// <summary>
        /// Create a new predictive inbox placement test. Predictive inbox placement tests can
        /// help you predict how your messages will be handled by various email providers around
        /// the world. When you perform a predictive inbox placement test, you provide a sample
        /// message that contains the content that you plan to send to your customers. Amazon
        /// SES then sends that message to special email addresses spread across several major
        /// email providers. After about 24 hours, the test is complete, and you can use the <c>GetDeliverabilityTestReport</c>
        /// operation to view the results of the test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeliverabilityTestReport service method.</param>
        /// 
        /// <returns>The response from the CreateDeliverabilityTestReport service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AccountSuspendedException">
        /// The message can't be sent because the account's ability to send email has been permanently
        /// restricted.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MailFromDomainNotVerifiedException">
        /// The message can't be sent because the sending domain isn't verified.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MessageRejectedException">
        /// The message can't be sent because it contains invalid content.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.SendingPausedException">
        /// The message can't be sent because the account's ability to send email is currently
        /// paused.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateDeliverabilityTestReport">REST API Reference for CreateDeliverabilityTestReport Operation</seealso>
        CreateDeliverabilityTestReportResponse CreateDeliverabilityTestReport(CreateDeliverabilityTestReportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeliverabilityTestReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeliverabilityTestReport operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeliverabilityTestReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateDeliverabilityTestReport">REST API Reference for CreateDeliverabilityTestReport Operation</seealso>
        IAsyncResult BeginCreateDeliverabilityTestReport(CreateDeliverabilityTestReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeliverabilityTestReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeliverabilityTestReport.</param>
        /// 
        /// <returns>Returns a  CreateDeliverabilityTestReportResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateDeliverabilityTestReport">REST API Reference for CreateDeliverabilityTestReport Operation</seealso>
        CreateDeliverabilityTestReportResponse EndCreateDeliverabilityTestReport(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEmailIdentity


        /// <summary>
        /// Starts the process of verifying an email identity. An <i>identity</i> is an email
        /// address or domain that you use when you send email. Before you can use an identity
        /// to send email, you first have to verify it. By verifying an identity, you demonstrate
        /// that you're the owner of the identity, and that you've given Amazon SES API v2 permission
        /// to send email from the identity.
        /// 
        ///  
        /// <para>
        /// When you verify an email address, Amazon SES sends an email to the address. Your email
        /// address is verified as soon as you follow the link in the verification email. 
        /// </para>
        ///  
        /// <para>
        /// When you verify a domain without specifying the <c>DkimSigningAttributes</c> object,
        /// this operation provides a set of DKIM tokens. You can convert these tokens into CNAME
        /// records, which you then add to the DNS configuration for your domain. Your domain
        /// is verified when Amazon SES detects these records in the DNS configuration for your
        /// domain. This verification method is known as <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Easy
        /// DKIM</a>.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can perform the verification process by providing your own public-private
        /// key pair. This verification method is known as Bring Your Own DKIM (BYODKIM). To use
        /// BYODKIM, your call to the <c>CreateEmailIdentity</c> operation has to include the
        /// <c>DkimSigningAttributes</c> object. When you specify this object, you provide a selector
        /// (a component of the DNS record name that identifies the public key to use for DKIM
        /// authentication) and a private key.
        /// </para>
        ///  
        /// <para>
        /// When you verify a domain, this operation provides a set of DKIM tokens, which you
        /// can convert into CNAME tokens. You add these CNAME tokens to the DNS configuration
        /// for your domain. Your domain is verified when Amazon SES detects these records in
        /// the DNS configuration for your domain. For some DNS providers, it can take 72 hours
        /// or more to complete the domain verification process.
        /// </para>
        ///  
        /// <para>
        /// Additionally, you can associate an existing configuration set with the email identity
        /// that you're verifying.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailIdentity service method.</param>
        /// 
        /// <returns>The response from the CreateEmailIdentity service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateEmailIdentity">REST API Reference for CreateEmailIdentity Operation</seealso>
        CreateEmailIdentityResponse CreateEmailIdentity(CreateEmailIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailIdentity operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEmailIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateEmailIdentity">REST API Reference for CreateEmailIdentity Operation</seealso>
        IAsyncResult BeginCreateEmailIdentity(CreateEmailIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEmailIdentity.</param>
        /// 
        /// <returns>Returns a  CreateEmailIdentityResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateEmailIdentity">REST API Reference for CreateEmailIdentity Operation</seealso>
        CreateEmailIdentityResponse EndCreateEmailIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEmailIdentityPolicy


        /// <summary>
        /// Creates the specified sending authorization policy for the given identity (an email
        /// address or a domain).
        /// 
        ///  <note> 
        /// <para>
        /// This API is for the identity owner only. If you have not verified the identity, this
        /// API will return an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailIdentityPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateEmailIdentityPolicy service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateEmailIdentityPolicy">REST API Reference for CreateEmailIdentityPolicy Operation</seealso>
        CreateEmailIdentityPolicyResponse CreateEmailIdentityPolicy(CreateEmailIdentityPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEmailIdentityPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailIdentityPolicy operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEmailIdentityPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateEmailIdentityPolicy">REST API Reference for CreateEmailIdentityPolicy Operation</seealso>
        IAsyncResult BeginCreateEmailIdentityPolicy(CreateEmailIdentityPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEmailIdentityPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEmailIdentityPolicy.</param>
        /// 
        /// <returns>Returns a  CreateEmailIdentityPolicyResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateEmailIdentityPolicy">REST API Reference for CreateEmailIdentityPolicy Operation</seealso>
        CreateEmailIdentityPolicyResponse EndCreateEmailIdentityPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEmailTemplate


        /// <summary>
        /// Creates an email template. Email templates enable you to send personalized email to
        /// one or more destinations in a single API operation. For more information, see the
        /// <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/send-personalized-email-api.html">Amazon
        /// SES Developer Guide</a>.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateEmailTemplate service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateEmailTemplate">REST API Reference for CreateEmailTemplate Operation</seealso>
        CreateEmailTemplateResponse CreateEmailTemplate(CreateEmailTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailTemplate operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEmailTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateEmailTemplate">REST API Reference for CreateEmailTemplate Operation</seealso>
        IAsyncResult BeginCreateEmailTemplate(CreateEmailTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEmailTemplate.</param>
        /// 
        /// <returns>Returns a  CreateEmailTemplateResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateEmailTemplate">REST API Reference for CreateEmailTemplate Operation</seealso>
        CreateEmailTemplateResponse EndCreateEmailTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateExportJob


        /// <summary>
        /// Creates an export job for a data source and destination.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExportJob service method.</param>
        /// 
        /// <returns>The response from the CreateExportJob service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateExportJob">REST API Reference for CreateExportJob Operation</seealso>
        CreateExportJobResponse CreateExportJob(CreateExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExportJob operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateExportJob">REST API Reference for CreateExportJob Operation</seealso>
        IAsyncResult BeginCreateExportJob(CreateExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExportJob.</param>
        /// 
        /// <returns>Returns a  CreateExportJobResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateExportJob">REST API Reference for CreateExportJob Operation</seealso>
        CreateExportJobResponse EndCreateExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateImportJob


        /// <summary>
        /// Creates an import job for a data destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImportJob service method.</param>
        /// 
        /// <returns>The response from the CreateImportJob service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateImportJob">REST API Reference for CreateImportJob Operation</seealso>
        CreateImportJobResponse CreateImportJob(CreateImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImportJob operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateImportJob">REST API Reference for CreateImportJob Operation</seealso>
        IAsyncResult BeginCreateImportJob(CreateImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImportJob.</param>
        /// 
        /// <returns>Returns a  CreateImportJobResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateImportJob">REST API Reference for CreateImportJob Operation</seealso>
        CreateImportJobResponse EndCreateImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMultiRegionEndpoint


        /// <summary>
        /// Creates a multi-region endpoint (global-endpoint).
        /// 
        ///  
        /// <para>
        /// The primary region is going to be the AWS-Region where the operation is executed.
        /// The secondary region has to be provided in request's parameters. From the data flow
        /// standpoint there is no difference between primary and secondary regions - sending
        /// traffic will be split equally between the two. The primary region is the region where
        /// the resource has been created and where it can be managed. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMultiRegionEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateMultiRegionEndpoint service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateMultiRegionEndpoint">REST API Reference for CreateMultiRegionEndpoint Operation</seealso>
        CreateMultiRegionEndpointResponse CreateMultiRegionEndpoint(CreateMultiRegionEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMultiRegionEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMultiRegionEndpoint operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMultiRegionEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateMultiRegionEndpoint">REST API Reference for CreateMultiRegionEndpoint Operation</seealso>
        IAsyncResult BeginCreateMultiRegionEndpoint(CreateMultiRegionEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMultiRegionEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMultiRegionEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateMultiRegionEndpointResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateMultiRegionEndpoint">REST API Reference for CreateMultiRegionEndpoint Operation</seealso>
        CreateMultiRegionEndpointResponse EndCreateMultiRegionEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTenant


        /// <summary>
        /// Create a tenant.
        /// 
        ///  
        /// <para>
        ///  <i>Tenants</i> are logical containers that group related SES resources together.
        /// Each tenant can have its own set of resources like email identities, configuration
        /// sets, and templates, along with reputation metrics and sending status. This helps
        /// isolate and manage email sending for different customers or business units within
        /// your Amazon SES API v2 account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTenant service method.</param>
        /// 
        /// <returns>The response from the CreateTenant service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateTenant">REST API Reference for CreateTenant Operation</seealso>
        CreateTenantResponse CreateTenant(CreateTenantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTenant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTenant operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTenant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateTenant">REST API Reference for CreateTenant Operation</seealso>
        IAsyncResult BeginCreateTenant(CreateTenantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTenant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTenant.</param>
        /// 
        /// <returns>Returns a  CreateTenantResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateTenant">REST API Reference for CreateTenant Operation</seealso>
        CreateTenantResponse EndCreateTenant(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTenantResourceAssociation


        /// <summary>
        /// Associate a resource with a tenant.
        /// 
        ///  
        /// <para>
        ///  <i>Resources</i> can be email identities, configuration sets, or email templates.
        /// When you associate a resource with a tenant, you can use that resource when sending
        /// emails on behalf of that tenant.
        /// </para>
        ///  
        /// <para>
        /// A single resource can be associated with multiple tenants, allowing for resource sharing
        /// across different tenants while maintaining isolation in email sending operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTenantResourceAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateTenantResourceAssociation service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateTenantResourceAssociation">REST API Reference for CreateTenantResourceAssociation Operation</seealso>
        CreateTenantResourceAssociationResponse CreateTenantResourceAssociation(CreateTenantResourceAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTenantResourceAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTenantResourceAssociation operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTenantResourceAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateTenantResourceAssociation">REST API Reference for CreateTenantResourceAssociation Operation</seealso>
        IAsyncResult BeginCreateTenantResourceAssociation(CreateTenantResourceAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTenantResourceAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTenantResourceAssociation.</param>
        /// 
        /// <returns>Returns a  CreateTenantResourceAssociationResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateTenantResourceAssociation">REST API Reference for CreateTenantResourceAssociation Operation</seealso>
        CreateTenantResourceAssociationResponse EndCreateTenantResourceAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConfigurationSet


        /// <summary>
        /// Delete an existing configuration set.
        /// 
        ///  
        /// <para>
        ///  <i>Configuration sets</i> are groups of rules that you can apply to the emails you
        /// send. You apply a configuration set to an email by including a reference to the configuration
        /// set in the headers of the email. When you apply a configuration set to an email, all
        /// of the rules in that configuration set are applied to the email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationSet service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        DeleteConfigurationSetResponse DeleteConfigurationSet(DeleteConfigurationSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigurationSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        IAsyncResult BeginDeleteConfigurationSet(DeleteConfigurationSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationSet.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationSetResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        DeleteConfigurationSetResponse EndDeleteConfigurationSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConfigurationSetEventDestination


        /// <summary>
        /// Delete an event destination.
        /// 
        ///  
        /// <para>
        ///  <i>Events</i> include message sends, deliveries, opens, clicks, bounces, and complaints.
        /// <i>Event destinations</i> are places that you can send information about these events
        /// to. For example, you can send event data to Amazon EventBridge and associate a rule
        /// to send the event to the specified target.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationSetEventDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteConfigurationSetEventDestination">REST API Reference for DeleteConfigurationSetEventDestination Operation</seealso>
        DeleteConfigurationSetEventDestinationResponse DeleteConfigurationSetEventDestination(DeleteConfigurationSetEventDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetEventDestination operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigurationSetEventDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteConfigurationSetEventDestination">REST API Reference for DeleteConfigurationSetEventDestination Operation</seealso>
        IAsyncResult BeginDeleteConfigurationSetEventDestination(DeleteConfigurationSetEventDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationSetEventDestination.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationSetEventDestinationResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteConfigurationSetEventDestination">REST API Reference for DeleteConfigurationSetEventDestination Operation</seealso>
        DeleteConfigurationSetEventDestinationResponse EndDeleteConfigurationSetEventDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteContact


        /// <summary>
        /// Removes a contact from a contact list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContact service method.</param>
        /// 
        /// <returns>The response from the DeleteContact service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteContact">REST API Reference for DeleteContact Operation</seealso>
        DeleteContactResponse DeleteContact(DeleteContactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContact operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteContact">REST API Reference for DeleteContact Operation</seealso>
        IAsyncResult BeginDeleteContact(DeleteContactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContact.</param>
        /// 
        /// <returns>Returns a  DeleteContactResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteContact">REST API Reference for DeleteContact Operation</seealso>
        DeleteContactResponse EndDeleteContact(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteContactList


        /// <summary>
        /// Deletes a contact list and all of the contacts on that list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContactList service method.</param>
        /// 
        /// <returns>The response from the DeleteContactList service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteContactList">REST API Reference for DeleteContactList Operation</seealso>
        DeleteContactListResponse DeleteContactList(DeleteContactListRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContactList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContactList operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContactList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteContactList">REST API Reference for DeleteContactList Operation</seealso>
        IAsyncResult BeginDeleteContactList(DeleteContactListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContactList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContactList.</param>
        /// 
        /// <returns>Returns a  DeleteContactListResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteContactList">REST API Reference for DeleteContactList Operation</seealso>
        DeleteContactListResponse EndDeleteContactList(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCustomVerificationEmailTemplate


        /// <summary>
        /// Deletes an existing custom verification email template.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// custom verification email templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomVerificationEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomVerificationEmailTemplate service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteCustomVerificationEmailTemplate">REST API Reference for DeleteCustomVerificationEmailTemplate Operation</seealso>
        DeleteCustomVerificationEmailTemplateResponse DeleteCustomVerificationEmailTemplate(DeleteCustomVerificationEmailTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomVerificationEmailTemplate operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomVerificationEmailTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteCustomVerificationEmailTemplate">REST API Reference for DeleteCustomVerificationEmailTemplate Operation</seealso>
        IAsyncResult BeginDeleteCustomVerificationEmailTemplate(DeleteCustomVerificationEmailTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomVerificationEmailTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteCustomVerificationEmailTemplateResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteCustomVerificationEmailTemplate">REST API Reference for DeleteCustomVerificationEmailTemplate Operation</seealso>
        DeleteCustomVerificationEmailTemplateResponse EndDeleteCustomVerificationEmailTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDedicatedIpPool


        /// <summary>
        /// Delete a dedicated IP pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDedicatedIpPool service method.</param>
        /// 
        /// <returns>The response from the DeleteDedicatedIpPool service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteDedicatedIpPool">REST API Reference for DeleteDedicatedIpPool Operation</seealso>
        DeleteDedicatedIpPoolResponse DeleteDedicatedIpPool(DeleteDedicatedIpPoolRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDedicatedIpPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDedicatedIpPool operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDedicatedIpPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteDedicatedIpPool">REST API Reference for DeleteDedicatedIpPool Operation</seealso>
        IAsyncResult BeginDeleteDedicatedIpPool(DeleteDedicatedIpPoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDedicatedIpPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDedicatedIpPool.</param>
        /// 
        /// <returns>Returns a  DeleteDedicatedIpPoolResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteDedicatedIpPool">REST API Reference for DeleteDedicatedIpPool Operation</seealso>
        DeleteDedicatedIpPoolResponse EndDeleteDedicatedIpPool(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEmailIdentity


        /// <summary>
        /// Deletes an email identity. An identity can be either an email address or a domain
        /// name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteEmailIdentity service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteEmailIdentity">REST API Reference for DeleteEmailIdentity Operation</seealso>
        DeleteEmailIdentityResponse DeleteEmailIdentity(DeleteEmailIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailIdentity operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEmailIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteEmailIdentity">REST API Reference for DeleteEmailIdentity Operation</seealso>
        IAsyncResult BeginDeleteEmailIdentity(DeleteEmailIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEmailIdentity.</param>
        /// 
        /// <returns>Returns a  DeleteEmailIdentityResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteEmailIdentity">REST API Reference for DeleteEmailIdentity Operation</seealso>
        DeleteEmailIdentityResponse EndDeleteEmailIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEmailIdentityPolicy


        /// <summary>
        /// Deletes the specified sending authorization policy for the given identity (an email
        /// address or a domain). This API returns successfully even if a policy with the specified
        /// name does not exist.
        /// 
        ///  <note> 
        /// <para>
        /// This API is for the identity owner only. If you have not verified the identity, this
        /// API will return an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailIdentityPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteEmailIdentityPolicy service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteEmailIdentityPolicy">REST API Reference for DeleteEmailIdentityPolicy Operation</seealso>
        DeleteEmailIdentityPolicyResponse DeleteEmailIdentityPolicy(DeleteEmailIdentityPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEmailIdentityPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailIdentityPolicy operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEmailIdentityPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteEmailIdentityPolicy">REST API Reference for DeleteEmailIdentityPolicy Operation</seealso>
        IAsyncResult BeginDeleteEmailIdentityPolicy(DeleteEmailIdentityPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEmailIdentityPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEmailIdentityPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteEmailIdentityPolicyResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteEmailIdentityPolicy">REST API Reference for DeleteEmailIdentityPolicy Operation</seealso>
        DeleteEmailIdentityPolicyResponse EndDeleteEmailIdentityPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEmailTemplate


        /// <summary>
        /// Deletes an email template.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteEmailTemplate service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteEmailTemplate">REST API Reference for DeleteEmailTemplate Operation</seealso>
        DeleteEmailTemplateResponse DeleteEmailTemplate(DeleteEmailTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailTemplate operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEmailTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteEmailTemplate">REST API Reference for DeleteEmailTemplate Operation</seealso>
        IAsyncResult BeginDeleteEmailTemplate(DeleteEmailTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEmailTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteEmailTemplateResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteEmailTemplate">REST API Reference for DeleteEmailTemplate Operation</seealso>
        DeleteEmailTemplateResponse EndDeleteEmailTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMultiRegionEndpoint


        /// <summary>
        /// Deletes a multi-region endpoint (global-endpoint).
        /// 
        ///  
        /// <para>
        /// Only multi-region endpoints (global-endpoints) whose primary region is the AWS-Region
        /// where operation is executed can be deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMultiRegionEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteMultiRegionEndpoint service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteMultiRegionEndpoint">REST API Reference for DeleteMultiRegionEndpoint Operation</seealso>
        DeleteMultiRegionEndpointResponse DeleteMultiRegionEndpoint(DeleteMultiRegionEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMultiRegionEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMultiRegionEndpoint operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMultiRegionEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteMultiRegionEndpoint">REST API Reference for DeleteMultiRegionEndpoint Operation</seealso>
        IAsyncResult BeginDeleteMultiRegionEndpoint(DeleteMultiRegionEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMultiRegionEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMultiRegionEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteMultiRegionEndpointResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteMultiRegionEndpoint">REST API Reference for DeleteMultiRegionEndpoint Operation</seealso>
        DeleteMultiRegionEndpointResponse EndDeleteMultiRegionEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSuppressedDestination


        /// <summary>
        /// Removes an email address from the suppression list for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSuppressedDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteSuppressedDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteSuppressedDestination">REST API Reference for DeleteSuppressedDestination Operation</seealso>
        DeleteSuppressedDestinationResponse DeleteSuppressedDestination(DeleteSuppressedDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSuppressedDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSuppressedDestination operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSuppressedDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteSuppressedDestination">REST API Reference for DeleteSuppressedDestination Operation</seealso>
        IAsyncResult BeginDeleteSuppressedDestination(DeleteSuppressedDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSuppressedDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSuppressedDestination.</param>
        /// 
        /// <returns>Returns a  DeleteSuppressedDestinationResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteSuppressedDestination">REST API Reference for DeleteSuppressedDestination Operation</seealso>
        DeleteSuppressedDestinationResponse EndDeleteSuppressedDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTenant


        /// <summary>
        /// Delete an existing tenant.
        /// 
        ///  
        /// <para>
        /// When you delete a tenant, its associations with resources are removed, but the resources
        /// themselves are not deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTenant service method.</param>
        /// 
        /// <returns>The response from the DeleteTenant service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteTenant">REST API Reference for DeleteTenant Operation</seealso>
        DeleteTenantResponse DeleteTenant(DeleteTenantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTenant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTenant operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTenant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteTenant">REST API Reference for DeleteTenant Operation</seealso>
        IAsyncResult BeginDeleteTenant(DeleteTenantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTenant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTenant.</param>
        /// 
        /// <returns>Returns a  DeleteTenantResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteTenant">REST API Reference for DeleteTenant Operation</seealso>
        DeleteTenantResponse EndDeleteTenant(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTenantResourceAssociation


        /// <summary>
        /// Delete an association between a tenant and a resource.
        /// 
        ///  
        /// <para>
        /// When you delete a tenant-resource association, the resource itself is not deleted,
        /// only its association with the specific tenant is removed. After removal, the resource
        /// will no longer be available for use with that tenant's email sending operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTenantResourceAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteTenantResourceAssociation service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteTenantResourceAssociation">REST API Reference for DeleteTenantResourceAssociation Operation</seealso>
        DeleteTenantResourceAssociationResponse DeleteTenantResourceAssociation(DeleteTenantResourceAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTenantResourceAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTenantResourceAssociation operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTenantResourceAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteTenantResourceAssociation">REST API Reference for DeleteTenantResourceAssociation Operation</seealso>
        IAsyncResult BeginDeleteTenantResourceAssociation(DeleteTenantResourceAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTenantResourceAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTenantResourceAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteTenantResourceAssociationResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/DeleteTenantResourceAssociation">REST API Reference for DeleteTenantResourceAssociation Operation</seealso>
        DeleteTenantResourceAssociationResponse EndDeleteTenantResourceAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccount


        /// <summary>
        /// Obtain information about the email-sending status and capabilities of your Amazon
        /// SES account in the current Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccount service method.</param>
        /// 
        /// <returns>The response from the GetAccount service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetAccount">REST API Reference for GetAccount Operation</seealso>
        GetAccountResponse GetAccount(GetAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccount operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetAccount">REST API Reference for GetAccount Operation</seealso>
        IAsyncResult BeginGetAccount(GetAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccount.</param>
        /// 
        /// <returns>Returns a  GetAccountResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetAccount">REST API Reference for GetAccount Operation</seealso>
        GetAccountResponse EndGetAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBlacklistReports


        /// <summary>
        /// Retrieve a list of the blacklists that your dedicated IP addresses appear on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlacklistReports service method.</param>
        /// 
        /// <returns>The response from the GetBlacklistReports service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetBlacklistReports">REST API Reference for GetBlacklistReports Operation</seealso>
        GetBlacklistReportsResponse GetBlacklistReports(GetBlacklistReportsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBlacklistReports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBlacklistReports operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBlacklistReports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetBlacklistReports">REST API Reference for GetBlacklistReports Operation</seealso>
        IAsyncResult BeginGetBlacklistReports(GetBlacklistReportsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBlacklistReports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBlacklistReports.</param>
        /// 
        /// <returns>Returns a  GetBlacklistReportsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetBlacklistReports">REST API Reference for GetBlacklistReports Operation</seealso>
        GetBlacklistReportsResponse EndGetBlacklistReports(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConfigurationSet


        /// <summary>
        /// Get information about an existing configuration set, including the dedicated IP pool
        /// that it's associated with, whether or not it's enabled for sending email, and more.
        /// 
        ///  
        /// <para>
        ///  <i>Configuration sets</i> are groups of rules that you can apply to the emails you
        /// send. You apply a configuration set to an email by including a reference to the configuration
        /// set in the headers of the email. When you apply a configuration set to an email, all
        /// of the rules in that configuration set are applied to the email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the GetConfigurationSet service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetConfigurationSet">REST API Reference for GetConfigurationSet Operation</seealso>
        GetConfigurationSetResponse GetConfigurationSet(GetConfigurationSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSet operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfigurationSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetConfigurationSet">REST API Reference for GetConfigurationSet Operation</seealso>
        IAsyncResult BeginGetConfigurationSet(GetConfigurationSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfigurationSet.</param>
        /// 
        /// <returns>Returns a  GetConfigurationSetResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetConfigurationSet">REST API Reference for GetConfigurationSet Operation</seealso>
        GetConfigurationSetResponse EndGetConfigurationSet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConfigurationSetEventDestinations


        /// <summary>
        /// Retrieve a list of event destinations that are associated with a configuration set.
        /// 
        ///  
        /// <para>
        ///  <i>Events</i> include message sends, deliveries, opens, clicks, bounces, and complaints.
        /// <i>Event destinations</i> are places that you can send information about these events
        /// to. For example, you can send event data to Amazon EventBridge and associate a rule
        /// to send the event to the specified target.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSetEventDestinations service method.</param>
        /// 
        /// <returns>The response from the GetConfigurationSetEventDestinations service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetConfigurationSetEventDestinations">REST API Reference for GetConfigurationSetEventDestinations Operation</seealso>
        GetConfigurationSetEventDestinationsResponse GetConfigurationSetEventDestinations(GetConfigurationSetEventDestinationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfigurationSetEventDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSetEventDestinations operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfigurationSetEventDestinations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetConfigurationSetEventDestinations">REST API Reference for GetConfigurationSetEventDestinations Operation</seealso>
        IAsyncResult BeginGetConfigurationSetEventDestinations(GetConfigurationSetEventDestinationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfigurationSetEventDestinations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfigurationSetEventDestinations.</param>
        /// 
        /// <returns>Returns a  GetConfigurationSetEventDestinationsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetConfigurationSetEventDestinations">REST API Reference for GetConfigurationSetEventDestinations Operation</seealso>
        GetConfigurationSetEventDestinationsResponse EndGetConfigurationSetEventDestinations(IAsyncResult asyncResult);

        #endregion
        
        #region  GetContact


        /// <summary>
        /// Returns a contact from a contact list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContact service method.</param>
        /// 
        /// <returns>The response from the GetContact service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetContact">REST API Reference for GetContact Operation</seealso>
        GetContactResponse GetContact(GetContactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContact operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetContact">REST API Reference for GetContact Operation</seealso>
        IAsyncResult BeginGetContact(GetContactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContact.</param>
        /// 
        /// <returns>Returns a  GetContactResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetContact">REST API Reference for GetContact Operation</seealso>
        GetContactResponse EndGetContact(IAsyncResult asyncResult);

        #endregion
        
        #region  GetContactList


        /// <summary>
        /// Returns contact list metadata. It does not return any information about the contacts
        /// present in the list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactList service method.</param>
        /// 
        /// <returns>The response from the GetContactList service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetContactList">REST API Reference for GetContactList Operation</seealso>
        GetContactListResponse GetContactList(GetContactListRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetContactList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContactList operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContactList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetContactList">REST API Reference for GetContactList Operation</seealso>
        IAsyncResult BeginGetContactList(GetContactListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContactList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContactList.</param>
        /// 
        /// <returns>Returns a  GetContactListResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetContactList">REST API Reference for GetContactList Operation</seealso>
        GetContactListResponse EndGetContactList(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCustomVerificationEmailTemplate


        /// <summary>
        /// Returns the custom email verification template for the template name you specify.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// custom verification email templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomVerificationEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the GetCustomVerificationEmailTemplate service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetCustomVerificationEmailTemplate">REST API Reference for GetCustomVerificationEmailTemplate Operation</seealso>
        GetCustomVerificationEmailTemplateResponse GetCustomVerificationEmailTemplate(GetCustomVerificationEmailTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCustomVerificationEmailTemplate operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCustomVerificationEmailTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetCustomVerificationEmailTemplate">REST API Reference for GetCustomVerificationEmailTemplate Operation</seealso>
        IAsyncResult BeginGetCustomVerificationEmailTemplate(GetCustomVerificationEmailTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCustomVerificationEmailTemplate.</param>
        /// 
        /// <returns>Returns a  GetCustomVerificationEmailTemplateResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetCustomVerificationEmailTemplate">REST API Reference for GetCustomVerificationEmailTemplate Operation</seealso>
        GetCustomVerificationEmailTemplateResponse EndGetCustomVerificationEmailTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDedicatedIp


        /// <summary>
        /// Get information about a dedicated IP address, including the name of the dedicated
        /// IP pool that it's associated with, as well information about the automatic warm-up
        /// process for the address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIp service method.</param>
        /// 
        /// <returns>The response from the GetDedicatedIp service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDedicatedIp">REST API Reference for GetDedicatedIp Operation</seealso>
        GetDedicatedIpResponse GetDedicatedIp(GetDedicatedIpRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDedicatedIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIp operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDedicatedIp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDedicatedIp">REST API Reference for GetDedicatedIp Operation</seealso>
        IAsyncResult BeginGetDedicatedIp(GetDedicatedIpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDedicatedIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDedicatedIp.</param>
        /// 
        /// <returns>Returns a  GetDedicatedIpResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDedicatedIp">REST API Reference for GetDedicatedIp Operation</seealso>
        GetDedicatedIpResponse EndGetDedicatedIp(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDedicatedIpPool


        /// <summary>
        /// Retrieve information about the dedicated pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIpPool service method.</param>
        /// 
        /// <returns>The response from the GetDedicatedIpPool service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDedicatedIpPool">REST API Reference for GetDedicatedIpPool Operation</seealso>
        GetDedicatedIpPoolResponse GetDedicatedIpPool(GetDedicatedIpPoolRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDedicatedIpPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIpPool operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDedicatedIpPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDedicatedIpPool">REST API Reference for GetDedicatedIpPool Operation</seealso>
        IAsyncResult BeginGetDedicatedIpPool(GetDedicatedIpPoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDedicatedIpPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDedicatedIpPool.</param>
        /// 
        /// <returns>Returns a  GetDedicatedIpPoolResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDedicatedIpPool">REST API Reference for GetDedicatedIpPool Operation</seealso>
        GetDedicatedIpPoolResponse EndGetDedicatedIpPool(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDedicatedIps


        /// <summary>
        /// List the dedicated IP addresses that are associated with your Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIps service method.</param>
        /// 
        /// <returns>The response from the GetDedicatedIps service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDedicatedIps">REST API Reference for GetDedicatedIps Operation</seealso>
        GetDedicatedIpsResponse GetDedicatedIps(GetDedicatedIpsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDedicatedIps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIps operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDedicatedIps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDedicatedIps">REST API Reference for GetDedicatedIps Operation</seealso>
        IAsyncResult BeginGetDedicatedIps(GetDedicatedIpsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDedicatedIps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDedicatedIps.</param>
        /// 
        /// <returns>Returns a  GetDedicatedIpsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDedicatedIps">REST API Reference for GetDedicatedIps Operation</seealso>
        GetDedicatedIpsResponse EndGetDedicatedIps(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDeliverabilityDashboardOptions


        /// <summary>
        /// Retrieve information about the status of the Deliverability dashboard for your account.
        /// When the Deliverability dashboard is enabled, you gain access to reputation, deliverability,
        /// and other metrics for the domains that you use to send email. You also gain the ability
        /// to perform predictive inbox placement tests.
        /// 
        ///  
        /// <para>
        /// When you use the Deliverability dashboard, you pay a monthly subscription charge,
        /// in addition to any other fees that you accrue by using Amazon SES and other Amazon
        /// Web Services services. For more information about the features and cost of a Deliverability
        /// dashboard subscription, see <a href="http://aws.amazon.com/ses/pricing/">Amazon SES
        /// Pricing</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityDashboardOptions service method.</param>
        /// 
        /// <returns>The response from the GetDeliverabilityDashboardOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDeliverabilityDashboardOptions">REST API Reference for GetDeliverabilityDashboardOptions Operation</seealso>
        GetDeliverabilityDashboardOptionsResponse GetDeliverabilityDashboardOptions(GetDeliverabilityDashboardOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeliverabilityDashboardOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityDashboardOptions operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeliverabilityDashboardOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDeliverabilityDashboardOptions">REST API Reference for GetDeliverabilityDashboardOptions Operation</seealso>
        IAsyncResult BeginGetDeliverabilityDashboardOptions(GetDeliverabilityDashboardOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeliverabilityDashboardOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeliverabilityDashboardOptions.</param>
        /// 
        /// <returns>Returns a  GetDeliverabilityDashboardOptionsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDeliverabilityDashboardOptions">REST API Reference for GetDeliverabilityDashboardOptions Operation</seealso>
        GetDeliverabilityDashboardOptionsResponse EndGetDeliverabilityDashboardOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDeliverabilityTestReport


        /// <summary>
        /// Retrieve the results of a predictive inbox placement test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityTestReport service method.</param>
        /// 
        /// <returns>The response from the GetDeliverabilityTestReport service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDeliverabilityTestReport">REST API Reference for GetDeliverabilityTestReport Operation</seealso>
        GetDeliverabilityTestReportResponse GetDeliverabilityTestReport(GetDeliverabilityTestReportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeliverabilityTestReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityTestReport operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeliverabilityTestReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDeliverabilityTestReport">REST API Reference for GetDeliverabilityTestReport Operation</seealso>
        IAsyncResult BeginGetDeliverabilityTestReport(GetDeliverabilityTestReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeliverabilityTestReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeliverabilityTestReport.</param>
        /// 
        /// <returns>Returns a  GetDeliverabilityTestReportResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDeliverabilityTestReport">REST API Reference for GetDeliverabilityTestReport Operation</seealso>
        GetDeliverabilityTestReportResponse EndGetDeliverabilityTestReport(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDomainDeliverabilityCampaign


        /// <summary>
        /// Retrieve all the deliverability data for a specific campaign. This data is available
        /// for a campaign only if the campaign sent email by using a domain that the Deliverability
        /// dashboard is enabled for.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDeliverabilityCampaign service method.</param>
        /// 
        /// <returns>The response from the GetDomainDeliverabilityCampaign service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDomainDeliverabilityCampaign">REST API Reference for GetDomainDeliverabilityCampaign Operation</seealso>
        GetDomainDeliverabilityCampaignResponse GetDomainDeliverabilityCampaign(GetDomainDeliverabilityCampaignRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainDeliverabilityCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDeliverabilityCampaign operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainDeliverabilityCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDomainDeliverabilityCampaign">REST API Reference for GetDomainDeliverabilityCampaign Operation</seealso>
        IAsyncResult BeginGetDomainDeliverabilityCampaign(GetDomainDeliverabilityCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainDeliverabilityCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainDeliverabilityCampaign.</param>
        /// 
        /// <returns>Returns a  GetDomainDeliverabilityCampaignResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDomainDeliverabilityCampaign">REST API Reference for GetDomainDeliverabilityCampaign Operation</seealso>
        GetDomainDeliverabilityCampaignResponse EndGetDomainDeliverabilityCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDomainStatisticsReport


        /// <summary>
        /// Retrieve inbox placement and engagement rates for the domains that you use to send
        /// email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainStatisticsReport service method.</param>
        /// 
        /// <returns>The response from the GetDomainStatisticsReport service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDomainStatisticsReport">REST API Reference for GetDomainStatisticsReport Operation</seealso>
        GetDomainStatisticsReportResponse GetDomainStatisticsReport(GetDomainStatisticsReportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainStatisticsReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainStatisticsReport operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainStatisticsReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDomainStatisticsReport">REST API Reference for GetDomainStatisticsReport Operation</seealso>
        IAsyncResult BeginGetDomainStatisticsReport(GetDomainStatisticsReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainStatisticsReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainStatisticsReport.</param>
        /// 
        /// <returns>Returns a  GetDomainStatisticsReportResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetDomainStatisticsReport">REST API Reference for GetDomainStatisticsReport Operation</seealso>
        GetDomainStatisticsReportResponse EndGetDomainStatisticsReport(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEmailIdentity


        /// <summary>
        /// Provides information about a specific identity, including the identity's verification
        /// status, sending authorization policies, its DKIM authentication status, and its custom
        /// Mail-From settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailIdentity service method.</param>
        /// 
        /// <returns>The response from the GetEmailIdentity service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetEmailIdentity">REST API Reference for GetEmailIdentity Operation</seealso>
        GetEmailIdentityResponse GetEmailIdentity(GetEmailIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEmailIdentity operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEmailIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetEmailIdentity">REST API Reference for GetEmailIdentity Operation</seealso>
        IAsyncResult BeginGetEmailIdentity(GetEmailIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEmailIdentity.</param>
        /// 
        /// <returns>Returns a  GetEmailIdentityResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetEmailIdentity">REST API Reference for GetEmailIdentity Operation</seealso>
        GetEmailIdentityResponse EndGetEmailIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEmailIdentityPolicies


        /// <summary>
        /// Returns the requested sending authorization policies for the given identity (an email
        /// address or a domain). The policies are returned as a map of policy names to policy
        /// contents. You can retrieve a maximum of 20 policies at a time.
        /// 
        ///  <note> 
        /// <para>
        /// This API is for the identity owner only. If you have not verified the identity, this
        /// API will return an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailIdentityPolicies service method.</param>
        /// 
        /// <returns>The response from the GetEmailIdentityPolicies service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetEmailIdentityPolicies">REST API Reference for GetEmailIdentityPolicies Operation</seealso>
        GetEmailIdentityPoliciesResponse GetEmailIdentityPolicies(GetEmailIdentityPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEmailIdentityPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEmailIdentityPolicies operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEmailIdentityPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetEmailIdentityPolicies">REST API Reference for GetEmailIdentityPolicies Operation</seealso>
        IAsyncResult BeginGetEmailIdentityPolicies(GetEmailIdentityPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEmailIdentityPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEmailIdentityPolicies.</param>
        /// 
        /// <returns>Returns a  GetEmailIdentityPoliciesResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetEmailIdentityPolicies">REST API Reference for GetEmailIdentityPolicies Operation</seealso>
        GetEmailIdentityPoliciesResponse EndGetEmailIdentityPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEmailTemplate


        /// <summary>
        /// Displays the template object (which includes the subject line, HTML part and text
        /// part) for the template you specify.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the GetEmailTemplate service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetEmailTemplate">REST API Reference for GetEmailTemplate Operation</seealso>
        GetEmailTemplateResponse GetEmailTemplate(GetEmailTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEmailTemplate operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEmailTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetEmailTemplate">REST API Reference for GetEmailTemplate Operation</seealso>
        IAsyncResult BeginGetEmailTemplate(GetEmailTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEmailTemplate.</param>
        /// 
        /// <returns>Returns a  GetEmailTemplateResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetEmailTemplate">REST API Reference for GetEmailTemplate Operation</seealso>
        GetEmailTemplateResponse EndGetEmailTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetExportJob


        /// <summary>
        /// Provides information about an export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExportJob service method.</param>
        /// 
        /// <returns>The response from the GetExportJob service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetExportJob">REST API Reference for GetExportJob Operation</seealso>
        GetExportJobResponse GetExportJob(GetExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExportJob operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetExportJob">REST API Reference for GetExportJob Operation</seealso>
        IAsyncResult BeginGetExportJob(GetExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExportJob.</param>
        /// 
        /// <returns>Returns a  GetExportJobResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetExportJob">REST API Reference for GetExportJob Operation</seealso>
        GetExportJobResponse EndGetExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetImportJob


        /// <summary>
        /// Provides information about an import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob service method.</param>
        /// 
        /// <returns>The response from the GetImportJob service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetImportJob">REST API Reference for GetImportJob Operation</seealso>
        GetImportJobResponse GetImportJob(GetImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetImportJob">REST API Reference for GetImportJob Operation</seealso>
        IAsyncResult BeginGetImportJob(GetImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImportJob.</param>
        /// 
        /// <returns>Returns a  GetImportJobResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetImportJob">REST API Reference for GetImportJob Operation</seealso>
        GetImportJobResponse EndGetImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMessageInsights


        /// <summary>
        /// Provides information about a specific message, including the from address, the subject,
        /// the recipient address, email tags, as well as events associated with the message.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMessageInsights service method.</param>
        /// 
        /// <returns>The response from the GetMessageInsights service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetMessageInsights">REST API Reference for GetMessageInsights Operation</seealso>
        GetMessageInsightsResponse GetMessageInsights(GetMessageInsightsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMessageInsights operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMessageInsights operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMessageInsights
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetMessageInsights">REST API Reference for GetMessageInsights Operation</seealso>
        IAsyncResult BeginGetMessageInsights(GetMessageInsightsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMessageInsights operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMessageInsights.</param>
        /// 
        /// <returns>Returns a  GetMessageInsightsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetMessageInsights">REST API Reference for GetMessageInsights Operation</seealso>
        GetMessageInsightsResponse EndGetMessageInsights(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMultiRegionEndpoint


        /// <summary>
        /// Displays the multi-region endpoint (global-endpoint) configuration.
        /// 
        ///  
        /// <para>
        /// Only multi-region endpoints (global-endpoints) whose primary region is the AWS-Region
        /// where operation is executed can be displayed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMultiRegionEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetMultiRegionEndpoint service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetMultiRegionEndpoint">REST API Reference for GetMultiRegionEndpoint Operation</seealso>
        GetMultiRegionEndpointResponse GetMultiRegionEndpoint(GetMultiRegionEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMultiRegionEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMultiRegionEndpoint operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMultiRegionEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetMultiRegionEndpoint">REST API Reference for GetMultiRegionEndpoint Operation</seealso>
        IAsyncResult BeginGetMultiRegionEndpoint(GetMultiRegionEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMultiRegionEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMultiRegionEndpoint.</param>
        /// 
        /// <returns>Returns a  GetMultiRegionEndpointResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetMultiRegionEndpoint">REST API Reference for GetMultiRegionEndpoint Operation</seealso>
        GetMultiRegionEndpointResponse EndGetMultiRegionEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReputationEntity


        /// <summary>
        /// Retrieve information about a specific reputation entity, including its reputation
        /// management policy, customer-managed status, Amazon Web Services Amazon SES-managed
        /// status, and aggregate sending status.
        /// 
        ///  
        /// <para>
        ///  <i>Reputation entities</i> represent resources in your Amazon SES account that have
        /// reputation tracking and management capabilities. The reputation impact reflects the
        /// highest impact reputation finding for the entity. Reputation findings can be retrieved
        /// using the <c>ListRecommendations</c> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReputationEntity service method.</param>
        /// 
        /// <returns>The response from the GetReputationEntity service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetReputationEntity">REST API Reference for GetReputationEntity Operation</seealso>
        GetReputationEntityResponse GetReputationEntity(GetReputationEntityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReputationEntity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReputationEntity operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReputationEntity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetReputationEntity">REST API Reference for GetReputationEntity Operation</seealso>
        IAsyncResult BeginGetReputationEntity(GetReputationEntityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReputationEntity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReputationEntity.</param>
        /// 
        /// <returns>Returns a  GetReputationEntityResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetReputationEntity">REST API Reference for GetReputationEntity Operation</seealso>
        GetReputationEntityResponse EndGetReputationEntity(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSuppressedDestination


        /// <summary>
        /// Retrieves information about a specific email address that's on the suppression list
        /// for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSuppressedDestination service method.</param>
        /// 
        /// <returns>The response from the GetSuppressedDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetSuppressedDestination">REST API Reference for GetSuppressedDestination Operation</seealso>
        GetSuppressedDestinationResponse GetSuppressedDestination(GetSuppressedDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSuppressedDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSuppressedDestination operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSuppressedDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetSuppressedDestination">REST API Reference for GetSuppressedDestination Operation</seealso>
        IAsyncResult BeginGetSuppressedDestination(GetSuppressedDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSuppressedDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSuppressedDestination.</param>
        /// 
        /// <returns>Returns a  GetSuppressedDestinationResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetSuppressedDestination">REST API Reference for GetSuppressedDestination Operation</seealso>
        GetSuppressedDestinationResponse EndGetSuppressedDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTenant


        /// <summary>
        /// Get information about a specific tenant, including the tenant's name, ID, ARN, creation
        /// timestamp, tags, and sending status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTenant service method.</param>
        /// 
        /// <returns>The response from the GetTenant service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetTenant">REST API Reference for GetTenant Operation</seealso>
        GetTenantResponse GetTenant(GetTenantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTenant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTenant operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTenant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetTenant">REST API Reference for GetTenant Operation</seealso>
        IAsyncResult BeginGetTenant(GetTenantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTenant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTenant.</param>
        /// 
        /// <returns>Returns a  GetTenantResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetTenant">REST API Reference for GetTenant Operation</seealso>
        GetTenantResponse EndGetTenant(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConfigurationSets


        /// <summary>
        /// List all of the configuration sets associated with your account in the current region.
        /// 
        ///  
        /// <para>
        ///  <i>Configuration sets</i> are groups of rules that you can apply to the emails you
        /// send. You apply a configuration set to an email by including a reference to the configuration
        /// set in the headers of the email. When you apply a configuration set to an email, all
        /// of the rules in that configuration set are applied to the email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationSets service method.</param>
        /// 
        /// <returns>The response from the ListConfigurationSets service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListConfigurationSets">REST API Reference for ListConfigurationSets Operation</seealso>
        ListConfigurationSetsResponse ListConfigurationSets(ListConfigurationSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurationSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationSets operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurationSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListConfigurationSets">REST API Reference for ListConfigurationSets Operation</seealso>
        IAsyncResult BeginListConfigurationSets(ListConfigurationSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurationSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurationSets.</param>
        /// 
        /// <returns>Returns a  ListConfigurationSetsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListConfigurationSets">REST API Reference for ListConfigurationSets Operation</seealso>
        ListConfigurationSetsResponse EndListConfigurationSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListContactLists


        /// <summary>
        /// Lists all of the contact lists available.
        /// 
        ///  
        /// <para>
        /// If your output includes a "NextToken" field with a string value, this indicates there
        /// may be additional contacts on the filtered list - regardless of the number of contacts
        /// returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContactLists service method.</param>
        /// 
        /// <returns>The response from the ListContactLists service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListContactLists">REST API Reference for ListContactLists Operation</seealso>
        ListContactListsResponse ListContactLists(ListContactListsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListContactLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContactLists operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContactLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListContactLists">REST API Reference for ListContactLists Operation</seealso>
        IAsyncResult BeginListContactLists(ListContactListsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListContactLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContactLists.</param>
        /// 
        /// <returns>Returns a  ListContactListsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListContactLists">REST API Reference for ListContactLists Operation</seealso>
        ListContactListsResponse EndListContactLists(IAsyncResult asyncResult);

        #endregion
        
        #region  ListContacts


        /// <summary>
        /// Lists the contacts present in a specific contact list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContacts service method.</param>
        /// 
        /// <returns>The response from the ListContacts service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListContacts">REST API Reference for ListContacts Operation</seealso>
        ListContactsResponse ListContacts(ListContactsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListContacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContacts operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListContacts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListContacts">REST API Reference for ListContacts Operation</seealso>
        IAsyncResult BeginListContacts(ListContactsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListContacts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListContacts.</param>
        /// 
        /// <returns>Returns a  ListContactsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListContacts">REST API Reference for ListContacts Operation</seealso>
        ListContactsResponse EndListContacts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCustomVerificationEmailTemplates


        /// <summary>
        /// Lists the existing custom verification email templates for your account in the current
        /// Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// custom verification email templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomVerificationEmailTemplates service method.</param>
        /// 
        /// <returns>The response from the ListCustomVerificationEmailTemplates service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListCustomVerificationEmailTemplates">REST API Reference for ListCustomVerificationEmailTemplates Operation</seealso>
        ListCustomVerificationEmailTemplatesResponse ListCustomVerificationEmailTemplates(ListCustomVerificationEmailTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomVerificationEmailTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomVerificationEmailTemplates operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomVerificationEmailTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListCustomVerificationEmailTemplates">REST API Reference for ListCustomVerificationEmailTemplates Operation</seealso>
        IAsyncResult BeginListCustomVerificationEmailTemplates(ListCustomVerificationEmailTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomVerificationEmailTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomVerificationEmailTemplates.</param>
        /// 
        /// <returns>Returns a  ListCustomVerificationEmailTemplatesResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListCustomVerificationEmailTemplates">REST API Reference for ListCustomVerificationEmailTemplates Operation</seealso>
        ListCustomVerificationEmailTemplatesResponse EndListCustomVerificationEmailTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDedicatedIpPools


        /// <summary>
        /// List all of the dedicated IP pools that exist in your Amazon Web Services account
        /// in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDedicatedIpPools service method.</param>
        /// 
        /// <returns>The response from the ListDedicatedIpPools service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListDedicatedIpPools">REST API Reference for ListDedicatedIpPools Operation</seealso>
        ListDedicatedIpPoolsResponse ListDedicatedIpPools(ListDedicatedIpPoolsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDedicatedIpPools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDedicatedIpPools operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDedicatedIpPools
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListDedicatedIpPools">REST API Reference for ListDedicatedIpPools Operation</seealso>
        IAsyncResult BeginListDedicatedIpPools(ListDedicatedIpPoolsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDedicatedIpPools operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDedicatedIpPools.</param>
        /// 
        /// <returns>Returns a  ListDedicatedIpPoolsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListDedicatedIpPools">REST API Reference for ListDedicatedIpPools Operation</seealso>
        ListDedicatedIpPoolsResponse EndListDedicatedIpPools(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDeliverabilityTestReports


        /// <summary>
        /// Show a list of the predictive inbox placement tests that you've performed, regardless
        /// of their statuses. For predictive inbox placement tests that are complete, you can
        /// use the <c>GetDeliverabilityTestReport</c> operation to view the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeliverabilityTestReports service method.</param>
        /// 
        /// <returns>The response from the ListDeliverabilityTestReports service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListDeliverabilityTestReports">REST API Reference for ListDeliverabilityTestReports Operation</seealso>
        ListDeliverabilityTestReportsResponse ListDeliverabilityTestReports(ListDeliverabilityTestReportsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeliverabilityTestReports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeliverabilityTestReports operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeliverabilityTestReports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListDeliverabilityTestReports">REST API Reference for ListDeliverabilityTestReports Operation</seealso>
        IAsyncResult BeginListDeliverabilityTestReports(ListDeliverabilityTestReportsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeliverabilityTestReports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeliverabilityTestReports.</param>
        /// 
        /// <returns>Returns a  ListDeliverabilityTestReportsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListDeliverabilityTestReports">REST API Reference for ListDeliverabilityTestReports Operation</seealso>
        ListDeliverabilityTestReportsResponse EndListDeliverabilityTestReports(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDomainDeliverabilityCampaigns


        /// <summary>
        /// Retrieve deliverability data for all the campaigns that used a specific domain to
        /// send email during a specified time range. This data is available for a domain only
        /// if you enabled the Deliverability dashboard for the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainDeliverabilityCampaigns service method.</param>
        /// 
        /// <returns>The response from the ListDomainDeliverabilityCampaigns service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListDomainDeliverabilityCampaigns">REST API Reference for ListDomainDeliverabilityCampaigns Operation</seealso>
        ListDomainDeliverabilityCampaignsResponse ListDomainDeliverabilityCampaigns(ListDomainDeliverabilityCampaignsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainDeliverabilityCampaigns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomainDeliverabilityCampaigns operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomainDeliverabilityCampaigns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListDomainDeliverabilityCampaigns">REST API Reference for ListDomainDeliverabilityCampaigns Operation</seealso>
        IAsyncResult BeginListDomainDeliverabilityCampaigns(ListDomainDeliverabilityCampaignsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomainDeliverabilityCampaigns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomainDeliverabilityCampaigns.</param>
        /// 
        /// <returns>Returns a  ListDomainDeliverabilityCampaignsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListDomainDeliverabilityCampaigns">REST API Reference for ListDomainDeliverabilityCampaigns Operation</seealso>
        ListDomainDeliverabilityCampaignsResponse EndListDomainDeliverabilityCampaigns(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEmailIdentities


        /// <summary>
        /// Returns a list of all of the email identities that are associated with your Amazon
        /// Web Services account. An identity can be either an email address or a domain. This
        /// operation returns identities that are verified as well as those that aren't. This
        /// operation returns identities that are associated with Amazon SES and Amazon Pinpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEmailIdentities service method.</param>
        /// 
        /// <returns>The response from the ListEmailIdentities service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListEmailIdentities">REST API Reference for ListEmailIdentities Operation</seealso>
        ListEmailIdentitiesResponse ListEmailIdentities(ListEmailIdentitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEmailIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEmailIdentities operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEmailIdentities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListEmailIdentities">REST API Reference for ListEmailIdentities Operation</seealso>
        IAsyncResult BeginListEmailIdentities(ListEmailIdentitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEmailIdentities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEmailIdentities.</param>
        /// 
        /// <returns>Returns a  ListEmailIdentitiesResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListEmailIdentities">REST API Reference for ListEmailIdentities Operation</seealso>
        ListEmailIdentitiesResponse EndListEmailIdentities(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEmailTemplates


        /// <summary>
        /// Lists the email templates present in your Amazon SES account in the current Amazon
        /// Web Services Region.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEmailTemplates service method.</param>
        /// 
        /// <returns>The response from the ListEmailTemplates service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListEmailTemplates">REST API Reference for ListEmailTemplates Operation</seealso>
        ListEmailTemplatesResponse ListEmailTemplates(ListEmailTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEmailTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEmailTemplates operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEmailTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListEmailTemplates">REST API Reference for ListEmailTemplates Operation</seealso>
        IAsyncResult BeginListEmailTemplates(ListEmailTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEmailTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEmailTemplates.</param>
        /// 
        /// <returns>Returns a  ListEmailTemplatesResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListEmailTemplates">REST API Reference for ListEmailTemplates Operation</seealso>
        ListEmailTemplatesResponse EndListEmailTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListExportJobs


        /// <summary>
        /// Lists all of the export jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExportJobs service method.</param>
        /// 
        /// <returns>The response from the ListExportJobs service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListExportJobs">REST API Reference for ListExportJobs Operation</seealso>
        ListExportJobsResponse ListExportJobs(ListExportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExportJobs operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListExportJobs">REST API Reference for ListExportJobs Operation</seealso>
        IAsyncResult BeginListExportJobs(ListExportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExportJobs.</param>
        /// 
        /// <returns>Returns a  ListExportJobsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListExportJobs">REST API Reference for ListExportJobs Operation</seealso>
        ListExportJobsResponse EndListExportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListImportJobs


        /// <summary>
        /// Lists all of the import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListImportJobs service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListImportJobs">REST API Reference for ListImportJobs Operation</seealso>
        ListImportJobsResponse ListImportJobs(ListImportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImportJobs operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListImportJobs">REST API Reference for ListImportJobs Operation</seealso>
        IAsyncResult BeginListImportJobs(ListImportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImportJobs.</param>
        /// 
        /// <returns>Returns a  ListImportJobsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListImportJobs">REST API Reference for ListImportJobs Operation</seealso>
        ListImportJobsResponse EndListImportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMultiRegionEndpoints


        /// <summary>
        /// List the multi-region endpoints (global-endpoints).
        /// 
        ///  
        /// <para>
        /// Only multi-region endpoints (global-endpoints) whose primary region is the AWS-Region
        /// where operation is executed will be listed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultiRegionEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListMultiRegionEndpoints service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListMultiRegionEndpoints">REST API Reference for ListMultiRegionEndpoints Operation</seealso>
        ListMultiRegionEndpointsResponse ListMultiRegionEndpoints(ListMultiRegionEndpointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMultiRegionEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMultiRegionEndpoints operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMultiRegionEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListMultiRegionEndpoints">REST API Reference for ListMultiRegionEndpoints Operation</seealso>
        IAsyncResult BeginListMultiRegionEndpoints(ListMultiRegionEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMultiRegionEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMultiRegionEndpoints.</param>
        /// 
        /// <returns>Returns a  ListMultiRegionEndpointsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListMultiRegionEndpoints">REST API Reference for ListMultiRegionEndpoints Operation</seealso>
        ListMultiRegionEndpointsResponse EndListMultiRegionEndpoints(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRecommendations


        /// <summary>
        /// Lists the recommendations present in your Amazon SES account in the current Amazon
        /// Web Services Region.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListRecommendations service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        ListRecommendationsResponse ListRecommendations(ListRecommendationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        IAsyncResult BeginListRecommendations(ListRecommendationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecommendations.</param>
        /// 
        /// <returns>Returns a  ListRecommendationsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        ListRecommendationsResponse EndListRecommendations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReputationEntities


        /// <summary>
        /// List reputation entities in your Amazon SES account in the current Amazon Web Services
        /// Region. You can filter the results by entity type, reputation impact, sending status,
        /// or entity reference prefix.
        /// 
        ///  
        /// <para>
        ///  <i>Reputation entities</i> represent resources in your account that have reputation
        /// tracking and management capabilities. Use this operation to get an overview of all
        /// entities and their current reputation status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReputationEntities service method.</param>
        /// 
        /// <returns>The response from the ListReputationEntities service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListReputationEntities">REST API Reference for ListReputationEntities Operation</seealso>
        ListReputationEntitiesResponse ListReputationEntities(ListReputationEntitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReputationEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReputationEntities operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReputationEntities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListReputationEntities">REST API Reference for ListReputationEntities Operation</seealso>
        IAsyncResult BeginListReputationEntities(ListReputationEntitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReputationEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReputationEntities.</param>
        /// 
        /// <returns>Returns a  ListReputationEntitiesResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListReputationEntities">REST API Reference for ListReputationEntities Operation</seealso>
        ListReputationEntitiesResponse EndListReputationEntities(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResourceTenants


        /// <summary>
        /// List all tenants associated with a specific resource.
        /// 
        ///  
        /// <para>
        /// This operation returns a list of tenants that are associated with the specified resource.
        /// This is useful for understanding which tenants are currently using a particular resource
        /// such as an email identity, configuration set, or email template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTenants service method.</param>
        /// 
        /// <returns>The response from the ListResourceTenants service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListResourceTenants">REST API Reference for ListResourceTenants Operation</seealso>
        ListResourceTenantsResponse ListResourceTenants(ListResourceTenantsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceTenants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTenants operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceTenants
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListResourceTenants">REST API Reference for ListResourceTenants Operation</seealso>
        IAsyncResult BeginListResourceTenants(ListResourceTenantsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceTenants operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceTenants.</param>
        /// 
        /// <returns>Returns a  ListResourceTenantsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListResourceTenants">REST API Reference for ListResourceTenants Operation</seealso>
        ListResourceTenantsResponse EndListResourceTenants(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSuppressedDestinations


        /// <summary>
        /// Retrieves a list of email addresses that are on the suppression list for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSuppressedDestinations service method.</param>
        /// 
        /// <returns>The response from the ListSuppressedDestinations service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.InvalidNextTokenException">
        /// The specified request includes an invalid or expired token.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListSuppressedDestinations">REST API Reference for ListSuppressedDestinations Operation</seealso>
        ListSuppressedDestinationsResponse ListSuppressedDestinations(ListSuppressedDestinationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSuppressedDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSuppressedDestinations operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSuppressedDestinations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListSuppressedDestinations">REST API Reference for ListSuppressedDestinations Operation</seealso>
        IAsyncResult BeginListSuppressedDestinations(ListSuppressedDestinationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSuppressedDestinations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSuppressedDestinations.</param>
        /// 
        /// <returns>Returns a  ListSuppressedDestinationsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListSuppressedDestinations">REST API Reference for ListSuppressedDestinations Operation</seealso>
        ListSuppressedDestinationsResponse EndListSuppressedDestinations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieve a list of the tags (keys and values) that are associated with a specified
        /// resource. A <i>tag</i> is a label that you optionally define and associate with a
        /// resource. Each tag consists of a required <i>tag key</i> and an optional associated <i>tag
        /// value</i>. A tag key is a general label that acts as a category for more specific
        /// tag values. A tag value acts as a descriptor within a tag key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTenantResources


        /// <summary>
        /// List all resources associated with a specific tenant.
        /// 
        ///  
        /// <para>
        /// This operation returns a list of resources (email identities, configuration sets,
        /// or email templates) that are associated with the specified tenant. You can optionally
        /// filter the results by resource type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTenantResources service method.</param>
        /// 
        /// <returns>The response from the ListTenantResources service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListTenantResources">REST API Reference for ListTenantResources Operation</seealso>
        ListTenantResourcesResponse ListTenantResources(ListTenantResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTenantResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTenantResources operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTenantResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListTenantResources">REST API Reference for ListTenantResources Operation</seealso>
        IAsyncResult BeginListTenantResources(ListTenantResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTenantResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTenantResources.</param>
        /// 
        /// <returns>Returns a  ListTenantResourcesResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListTenantResources">REST API Reference for ListTenantResources Operation</seealso>
        ListTenantResourcesResponse EndListTenantResources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTenants


        /// <summary>
        /// List all tenants associated with your account in the current Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        /// This operation returns basic information about each tenant, such as tenant name, ID,
        /// ARN, and creation timestamp.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTenants service method.</param>
        /// 
        /// <returns>The response from the ListTenants service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListTenants">REST API Reference for ListTenants Operation</seealso>
        ListTenantsResponse ListTenants(ListTenantsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTenants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTenants operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTenants
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListTenants">REST API Reference for ListTenants Operation</seealso>
        IAsyncResult BeginListTenants(ListTenantsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTenants operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTenants.</param>
        /// 
        /// <returns>Returns a  ListTenantsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListTenants">REST API Reference for ListTenants Operation</seealso>
        ListTenantsResponse EndListTenants(IAsyncResult asyncResult);

        #endregion
        
        #region  PutAccountDedicatedIpWarmupAttributes


        /// <summary>
        /// Enable or disable the automatic warm-up feature for dedicated IP addresses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountDedicatedIpWarmupAttributes service method.</param>
        /// 
        /// <returns>The response from the PutAccountDedicatedIpWarmupAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountDedicatedIpWarmupAttributes">REST API Reference for PutAccountDedicatedIpWarmupAttributes Operation</seealso>
        PutAccountDedicatedIpWarmupAttributesResponse PutAccountDedicatedIpWarmupAttributes(PutAccountDedicatedIpWarmupAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAccountDedicatedIpWarmupAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAccountDedicatedIpWarmupAttributes operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAccountDedicatedIpWarmupAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountDedicatedIpWarmupAttributes">REST API Reference for PutAccountDedicatedIpWarmupAttributes Operation</seealso>
        IAsyncResult BeginPutAccountDedicatedIpWarmupAttributes(PutAccountDedicatedIpWarmupAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAccountDedicatedIpWarmupAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAccountDedicatedIpWarmupAttributes.</param>
        /// 
        /// <returns>Returns a  PutAccountDedicatedIpWarmupAttributesResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountDedicatedIpWarmupAttributes">REST API Reference for PutAccountDedicatedIpWarmupAttributes Operation</seealso>
        PutAccountDedicatedIpWarmupAttributesResponse EndPutAccountDedicatedIpWarmupAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  PutAccountDetails


        /// <summary>
        /// Update your Amazon SES account details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountDetails service method.</param>
        /// 
        /// <returns>The response from the PutAccountDetails service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConflictException">
        /// If there is already an ongoing account details update under review.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountDetails">REST API Reference for PutAccountDetails Operation</seealso>
        PutAccountDetailsResponse PutAccountDetails(PutAccountDetailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAccountDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAccountDetails operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAccountDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountDetails">REST API Reference for PutAccountDetails Operation</seealso>
        IAsyncResult BeginPutAccountDetails(PutAccountDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAccountDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAccountDetails.</param>
        /// 
        /// <returns>Returns a  PutAccountDetailsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountDetails">REST API Reference for PutAccountDetails Operation</seealso>
        PutAccountDetailsResponse EndPutAccountDetails(IAsyncResult asyncResult);

        #endregion
        
        #region  PutAccountSendingAttributes


        /// <summary>
        /// Enable or disable the ability of your account to send email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSendingAttributes service method.</param>
        /// 
        /// <returns>The response from the PutAccountSendingAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountSendingAttributes">REST API Reference for PutAccountSendingAttributes Operation</seealso>
        PutAccountSendingAttributesResponse PutAccountSendingAttributes(PutAccountSendingAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAccountSendingAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSendingAttributes operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAccountSendingAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountSendingAttributes">REST API Reference for PutAccountSendingAttributes Operation</seealso>
        IAsyncResult BeginPutAccountSendingAttributes(PutAccountSendingAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAccountSendingAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAccountSendingAttributes.</param>
        /// 
        /// <returns>Returns a  PutAccountSendingAttributesResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountSendingAttributes">REST API Reference for PutAccountSendingAttributes Operation</seealso>
        PutAccountSendingAttributesResponse EndPutAccountSendingAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  PutAccountSuppressionAttributes


        /// <summary>
        /// Change the settings for the account-level suppression list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSuppressionAttributes service method.</param>
        /// 
        /// <returns>The response from the PutAccountSuppressionAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountSuppressionAttributes">REST API Reference for PutAccountSuppressionAttributes Operation</seealso>
        PutAccountSuppressionAttributesResponse PutAccountSuppressionAttributes(PutAccountSuppressionAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAccountSuppressionAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSuppressionAttributes operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAccountSuppressionAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountSuppressionAttributes">REST API Reference for PutAccountSuppressionAttributes Operation</seealso>
        IAsyncResult BeginPutAccountSuppressionAttributes(PutAccountSuppressionAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAccountSuppressionAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAccountSuppressionAttributes.</param>
        /// 
        /// <returns>Returns a  PutAccountSuppressionAttributesResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountSuppressionAttributes">REST API Reference for PutAccountSuppressionAttributes Operation</seealso>
        PutAccountSuppressionAttributesResponse EndPutAccountSuppressionAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  PutAccountVdmAttributes


        /// <summary>
        /// Update your Amazon SES account VDM attributes.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountVdmAttributes service method.</param>
        /// 
        /// <returns>The response from the PutAccountVdmAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountVdmAttributes">REST API Reference for PutAccountVdmAttributes Operation</seealso>
        PutAccountVdmAttributesResponse PutAccountVdmAttributes(PutAccountVdmAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAccountVdmAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAccountVdmAttributes operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAccountVdmAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountVdmAttributes">REST API Reference for PutAccountVdmAttributes Operation</seealso>
        IAsyncResult BeginPutAccountVdmAttributes(PutAccountVdmAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAccountVdmAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAccountVdmAttributes.</param>
        /// 
        /// <returns>Returns a  PutAccountVdmAttributesResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountVdmAttributes">REST API Reference for PutAccountVdmAttributes Operation</seealso>
        PutAccountVdmAttributesResponse EndPutAccountVdmAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  PutConfigurationSetArchivingOptions


        /// <summary>
        /// Associate the configuration set with a MailManager archive. When you send email using
        /// the <c>SendEmail</c> or <c>SendBulkEmail</c> operations the message as it will be
        /// given to the receiving SMTP server will be archived, along with the recipient information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetArchivingOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetArchivingOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetArchivingOptions">REST API Reference for PutConfigurationSetArchivingOptions Operation</seealso>
        PutConfigurationSetArchivingOptionsResponse PutConfigurationSetArchivingOptions(PutConfigurationSetArchivingOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationSetArchivingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetArchivingOptions operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConfigurationSetArchivingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetArchivingOptions">REST API Reference for PutConfigurationSetArchivingOptions Operation</seealso>
        IAsyncResult BeginPutConfigurationSetArchivingOptions(PutConfigurationSetArchivingOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutConfigurationSetArchivingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConfigurationSetArchivingOptions.</param>
        /// 
        /// <returns>Returns a  PutConfigurationSetArchivingOptionsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetArchivingOptions">REST API Reference for PutConfigurationSetArchivingOptions Operation</seealso>
        PutConfigurationSetArchivingOptionsResponse EndPutConfigurationSetArchivingOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  PutConfigurationSetDeliveryOptions


        /// <summary>
        /// Associate a configuration set with a dedicated IP pool. You can use dedicated IP pools
        /// to create groups of dedicated IP addresses for sending specific types of email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetDeliveryOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetDeliveryOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetDeliveryOptions">REST API Reference for PutConfigurationSetDeliveryOptions Operation</seealso>
        PutConfigurationSetDeliveryOptionsResponse PutConfigurationSetDeliveryOptions(PutConfigurationSetDeliveryOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationSetDeliveryOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetDeliveryOptions operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConfigurationSetDeliveryOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetDeliveryOptions">REST API Reference for PutConfigurationSetDeliveryOptions Operation</seealso>
        IAsyncResult BeginPutConfigurationSetDeliveryOptions(PutConfigurationSetDeliveryOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutConfigurationSetDeliveryOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConfigurationSetDeliveryOptions.</param>
        /// 
        /// <returns>Returns a  PutConfigurationSetDeliveryOptionsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetDeliveryOptions">REST API Reference for PutConfigurationSetDeliveryOptions Operation</seealso>
        PutConfigurationSetDeliveryOptionsResponse EndPutConfigurationSetDeliveryOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  PutConfigurationSetReputationOptions


        /// <summary>
        /// Enable or disable collection of reputation metrics for emails that you send using
        /// a particular configuration set in a specific Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetReputationOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetReputationOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetReputationOptions">REST API Reference for PutConfigurationSetReputationOptions Operation</seealso>
        PutConfigurationSetReputationOptionsResponse PutConfigurationSetReputationOptions(PutConfigurationSetReputationOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationSetReputationOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetReputationOptions operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConfigurationSetReputationOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetReputationOptions">REST API Reference for PutConfigurationSetReputationOptions Operation</seealso>
        IAsyncResult BeginPutConfigurationSetReputationOptions(PutConfigurationSetReputationOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutConfigurationSetReputationOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConfigurationSetReputationOptions.</param>
        /// 
        /// <returns>Returns a  PutConfigurationSetReputationOptionsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetReputationOptions">REST API Reference for PutConfigurationSetReputationOptions Operation</seealso>
        PutConfigurationSetReputationOptionsResponse EndPutConfigurationSetReputationOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  PutConfigurationSetSendingOptions


        /// <summary>
        /// Enable or disable email sending for messages that use a particular configuration set
        /// in a specific Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetSendingOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetSendingOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetSendingOptions">REST API Reference for PutConfigurationSetSendingOptions Operation</seealso>
        PutConfigurationSetSendingOptionsResponse PutConfigurationSetSendingOptions(PutConfigurationSetSendingOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationSetSendingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetSendingOptions operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConfigurationSetSendingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetSendingOptions">REST API Reference for PutConfigurationSetSendingOptions Operation</seealso>
        IAsyncResult BeginPutConfigurationSetSendingOptions(PutConfigurationSetSendingOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutConfigurationSetSendingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConfigurationSetSendingOptions.</param>
        /// 
        /// <returns>Returns a  PutConfigurationSetSendingOptionsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetSendingOptions">REST API Reference for PutConfigurationSetSendingOptions Operation</seealso>
        PutConfigurationSetSendingOptionsResponse EndPutConfigurationSetSendingOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  PutConfigurationSetSuppressionOptions


        /// <summary>
        /// Specify the account suppression list preferences for a configuration set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetSuppressionOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetSuppressionOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetSuppressionOptions">REST API Reference for PutConfigurationSetSuppressionOptions Operation</seealso>
        PutConfigurationSetSuppressionOptionsResponse PutConfigurationSetSuppressionOptions(PutConfigurationSetSuppressionOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationSetSuppressionOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetSuppressionOptions operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConfigurationSetSuppressionOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetSuppressionOptions">REST API Reference for PutConfigurationSetSuppressionOptions Operation</seealso>
        IAsyncResult BeginPutConfigurationSetSuppressionOptions(PutConfigurationSetSuppressionOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutConfigurationSetSuppressionOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConfigurationSetSuppressionOptions.</param>
        /// 
        /// <returns>Returns a  PutConfigurationSetSuppressionOptionsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetSuppressionOptions">REST API Reference for PutConfigurationSetSuppressionOptions Operation</seealso>
        PutConfigurationSetSuppressionOptionsResponse EndPutConfigurationSetSuppressionOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  PutConfigurationSetTrackingOptions


        /// <summary>
        /// Specify a custom domain to use for open and click tracking elements in email that
        /// you send.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetTrackingOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetTrackingOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetTrackingOptions">REST API Reference for PutConfigurationSetTrackingOptions Operation</seealso>
        PutConfigurationSetTrackingOptionsResponse PutConfigurationSetTrackingOptions(PutConfigurationSetTrackingOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationSetTrackingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetTrackingOptions operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConfigurationSetTrackingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetTrackingOptions">REST API Reference for PutConfigurationSetTrackingOptions Operation</seealso>
        IAsyncResult BeginPutConfigurationSetTrackingOptions(PutConfigurationSetTrackingOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutConfigurationSetTrackingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConfigurationSetTrackingOptions.</param>
        /// 
        /// <returns>Returns a  PutConfigurationSetTrackingOptionsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetTrackingOptions">REST API Reference for PutConfigurationSetTrackingOptions Operation</seealso>
        PutConfigurationSetTrackingOptionsResponse EndPutConfigurationSetTrackingOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  PutConfigurationSetVdmOptions


        /// <summary>
        /// Specify VDM preferences for email that you send using the configuration set.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetVdmOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetVdmOptions service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetVdmOptions">REST API Reference for PutConfigurationSetVdmOptions Operation</seealso>
        PutConfigurationSetVdmOptionsResponse PutConfigurationSetVdmOptions(PutConfigurationSetVdmOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationSetVdmOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetVdmOptions operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConfigurationSetVdmOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetVdmOptions">REST API Reference for PutConfigurationSetVdmOptions Operation</seealso>
        IAsyncResult BeginPutConfigurationSetVdmOptions(PutConfigurationSetVdmOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutConfigurationSetVdmOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConfigurationSetVdmOptions.</param>
        /// 
        /// <returns>Returns a  PutConfigurationSetVdmOptionsResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutConfigurationSetVdmOptions">REST API Reference for PutConfigurationSetVdmOptions Operation</seealso>
        PutConfigurationSetVdmOptionsResponse EndPutConfigurationSetVdmOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  PutDedicatedIpInPool


        /// <summary>
        /// Move a dedicated IP address to an existing dedicated IP pool.
        /// 
        ///  <note> 
        /// <para>
        /// The dedicated IP address that you specify must already exist, and must be associated
        /// with your Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        /// The dedicated IP pool you specify must already exist. You can create a new pool by
        /// using the <c>CreateDedicatedIpPool</c> operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpInPool service method.</param>
        /// 
        /// <returns>The response from the PutDedicatedIpInPool service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDedicatedIpInPool">REST API Reference for PutDedicatedIpInPool Operation</seealso>
        PutDedicatedIpInPoolResponse PutDedicatedIpInPool(PutDedicatedIpInPoolRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutDedicatedIpInPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpInPool operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDedicatedIpInPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDedicatedIpInPool">REST API Reference for PutDedicatedIpInPool Operation</seealso>
        IAsyncResult BeginPutDedicatedIpInPool(PutDedicatedIpInPoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutDedicatedIpInPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDedicatedIpInPool.</param>
        /// 
        /// <returns>Returns a  PutDedicatedIpInPoolResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDedicatedIpInPool">REST API Reference for PutDedicatedIpInPool Operation</seealso>
        PutDedicatedIpInPoolResponse EndPutDedicatedIpInPool(IAsyncResult asyncResult);

        #endregion
        
        #region  PutDedicatedIpPoolScalingAttributes


        /// <summary>
        /// Used to convert a dedicated IP pool to a different scaling mode.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>MANAGED</c> pools cannot be converted to <c>STANDARD</c> scaling mode.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpPoolScalingAttributes service method.</param>
        /// 
        /// <returns>The response from the PutDedicatedIpPoolScalingAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDedicatedIpPoolScalingAttributes">REST API Reference for PutDedicatedIpPoolScalingAttributes Operation</seealso>
        PutDedicatedIpPoolScalingAttributesResponse PutDedicatedIpPoolScalingAttributes(PutDedicatedIpPoolScalingAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutDedicatedIpPoolScalingAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpPoolScalingAttributes operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDedicatedIpPoolScalingAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDedicatedIpPoolScalingAttributes">REST API Reference for PutDedicatedIpPoolScalingAttributes Operation</seealso>
        IAsyncResult BeginPutDedicatedIpPoolScalingAttributes(PutDedicatedIpPoolScalingAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutDedicatedIpPoolScalingAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDedicatedIpPoolScalingAttributes.</param>
        /// 
        /// <returns>Returns a  PutDedicatedIpPoolScalingAttributesResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDedicatedIpPoolScalingAttributes">REST API Reference for PutDedicatedIpPoolScalingAttributes Operation</seealso>
        PutDedicatedIpPoolScalingAttributesResponse EndPutDedicatedIpPoolScalingAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  PutDedicatedIpWarmupAttributes


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpWarmupAttributes service method.</param>
        /// 
        /// <returns>The response from the PutDedicatedIpWarmupAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDedicatedIpWarmupAttributes">REST API Reference for PutDedicatedIpWarmupAttributes Operation</seealso>
        PutDedicatedIpWarmupAttributesResponse PutDedicatedIpWarmupAttributes(PutDedicatedIpWarmupAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutDedicatedIpWarmupAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpWarmupAttributes operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDedicatedIpWarmupAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDedicatedIpWarmupAttributes">REST API Reference for PutDedicatedIpWarmupAttributes Operation</seealso>
        IAsyncResult BeginPutDedicatedIpWarmupAttributes(PutDedicatedIpWarmupAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutDedicatedIpWarmupAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDedicatedIpWarmupAttributes.</param>
        /// 
        /// <returns>Returns a  PutDedicatedIpWarmupAttributesResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDedicatedIpWarmupAttributes">REST API Reference for PutDedicatedIpWarmupAttributes Operation</seealso>
        PutDedicatedIpWarmupAttributesResponse EndPutDedicatedIpWarmupAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  PutDeliverabilityDashboardOption


        /// <summary>
        /// Enable or disable the Deliverability dashboard. When you enable the Deliverability
        /// dashboard, you gain access to reputation, deliverability, and other metrics for the
        /// domains that you use to send email. You also gain the ability to perform predictive
        /// inbox placement tests.
        /// 
        ///  
        /// <para>
        /// When you use the Deliverability dashboard, you pay a monthly subscription charge,
        /// in addition to any other fees that you accrue by using Amazon SES and other Amazon
        /// Web Services services. For more information about the features and cost of a Deliverability
        /// dashboard subscription, see <a href="http://aws.amazon.com/ses/pricing/">Amazon SES
        /// Pricing</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeliverabilityDashboardOption service method.</param>
        /// 
        /// <returns>The response from the PutDeliverabilityDashboardOption service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDeliverabilityDashboardOption">REST API Reference for PutDeliverabilityDashboardOption Operation</seealso>
        PutDeliverabilityDashboardOptionResponse PutDeliverabilityDashboardOption(PutDeliverabilityDashboardOptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutDeliverabilityDashboardOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDeliverabilityDashboardOption operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDeliverabilityDashboardOption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDeliverabilityDashboardOption">REST API Reference for PutDeliverabilityDashboardOption Operation</seealso>
        IAsyncResult BeginPutDeliverabilityDashboardOption(PutDeliverabilityDashboardOptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutDeliverabilityDashboardOption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDeliverabilityDashboardOption.</param>
        /// 
        /// <returns>Returns a  PutDeliverabilityDashboardOptionResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutDeliverabilityDashboardOption">REST API Reference for PutDeliverabilityDashboardOption Operation</seealso>
        PutDeliverabilityDashboardOptionResponse EndPutDeliverabilityDashboardOption(IAsyncResult asyncResult);

        #endregion
        
        #region  PutEmailIdentityConfigurationSetAttributes


        /// <summary>
        /// Used to associate a configuration set with an email identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityConfigurationSetAttributes service method.</param>
        /// 
        /// <returns>The response from the PutEmailIdentityConfigurationSetAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityConfigurationSetAttributes">REST API Reference for PutEmailIdentityConfigurationSetAttributes Operation</seealso>
        PutEmailIdentityConfigurationSetAttributesResponse PutEmailIdentityConfigurationSetAttributes(PutEmailIdentityConfigurationSetAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutEmailIdentityConfigurationSetAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityConfigurationSetAttributes operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEmailIdentityConfigurationSetAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityConfigurationSetAttributes">REST API Reference for PutEmailIdentityConfigurationSetAttributes Operation</seealso>
        IAsyncResult BeginPutEmailIdentityConfigurationSetAttributes(PutEmailIdentityConfigurationSetAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEmailIdentityConfigurationSetAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEmailIdentityConfigurationSetAttributes.</param>
        /// 
        /// <returns>Returns a  PutEmailIdentityConfigurationSetAttributesResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityConfigurationSetAttributes">REST API Reference for PutEmailIdentityConfigurationSetAttributes Operation</seealso>
        PutEmailIdentityConfigurationSetAttributesResponse EndPutEmailIdentityConfigurationSetAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  PutEmailIdentityDkimAttributes


        /// <summary>
        /// Used to enable or disable DKIM authentication for an email identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityDkimAttributes service method.</param>
        /// 
        /// <returns>The response from the PutEmailIdentityDkimAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityDkimAttributes">REST API Reference for PutEmailIdentityDkimAttributes Operation</seealso>
        PutEmailIdentityDkimAttributesResponse PutEmailIdentityDkimAttributes(PutEmailIdentityDkimAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutEmailIdentityDkimAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityDkimAttributes operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEmailIdentityDkimAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityDkimAttributes">REST API Reference for PutEmailIdentityDkimAttributes Operation</seealso>
        IAsyncResult BeginPutEmailIdentityDkimAttributes(PutEmailIdentityDkimAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEmailIdentityDkimAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEmailIdentityDkimAttributes.</param>
        /// 
        /// <returns>Returns a  PutEmailIdentityDkimAttributesResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityDkimAttributes">REST API Reference for PutEmailIdentityDkimAttributes Operation</seealso>
        PutEmailIdentityDkimAttributesResponse EndPutEmailIdentityDkimAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  PutEmailIdentityDkimSigningAttributes


        /// <summary>
        /// Used to configure or change the DKIM authentication settings for an email domain identity.
        /// You can use this operation to do any of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Update the signing attributes for an identity that uses Bring Your Own DKIM (BYODKIM).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update the key length that should be used for Easy DKIM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change from using no DKIM authentication to using Easy DKIM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change from using no DKIM authentication to using BYODKIM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change from using Easy DKIM to using BYODKIM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change from using BYODKIM to using Easy DKIM.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityDkimSigningAttributes service method.</param>
        /// 
        /// <returns>The response from the PutEmailIdentityDkimSigningAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityDkimSigningAttributes">REST API Reference for PutEmailIdentityDkimSigningAttributes Operation</seealso>
        PutEmailIdentityDkimSigningAttributesResponse PutEmailIdentityDkimSigningAttributes(PutEmailIdentityDkimSigningAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutEmailIdentityDkimSigningAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityDkimSigningAttributes operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEmailIdentityDkimSigningAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityDkimSigningAttributes">REST API Reference for PutEmailIdentityDkimSigningAttributes Operation</seealso>
        IAsyncResult BeginPutEmailIdentityDkimSigningAttributes(PutEmailIdentityDkimSigningAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEmailIdentityDkimSigningAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEmailIdentityDkimSigningAttributes.</param>
        /// 
        /// <returns>Returns a  PutEmailIdentityDkimSigningAttributesResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityDkimSigningAttributes">REST API Reference for PutEmailIdentityDkimSigningAttributes Operation</seealso>
        PutEmailIdentityDkimSigningAttributesResponse EndPutEmailIdentityDkimSigningAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  PutEmailIdentityFeedbackAttributes


        /// <summary>
        /// Used to enable or disable feedback forwarding for an identity. This setting determines
        /// what happens when an identity is used to send an email that results in a bounce or
        /// complaint event.
        /// 
        ///  
        /// <para>
        /// If the value is <c>true</c>, you receive email notifications when bounce or complaint
        /// events occur. These notifications are sent to the address that you specified in the
        /// <c>Return-Path</c> header of the original email.
        /// </para>
        ///  
        /// <para>
        /// You're required to have a method of tracking bounces and complaints. If you haven't
        /// set up another mechanism for receiving bounce or complaint notifications (for example,
        /// by setting up an event destination), you receive an email notification when these
        /// events occur (even if this setting is disabled).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityFeedbackAttributes service method.</param>
        /// 
        /// <returns>The response from the PutEmailIdentityFeedbackAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityFeedbackAttributes">REST API Reference for PutEmailIdentityFeedbackAttributes Operation</seealso>
        PutEmailIdentityFeedbackAttributesResponse PutEmailIdentityFeedbackAttributes(PutEmailIdentityFeedbackAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutEmailIdentityFeedbackAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityFeedbackAttributes operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEmailIdentityFeedbackAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityFeedbackAttributes">REST API Reference for PutEmailIdentityFeedbackAttributes Operation</seealso>
        IAsyncResult BeginPutEmailIdentityFeedbackAttributes(PutEmailIdentityFeedbackAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEmailIdentityFeedbackAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEmailIdentityFeedbackAttributes.</param>
        /// 
        /// <returns>Returns a  PutEmailIdentityFeedbackAttributesResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityFeedbackAttributes">REST API Reference for PutEmailIdentityFeedbackAttributes Operation</seealso>
        PutEmailIdentityFeedbackAttributesResponse EndPutEmailIdentityFeedbackAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  PutEmailIdentityMailFromAttributes


        /// <summary>
        /// Used to enable or disable the custom Mail-From domain configuration for an email identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityMailFromAttributes service method.</param>
        /// 
        /// <returns>The response from the PutEmailIdentityMailFromAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityMailFromAttributes">REST API Reference for PutEmailIdentityMailFromAttributes Operation</seealso>
        PutEmailIdentityMailFromAttributesResponse PutEmailIdentityMailFromAttributes(PutEmailIdentityMailFromAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutEmailIdentityMailFromAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityMailFromAttributes operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEmailIdentityMailFromAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityMailFromAttributes">REST API Reference for PutEmailIdentityMailFromAttributes Operation</seealso>
        IAsyncResult BeginPutEmailIdentityMailFromAttributes(PutEmailIdentityMailFromAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEmailIdentityMailFromAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEmailIdentityMailFromAttributes.</param>
        /// 
        /// <returns>Returns a  PutEmailIdentityMailFromAttributesResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutEmailIdentityMailFromAttributes">REST API Reference for PutEmailIdentityMailFromAttributes Operation</seealso>
        PutEmailIdentityMailFromAttributesResponse EndPutEmailIdentityMailFromAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  PutSuppressedDestination


        /// <summary>
        /// Adds an email address to the suppression list for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSuppressedDestination service method.</param>
        /// 
        /// <returns>The response from the PutSuppressedDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutSuppressedDestination">REST API Reference for PutSuppressedDestination Operation</seealso>
        PutSuppressedDestinationResponse PutSuppressedDestination(PutSuppressedDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutSuppressedDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSuppressedDestination operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSuppressedDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutSuppressedDestination">REST API Reference for PutSuppressedDestination Operation</seealso>
        IAsyncResult BeginPutSuppressedDestination(PutSuppressedDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutSuppressedDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSuppressedDestination.</param>
        /// 
        /// <returns>Returns a  PutSuppressedDestinationResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutSuppressedDestination">REST API Reference for PutSuppressedDestination Operation</seealso>
        PutSuppressedDestinationResponse EndPutSuppressedDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  SendBulkEmail


        /// <summary>
        /// Composes an email message to multiple destinations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendBulkEmail service method.</param>
        /// 
        /// <returns>The response from the SendBulkEmail service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AccountSuspendedException">
        /// The message can't be sent because the account's ability to send email has been permanently
        /// restricted.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MailFromDomainNotVerifiedException">
        /// The message can't be sent because the sending domain isn't verified.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MessageRejectedException">
        /// The message can't be sent because it contains invalid content.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.SendingPausedException">
        /// The message can't be sent because the account's ability to send email is currently
        /// paused.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/SendBulkEmail">REST API Reference for SendBulkEmail Operation</seealso>
        SendBulkEmailResponse SendBulkEmail(SendBulkEmailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendBulkEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendBulkEmail operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendBulkEmail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/SendBulkEmail">REST API Reference for SendBulkEmail Operation</seealso>
        IAsyncResult BeginSendBulkEmail(SendBulkEmailRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendBulkEmail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendBulkEmail.</param>
        /// 
        /// <returns>Returns a  SendBulkEmailResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/SendBulkEmail">REST API Reference for SendBulkEmail Operation</seealso>
        SendBulkEmailResponse EndSendBulkEmail(IAsyncResult asyncResult);

        #endregion
        
        #region  SendCustomVerificationEmail


        /// <summary>
        /// Adds an email address to the list of identities for your Amazon SES account in the
        /// current Amazon Web Services Region and attempts to verify it. As a result of executing
        /// this operation, a customized verification email is sent to the specified address.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must first create a custom verification email template.
        /// For more information about creating and using custom verification email templates,
        /// see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// custom verification email templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCustomVerificationEmail service method.</param>
        /// 
        /// <returns>The response from the SendCustomVerificationEmail service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MailFromDomainNotVerifiedException">
        /// The message can't be sent because the sending domain isn't verified.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MessageRejectedException">
        /// The message can't be sent because it contains invalid content.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.SendingPausedException">
        /// The message can't be sent because the account's ability to send email is currently
        /// paused.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/SendCustomVerificationEmail">REST API Reference for SendCustomVerificationEmail Operation</seealso>
        SendCustomVerificationEmailResponse SendCustomVerificationEmail(SendCustomVerificationEmailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendCustomVerificationEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendCustomVerificationEmail operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendCustomVerificationEmail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/SendCustomVerificationEmail">REST API Reference for SendCustomVerificationEmail Operation</seealso>
        IAsyncResult BeginSendCustomVerificationEmail(SendCustomVerificationEmailRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendCustomVerificationEmail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendCustomVerificationEmail.</param>
        /// 
        /// <returns>Returns a  SendCustomVerificationEmailResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/SendCustomVerificationEmail">REST API Reference for SendCustomVerificationEmail Operation</seealso>
        SendCustomVerificationEmailResponse EndSendCustomVerificationEmail(IAsyncResult asyncResult);

        #endregion
        
        #region  SendEmail


        /// <summary>
        /// Sends an email message. You can use the Amazon SES API v2 to send the following types
        /// of messages:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Simple</b> – A standard email message. When you create this type of message, you
        /// specify the sender, the recipient, and the message body, and Amazon SES assembles
        /// the message for you.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Raw</b> – A raw, MIME-formatted email message. When you send this type of email,
        /// you have to specify all of the message headers, as well as the message body. You can
        /// use this message type to send messages that contain attachments. The message that
        /// you specify has to be a valid MIME message.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Templated</b> – A message that contains personalization tags. When you send this
        /// type of email, Amazon SES API v2 automatically replaces the tags with values that
        /// you specify.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEmail service method.</param>
        /// 
        /// <returns>The response from the SendEmail service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.AccountSuspendedException">
        /// The message can't be sent because the account's ability to send email has been permanently
        /// restricted.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MailFromDomainNotVerifiedException">
        /// The message can't be sent because the sending domain isn't verified.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.MessageRejectedException">
        /// The message can't be sent because it contains invalid content.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.SendingPausedException">
        /// The message can't be sent because the account's ability to send email is currently
        /// paused.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/SendEmail">REST API Reference for SendEmail Operation</seealso>
        SendEmailResponse SendEmail(SendEmailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendEmail operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendEmail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/SendEmail">REST API Reference for SendEmail Operation</seealso>
        IAsyncResult BeginSendEmail(SendEmailRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendEmail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendEmail.</param>
        /// 
        /// <returns>Returns a  SendEmailResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/SendEmail">REST API Reference for SendEmail Operation</seealso>
        SendEmailResponse EndSendEmail(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Add one or more tags (keys and values) to a specified resource. A <i>tag</i> is a
        /// label that you optionally define and associate with a resource. Tags can help you
        /// categorize and manage resources in different ways, such as by purpose, owner, environment,
        /// or other criteria. A resource can have as many as 50 tags.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a required <i>tag key</i> and an associated <i>tag value</i>,
        /// both of which you define. A tag key is a general label that acts as a category for
        /// more specific tag values. A tag value acts as a descriptor within a tag key.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TestRenderEmailTemplate


        /// <summary>
        /// Creates a preview of the MIME content of an email when provided with a template and
        /// a set of replacement data.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestRenderEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the TestRenderEmailTemplate service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/TestRenderEmailTemplate">REST API Reference for TestRenderEmailTemplate Operation</seealso>
        TestRenderEmailTemplateResponse TestRenderEmailTemplate(TestRenderEmailTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TestRenderEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestRenderEmailTemplate operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestRenderEmailTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/TestRenderEmailTemplate">REST API Reference for TestRenderEmailTemplate Operation</seealso>
        IAsyncResult BeginTestRenderEmailTemplate(TestRenderEmailTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestRenderEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestRenderEmailTemplate.</param>
        /// 
        /// <returns>Returns a  TestRenderEmailTemplateResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/TestRenderEmailTemplate">REST API Reference for TestRenderEmailTemplate Operation</seealso>
        TestRenderEmailTemplateResponse EndTestRenderEmailTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove one or more tags (keys and values) from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConfigurationSetEventDestination


        /// <summary>
        /// Update the configuration of an event destination for a configuration set.
        /// 
        ///  
        /// <para>
        ///  <i>Events</i> include message sends, deliveries, opens, clicks, bounces, and complaints.
        /// <i>Event destinations</i> are places that you can send information about these events
        /// to. For example, you can send event data to Amazon EventBridge and associate a rule
        /// to send the event to the specified target.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationSetEventDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateConfigurationSetEventDestination">REST API Reference for UpdateConfigurationSetEventDestination Operation</seealso>
        UpdateConfigurationSetEventDestinationResponse UpdateConfigurationSetEventDestination(UpdateConfigurationSetEventDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetEventDestination operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfigurationSetEventDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateConfigurationSetEventDestination">REST API Reference for UpdateConfigurationSetEventDestination Operation</seealso>
        IAsyncResult BeginUpdateConfigurationSetEventDestination(UpdateConfigurationSetEventDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfigurationSetEventDestination.</param>
        /// 
        /// <returns>Returns a  UpdateConfigurationSetEventDestinationResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateConfigurationSetEventDestination">REST API Reference for UpdateConfigurationSetEventDestination Operation</seealso>
        UpdateConfigurationSetEventDestinationResponse EndUpdateConfigurationSetEventDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateContact


        /// <summary>
        /// Updates a contact's preferences for a list.
        /// 
        ///  <note> 
        /// <para>
        /// You must specify all existing topic preferences in the <c>TopicPreferences</c> object,
        /// not just the ones that need updating; otherwise, all your existing preferences will
        /// be removed.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContact service method.</param>
        /// 
        /// <returns>The response from the UpdateContact service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateContact">REST API Reference for UpdateContact Operation</seealso>
        UpdateContactResponse UpdateContact(UpdateContactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContact operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateContact">REST API Reference for UpdateContact Operation</seealso>
        IAsyncResult BeginUpdateContact(UpdateContactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContact.</param>
        /// 
        /// <returns>Returns a  UpdateContactResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateContact">REST API Reference for UpdateContact Operation</seealso>
        UpdateContactResponse EndUpdateContact(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateContactList


        /// <summary>
        /// Updates contact list metadata. This operation does a complete replacement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactList service method.</param>
        /// 
        /// <returns>The response from the UpdateContactList service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateContactList">REST API Reference for UpdateContactList Operation</seealso>
        UpdateContactListResponse UpdateContactList(UpdateContactListRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateContactList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactList operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContactList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateContactList">REST API Reference for UpdateContactList Operation</seealso>
        IAsyncResult BeginUpdateContactList(UpdateContactListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContactList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContactList.</param>
        /// 
        /// <returns>Returns a  UpdateContactListResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateContactList">REST API Reference for UpdateContactList Operation</seealso>
        UpdateContactListResponse EndUpdateContactList(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCustomVerificationEmailTemplate


        /// <summary>
        /// Updates an existing custom verification email template.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
        /// custom verification email templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomVerificationEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateCustomVerificationEmailTemplate service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateCustomVerificationEmailTemplate">REST API Reference for UpdateCustomVerificationEmailTemplate Operation</seealso>
        UpdateCustomVerificationEmailTemplateResponse UpdateCustomVerificationEmailTemplate(UpdateCustomVerificationEmailTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomVerificationEmailTemplate operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCustomVerificationEmailTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateCustomVerificationEmailTemplate">REST API Reference for UpdateCustomVerificationEmailTemplate Operation</seealso>
        IAsyncResult BeginUpdateCustomVerificationEmailTemplate(UpdateCustomVerificationEmailTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCustomVerificationEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCustomVerificationEmailTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateCustomVerificationEmailTemplateResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateCustomVerificationEmailTemplate">REST API Reference for UpdateCustomVerificationEmailTemplate Operation</seealso>
        UpdateCustomVerificationEmailTemplateResponse EndUpdateCustomVerificationEmailTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEmailIdentityPolicy


        /// <summary>
        /// Updates the specified sending authorization policy for the given identity (an email
        /// address or a domain). This API returns successfully even if a policy with the specified
        /// name does not exist.
        /// 
        ///  <note> 
        /// <para>
        /// This API is for the identity owner only. If you have not verified the identity, this
        /// API will return an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Sending authorization is a feature that enables an identity owner to authorize other
        /// senders to use its identities. For information about using sending authorization,
        /// see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailIdentityPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateEmailIdentityPolicy service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateEmailIdentityPolicy">REST API Reference for UpdateEmailIdentityPolicy Operation</seealso>
        UpdateEmailIdentityPolicyResponse UpdateEmailIdentityPolicy(UpdateEmailIdentityPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEmailIdentityPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailIdentityPolicy operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEmailIdentityPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateEmailIdentityPolicy">REST API Reference for UpdateEmailIdentityPolicy Operation</seealso>
        IAsyncResult BeginUpdateEmailIdentityPolicy(UpdateEmailIdentityPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEmailIdentityPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEmailIdentityPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateEmailIdentityPolicyResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateEmailIdentityPolicy">REST API Reference for UpdateEmailIdentityPolicy Operation</seealso>
        UpdateEmailIdentityPolicyResponse EndUpdateEmailIdentityPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEmailTemplate


        /// <summary>
        /// Updates an email template. Email templates enable you to send personalized email to
        /// one or more destinations in a single API operation. For more information, see the
        /// <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/send-personalized-email-api.html">Amazon
        /// SES Developer Guide</a>.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateEmailTemplate service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateEmailTemplate">REST API Reference for UpdateEmailTemplate Operation</seealso>
        UpdateEmailTemplateResponse UpdateEmailTemplate(UpdateEmailTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailTemplate operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEmailTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateEmailTemplate">REST API Reference for UpdateEmailTemplate Operation</seealso>
        IAsyncResult BeginUpdateEmailTemplate(UpdateEmailTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEmailTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateEmailTemplateResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateEmailTemplate">REST API Reference for UpdateEmailTemplate Operation</seealso>
        UpdateEmailTemplateResponse EndUpdateEmailTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateReputationEntityCustomerManagedStatus


        /// <summary>
        /// Update the customer-managed sending status for a reputation entity. This allows you
        /// to enable, disable, or reinstate sending for the entity.
        /// 
        ///  
        /// <para>
        /// The customer-managed status works in conjunction with the Amazon Web Services Amazon
        /// SES-managed status to determine the overall sending capability. When you update the
        /// customer-managed status, the Amazon Web Services Amazon SES-managed status remains
        /// unchanged. If Amazon Web Services Amazon SES has disabled the entity, it will not
        /// be allowed to send regardless of the customer-managed status setting. When you reinstate
        /// an entity through the customer-managed status, it can continue sending only if the
        /// Amazon Web Services Amazon SES-managed status also permits sending, even if there
        /// are active reputation findings, until the findings are resolved or new violations
        /// occur.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReputationEntityCustomerManagedStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateReputationEntityCustomerManagedStatus service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConflictException">
        /// If there is already an ongoing account details update under review.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateReputationEntityCustomerManagedStatus">REST API Reference for UpdateReputationEntityCustomerManagedStatus Operation</seealso>
        UpdateReputationEntityCustomerManagedStatusResponse UpdateReputationEntityCustomerManagedStatus(UpdateReputationEntityCustomerManagedStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReputationEntityCustomerManagedStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReputationEntityCustomerManagedStatus operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReputationEntityCustomerManagedStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateReputationEntityCustomerManagedStatus">REST API Reference for UpdateReputationEntityCustomerManagedStatus Operation</seealso>
        IAsyncResult BeginUpdateReputationEntityCustomerManagedStatus(UpdateReputationEntityCustomerManagedStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReputationEntityCustomerManagedStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReputationEntityCustomerManagedStatus.</param>
        /// 
        /// <returns>Returns a  UpdateReputationEntityCustomerManagedStatusResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateReputationEntityCustomerManagedStatus">REST API Reference for UpdateReputationEntityCustomerManagedStatus Operation</seealso>
        UpdateReputationEntityCustomerManagedStatusResponse EndUpdateReputationEntityCustomerManagedStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateReputationEntityPolicy


        /// <summary>
        /// Update the reputation management policy for a reputation entity. The policy determines
        /// how the entity responds to reputation findings, such as automatically pausing sending
        /// when certain thresholds are exceeded.
        /// 
        ///  
        /// <para>
        /// Reputation management policies are Amazon Web Services Amazon SES-managed (predefined
        /// policies). You can select from none, standard, and strict policies.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReputationEntityPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateReputationEntityPolicy service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.ConflictException">
        /// If there is already an ongoing account details update under review.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateReputationEntityPolicy">REST API Reference for UpdateReputationEntityPolicy Operation</seealso>
        UpdateReputationEntityPolicyResponse UpdateReputationEntityPolicy(UpdateReputationEntityPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReputationEntityPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReputationEntityPolicy operation on AmazonSimpleEmailServiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReputationEntityPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateReputationEntityPolicy">REST API Reference for UpdateReputationEntityPolicy Operation</seealso>
        IAsyncResult BeginUpdateReputationEntityPolicy(UpdateReputationEntityPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReputationEntityPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReputationEntityPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateReputationEntityPolicyResult from SimpleEmailServiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/UpdateReputationEntityPolicy">REST API Reference for UpdateReputationEntityPolicy Operation</seealso>
        UpdateReputationEntityPolicyResponse EndUpdateReputationEntityPolicy(IAsyncResult asyncResult);

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
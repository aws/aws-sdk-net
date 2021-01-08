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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PinpointEmail.Model;

namespace Amazon.PinpointEmail
{
    /// <summary>
    /// Interface for accessing PinpointEmail
    ///
    /// Amazon Pinpoint Email Service 
    /// <para>
    /// Welcome to the <i>Amazon Pinpoint Email API Reference</i>. This guide provides information
    /// about the Amazon Pinpoint Email API (version 1.0), including supported operations,
    /// data types, parameters, and schemas.
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://aws.amazon.com/pinpoint">Amazon Pinpoint</a> is an AWS service that
    /// you can use to engage with your customers across multiple messaging channels. You
    /// can use Amazon Pinpoint to send email, SMS text messages, voice messages, and push
    /// notifications. The Amazon Pinpoint Email API provides programmatic access to options
    /// that are unique to the email channel and supplement the options provided by the Amazon
    /// Pinpoint API.
    /// </para>
    ///  
    /// <para>
    /// If you're new to Amazon Pinpoint, you might find it helpful to also review the <a
    /// href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/welcome.html">Amazon
    /// Pinpoint Developer Guide</a>. The <i>Amazon Pinpoint Developer Guide</i> provides
    /// tutorials, code samples, and procedures that demonstrate how to use Amazon Pinpoint
    /// features programmatically and how to integrate Amazon Pinpoint functionality into
    /// mobile apps and other types of applications. The guide also provides information about
    /// key topics such as Amazon Pinpoint integration with other AWS services and the limits
    /// that apply to using the service.
    /// </para>
    ///  
    /// <para>
    /// The Amazon Pinpoint Email API is available in several AWS Regions and it provides
    /// an endpoint for each of these Regions. For a list of all the Regions and endpoints
    /// where the API is currently available, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#pinpoint_region">AWS
    /// Service Endpoints</a> in the <i>Amazon Web Services General Reference</i>. To learn
    /// more about AWS Regions, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande-manage.html">Managing
    /// AWS Regions</a> in the <i>Amazon Web Services General Reference</i>.
    /// </para>
    ///  
    /// <para>
    /// In each Region, AWS maintains multiple Availability Zones. These Availability Zones
    /// are physically isolated from each other, but are united by private, low-latency, high-throughput,
    /// and highly redundant network connections. These Availability Zones enable us to provide
    /// very high levels of availability and redundancy, while also minimizing latency. To
    /// learn more about the number of Availability Zones that are available in each Region,
    /// see <a href="http://aws.amazon.com/about-aws/global-infrastructure/">AWS Global Infrastructure</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonPinpointEmail : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPinpointEmailPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateConfigurationSet


        /// <summary>
        /// Create a configuration set. <i>Configuration sets</i> are groups of rules that you
        /// can apply to the emails you send using Amazon Pinpoint. You apply a configuration
        /// set to an email by including a reference to the configuration set in the headers of
        /// the email. When you apply a configuration set to an email, all of the rules in that
        /// configuration set are applied to the email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationSet service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        CreateConfigurationSetResponse CreateConfigurationSet(CreateConfigurationSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfigurationSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        IAsyncResult BeginCreateConfigurationSet(CreateConfigurationSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfigurationSet.</param>
        /// 
        /// <returns>Returns a  CreateConfigurationSetResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        CreateConfigurationSetResponse EndCreateConfigurationSet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConfigurationSetEventDestination


        /// <summary>
        /// Create an event destination. In Amazon Pinpoint, <i>events</i> include message sends,
        /// deliveries, opens, clicks, bounces, and complaints. <i>Event destinations</i> are
        /// places that you can send information about these events to. For example, you can send
        /// event data to Amazon SNS to receive notifications when you receive bounces or complaints,
        /// or you can use Amazon Kinesis Data Firehose to stream data to Amazon S3 for long-term
        /// storage.
        /// 
        ///  
        /// <para>
        /// A single configuration set can include more than one event destination.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationSetEventDestination service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/CreateConfigurationSetEventDestination">REST API Reference for CreateConfigurationSetEventDestination Operation</seealso>
        CreateConfigurationSetEventDestinationResponse CreateConfigurationSetEventDestination(CreateConfigurationSetEventDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetEventDestination operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfigurationSetEventDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/CreateConfigurationSetEventDestination">REST API Reference for CreateConfigurationSetEventDestination Operation</seealso>
        IAsyncResult BeginCreateConfigurationSetEventDestination(CreateConfigurationSetEventDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfigurationSetEventDestination.</param>
        /// 
        /// <returns>Returns a  CreateConfigurationSetEventDestinationResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/CreateConfigurationSetEventDestination">REST API Reference for CreateConfigurationSetEventDestination Operation</seealso>
        CreateConfigurationSetEventDestinationResponse EndCreateConfigurationSetEventDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDedicatedIpPool


        /// <summary>
        /// Create a new pool of dedicated IP addresses. A pool can include one or more dedicated
        /// IP addresses that are associated with your Amazon Pinpoint account. You can associate
        /// a pool with a configuration set. When you send an email that uses that configuration
        /// set, Amazon Pinpoint sends it using only the IP addresses in the associated pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDedicatedIpPool service method.</param>
        /// 
        /// <returns>The response from the CreateDedicatedIpPool service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/CreateDedicatedIpPool">REST API Reference for CreateDedicatedIpPool Operation</seealso>
        CreateDedicatedIpPoolResponse CreateDedicatedIpPool(CreateDedicatedIpPoolRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDedicatedIpPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDedicatedIpPool operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDedicatedIpPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/CreateDedicatedIpPool">REST API Reference for CreateDedicatedIpPool Operation</seealso>
        IAsyncResult BeginCreateDedicatedIpPool(CreateDedicatedIpPoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDedicatedIpPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDedicatedIpPool.</param>
        /// 
        /// <returns>Returns a  CreateDedicatedIpPoolResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/CreateDedicatedIpPool">REST API Reference for CreateDedicatedIpPool Operation</seealso>
        CreateDedicatedIpPoolResponse EndCreateDedicatedIpPool(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDeliverabilityTestReport


        /// <summary>
        /// Create a new predictive inbox placement test. Predictive inbox placement tests can
        /// help you predict how your messages will be handled by various email providers around
        /// the world. When you perform a predictive inbox placement test, you provide a sample
        /// message that contains the content that you plan to send to your customers. Amazon
        /// Pinpoint then sends that message to special email addresses spread across several
        /// major email providers. After about 24 hours, the test is complete, and you can use
        /// the <code>GetDeliverabilityTestReport</code> operation to view the results of the
        /// test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeliverabilityTestReport service method.</param>
        /// 
        /// <returns>The response from the CreateDeliverabilityTestReport service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.AccountSuspendedException">
        /// The message can't be sent because the account's ability to send email has been permanently
        /// restricted.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.MailFromDomainNotVerifiedException">
        /// The message can't be sent because the sending domain isn't verified.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.MessageRejectedException">
        /// The message can't be sent because it contains invalid content.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.SendingPausedException">
        /// The message can't be sent because the account's ability to send email is currently
        /// paused.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/CreateDeliverabilityTestReport">REST API Reference for CreateDeliverabilityTestReport Operation</seealso>
        CreateDeliverabilityTestReportResponse CreateDeliverabilityTestReport(CreateDeliverabilityTestReportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeliverabilityTestReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeliverabilityTestReport operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeliverabilityTestReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/CreateDeliverabilityTestReport">REST API Reference for CreateDeliverabilityTestReport Operation</seealso>
        IAsyncResult BeginCreateDeliverabilityTestReport(CreateDeliverabilityTestReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeliverabilityTestReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeliverabilityTestReport.</param>
        /// 
        /// <returns>Returns a  CreateDeliverabilityTestReportResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/CreateDeliverabilityTestReport">REST API Reference for CreateDeliverabilityTestReport Operation</seealso>
        CreateDeliverabilityTestReportResponse EndCreateDeliverabilityTestReport(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEmailIdentity


        /// <summary>
        /// Verifies an email identity for use with Amazon Pinpoint. In Amazon Pinpoint, an identity
        /// is an email address or domain that you use when you send email. Before you can use
        /// an identity to send email with Amazon Pinpoint, you first have to verify it. By verifying
        /// an address, you demonstrate that you're the owner of the address, and that you've
        /// given Amazon Pinpoint permission to send email from the address.
        /// 
        ///  
        /// <para>
        /// When you verify an email address, Amazon Pinpoint sends an email to the address. Your
        /// email address is verified as soon as you follow the link in the verification email.
        /// 
        /// </para>
        ///  
        /// <para>
        /// When you verify a domain, this operation provides a set of DKIM tokens, which you
        /// can convert into CNAME tokens. You add these CNAME tokens to the DNS configuration
        /// for your domain. Your domain is verified when Amazon Pinpoint detects these records
        /// in the DNS configuration for your domain. It usually takes around 72 hours to complete
        /// the domain verification process.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailIdentity service method.</param>
        /// 
        /// <returns>The response from the CreateEmailIdentity service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/CreateEmailIdentity">REST API Reference for CreateEmailIdentity Operation</seealso>
        CreateEmailIdentityResponse CreateEmailIdentity(CreateEmailIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailIdentity operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEmailIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/CreateEmailIdentity">REST API Reference for CreateEmailIdentity Operation</seealso>
        IAsyncResult BeginCreateEmailIdentity(CreateEmailIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEmailIdentity.</param>
        /// 
        /// <returns>Returns a  CreateEmailIdentityResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/CreateEmailIdentity">REST API Reference for CreateEmailIdentity Operation</seealso>
        CreateEmailIdentityResponse EndCreateEmailIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConfigurationSet


        /// <summary>
        /// Delete an existing configuration set.
        /// 
        ///  
        /// <para>
        /// In Amazon Pinpoint, <i>configuration sets</i> are groups of rules that you can apply
        /// to the emails you send. You apply a configuration set to an email by including a reference
        /// to the configuration set in the headers of the email. When you apply a configuration
        /// set to an email, all of the rules in that configuration set are applied to the email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationSet service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        DeleteConfigurationSetResponse DeleteConfigurationSet(DeleteConfigurationSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigurationSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        IAsyncResult BeginDeleteConfigurationSet(DeleteConfigurationSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationSet.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationSetResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        DeleteConfigurationSetResponse EndDeleteConfigurationSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConfigurationSetEventDestination


        /// <summary>
        /// Delete an event destination.
        /// 
        ///  
        /// <para>
        /// In Amazon Pinpoint, <i>events</i> include message sends, deliveries, opens, clicks,
        /// bounces, and complaints. <i>Event destinations</i> are places that you can send information
        /// about these events to. For example, you can send event data to Amazon SNS to receive
        /// notifications when you receive bounces or complaints, or you can use Amazon Kinesis
        /// Data Firehose to stream data to Amazon S3 for long-term storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationSetEventDestination service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/DeleteConfigurationSetEventDestination">REST API Reference for DeleteConfigurationSetEventDestination Operation</seealso>
        DeleteConfigurationSetEventDestinationResponse DeleteConfigurationSetEventDestination(DeleteConfigurationSetEventDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetEventDestination operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigurationSetEventDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/DeleteConfigurationSetEventDestination">REST API Reference for DeleteConfigurationSetEventDestination Operation</seealso>
        IAsyncResult BeginDeleteConfigurationSetEventDestination(DeleteConfigurationSetEventDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationSetEventDestination.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationSetEventDestinationResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/DeleteConfigurationSetEventDestination">REST API Reference for DeleteConfigurationSetEventDestination Operation</seealso>
        DeleteConfigurationSetEventDestinationResponse EndDeleteConfigurationSetEventDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDedicatedIpPool


        /// <summary>
        /// Delete a dedicated IP pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDedicatedIpPool service method.</param>
        /// 
        /// <returns>The response from the DeleteDedicatedIpPool service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/DeleteDedicatedIpPool">REST API Reference for DeleteDedicatedIpPool Operation</seealso>
        DeleteDedicatedIpPoolResponse DeleteDedicatedIpPool(DeleteDedicatedIpPoolRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDedicatedIpPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDedicatedIpPool operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDedicatedIpPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/DeleteDedicatedIpPool">REST API Reference for DeleteDedicatedIpPool Operation</seealso>
        IAsyncResult BeginDeleteDedicatedIpPool(DeleteDedicatedIpPoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDedicatedIpPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDedicatedIpPool.</param>
        /// 
        /// <returns>Returns a  DeleteDedicatedIpPoolResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/DeleteDedicatedIpPool">REST API Reference for DeleteDedicatedIpPool Operation</seealso>
        DeleteDedicatedIpPoolResponse EndDeleteDedicatedIpPool(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEmailIdentity


        /// <summary>
        /// Deletes an email identity that you previously verified for use with Amazon Pinpoint.
        /// An identity can be either an email address or a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteEmailIdentity service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/DeleteEmailIdentity">REST API Reference for DeleteEmailIdentity Operation</seealso>
        DeleteEmailIdentityResponse DeleteEmailIdentity(DeleteEmailIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailIdentity operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEmailIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/DeleteEmailIdentity">REST API Reference for DeleteEmailIdentity Operation</seealso>
        IAsyncResult BeginDeleteEmailIdentity(DeleteEmailIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEmailIdentity.</param>
        /// 
        /// <returns>Returns a  DeleteEmailIdentityResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/DeleteEmailIdentity">REST API Reference for DeleteEmailIdentity Operation</seealso>
        DeleteEmailIdentityResponse EndDeleteEmailIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccount


        /// <summary>
        /// Obtain information about the email-sending status and capabilities of your Amazon
        /// Pinpoint account in the current AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccount service method.</param>
        /// 
        /// <returns>The response from the GetAccount service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetAccount">REST API Reference for GetAccount Operation</seealso>
        GetAccountResponse GetAccount(GetAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccount operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetAccount">REST API Reference for GetAccount Operation</seealso>
        IAsyncResult BeginGetAccount(GetAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccount.</param>
        /// 
        /// <returns>Returns a  GetAccountResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetAccount">REST API Reference for GetAccount Operation</seealso>
        GetAccountResponse EndGetAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBlacklistReports


        /// <summary>
        /// Retrieve a list of the blacklists that your dedicated IP addresses appear on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlacklistReports service method.</param>
        /// 
        /// <returns>The response from the GetBlacklistReports service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetBlacklistReports">REST API Reference for GetBlacklistReports Operation</seealso>
        GetBlacklistReportsResponse GetBlacklistReports(GetBlacklistReportsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBlacklistReports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBlacklistReports operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBlacklistReports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetBlacklistReports">REST API Reference for GetBlacklistReports Operation</seealso>
        IAsyncResult BeginGetBlacklistReports(GetBlacklistReportsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBlacklistReports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBlacklistReports.</param>
        /// 
        /// <returns>Returns a  GetBlacklistReportsResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetBlacklistReports">REST API Reference for GetBlacklistReports Operation</seealso>
        GetBlacklistReportsResponse EndGetBlacklistReports(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConfigurationSet


        /// <summary>
        /// Get information about an existing configuration set, including the dedicated IP pool
        /// that it's associated with, whether or not it's enabled for sending email, and more.
        /// 
        ///  
        /// <para>
        /// In Amazon Pinpoint, <i>configuration sets</i> are groups of rules that you can apply
        /// to the emails you send. You apply a configuration set to an email by including a reference
        /// to the configuration set in the headers of the email. When you apply a configuration
        /// set to an email, all of the rules in that configuration set are applied to the email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the GetConfigurationSet service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetConfigurationSet">REST API Reference for GetConfigurationSet Operation</seealso>
        GetConfigurationSetResponse GetConfigurationSet(GetConfigurationSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSet operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfigurationSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetConfigurationSet">REST API Reference for GetConfigurationSet Operation</seealso>
        IAsyncResult BeginGetConfigurationSet(GetConfigurationSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfigurationSet.</param>
        /// 
        /// <returns>Returns a  GetConfigurationSetResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetConfigurationSet">REST API Reference for GetConfigurationSet Operation</seealso>
        GetConfigurationSetResponse EndGetConfigurationSet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConfigurationSetEventDestinations


        /// <summary>
        /// Retrieve a list of event destinations that are associated with a configuration set.
        /// 
        ///  
        /// <para>
        /// In Amazon Pinpoint, <i>events</i> include message sends, deliveries, opens, clicks,
        /// bounces, and complaints. <i>Event destinations</i> are places that you can send information
        /// about these events to. For example, you can send event data to Amazon SNS to receive
        /// notifications when you receive bounces or complaints, or you can use Amazon Kinesis
        /// Data Firehose to stream data to Amazon S3 for long-term storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSetEventDestinations service method.</param>
        /// 
        /// <returns>The response from the GetConfigurationSetEventDestinations service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetConfigurationSetEventDestinations">REST API Reference for GetConfigurationSetEventDestinations Operation</seealso>
        GetConfigurationSetEventDestinationsResponse GetConfigurationSetEventDestinations(GetConfigurationSetEventDestinationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfigurationSetEventDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSetEventDestinations operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfigurationSetEventDestinations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetConfigurationSetEventDestinations">REST API Reference for GetConfigurationSetEventDestinations Operation</seealso>
        IAsyncResult BeginGetConfigurationSetEventDestinations(GetConfigurationSetEventDestinationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfigurationSetEventDestinations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfigurationSetEventDestinations.</param>
        /// 
        /// <returns>Returns a  GetConfigurationSetEventDestinationsResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetConfigurationSetEventDestinations">REST API Reference for GetConfigurationSetEventDestinations Operation</seealso>
        GetConfigurationSetEventDestinationsResponse EndGetConfigurationSetEventDestinations(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDedicatedIp


        /// <summary>
        /// Get information about a dedicated IP address, including the name of the dedicated
        /// IP pool that it's associated with, as well information about the automatic warm-up
        /// process for the address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIp service method.</param>
        /// 
        /// <returns>The response from the GetDedicatedIp service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetDedicatedIp">REST API Reference for GetDedicatedIp Operation</seealso>
        GetDedicatedIpResponse GetDedicatedIp(GetDedicatedIpRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDedicatedIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIp operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDedicatedIp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetDedicatedIp">REST API Reference for GetDedicatedIp Operation</seealso>
        IAsyncResult BeginGetDedicatedIp(GetDedicatedIpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDedicatedIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDedicatedIp.</param>
        /// 
        /// <returns>Returns a  GetDedicatedIpResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetDedicatedIp">REST API Reference for GetDedicatedIp Operation</seealso>
        GetDedicatedIpResponse EndGetDedicatedIp(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDedicatedIps


        /// <summary>
        /// List the dedicated IP addresses that are associated with your Amazon Pinpoint account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIps service method.</param>
        /// 
        /// <returns>The response from the GetDedicatedIps service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetDedicatedIps">REST API Reference for GetDedicatedIps Operation</seealso>
        GetDedicatedIpsResponse GetDedicatedIps(GetDedicatedIpsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDedicatedIps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIps operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDedicatedIps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetDedicatedIps">REST API Reference for GetDedicatedIps Operation</seealso>
        IAsyncResult BeginGetDedicatedIps(GetDedicatedIpsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDedicatedIps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDedicatedIps.</param>
        /// 
        /// <returns>Returns a  GetDedicatedIpsResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetDedicatedIps">REST API Reference for GetDedicatedIps Operation</seealso>
        GetDedicatedIpsResponse EndGetDedicatedIps(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDeliverabilityDashboardOptions


        /// <summary>
        /// Retrieve information about the status of the Deliverability dashboard for your Amazon
        /// Pinpoint account. When the Deliverability dashboard is enabled, you gain access to
        /// reputation, deliverability, and other metrics for the domains that you use to send
        /// email using Amazon Pinpoint. You also gain the ability to perform predictive inbox
        /// placement tests.
        /// 
        ///  
        /// <para>
        /// When you use the Deliverability dashboard, you pay a monthly subscription charge,
        /// in addition to any other fees that you accrue by using Amazon Pinpoint. For more information
        /// about the features and cost of a Deliverability dashboard subscription, see <a href="http://aws.amazon.com/pinpoint/pricing/">Amazon
        /// Pinpoint Pricing</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityDashboardOptions service method.</param>
        /// 
        /// <returns>The response from the GetDeliverabilityDashboardOptions service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetDeliverabilityDashboardOptions">REST API Reference for GetDeliverabilityDashboardOptions Operation</seealso>
        GetDeliverabilityDashboardOptionsResponse GetDeliverabilityDashboardOptions(GetDeliverabilityDashboardOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeliverabilityDashboardOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityDashboardOptions operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeliverabilityDashboardOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetDeliverabilityDashboardOptions">REST API Reference for GetDeliverabilityDashboardOptions Operation</seealso>
        IAsyncResult BeginGetDeliverabilityDashboardOptions(GetDeliverabilityDashboardOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeliverabilityDashboardOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeliverabilityDashboardOptions.</param>
        /// 
        /// <returns>Returns a  GetDeliverabilityDashboardOptionsResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetDeliverabilityDashboardOptions">REST API Reference for GetDeliverabilityDashboardOptions Operation</seealso>
        GetDeliverabilityDashboardOptionsResponse EndGetDeliverabilityDashboardOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDeliverabilityTestReport


        /// <summary>
        /// Retrieve the results of a predictive inbox placement test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityTestReport service method.</param>
        /// 
        /// <returns>The response from the GetDeliverabilityTestReport service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetDeliverabilityTestReport">REST API Reference for GetDeliverabilityTestReport Operation</seealso>
        GetDeliverabilityTestReportResponse GetDeliverabilityTestReport(GetDeliverabilityTestReportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeliverabilityTestReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityTestReport operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeliverabilityTestReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetDeliverabilityTestReport">REST API Reference for GetDeliverabilityTestReport Operation</seealso>
        IAsyncResult BeginGetDeliverabilityTestReport(GetDeliverabilityTestReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeliverabilityTestReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeliverabilityTestReport.</param>
        /// 
        /// <returns>Returns a  GetDeliverabilityTestReportResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetDeliverabilityTestReport">REST API Reference for GetDeliverabilityTestReport Operation</seealso>
        GetDeliverabilityTestReportResponse EndGetDeliverabilityTestReport(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDomainDeliverabilityCampaign


        /// <summary>
        /// Retrieve all the deliverability data for a specific campaign. This data is available
        /// for a campaign only if the campaign sent email by using a domain that the Deliverability
        /// dashboard is enabled for (<code>PutDeliverabilityDashboardOption</code> operation).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDeliverabilityCampaign service method.</param>
        /// 
        /// <returns>The response from the GetDomainDeliverabilityCampaign service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetDomainDeliverabilityCampaign">REST API Reference for GetDomainDeliverabilityCampaign Operation</seealso>
        GetDomainDeliverabilityCampaignResponse GetDomainDeliverabilityCampaign(GetDomainDeliverabilityCampaignRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainDeliverabilityCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDeliverabilityCampaign operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainDeliverabilityCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetDomainDeliverabilityCampaign">REST API Reference for GetDomainDeliverabilityCampaign Operation</seealso>
        IAsyncResult BeginGetDomainDeliverabilityCampaign(GetDomainDeliverabilityCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainDeliverabilityCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainDeliverabilityCampaign.</param>
        /// 
        /// <returns>Returns a  GetDomainDeliverabilityCampaignResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetDomainDeliverabilityCampaign">REST API Reference for GetDomainDeliverabilityCampaign Operation</seealso>
        GetDomainDeliverabilityCampaignResponse EndGetDomainDeliverabilityCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDomainStatisticsReport


        /// <summary>
        /// Retrieve inbox placement and engagement rates for the domains that you use to send
        /// email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainStatisticsReport service method.</param>
        /// 
        /// <returns>The response from the GetDomainStatisticsReport service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetDomainStatisticsReport">REST API Reference for GetDomainStatisticsReport Operation</seealso>
        GetDomainStatisticsReportResponse GetDomainStatisticsReport(GetDomainStatisticsReportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainStatisticsReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainStatisticsReport operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainStatisticsReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetDomainStatisticsReport">REST API Reference for GetDomainStatisticsReport Operation</seealso>
        IAsyncResult BeginGetDomainStatisticsReport(GetDomainStatisticsReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainStatisticsReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainStatisticsReport.</param>
        /// 
        /// <returns>Returns a  GetDomainStatisticsReportResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetDomainStatisticsReport">REST API Reference for GetDomainStatisticsReport Operation</seealso>
        GetDomainStatisticsReportResponse EndGetDomainStatisticsReport(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEmailIdentity


        /// <summary>
        /// Provides information about a specific identity associated with your Amazon Pinpoint
        /// account, including the identity's verification status, its DKIM authentication status,
        /// and its custom Mail-From settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailIdentity service method.</param>
        /// 
        /// <returns>The response from the GetEmailIdentity service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetEmailIdentity">REST API Reference for GetEmailIdentity Operation</seealso>
        GetEmailIdentityResponse GetEmailIdentity(GetEmailIdentityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEmailIdentity operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEmailIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetEmailIdentity">REST API Reference for GetEmailIdentity Operation</seealso>
        IAsyncResult BeginGetEmailIdentity(GetEmailIdentityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEmailIdentity.</param>
        /// 
        /// <returns>Returns a  GetEmailIdentityResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/GetEmailIdentity">REST API Reference for GetEmailIdentity Operation</seealso>
        GetEmailIdentityResponse EndGetEmailIdentity(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConfigurationSets


        /// <summary>
        /// List all of the configuration sets associated with your Amazon Pinpoint account in
        /// the current region.
        /// 
        ///  
        /// <para>
        /// In Amazon Pinpoint, <i>configuration sets</i> are groups of rules that you can apply
        /// to the emails you send. You apply a configuration set to an email by including a reference
        /// to the configuration set in the headers of the email. When you apply a configuration
        /// set to an email, all of the rules in that configuration set are applied to the email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationSets service method.</param>
        /// 
        /// <returns>The response from the ListConfigurationSets service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/ListConfigurationSets">REST API Reference for ListConfigurationSets Operation</seealso>
        ListConfigurationSetsResponse ListConfigurationSets(ListConfigurationSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurationSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationSets operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurationSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/ListConfigurationSets">REST API Reference for ListConfigurationSets Operation</seealso>
        IAsyncResult BeginListConfigurationSets(ListConfigurationSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurationSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurationSets.</param>
        /// 
        /// <returns>Returns a  ListConfigurationSetsResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/ListConfigurationSets">REST API Reference for ListConfigurationSets Operation</seealso>
        ListConfigurationSetsResponse EndListConfigurationSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDedicatedIpPools


        /// <summary>
        /// List all of the dedicated IP pools that exist in your Amazon Pinpoint account in the
        /// current AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDedicatedIpPools service method.</param>
        /// 
        /// <returns>The response from the ListDedicatedIpPools service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/ListDedicatedIpPools">REST API Reference for ListDedicatedIpPools Operation</seealso>
        ListDedicatedIpPoolsResponse ListDedicatedIpPools(ListDedicatedIpPoolsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDedicatedIpPools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDedicatedIpPools operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDedicatedIpPools
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/ListDedicatedIpPools">REST API Reference for ListDedicatedIpPools Operation</seealso>
        IAsyncResult BeginListDedicatedIpPools(ListDedicatedIpPoolsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDedicatedIpPools operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDedicatedIpPools.</param>
        /// 
        /// <returns>Returns a  ListDedicatedIpPoolsResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/ListDedicatedIpPools">REST API Reference for ListDedicatedIpPools Operation</seealso>
        ListDedicatedIpPoolsResponse EndListDedicatedIpPools(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDeliverabilityTestReports


        /// <summary>
        /// Show a list of the predictive inbox placement tests that you've performed, regardless
        /// of their statuses. For predictive inbox placement tests that are complete, you can
        /// use the <code>GetDeliverabilityTestReport</code> operation to view the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeliverabilityTestReports service method.</param>
        /// 
        /// <returns>The response from the ListDeliverabilityTestReports service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/ListDeliverabilityTestReports">REST API Reference for ListDeliverabilityTestReports Operation</seealso>
        ListDeliverabilityTestReportsResponse ListDeliverabilityTestReports(ListDeliverabilityTestReportsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeliverabilityTestReports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeliverabilityTestReports operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeliverabilityTestReports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/ListDeliverabilityTestReports">REST API Reference for ListDeliverabilityTestReports Operation</seealso>
        IAsyncResult BeginListDeliverabilityTestReports(ListDeliverabilityTestReportsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeliverabilityTestReports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeliverabilityTestReports.</param>
        /// 
        /// <returns>Returns a  ListDeliverabilityTestReportsResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/ListDeliverabilityTestReports">REST API Reference for ListDeliverabilityTestReports Operation</seealso>
        ListDeliverabilityTestReportsResponse EndListDeliverabilityTestReports(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDomainDeliverabilityCampaigns


        /// <summary>
        /// Retrieve deliverability data for all the campaigns that used a specific domain to
        /// send email during a specified time range. This data is available for a domain only
        /// if you enabled the Deliverability dashboard (<code>PutDeliverabilityDashboardOption</code>
        /// operation) for the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainDeliverabilityCampaigns service method.</param>
        /// 
        /// <returns>The response from the ListDomainDeliverabilityCampaigns service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/ListDomainDeliverabilityCampaigns">REST API Reference for ListDomainDeliverabilityCampaigns Operation</seealso>
        ListDomainDeliverabilityCampaignsResponse ListDomainDeliverabilityCampaigns(ListDomainDeliverabilityCampaignsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainDeliverabilityCampaigns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomainDeliverabilityCampaigns operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomainDeliverabilityCampaigns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/ListDomainDeliverabilityCampaigns">REST API Reference for ListDomainDeliverabilityCampaigns Operation</seealso>
        IAsyncResult BeginListDomainDeliverabilityCampaigns(ListDomainDeliverabilityCampaignsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomainDeliverabilityCampaigns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomainDeliverabilityCampaigns.</param>
        /// 
        /// <returns>Returns a  ListDomainDeliverabilityCampaignsResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/ListDomainDeliverabilityCampaigns">REST API Reference for ListDomainDeliverabilityCampaigns Operation</seealso>
        ListDomainDeliverabilityCampaignsResponse EndListDomainDeliverabilityCampaigns(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEmailIdentities


        /// <summary>
        /// Returns a list of all of the email identities that are associated with your Amazon
        /// Pinpoint account. An identity can be either an email address or a domain. This operation
        /// returns identities that are verified as well as those that aren't.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEmailIdentities service method.</param>
        /// 
        /// <returns>The response from the ListEmailIdentities service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/ListEmailIdentities">REST API Reference for ListEmailIdentities Operation</seealso>
        ListEmailIdentitiesResponse ListEmailIdentities(ListEmailIdentitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEmailIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEmailIdentities operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEmailIdentities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/ListEmailIdentities">REST API Reference for ListEmailIdentities Operation</seealso>
        IAsyncResult BeginListEmailIdentities(ListEmailIdentitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEmailIdentities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEmailIdentities.</param>
        /// 
        /// <returns>Returns a  ListEmailIdentitiesResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/ListEmailIdentities">REST API Reference for ListEmailIdentities Operation</seealso>
        ListEmailIdentitiesResponse EndListEmailIdentities(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieve a list of the tags (keys and values) that are associated with a specified
        /// resource. A <i>tag</i> is a label that you optionally define and associate with a
        /// resource in Amazon Pinpoint. Each tag consists of a required <i>tag key</i> and an
        /// optional associated <i>tag value</i>. A tag key is a general label that acts as a
        /// category for more specific tag values. A tag value acts as a descriptor within a tag
        /// key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutAccountDedicatedIpWarmupAttributes


        /// <summary>
        /// Enable or disable the automatic warm-up feature for dedicated IP addresses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountDedicatedIpWarmupAttributes service method.</param>
        /// 
        /// <returns>The response from the PutAccountDedicatedIpWarmupAttributes service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutAccountDedicatedIpWarmupAttributes">REST API Reference for PutAccountDedicatedIpWarmupAttributes Operation</seealso>
        PutAccountDedicatedIpWarmupAttributesResponse PutAccountDedicatedIpWarmupAttributes(PutAccountDedicatedIpWarmupAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAccountDedicatedIpWarmupAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAccountDedicatedIpWarmupAttributes operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAccountDedicatedIpWarmupAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutAccountDedicatedIpWarmupAttributes">REST API Reference for PutAccountDedicatedIpWarmupAttributes Operation</seealso>
        IAsyncResult BeginPutAccountDedicatedIpWarmupAttributes(PutAccountDedicatedIpWarmupAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAccountDedicatedIpWarmupAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAccountDedicatedIpWarmupAttributes.</param>
        /// 
        /// <returns>Returns a  PutAccountDedicatedIpWarmupAttributesResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutAccountDedicatedIpWarmupAttributes">REST API Reference for PutAccountDedicatedIpWarmupAttributes Operation</seealso>
        PutAccountDedicatedIpWarmupAttributesResponse EndPutAccountDedicatedIpWarmupAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  PutAccountSendingAttributes


        /// <summary>
        /// Enable or disable the ability of your account to send email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSendingAttributes service method.</param>
        /// 
        /// <returns>The response from the PutAccountSendingAttributes service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutAccountSendingAttributes">REST API Reference for PutAccountSendingAttributes Operation</seealso>
        PutAccountSendingAttributesResponse PutAccountSendingAttributes(PutAccountSendingAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAccountSendingAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSendingAttributes operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAccountSendingAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutAccountSendingAttributes">REST API Reference for PutAccountSendingAttributes Operation</seealso>
        IAsyncResult BeginPutAccountSendingAttributes(PutAccountSendingAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAccountSendingAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAccountSendingAttributes.</param>
        /// 
        /// <returns>Returns a  PutAccountSendingAttributesResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutAccountSendingAttributes">REST API Reference for PutAccountSendingAttributes Operation</seealso>
        PutAccountSendingAttributesResponse EndPutAccountSendingAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  PutConfigurationSetDeliveryOptions


        /// <summary>
        /// Associate a configuration set with a dedicated IP pool. You can use dedicated IP pools
        /// to create groups of dedicated IP addresses for sending specific types of email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetDeliveryOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetDeliveryOptions service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutConfigurationSetDeliveryOptions">REST API Reference for PutConfigurationSetDeliveryOptions Operation</seealso>
        PutConfigurationSetDeliveryOptionsResponse PutConfigurationSetDeliveryOptions(PutConfigurationSetDeliveryOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationSetDeliveryOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetDeliveryOptions operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConfigurationSetDeliveryOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutConfigurationSetDeliveryOptions">REST API Reference for PutConfigurationSetDeliveryOptions Operation</seealso>
        IAsyncResult BeginPutConfigurationSetDeliveryOptions(PutConfigurationSetDeliveryOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutConfigurationSetDeliveryOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConfigurationSetDeliveryOptions.</param>
        /// 
        /// <returns>Returns a  PutConfigurationSetDeliveryOptionsResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutConfigurationSetDeliveryOptions">REST API Reference for PutConfigurationSetDeliveryOptions Operation</seealso>
        PutConfigurationSetDeliveryOptionsResponse EndPutConfigurationSetDeliveryOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  PutConfigurationSetReputationOptions


        /// <summary>
        /// Enable or disable collection of reputation metrics for emails that you send using
        /// a particular configuration set in a specific AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetReputationOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetReputationOptions service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutConfigurationSetReputationOptions">REST API Reference for PutConfigurationSetReputationOptions Operation</seealso>
        PutConfigurationSetReputationOptionsResponse PutConfigurationSetReputationOptions(PutConfigurationSetReputationOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationSetReputationOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetReputationOptions operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConfigurationSetReputationOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutConfigurationSetReputationOptions">REST API Reference for PutConfigurationSetReputationOptions Operation</seealso>
        IAsyncResult BeginPutConfigurationSetReputationOptions(PutConfigurationSetReputationOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutConfigurationSetReputationOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConfigurationSetReputationOptions.</param>
        /// 
        /// <returns>Returns a  PutConfigurationSetReputationOptionsResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutConfigurationSetReputationOptions">REST API Reference for PutConfigurationSetReputationOptions Operation</seealso>
        PutConfigurationSetReputationOptionsResponse EndPutConfigurationSetReputationOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  PutConfigurationSetSendingOptions


        /// <summary>
        /// Enable or disable email sending for messages that use a particular configuration set
        /// in a specific AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetSendingOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetSendingOptions service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutConfigurationSetSendingOptions">REST API Reference for PutConfigurationSetSendingOptions Operation</seealso>
        PutConfigurationSetSendingOptionsResponse PutConfigurationSetSendingOptions(PutConfigurationSetSendingOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationSetSendingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetSendingOptions operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConfigurationSetSendingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutConfigurationSetSendingOptions">REST API Reference for PutConfigurationSetSendingOptions Operation</seealso>
        IAsyncResult BeginPutConfigurationSetSendingOptions(PutConfigurationSetSendingOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutConfigurationSetSendingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConfigurationSetSendingOptions.</param>
        /// 
        /// <returns>Returns a  PutConfigurationSetSendingOptionsResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutConfigurationSetSendingOptions">REST API Reference for PutConfigurationSetSendingOptions Operation</seealso>
        PutConfigurationSetSendingOptionsResponse EndPutConfigurationSetSendingOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  PutConfigurationSetTrackingOptions


        /// <summary>
        /// Specify a custom domain to use for open and click tracking elements in email that
        /// you send using Amazon Pinpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetTrackingOptions service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationSetTrackingOptions service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutConfigurationSetTrackingOptions">REST API Reference for PutConfigurationSetTrackingOptions Operation</seealso>
        PutConfigurationSetTrackingOptionsResponse PutConfigurationSetTrackingOptions(PutConfigurationSetTrackingOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationSetTrackingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetTrackingOptions operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConfigurationSetTrackingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutConfigurationSetTrackingOptions">REST API Reference for PutConfigurationSetTrackingOptions Operation</seealso>
        IAsyncResult BeginPutConfigurationSetTrackingOptions(PutConfigurationSetTrackingOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutConfigurationSetTrackingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConfigurationSetTrackingOptions.</param>
        /// 
        /// <returns>Returns a  PutConfigurationSetTrackingOptionsResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutConfigurationSetTrackingOptions">REST API Reference for PutConfigurationSetTrackingOptions Operation</seealso>
        PutConfigurationSetTrackingOptionsResponse EndPutConfigurationSetTrackingOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  PutDedicatedIpInPool


        /// <summary>
        /// Move a dedicated IP address to an existing dedicated IP pool.
        /// 
        ///  <note> 
        /// <para>
        /// The dedicated IP address that you specify must already exist, and must be associated
        /// with your Amazon Pinpoint account. 
        /// </para>
        ///  
        /// <para>
        /// The dedicated IP pool you specify must already exist. You can create a new pool by
        /// using the <code>CreateDedicatedIpPool</code> operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpInPool service method.</param>
        /// 
        /// <returns>The response from the PutDedicatedIpInPool service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutDedicatedIpInPool">REST API Reference for PutDedicatedIpInPool Operation</seealso>
        PutDedicatedIpInPoolResponse PutDedicatedIpInPool(PutDedicatedIpInPoolRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutDedicatedIpInPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpInPool operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDedicatedIpInPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutDedicatedIpInPool">REST API Reference for PutDedicatedIpInPool Operation</seealso>
        IAsyncResult BeginPutDedicatedIpInPool(PutDedicatedIpInPoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutDedicatedIpInPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDedicatedIpInPool.</param>
        /// 
        /// <returns>Returns a  PutDedicatedIpInPoolResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutDedicatedIpInPool">REST API Reference for PutDedicatedIpInPool Operation</seealso>
        PutDedicatedIpInPoolResponse EndPutDedicatedIpInPool(IAsyncResult asyncResult);

        #endregion
        
        #region  PutDedicatedIpWarmupAttributes


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpWarmupAttributes service method.</param>
        /// 
        /// <returns>The response from the PutDedicatedIpWarmupAttributes service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutDedicatedIpWarmupAttributes">REST API Reference for PutDedicatedIpWarmupAttributes Operation</seealso>
        PutDedicatedIpWarmupAttributesResponse PutDedicatedIpWarmupAttributes(PutDedicatedIpWarmupAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutDedicatedIpWarmupAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpWarmupAttributes operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDedicatedIpWarmupAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutDedicatedIpWarmupAttributes">REST API Reference for PutDedicatedIpWarmupAttributes Operation</seealso>
        IAsyncResult BeginPutDedicatedIpWarmupAttributes(PutDedicatedIpWarmupAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutDedicatedIpWarmupAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDedicatedIpWarmupAttributes.</param>
        /// 
        /// <returns>Returns a  PutDedicatedIpWarmupAttributesResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutDedicatedIpWarmupAttributes">REST API Reference for PutDedicatedIpWarmupAttributes Operation</seealso>
        PutDedicatedIpWarmupAttributesResponse EndPutDedicatedIpWarmupAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  PutDeliverabilityDashboardOption


        /// <summary>
        /// Enable or disable the Deliverability dashboard for your Amazon Pinpoint account. When
        /// you enable the Deliverability dashboard, you gain access to reputation, deliverability,
        /// and other metrics for the domains that you use to send email using Amazon Pinpoint.
        /// You also gain the ability to perform predictive inbox placement tests.
        /// 
        ///  
        /// <para>
        /// When you use the Deliverability dashboard, you pay a monthly subscription charge,
        /// in addition to any other fees that you accrue by using Amazon Pinpoint. For more information
        /// about the features and cost of a Deliverability dashboard subscription, see <a href="http://aws.amazon.com/pinpoint/pricing/">Amazon
        /// Pinpoint Pricing</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeliverabilityDashboardOption service method.</param>
        /// 
        /// <returns>The response from the PutDeliverabilityDashboardOption service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.AlreadyExistsException">
        /// The resource specified in your request already exists.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutDeliverabilityDashboardOption">REST API Reference for PutDeliverabilityDashboardOption Operation</seealso>
        PutDeliverabilityDashboardOptionResponse PutDeliverabilityDashboardOption(PutDeliverabilityDashboardOptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutDeliverabilityDashboardOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDeliverabilityDashboardOption operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDeliverabilityDashboardOption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutDeliverabilityDashboardOption">REST API Reference for PutDeliverabilityDashboardOption Operation</seealso>
        IAsyncResult BeginPutDeliverabilityDashboardOption(PutDeliverabilityDashboardOptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutDeliverabilityDashboardOption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDeliverabilityDashboardOption.</param>
        /// 
        /// <returns>Returns a  PutDeliverabilityDashboardOptionResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutDeliverabilityDashboardOption">REST API Reference for PutDeliverabilityDashboardOption Operation</seealso>
        PutDeliverabilityDashboardOptionResponse EndPutDeliverabilityDashboardOption(IAsyncResult asyncResult);

        #endregion
        
        #region  PutEmailIdentityDkimAttributes


        /// <summary>
        /// Used to enable or disable DKIM authentication for an email identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityDkimAttributes service method.</param>
        /// 
        /// <returns>The response from the PutEmailIdentityDkimAttributes service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutEmailIdentityDkimAttributes">REST API Reference for PutEmailIdentityDkimAttributes Operation</seealso>
        PutEmailIdentityDkimAttributesResponse PutEmailIdentityDkimAttributes(PutEmailIdentityDkimAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutEmailIdentityDkimAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityDkimAttributes operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEmailIdentityDkimAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutEmailIdentityDkimAttributes">REST API Reference for PutEmailIdentityDkimAttributes Operation</seealso>
        IAsyncResult BeginPutEmailIdentityDkimAttributes(PutEmailIdentityDkimAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEmailIdentityDkimAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEmailIdentityDkimAttributes.</param>
        /// 
        /// <returns>Returns a  PutEmailIdentityDkimAttributesResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutEmailIdentityDkimAttributes">REST API Reference for PutEmailIdentityDkimAttributes Operation</seealso>
        PutEmailIdentityDkimAttributesResponse EndPutEmailIdentityDkimAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  PutEmailIdentityFeedbackAttributes


        /// <summary>
        /// Used to enable or disable feedback forwarding for an identity. This setting determines
        /// what happens when an identity is used to send an email that results in a bounce or
        /// complaint event.
        /// 
        ///  
        /// <para>
        /// When you enable feedback forwarding, Amazon Pinpoint sends you email notifications
        /// when bounce or complaint events occur. Amazon Pinpoint sends this notification to
        /// the address that you specified in the Return-Path header of the original email.
        /// </para>
        ///  
        /// <para>
        /// When you disable feedback forwarding, Amazon Pinpoint sends notifications through
        /// other mechanisms, such as by notifying an Amazon SNS topic. You're required to have
        /// a method of tracking bounces and complaints. If you haven't set up another mechanism
        /// for receiving bounce or complaint notifications, Amazon Pinpoint sends an email notification
        /// when these events occur (even if this setting is disabled).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityFeedbackAttributes service method.</param>
        /// 
        /// <returns>The response from the PutEmailIdentityFeedbackAttributes service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutEmailIdentityFeedbackAttributes">REST API Reference for PutEmailIdentityFeedbackAttributes Operation</seealso>
        PutEmailIdentityFeedbackAttributesResponse PutEmailIdentityFeedbackAttributes(PutEmailIdentityFeedbackAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutEmailIdentityFeedbackAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityFeedbackAttributes operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEmailIdentityFeedbackAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutEmailIdentityFeedbackAttributes">REST API Reference for PutEmailIdentityFeedbackAttributes Operation</seealso>
        IAsyncResult BeginPutEmailIdentityFeedbackAttributes(PutEmailIdentityFeedbackAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEmailIdentityFeedbackAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEmailIdentityFeedbackAttributes.</param>
        /// 
        /// <returns>Returns a  PutEmailIdentityFeedbackAttributesResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutEmailIdentityFeedbackAttributes">REST API Reference for PutEmailIdentityFeedbackAttributes Operation</seealso>
        PutEmailIdentityFeedbackAttributesResponse EndPutEmailIdentityFeedbackAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  PutEmailIdentityMailFromAttributes


        /// <summary>
        /// Used to enable or disable the custom Mail-From domain configuration for an email identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityMailFromAttributes service method.</param>
        /// 
        /// <returns>The response from the PutEmailIdentityMailFromAttributes service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutEmailIdentityMailFromAttributes">REST API Reference for PutEmailIdentityMailFromAttributes Operation</seealso>
        PutEmailIdentityMailFromAttributesResponse PutEmailIdentityMailFromAttributes(PutEmailIdentityMailFromAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutEmailIdentityMailFromAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityMailFromAttributes operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEmailIdentityMailFromAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutEmailIdentityMailFromAttributes">REST API Reference for PutEmailIdentityMailFromAttributes Operation</seealso>
        IAsyncResult BeginPutEmailIdentityMailFromAttributes(PutEmailIdentityMailFromAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEmailIdentityMailFromAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEmailIdentityMailFromAttributes.</param>
        /// 
        /// <returns>Returns a  PutEmailIdentityMailFromAttributesResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/PutEmailIdentityMailFromAttributes">REST API Reference for PutEmailIdentityMailFromAttributes Operation</seealso>
        PutEmailIdentityMailFromAttributesResponse EndPutEmailIdentityMailFromAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  SendEmail


        /// <summary>
        /// Sends an email message. You can use the Amazon Pinpoint Email API to send two types
        /// of messages:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Simple</b> – A standard email message. When you create this type of message, you
        /// specify the sender, the recipient, and the message body, and Amazon Pinpoint assembles
        /// the message for you.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Raw</b> – A raw, MIME-formatted email message. When you send this type of email,
        /// you have to specify all of the message headers, as well as the message body. You can
        /// use this message type to send messages that contain attachments. The message that
        /// you specify has to be a valid MIME message.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEmail service method.</param>
        /// 
        /// <returns>The response from the SendEmail service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.AccountSuspendedException">
        /// The message can't be sent because the account's ability to send email has been permanently
        /// restricted.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.MailFromDomainNotVerifiedException">
        /// The message can't be sent because the sending domain isn't verified.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.MessageRejectedException">
        /// The message can't be sent because it contains invalid content.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.SendingPausedException">
        /// The message can't be sent because the account's ability to send email is currently
        /// paused.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/SendEmail">REST API Reference for SendEmail Operation</seealso>
        SendEmailResponse SendEmail(SendEmailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendEmail operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendEmail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/SendEmail">REST API Reference for SendEmail Operation</seealso>
        IAsyncResult BeginSendEmail(SendEmailRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendEmail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendEmail.</param>
        /// 
        /// <returns>Returns a  SendEmailResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/SendEmail">REST API Reference for SendEmail Operation</seealso>
        SendEmailResponse EndSendEmail(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Add one or more tags (keys and values) to a specified resource. A <i>tag</i> is a
        /// label that you optionally define and associate with a resource in Amazon Pinpoint.
        /// Tags can help you categorize and manage resources in different ways, such as by purpose,
        /// owner, environment, or other criteria. A resource can have as many as 50 tags.
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
        /// <returns>The response from the TagResource service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove one or more tags (keys and values) from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.ConcurrentModificationException">
        /// The resource is being modified by another operation or thread.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConfigurationSetEventDestination


        /// <summary>
        /// Update the configuration of an event destination for a configuration set.
        /// 
        ///  
        /// <para>
        /// In Amazon Pinpoint, <i>events</i> include message sends, deliveries, opens, clicks,
        /// bounces, and complaints. <i>Event destinations</i> are places that you can send information
        /// about these events to. For example, you can send event data to Amazon SNS to receive
        /// notifications when you receive bounces or complaints, or you can use Amazon Kinesis
        /// Data Firehose to stream data to Amazon S3 for long-term storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetEventDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationSetEventDestination service method, as returned by PinpointEmail.</returns>
        /// <exception cref="Amazon.PinpointEmail.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/UpdateConfigurationSetEventDestination">REST API Reference for UpdateConfigurationSetEventDestination Operation</seealso>
        UpdateConfigurationSetEventDestinationResponse UpdateConfigurationSetEventDestination(UpdateConfigurationSetEventDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetEventDestination operation on AmazonPinpointEmailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfigurationSetEventDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/UpdateConfigurationSetEventDestination">REST API Reference for UpdateConfigurationSetEventDestination Operation</seealso>
        IAsyncResult BeginUpdateConfigurationSetEventDestination(UpdateConfigurationSetEventDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfigurationSetEventDestination.</param>
        /// 
        /// <returns>Returns a  UpdateConfigurationSetEventDestinationResult from PinpointEmail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-email-2018-07-26/UpdateConfigurationSetEventDestination">REST API Reference for UpdateConfigurationSetEventDestination Operation</seealso>
        UpdateConfigurationSetEventDestinationResponse EndUpdateConfigurationSetEventDestination(IAsyncResult asyncResult);

        #endregion
        
    }
}
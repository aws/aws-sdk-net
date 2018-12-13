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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
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
    ///  This document contains reference information for the <a href="https://aws.amazon.com/pinpoint">Amazon
    /// Pinpoint</a> Email API, version 1.0. This document is best used in conjunction with
    /// the <a href="http://docs.aws.amazon.com/pinpoint/latest/developerguide/welcome.html">Amazon
    /// Pinpoint Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// The Amazon Pinpoint Email API is available in the US East (N. Virginia), US West (Oregon)
    /// and the EU (Ireland) Regions at the following endpoints:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>US East (N. Virginia)</b>: <code>email.us-east-1.amazonaws.com</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>US West (Oregon)</b>: <code>email.us-west-2.amazonaws.com</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>EU (Ireland)</b>: <code>email.eu-west-1.amazonaws.com</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonPinpointEmail : IAmazonService, IDisposable
    {

        
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
        /// <exception cref="Amazon.PinpointEmail.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        CreateConfigurationSetResponse CreateConfigurationSet(CreateConfigurationSetRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateConfigurationSetResponse> CreateConfigurationSetAsync(CreateConfigurationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateConfigurationSetEventDestinationResponse CreateConfigurationSetEventDestination(CreateConfigurationSetEventDestinationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetEventDestination operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateConfigurationSetEventDestinationResponse> CreateConfigurationSetEventDestinationAsync(CreateConfigurationSetEventDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <exception cref="Amazon.PinpointEmail.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        CreateDedicatedIpPoolResponse CreateDedicatedIpPool(CreateDedicatedIpPoolRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDedicatedIpPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDedicatedIpPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDedicatedIpPoolResponse> CreateDedicatedIpPoolAsync(CreateDedicatedIpPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateDeliverabilityTestReportResponse CreateDeliverabilityTestReport(CreateDeliverabilityTestReportRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeliverabilityTestReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeliverabilityTestReport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDeliverabilityTestReportResponse> CreateDeliverabilityTestReportAsync(CreateDeliverabilityTestReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <exception cref="Amazon.PinpointEmail.Model.LimitExceededException">
        /// There are too many instances of the specified resource type.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        CreateEmailIdentityResponse CreateEmailIdentity(CreateEmailIdentityRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateEmailIdentityResponse> CreateEmailIdentityAsync(CreateEmailIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        DeleteConfigurationSetResponse DeleteConfigurationSet(DeleteConfigurationSetRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteConfigurationSetResponse> DeleteConfigurationSetAsync(DeleteConfigurationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteConfigurationSetEventDestinationResponse DeleteConfigurationSetEventDestination(DeleteConfigurationSetEventDestinationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetEventDestination operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteConfigurationSetEventDestinationResponse> DeleteConfigurationSetEventDestinationAsync(DeleteConfigurationSetEventDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        DeleteDedicatedIpPoolResponse DeleteDedicatedIpPool(DeleteDedicatedIpPoolRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDedicatedIpPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDedicatedIpPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDedicatedIpPoolResponse> DeleteDedicatedIpPoolAsync(DeleteDedicatedIpPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <exception cref="Amazon.PinpointEmail.Model.NotFoundException">
        /// The resource you attempted to access doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PinpointEmail.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        DeleteEmailIdentityResponse DeleteEmailIdentity(DeleteEmailIdentityRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteEmailIdentityResponse> DeleteEmailIdentityAsync(DeleteEmailIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetAccountResponse GetAccount(GetAccountRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetAccountResponse> GetAccountAsync(GetAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetBlacklistReportsResponse GetBlacklistReports(GetBlacklistReportsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetBlacklistReports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBlacklistReports operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetBlacklistReportsResponse> GetBlacklistReportsAsync(GetBlacklistReportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetConfigurationSetResponse GetConfigurationSet(GetConfigurationSetRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetConfigurationSetResponse> GetConfigurationSetAsync(GetConfigurationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetConfigurationSetEventDestinationsResponse GetConfigurationSetEventDestinations(GetConfigurationSetEventDestinationsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetConfigurationSetEventDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSetEventDestinations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetConfigurationSetEventDestinationsResponse> GetConfigurationSetEventDestinationsAsync(GetConfigurationSetEventDestinationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetDedicatedIpResponse GetDedicatedIp(GetDedicatedIpRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDedicatedIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDedicatedIpResponse> GetDedicatedIpAsync(GetDedicatedIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetDedicatedIpsResponse GetDedicatedIps(GetDedicatedIpsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDedicatedIps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDedicatedIpsResponse> GetDedicatedIpsAsync(GetDedicatedIpsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDeliverabilityDashboardOptions


        /// <summary>
        /// Show the status of the Deliverability dashboard. When the Deliverability dashboard
        /// is enabled, you gain access to reputation metrics for the domains that you use to
        /// send email using Amazon Pinpoint. You also gain the ability to perform predictive
        /// inbox placement tests.
        /// 
        ///  
        /// <para>
        /// When you use the Deliverability dashboard, you pay a monthly charge of USD$1,250.00,
        /// in addition to any other fees that you accrue by using Amazon Pinpoint. If you enable
        /// the Deliverability dashboard after the first day of a calendar month, AWS prorates
        /// the monthly charge based on how many days have elapsed in the current calendar month.
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
        GetDeliverabilityDashboardOptionsResponse GetDeliverabilityDashboardOptions(GetDeliverabilityDashboardOptionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDeliverabilityDashboardOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityDashboardOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDeliverabilityDashboardOptionsResponse> GetDeliverabilityDashboardOptionsAsync(GetDeliverabilityDashboardOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetDeliverabilityTestReportResponse GetDeliverabilityTestReport(GetDeliverabilityTestReportRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDeliverabilityTestReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityTestReport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDeliverabilityTestReportResponse> GetDeliverabilityTestReportAsync(GetDeliverabilityTestReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetDomainStatisticsReportResponse GetDomainStatisticsReport(GetDomainStatisticsReportRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainStatisticsReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainStatisticsReport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDomainStatisticsReportResponse> GetDomainStatisticsReportAsync(GetDomainStatisticsReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        GetEmailIdentityResponse GetEmailIdentity(GetEmailIdentityRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetEmailIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEmailIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetEmailIdentityResponse> GetEmailIdentityAsync(GetEmailIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListConfigurationSetsResponse ListConfigurationSets(ListConfigurationSetsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurationSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListConfigurationSetsResponse> ListConfigurationSetsAsync(ListConfigurationSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListDedicatedIpPoolsResponse ListDedicatedIpPools(ListDedicatedIpPoolsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListDedicatedIpPools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDedicatedIpPools operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListDedicatedIpPoolsResponse> ListDedicatedIpPoolsAsync(ListDedicatedIpPoolsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListDeliverabilityTestReportsResponse ListDeliverabilityTestReports(ListDeliverabilityTestReportsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListDeliverabilityTestReports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeliverabilityTestReports operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListDeliverabilityTestReportsResponse> ListDeliverabilityTestReportsAsync(ListDeliverabilityTestReportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListEmailIdentitiesResponse ListEmailIdentities(ListEmailIdentitiesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListEmailIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEmailIdentities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListEmailIdentitiesResponse> ListEmailIdentitiesAsync(ListEmailIdentitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        PutAccountDedicatedIpWarmupAttributesResponse PutAccountDedicatedIpWarmupAttributes(PutAccountDedicatedIpWarmupAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutAccountDedicatedIpWarmupAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAccountDedicatedIpWarmupAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutAccountDedicatedIpWarmupAttributesResponse> PutAccountDedicatedIpWarmupAttributesAsync(PutAccountDedicatedIpWarmupAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        PutAccountSendingAttributesResponse PutAccountSendingAttributes(PutAccountSendingAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutAccountSendingAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSendingAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutAccountSendingAttributesResponse> PutAccountSendingAttributesAsync(PutAccountSendingAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        PutConfigurationSetDeliveryOptionsResponse PutConfigurationSetDeliveryOptions(PutConfigurationSetDeliveryOptionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationSetDeliveryOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetDeliveryOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutConfigurationSetDeliveryOptionsResponse> PutConfigurationSetDeliveryOptionsAsync(PutConfigurationSetDeliveryOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        PutConfigurationSetReputationOptionsResponse PutConfigurationSetReputationOptions(PutConfigurationSetReputationOptionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationSetReputationOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetReputationOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutConfigurationSetReputationOptionsResponse> PutConfigurationSetReputationOptionsAsync(PutConfigurationSetReputationOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        PutConfigurationSetSendingOptionsResponse PutConfigurationSetSendingOptions(PutConfigurationSetSendingOptionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationSetSendingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetSendingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutConfigurationSetSendingOptionsResponse> PutConfigurationSetSendingOptionsAsync(PutConfigurationSetSendingOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        PutConfigurationSetTrackingOptionsResponse PutConfigurationSetTrackingOptions(PutConfigurationSetTrackingOptionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationSetTrackingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetTrackingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutConfigurationSetTrackingOptionsResponse> PutConfigurationSetTrackingOptionsAsync(PutConfigurationSetTrackingOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        PutDedicatedIpInPoolResponse PutDedicatedIpInPool(PutDedicatedIpInPoolRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutDedicatedIpInPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpInPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutDedicatedIpInPoolResponse> PutDedicatedIpInPoolAsync(PutDedicatedIpInPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        PutDedicatedIpWarmupAttributesResponse PutDedicatedIpWarmupAttributes(PutDedicatedIpWarmupAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutDedicatedIpWarmupAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpWarmupAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutDedicatedIpWarmupAttributesResponse> PutDedicatedIpWarmupAttributesAsync(PutDedicatedIpWarmupAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutDeliverabilityDashboardOption


        /// <summary>
        /// Enable or disable the Deliverability dashboard. When you enable the Deliverability
        /// dashboard, you gain access to reputation metrics for the domains that you use to send
        /// email using Amazon Pinpoint. You also gain the ability to perform predictive inbox
        /// placement tests.
        /// 
        ///  
        /// <para>
        /// When you use the Deliverability dashboard, you pay a monthly charge of USD$1,250.00,
        /// in addition to any other fees that you accrue by using Amazon Pinpoint. If you enable
        /// the Deliverability dashboard after the first day of a calendar month, we prorate the
        /// monthly charge based on how many days have elapsed in the current calendar month.
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
        PutDeliverabilityDashboardOptionResponse PutDeliverabilityDashboardOption(PutDeliverabilityDashboardOptionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutDeliverabilityDashboardOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDeliverabilityDashboardOption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutDeliverabilityDashboardOptionResponse> PutDeliverabilityDashboardOptionAsync(PutDeliverabilityDashboardOptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        PutEmailIdentityDkimAttributesResponse PutEmailIdentityDkimAttributes(PutEmailIdentityDkimAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutEmailIdentityDkimAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityDkimAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutEmailIdentityDkimAttributesResponse> PutEmailIdentityDkimAttributesAsync(PutEmailIdentityDkimAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        PutEmailIdentityFeedbackAttributesResponse PutEmailIdentityFeedbackAttributes(PutEmailIdentityFeedbackAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutEmailIdentityFeedbackAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityFeedbackAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutEmailIdentityFeedbackAttributesResponse> PutEmailIdentityFeedbackAttributesAsync(PutEmailIdentityFeedbackAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        PutEmailIdentityMailFromAttributesResponse PutEmailIdentityMailFromAttributes(PutEmailIdentityMailFromAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutEmailIdentityMailFromAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityMailFromAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutEmailIdentityMailFromAttributesResponse> PutEmailIdentityMailFromAttributesAsync(PutEmailIdentityMailFromAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        SendEmailResponse SendEmail(SendEmailRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SendEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendEmail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SendEmailResponse> SendEmailAsync(SendEmailRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateConfigurationSetEventDestinationResponse UpdateConfigurationSetEventDestination(UpdateConfigurationSetEventDestinationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationSetEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetEventDestination operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateConfigurationSetEventDestinationResponse> UpdateConfigurationSetEventDestinationAsync(UpdateConfigurationSetEventDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
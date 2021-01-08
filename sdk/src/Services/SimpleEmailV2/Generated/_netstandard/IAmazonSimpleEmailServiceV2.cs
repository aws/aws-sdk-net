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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SimpleEmailV2.Model;

namespace Amazon.SimpleEmailV2
{
    /// <summary>
    /// Interface for accessing SimpleEmailServiceV2
    ///
    /// Amazon SES API v2 
    /// <para>
    /// Welcome to the Amazon SES API v2 Reference. This guide provides information about
    /// the Amazon SES API v2, including supported operations, data types, parameters, and
    /// schemas.
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://aws.amazon.com/pinpoint">Amazon SES</a> is an AWS service that you
    /// can use to send email messages to your customers.
    /// </para>
    ///  
    /// <para>
    /// If you're new to Amazon SES API v2, you might find it helpful to also review the <a
    /// href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/">Amazon Simple Email
    /// Service Developer Guide</a>. The <i>Amazon SES Developer Guide</i> provides information
    /// and code samples that demonstrate how to use Amazon SES API v2 features programmatically.
    /// </para>
    ///  
    /// <para>
    /// The Amazon SES API v2 is available in several AWS Regions and it provides an endpoint
    /// for each of these Regions. For a list of all the Regions and endpoints where the API
    /// is currently available, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#ses_region">AWS
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
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonSimpleEmailServiceV2 : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISimpleEmailV2PaginatorFactory Paginators { get; }
#endif
                
        #region  CreateConfigurationSet



        /// <summary>
        /// Create a configuration set. <i>Configuration sets</i> are groups of rules that you
        /// can apply to the emails that you send. You apply a configuration set to an email by
        /// specifying the name of the configuration set when you call the Amazon SES API v2.
        /// When you apply a configuration set to an email, all of the rules in that configuration
        /// set are applied to the email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateConfigurationSetResponse> CreateConfigurationSetAsync(CreateConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateConfigurationSetEventDestination



        /// <summary>
        /// Create an event destination. <i>Events</i> include message sends, deliveries, opens,
        /// clicks, bounces, and complaints. <i>Event destinations</i> are places that you can
        /// send information about these events to. For example, you can send event data to Amazon
        /// SNS to receive notifications when you receive bounces or complaints, or you can use
        /// Amazon Kinesis Data Firehose to stream data to Amazon S3 for long-term storage.
        /// 
        ///  
        /// <para>
        /// A single configuration set can include more than one event destination.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSetEventDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateConfigurationSetEventDestinationResponse> CreateConfigurationSetEventDestinationAsync(CreateConfigurationSetEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateContact



        /// <summary>
        /// Creates a contact, which is an end-user who is receiving the email, and adds them
        /// to a contact list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateContactResponse> CreateContactAsync(CreateContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateContactList



        /// <summary>
        /// Creates a contact list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContactList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateContactListResponse> CreateContactListAsync(CreateContactListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCustomVerificationEmailTemplate



        /// <summary>
        /// Creates a new custom verification email template.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/send-email-verify-address-custom.html">Using
        /// Custom Verification Email Templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomVerificationEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateCustomVerificationEmailTemplateResponse> CreateCustomVerificationEmailTemplateAsync(CreateCustomVerificationEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDedicatedIpPool



        /// <summary>
        /// Create a new pool of dedicated IP addresses. A pool can include one or more dedicated
        /// IP addresses that are associated with your AWS account. You can associate a pool with
        /// a configuration set. When you send an email that uses that configuration set, the
        /// message is sent from one of the addresses in the associated pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDedicatedIpPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateDedicatedIpPoolResponse> CreateDedicatedIpPoolAsync(CreateDedicatedIpPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDeliverabilityTestReport



        /// <summary>
        /// Create a new predictive inbox placement test. Predictive inbox placement tests can
        /// help you predict how your messages will be handled by various email providers around
        /// the world. When you perform a predictive inbox placement test, you provide a sample
        /// message that contains the content that you plan to send to your customers. Amazon
        /// SES then sends that message to special email addresses spread across several major
        /// email providers. After about 24 hours, the test is complete, and you can use the <code>GetDeliverabilityTestReport</code>
        /// operation to view the results of the test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeliverabilityTestReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateDeliverabilityTestReportResponse> CreateDeliverabilityTestReportAsync(CreateDeliverabilityTestReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// When you verify a domain without specifying the <code>DkimSigningAttributes</code>
        /// object, this operation provides a set of DKIM tokens. You can convert these tokens
        /// into CNAME records, which you then add to the DNS configuration for your domain. Your
        /// domain is verified when Amazon SES detects these records in the DNS configuration
        /// for your domain. This verification method is known as <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Easy
        /// DKIM</a>.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can perform the verification process by providing your own public-private
        /// key pair. This verification method is known as Bring Your Own DKIM (BYODKIM). To use
        /// BYODKIM, your call to the <code>CreateEmailIdentity</code> operation has to include
        /// the <code>DkimSigningAttributes</code> object. When you specify this object, you provide
        /// a selector (a component of the DNS record name that identifies the public key that
        /// you want to use for DKIM authentication) and a private key.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/CreateEmailIdentity">REST API Reference for CreateEmailIdentity Operation</seealso>
        Task<CreateEmailIdentityResponse> CreateEmailIdentityAsync(CreateEmailIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateEmailIdentityPolicyResponse> CreateEmailIdentityPolicyAsync(CreateEmailIdentityPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateEmailTemplateResponse> CreateEmailTemplateAsync(CreateEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateImportJob



        /// <summary>
        /// Creates an import job for a data destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateImportJobResponse> CreateImportJobAsync(CreateImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteConfigurationSetResponse> DeleteConfigurationSetAsync(DeleteConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteConfigurationSetEventDestination



        /// <summary>
        /// Delete an event destination.
        /// 
        ///  
        /// <para>
        ///  <i>Events</i> include message sends, deliveries, opens, clicks, bounces, and complaints.
        /// <i>Event destinations</i> are places that you can send information about these events
        /// to. For example, you can send event data to Amazon SNS to receive notifications when
        /// you receive bounces or complaints, or you can use Amazon Kinesis Data Firehose to
        /// stream data to Amazon S3 for long-term storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSetEventDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteConfigurationSetEventDestinationResponse> DeleteConfigurationSetEventDestinationAsync(DeleteConfigurationSetEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteContact



        /// <summary>
        /// Removes a contact from a contact list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteContactResponse> DeleteContactAsync(DeleteContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteContactList



        /// <summary>
        /// Deletes a contact list and all of the contacts on that list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContactList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteContactListResponse> DeleteContactListAsync(DeleteContactListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCustomVerificationEmailTemplate



        /// <summary>
        /// Deletes an existing custom verification email template.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/es/latest/DeveloperGuide/send-email-verify-address-custom.html">Using
        /// Custom Verification Email Templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomVerificationEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteCustomVerificationEmailTemplateResponse> DeleteCustomVerificationEmailTemplateAsync(DeleteCustomVerificationEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDedicatedIpPool



        /// <summary>
        /// Delete a dedicated IP pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDedicatedIpPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteDedicatedIpPoolResponse> DeleteDedicatedIpPoolAsync(DeleteDedicatedIpPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEmailIdentity



        /// <summary>
        /// Deletes an email identity. An identity can be either an email address or a domain
        /// name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteEmailIdentityResponse> DeleteEmailIdentityAsync(DeleteEmailIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteEmailIdentityPolicyResponse> DeleteEmailIdentityPolicyAsync(DeleteEmailIdentityPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteEmailTemplateResponse> DeleteEmailTemplateAsync(DeleteEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSuppressedDestination



        /// <summary>
        /// Removes an email address from the suppression list for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSuppressedDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteSuppressedDestinationResponse> DeleteSuppressedDestinationAsync(DeleteSuppressedDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccount



        /// <summary>
        /// Obtain information about the email-sending status and capabilities of your Amazon
        /// SES account in the current AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccount service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/GetAccount">REST API Reference for GetAccount Operation</seealso>
        Task<GetAccountResponse> GetAccountAsync(GetAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBlacklistReports



        /// <summary>
        /// Retrieve a list of the blacklists that your dedicated IP addresses appear on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlacklistReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetBlacklistReportsResponse> GetBlacklistReportsAsync(GetBlacklistReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetConfigurationSetResponse> GetConfigurationSetAsync(GetConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetConfigurationSetEventDestinations



        /// <summary>
        /// Retrieve a list of event destinations that are associated with a configuration set.
        /// 
        ///  
        /// <para>
        ///  <i>Events</i> include message sends, deliveries, opens, clicks, bounces, and complaints.
        /// <i>Event destinations</i> are places that you can send information about these events
        /// to. For example, you can send event data to Amazon SNS to receive notifications when
        /// you receive bounces or complaints, or you can use Amazon Kinesis Data Firehose to
        /// stream data to Amazon S3 for long-term storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationSetEventDestinations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetConfigurationSetEventDestinationsResponse> GetConfigurationSetEventDestinationsAsync(GetConfigurationSetEventDestinationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetContact



        /// <summary>
        /// Returns a contact from a contact list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetContactResponse> GetContactAsync(GetContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetContactList



        /// <summary>
        /// Returns contact list metadata. It does not return any information about the contacts
        /// present in the list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetContactListResponse> GetContactListAsync(GetContactListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCustomVerificationEmailTemplate



        /// <summary>
        /// Returns the custom email verification template for the template name you specify.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/send-email-verify-address-custom.html">Using
        /// Custom Verification Email Templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomVerificationEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetCustomVerificationEmailTemplateResponse> GetCustomVerificationEmailTemplateAsync(GetCustomVerificationEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDedicatedIp



        /// <summary>
        /// Get information about a dedicated IP address, including the name of the dedicated
        /// IP pool that it's associated with, as well information about the automatic warm-up
        /// process for the address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDedicatedIpResponse> GetDedicatedIpAsync(GetDedicatedIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDedicatedIps



        /// <summary>
        /// List the dedicated IP addresses that are associated with your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDedicatedIps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDedicatedIpsResponse> GetDedicatedIpsAsync(GetDedicatedIpsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// in addition to any other fees that you accrue by using Amazon SES and other AWS services.
        /// For more information about the features and cost of a Deliverability dashboard subscription,
        /// see <a href="http://aws.amazon.com/ses/pricing/">Amazon SES Pricing</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityDashboardOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDeliverabilityDashboardOptionsResponse> GetDeliverabilityDashboardOptionsAsync(GetDeliverabilityDashboardOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDeliverabilityTestReport



        /// <summary>
        /// Retrieve the results of a predictive inbox placement test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverabilityTestReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDeliverabilityTestReportResponse> GetDeliverabilityTestReportAsync(GetDeliverabilityTestReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDomainDeliverabilityCampaign



        /// <summary>
        /// Retrieve all the deliverability data for a specific campaign. This data is available
        /// for a campaign only if the campaign sent email by using a domain that the Deliverability
        /// dashboard is enabled for.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDeliverabilityCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDomainDeliverabilityCampaignResponse> GetDomainDeliverabilityCampaignAsync(GetDomainDeliverabilityCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDomainStatisticsReport



        /// <summary>
        /// Retrieve inbox placement and engagement rates for the domains that you use to send
        /// email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainStatisticsReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDomainStatisticsReportResponse> GetDomainStatisticsReportAsync(GetDomainStatisticsReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEmailIdentity



        /// <summary>
        /// Provides information about a specific identity, including the identity's verification
        /// status, sending authorization policies, its DKIM authentication status, and its custom
        /// Mail-From settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetEmailIdentityResponse> GetEmailIdentityAsync(GetEmailIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetEmailIdentityPoliciesResponse> GetEmailIdentityPoliciesAsync(GetEmailIdentityPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetEmailTemplateResponse> GetEmailTemplateAsync(GetEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetImportJob



        /// <summary>
        /// Provides information about an import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetImportJobResponse> GetImportJobAsync(GetImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSuppressedDestination



        /// <summary>
        /// Retrieves information about a specific email address that's on the suppression list
        /// for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSuppressedDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetSuppressedDestinationResponse> GetSuppressedDestinationAsync(GetSuppressedDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigurationSets service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListConfigurationSets">REST API Reference for ListConfigurationSets Operation</seealso>
        Task<ListConfigurationSetsResponse> ListConfigurationSetsAsync(ListConfigurationSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListContactLists



        /// <summary>
        /// Lists all of the contact lists available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContactLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContactLists service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListContactLists">REST API Reference for ListContactLists Operation</seealso>
        Task<ListContactListsResponse> ListContactListsAsync(ListContactListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListContacts



        /// <summary>
        /// Lists the contacts present in a specific contact list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListContactsResponse> ListContactsAsync(ListContactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCustomVerificationEmailTemplates



        /// <summary>
        /// Lists the existing custom verification email templates for your account in the current
        /// AWS Region.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/send-email-verify-address-custom.html">Using
        /// Custom Verification Email Templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomVerificationEmailTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomVerificationEmailTemplates service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListCustomVerificationEmailTemplates">REST API Reference for ListCustomVerificationEmailTemplates Operation</seealso>
        Task<ListCustomVerificationEmailTemplatesResponse> ListCustomVerificationEmailTemplatesAsync(ListCustomVerificationEmailTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDedicatedIpPools



        /// <summary>
        /// List all of the dedicated IP pools that exist in your AWS account in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDedicatedIpPools service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDedicatedIpPools service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListDedicatedIpPools">REST API Reference for ListDedicatedIpPools Operation</seealso>
        Task<ListDedicatedIpPoolsResponse> ListDedicatedIpPoolsAsync(ListDedicatedIpPoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDeliverabilityTestReports



        /// <summary>
        /// Show a list of the predictive inbox placement tests that you've performed, regardless
        /// of their statuses. For predictive inbox placement tests that are complete, you can
        /// use the <code>GetDeliverabilityTestReport</code> operation to view the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeliverabilityTestReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListDeliverabilityTestReportsResponse> ListDeliverabilityTestReportsAsync(ListDeliverabilityTestReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDomainDeliverabilityCampaigns



        /// <summary>
        /// Retrieve deliverability data for all the campaigns that used a specific domain to
        /// send email during a specified time range. This data is available for a domain only
        /// if you enabled the Deliverability dashboard for the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainDeliverabilityCampaigns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListDomainDeliverabilityCampaignsResponse> ListDomainDeliverabilityCampaignsAsync(ListDomainDeliverabilityCampaignsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEmailIdentities



        /// <summary>
        /// Returns a list of all of the email identities that are associated with your AWS account.
        /// An identity can be either an email address or a domain. This operation returns identities
        /// that are verified as well as those that aren't. This operation returns identities
        /// that are associated with Amazon SES and Amazon Pinpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEmailIdentities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEmailIdentities service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListEmailIdentities">REST API Reference for ListEmailIdentities Operation</seealso>
        Task<ListEmailIdentitiesResponse> ListEmailIdentitiesAsync(ListEmailIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEmailTemplates



        /// <summary>
        /// Lists the email templates present in your Amazon SES account in the current AWS Region.
        /// 
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEmailTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEmailTemplates service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListEmailTemplates">REST API Reference for ListEmailTemplates Operation</seealso>
        Task<ListEmailTemplatesResponse> ListEmailTemplatesAsync(ListEmailTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListImportJobs



        /// <summary>
        /// Lists all of the import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImportJobs service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/ListImportJobs">REST API Reference for ListImportJobs Operation</seealso>
        Task<ListImportJobsResponse> ListImportJobsAsync(ListImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSuppressedDestinations



        /// <summary>
        /// Retrieves a list of email addresses that are on the suppression list for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSuppressedDestinations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListSuppressedDestinationsResponse> ListSuppressedDestinationsAsync(ListSuppressedDestinationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutAccountDedicatedIpWarmupAttributes



        /// <summary>
        /// Enable or disable the automatic warm-up feature for dedicated IP addresses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountDedicatedIpWarmupAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountDedicatedIpWarmupAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountDedicatedIpWarmupAttributes">REST API Reference for PutAccountDedicatedIpWarmupAttributes Operation</seealso>
        Task<PutAccountDedicatedIpWarmupAttributesResponse> PutAccountDedicatedIpWarmupAttributesAsync(PutAccountDedicatedIpWarmupAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutAccountDetails



        /// <summary>
        /// Update your Amazon SES account details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutAccountDetailsResponse> PutAccountDetailsAsync(PutAccountDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutAccountSendingAttributes



        /// <summary>
        /// Enable or disable the ability of your account to send email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSendingAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountSendingAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountSendingAttributes">REST API Reference for PutAccountSendingAttributes Operation</seealso>
        Task<PutAccountSendingAttributesResponse> PutAccountSendingAttributesAsync(PutAccountSendingAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutAccountSuppressionAttributes



        /// <summary>
        /// Change the settings for the account-level suppression list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSuppressionAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountSuppressionAttributes service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutAccountSuppressionAttributes">REST API Reference for PutAccountSuppressionAttributes Operation</seealso>
        Task<PutAccountSuppressionAttributesResponse> PutAccountSuppressionAttributesAsync(PutAccountSuppressionAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutConfigurationSetDeliveryOptions



        /// <summary>
        /// Associate a configuration set with a dedicated IP pool. You can use dedicated IP pools
        /// to create groups of dedicated IP addresses for sending specific types of email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetDeliveryOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutConfigurationSetDeliveryOptionsResponse> PutConfigurationSetDeliveryOptionsAsync(PutConfigurationSetDeliveryOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutConfigurationSetReputationOptions



        /// <summary>
        /// Enable or disable collection of reputation metrics for emails that you send using
        /// a particular configuration set in a specific AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetReputationOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutConfigurationSetReputationOptionsResponse> PutConfigurationSetReputationOptionsAsync(PutConfigurationSetReputationOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutConfigurationSetSendingOptions



        /// <summary>
        /// Enable or disable email sending for messages that use a particular configuration set
        /// in a specific AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetSendingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutConfigurationSetSendingOptionsResponse> PutConfigurationSetSendingOptionsAsync(PutConfigurationSetSendingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutConfigurationSetSuppressionOptions



        /// <summary>
        /// Specify the account suppression list preferences for a configuration set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetSuppressionOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutConfigurationSetSuppressionOptionsResponse> PutConfigurationSetSuppressionOptionsAsync(PutConfigurationSetSuppressionOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutConfigurationSetTrackingOptions



        /// <summary>
        /// Specify a custom domain to use for open and click tracking elements in email that
        /// you send.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationSetTrackingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutConfigurationSetTrackingOptionsResponse> PutConfigurationSetTrackingOptionsAsync(PutConfigurationSetTrackingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutDedicatedIpInPool



        /// <summary>
        /// Move a dedicated IP address to an existing dedicated IP pool.
        /// 
        ///  <note> 
        /// <para>
        /// The dedicated IP address that you specify must already exist, and must be associated
        /// with your AWS account. 
        /// </para>
        ///  
        /// <para>
        /// The dedicated IP pool you specify must already exist. You can create a new pool by
        /// using the <code>CreateDedicatedIpPool</code> operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpInPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutDedicatedIpInPoolResponse> PutDedicatedIpInPoolAsync(PutDedicatedIpInPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutDedicatedIpWarmupAttributes



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDedicatedIpWarmupAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutDedicatedIpWarmupAttributesResponse> PutDedicatedIpWarmupAttributesAsync(PutDedicatedIpWarmupAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// in addition to any other fees that you accrue by using Amazon SES and other AWS services.
        /// For more information about the features and cost of a Deliverability dashboard subscription,
        /// see <a href="http://aws.amazon.com/ses/pricing/">Amazon SES Pricing</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeliverabilityDashboardOption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutDeliverabilityDashboardOptionResponse> PutDeliverabilityDashboardOptionAsync(PutDeliverabilityDashboardOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutEmailIdentityDkimAttributes



        /// <summary>
        /// Used to enable or disable DKIM authentication for an email identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityDkimAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutEmailIdentityDkimAttributesResponse> PutEmailIdentityDkimAttributesAsync(PutEmailIdentityDkimAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutEmailIdentityDkimSigningAttributesResponse> PutEmailIdentityDkimSigningAttributesAsync(PutEmailIdentityDkimSigningAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutEmailIdentityFeedbackAttributes



        /// <summary>
        /// Used to enable or disable feedback forwarding for an identity. This setting determines
        /// what happens when an identity is used to send an email that results in a bounce or
        /// complaint event.
        /// 
        ///  
        /// <para>
        /// If the value is <code>true</code>, you receive email notifications when bounce or
        /// complaint events occur. These notifications are sent to the address that you specified
        /// in the <code>Return-Path</code> header of the original email.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutEmailIdentityFeedbackAttributesResponse> PutEmailIdentityFeedbackAttributesAsync(PutEmailIdentityFeedbackAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutEmailIdentityMailFromAttributes



        /// <summary>
        /// Used to enable or disable the custom Mail-From domain configuration for an email identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailIdentityMailFromAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutEmailIdentityMailFromAttributesResponse> PutEmailIdentityMailFromAttributesAsync(PutEmailIdentityMailFromAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutSuppressedDestination



        /// <summary>
        /// Adds an email address to the suppression list for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSuppressedDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSuppressedDestination service method, as returned by SimpleEmailServiceV2.</returns>
        /// <exception cref="Amazon.SimpleEmailV2.Model.BadRequestException">
        /// The input you provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleEmailV2.Model.TooManyRequestsException">
        /// Too many requests have been made to the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sesv2-2019-09-27/PutSuppressedDestination">REST API Reference for PutSuppressedDestination Operation</seealso>
        Task<PutSuppressedDestinationResponse> PutSuppressedDestinationAsync(PutSuppressedDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendBulkEmail



        /// <summary>
        /// Composes an email message to multiple destinations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendBulkEmail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<SendBulkEmailResponse> SendBulkEmailAsync(SendBulkEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendCustomVerificationEmail



        /// <summary>
        /// Adds an email address to the list of identities for your Amazon SES account in the
        /// current AWS Region and attempts to verify it. As a result of executing this operation,
        /// a customized verification email is sent to the specified address.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must first create a custom verification email template.
        /// For more information about creating and using custom verification email templates,
        /// see <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/send-email-verify-address-custom.html">Using
        /// Custom Verification Email Templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCustomVerificationEmail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<SendCustomVerificationEmailResponse> SendCustomVerificationEmailAsync(SendCustomVerificationEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendEmail



        /// <summary>
        /// Sends an email message. You can use the Amazon SES API v2 to send two types of messages:
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<SendEmailResponse> SendEmailAsync(SendEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TestRenderEmailTemplateResponse> TestRenderEmailTemplateAsync(TestRenderEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Remove one or more tags (keys and values) from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateConfigurationSetEventDestination



        /// <summary>
        /// Update the configuration of an event destination for a configuration set.
        /// 
        ///  
        /// <para>
        ///  <i>Events</i> include message sends, deliveries, opens, clicks, bounces, and complaints.
        /// <i>Event destinations</i> are places that you can send information about these events
        /// to. For example, you can send event data to Amazon SNS to receive notifications when
        /// you receive bounces or complaints, or you can use Amazon Kinesis Data Firehose to
        /// stream data to Amazon S3 for long-term storage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationSetEventDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateConfigurationSetEventDestinationResponse> UpdateConfigurationSetEventDestinationAsync(UpdateConfigurationSetEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateContact



        /// <summary>
        /// Updates a contact's preferences for a list. It is not necessary to specify all existing
        /// topic preferences in the TopicPreferences object, just the ones that need updating.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateContactResponse> UpdateContactAsync(UpdateContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateContactList



        /// <summary>
        /// Updates contact list metadata. This operation does a complete replacement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContactList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateContactListResponse> UpdateContactListAsync(UpdateContactListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCustomVerificationEmailTemplate



        /// <summary>
        /// Updates an existing custom verification email template.
        /// 
        ///  
        /// <para>
        /// For more information about custom verification email templates, see <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/send-email-verify-address-custom.html">Using
        /// Custom Verification Email Templates</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can execute this operation no more than once per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomVerificationEmailTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateCustomVerificationEmailTemplateResponse> UpdateCustomVerificationEmailTemplateAsync(UpdateCustomVerificationEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateEmailIdentityPolicyResponse> UpdateEmailIdentityPolicyAsync(UpdateEmailIdentityPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateEmailTemplateResponse> UpdateEmailTemplateAsync(UpdateEmailTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
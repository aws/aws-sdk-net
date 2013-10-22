/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon.SimpleEmail.Model;

namespace Amazon.SimpleEmail
{
    /// <summary>
    /// Interface for accessing AmazonSimpleEmailService.
    /// 
    /// Amazon Simple Email Service <para> This is the API Reference for Amazon Simple Email Service (Amazon SES). This documentation is intended to
    /// be used in conjunction with the Amazon SES Developer Guide. </para> <para> For specific details on how to construct a service request,
    /// please consult the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide">Amazon SES Developer Guide</a> .
    /// </para> <para><b>NOTE:</b>The endpoint for Amazon SES is located at: https://email.us-east-1.amazonaws.com </para>
    /// </summary>
	public partial interface IAmazonSimpleEmailService : IDisposable
    {
 
        /// <summary>
        /// <para>Deletes the specified identity (email address or domain) from the list of verified identities.</para> <para>This action is throttled
        /// at one request per second.</para>
        /// </summary>
        /// 
        /// <param name="deleteIdentityRequest">Container for the necessary parameters to execute the DeleteIdentity service method on
        /// AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the DeleteIdentity service method, as returned by AmazonSimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteIdentityResponse> DeleteIdentityAsync(DeleteIdentityRequest deleteIdentityRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Deletes the specified email address from the list of verified addresses.</para> <para><b>IMPORTANT:</b>The DeleteVerifiedEmailAddress
        /// action is deprecated as of the May 15, 2012 release of Domain Verification. The DeleteIdentity action is now preferred.</para> <para>This
        /// action is throttled at one request per second.</para>
        /// </summary>
        /// 
        /// <param name="deleteVerifiedEmailAddressRequest">Container for the necessary parameters to execute the DeleteVerifiedEmailAddress service
        /// method on AmazonSimpleEmailService.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteVerifiedEmailAddressResponse> DeleteVerifiedEmailAddressAsync(DeleteVerifiedEmailAddressRequest deleteVerifiedEmailAddressRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns the current status of Easy DKIM signing for an entity. For domain name identities, this action also returns the DKIM tokens
        /// that are required for Easy DKIM signing, and whether Amazon SES has successfully verified that these tokens have been published.</para>
        /// <para>This action takes a list of identities as input and returns the following information for each:</para>
        /// <ul>
        /// <li>Whether Easy DKIM signing is enabled or disabled.</li>
        /// <li>A set of DKIM tokens that represent the identity. If the identity is an email address, the tokens represent the domain of that
        /// address.</li>
        /// <li>Whether Amazon SES has successfully verified the DKIM tokens published in the domain's DNS. This information is only returned for
        /// domain name identities, not for email addresses.</li>
        /// 
        /// </ul>
        /// <para>This action is throttled at one request per second.</para> <para>For more information about creating DNS records using DKIM tokens,
        /// go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim-dns-records.html">Amazon SES Developer Guide</a> .</para>
        /// </summary>
        /// 
        /// <param name="getIdentityDkimAttributesRequest">Container for the necessary parameters to execute the GetIdentityDkimAttributes service
        /// method on AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the GetIdentityDkimAttributes service method, as returned by AmazonSimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetIdentityDkimAttributesResponse> GetIdentityDkimAttributesAsync(GetIdentityDkimAttributesRequest getIdentityDkimAttributesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Given a list of verified identities (email addresses and/or domains), returns a structure describing identity notification
        /// attributes.</para> <para>This action is throttled at one request per second.</para> <para>For more information about feedback notification,
        /// see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/bounce-complaint-notifications.html">Amazon SES Developer Guide</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="getIdentityNotificationAttributesRequest">Container for the necessary parameters to execute the
        /// GetIdentityNotificationAttributes service method on AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the GetIdentityNotificationAttributes service method, as returned by AmazonSimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetIdentityNotificationAttributesResponse> GetIdentityNotificationAttributesAsync(GetIdentityNotificationAttributesRequest getIdentityNotificationAttributesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Given a list of identities (email addresses and/or domains), returns the verification status and (for domain identities) the
        /// verification token for each identity.</para> <para>This action is throttled at one request per second.</para>
        /// </summary>
        /// 
        /// <param name="getIdentityVerificationAttributesRequest">Container for the necessary parameters to execute the
        /// GetIdentityVerificationAttributes service method on AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the GetIdentityVerificationAttributes service method, as returned by AmazonSimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetIdentityVerificationAttributesResponse> GetIdentityVerificationAttributesAsync(GetIdentityVerificationAttributesRequest getIdentityVerificationAttributesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns the user's current sending limits.</para> <para>This action is throttled at one request per second.</para>
        /// </summary>
        /// 
        /// <param name="getSendQuotaRequest">Container for the necessary parameters to execute the GetSendQuota service method on
        /// AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the GetSendQuota service method, as returned by AmazonSimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetSendQuotaResponse> GetSendQuotaAsync(GetSendQuotaRequest getSendQuotaRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns the user's sending statistics. The result is a list of data points, representing the last two weeks of sending activity.
        /// </para> <para>Each data point in the list contains statistics for a 15-minute interval.</para> <para>This action is throttled at one request
        /// per second.</para>
        /// </summary>
        /// 
        /// <param name="getSendStatisticsRequest">Container for the necessary parameters to execute the GetSendStatistics service method on
        /// AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the GetSendStatistics service method, as returned by AmazonSimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetSendStatisticsResponse> GetSendStatisticsAsync(GetSendStatisticsRequest getSendStatisticsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns a list containing all of the identities (email addresses and domains) for a specific AWS Account, regardless of verification
        /// status.</para> <para>This action is throttled at one request per second.</para>
        /// </summary>
        /// 
        /// <param name="listIdentitiesRequest">Container for the necessary parameters to execute the ListIdentities service method on
        /// AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the ListIdentities service method, as returned by AmazonSimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListIdentitiesResponse> ListIdentitiesAsync(ListIdentitiesRequest listIdentitiesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns a list containing all of the email addresses that have been verified.</para> <para><b>IMPORTANT:</b>The
        /// ListVerifiedEmailAddresses action is deprecated as of the May 15, 2012 release of Domain Verification. The ListIdentities action is now
        /// preferred.</para> <para>This action is throttled at one request per second.</para>
        /// </summary>
        /// 
        /// <param name="listVerifiedEmailAddressesRequest">Container for the necessary parameters to execute the ListVerifiedEmailAddresses service
        /// method on AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the ListVerifiedEmailAddresses service method, as returned by AmazonSimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListVerifiedEmailAddressesResponse> ListVerifiedEmailAddressesAsync(ListVerifiedEmailAddressesRequest listVerifiedEmailAddressesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Composes an email message based on input data, and then immediately queues the message for sending. </para> <para><b>IMPORTANT:</b>
        /// You can only send email from verified email addresses and domains. If you have not requested production access to Amazon SES, you must also
        /// verify every recipient email address except for the recipients provided by the Amazon SES mailbox simulator. For more information, go to the
        /// Amazon SES Developer Guide. </para> <para>The total size of the message cannot exceed 10 MB.</para> <para>Amazon SES has a limit on the
        /// total number of recipients per message: The combined number of To:, CC: and BCC: email addresses cannot exceed 50. If you need to send an
        /// email message to a larger audience, you can divide your recipient list into groups of 50 or fewer, and then call Amazon SES repeatedly to
        /// send the message to each group. </para> <para>For every message that you send, the total number of recipients (To:, CC: and BCC:) is counted
        /// against your <i>sending quota</i> - the maximum number of emails you can send in a 24-hour period. For information about your sending quota,
        /// go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html">Amazon SES Developer Guide</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="sendEmailRequest">Container for the necessary parameters to execute the SendEmail service method on
        /// AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the SendEmail service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleEmail.Model.MessageRejectedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SendEmailResponse> SendEmailAsync(SendEmailRequest sendEmailRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Sends an email message, with header and content specified by the client. The <c>SendRawEmail</c> action is useful for sending
        /// multipart MIME emails. The raw text of the message must comply with Internet email standards; otherwise, the message cannot be sent. </para>
        /// <para><b>IMPORTANT:</b> You can only send email from verified email addresses and domains. If you have not requested production access to
        /// Amazon SES, you must also verify every recipient email address except for the recipients provided by the Amazon SES mailbox simulator. For
        /// more information, go to the Amazon SES Developer Guide. </para> <para>The total size of the message cannot exceed 10 MB. This includes any
        /// attachments that are part of the message.</para> <para>Amazon SES has a limit on the total number of recipients per message: The combined
        /// number of To:, CC: and BCC: email addresses cannot exceed 50. If you need to send an email message to a larger audience, you can divide your
        /// recipient list into groups of 50 or fewer, and then call Amazon SES repeatedly to send the message to each group. </para> <para>For every
        /// message that you send, the total number of recipients (To:, CC: and BCC:) is counted against your <i>sending quota</i> - the maximum number
        /// of emails you can send in a 24-hour period. For information about your sending quota, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html">Amazon SES Developer Guide</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="sendRawEmailRequest">Container for the necessary parameters to execute the SendRawEmail service method on
        /// AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the SendRawEmail service method, as returned by AmazonSimpleEmailService.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleEmail.Model.MessageRejectedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SendRawEmailResponse> SendRawEmailAsync(SendRawEmailRequest sendRawEmailRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Enables or disables Easy DKIM signing of email sent from an identity:</para>
        /// <ul>
        /// <li>If Easy DKIM signing is enabled for a domain name identity (e.g., <c>example.com</c> ), then Amazon SES will DKIM-sign all email sent
        /// by addresses under that domain name (e.g., <c>user@example.com</c> ).</li>
        /// <li>If Easy DKIM signing is enabled for an email address, then Amazon SES will DKIM-sign all email sent by that email address.</li>
        /// 
        /// </ul>
        /// <para>For email addresses (e.g., <c>user@example.com</c> ), you can only enable Easy DKIM signing if the corresponding domain (e.g.,
        /// <c>example.com</c> ) has been set up for Easy DKIM using the AWS Console or the <c>VerifyDomainDkim</c> action.</para> <para>This action is
        /// throttled at one request per second.</para> <para>For more information about Easy DKIM signing, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Amazon SES Developer Guide</a> .</para>
        /// </summary>
        /// 
        /// <param name="setIdentityDkimEnabledRequest">Container for the necessary parameters to execute the SetIdentityDkimEnabled service method on
        /// AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the SetIdentityDkimEnabled service method, as returned by AmazonSimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SetIdentityDkimEnabledResponse> SetIdentityDkimEnabledAsync(SetIdentityDkimEnabledRequest setIdentityDkimEnabledRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Given an identity (email address or domain), enables or disables whether Amazon SES forwards feedback notifications as email. Feedback
        /// forwarding may only be disabled when both complaint and bounce topics are set.</para> <para>This action is throttled at one request per
        /// second.</para> <para>For more information about feedback notification, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/bounce-complaint-notifications.html">Amazon SES Developer Guide</a> .</para>
        /// </summary>
        /// 
        /// <param name="setIdentityFeedbackForwardingEnabledRequest">Container for the necessary parameters to execute the
        /// SetIdentityFeedbackForwardingEnabled service method on AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the SetIdentityFeedbackForwardingEnabled service method, as returned by AmazonSimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SetIdentityFeedbackForwardingEnabledResponse> SetIdentityFeedbackForwardingEnabledAsync(SetIdentityFeedbackForwardingEnabledRequest setIdentityFeedbackForwardingEnabledRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Given an identity (email address or domain), sets the Amazon SNS topic to which Amazon SES will publish bounce and complaint
        /// notifications for emails sent with that identity as the <c>Source</c> .
        /// Publishing to topics may only be disabled when feedback forwarding is enabled.</para> <para>This action is throttled at one request
        /// per second.</para> <para>For more information about feedback notification, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/bounce-complaint-notifications.html">Amazon SES Developer Guide</a> .</para>
        /// </summary>
        /// 
        /// <param name="setIdentityNotificationTopicRequest">Container for the necessary parameters to execute the SetIdentityNotificationTopic service
        /// method on AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the SetIdentityNotificationTopic service method, as returned by AmazonSimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SetIdentityNotificationTopicResponse> SetIdentityNotificationTopicAsync(SetIdentityNotificationTopicRequest setIdentityNotificationTopicRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns a set of DKIM tokens for a domain. DKIM <i>tokens</i> are character strings that represent your domain's identity. Using these
        /// tokens, you will need to create DNS CNAME records that point to DKIM public keys hosted by Amazon SES. Amazon Web Services will eventually
        /// detect that you have updated your DNS records; this detection process may take up to 72 hours. Upon successful detection, Amazon SES will be
        /// able to DKIM-sign email originating from that domain.</para> <para>This action is throttled at one request per second.</para> <para>To
        /// enable or disable Easy DKIM signing for a domain, use the <c>SetIdentityDkimEnabled</c> action.</para> <para>For more information about
        /// creating DNS records using DKIM tokens, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim-dns-records.html">Amazon SES Developer Guide</a> .</para>
        /// </summary>
        /// 
        /// <param name="verifyDomainDkimRequest">Container for the necessary parameters to execute the VerifyDomainDkim service method on
        /// AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the VerifyDomainDkim service method, as returned by AmazonSimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<VerifyDomainDkimResponse> VerifyDomainDkimAsync(VerifyDomainDkimRequest verifyDomainDkimRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Verifies a domain.</para> <para>This action is throttled at one request per second.</para>
        /// </summary>
        /// 
        /// <param name="verifyDomainIdentityRequest">Container for the necessary parameters to execute the VerifyDomainIdentity service method on
        /// AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the VerifyDomainIdentity service method, as returned by AmazonSimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<VerifyDomainIdentityResponse> VerifyDomainIdentityAsync(VerifyDomainIdentityRequest verifyDomainIdentityRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Verifies an email address. This action causes a confirmation email message to be sent to the specified address.</para>
        /// <para><b>IMPORTANT:</b>The VerifyEmailAddress action is deprecated as of the May 15, 2012 release of Domain Verification. The
        /// VerifyEmailIdentity action is now preferred.</para> <para>This action is throttled at one request per second.</para>
        /// </summary>
        /// 
        /// <param name="verifyEmailAddressRequest">Container for the necessary parameters to execute the VerifyEmailAddress service method on
        /// AmazonSimpleEmailService.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<VerifyEmailAddressResponse> VerifyEmailAddressAsync(VerifyEmailAddressRequest verifyEmailAddressRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Verifies an email address. This action causes a confirmation email message to be sent to the specified address.</para> <para>This
        /// action is throttled at one request per second.</para>
        /// </summary>
        /// 
        /// <param name="verifyEmailIdentityRequest">Container for the necessary parameters to execute the VerifyEmailIdentity service method on
        /// AmazonSimpleEmailService.</param>
        /// 
        /// <returns>The response from the VerifyEmailIdentity service method, as returned by AmazonSimpleEmailService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<VerifyEmailIdentityResponse> VerifyEmailIdentityAsync(VerifyEmailIdentityRequest verifyEmailIdentityRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}
